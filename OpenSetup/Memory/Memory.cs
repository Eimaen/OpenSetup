using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace MemoryHacking
{
    /// <summary>
    /// Some memory-related extensions.
    /// </summary>
    public static class Extensions
    {
        public static string Hex(this IntPtr intptr) => "0x" + intptr.ToString("X");
        public static Memory InitializeMemory(this Process process) => new Memory(process);
    }

    public class Memory
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [Out] byte[] buffer, int size, out int lpNumberOfBytesRead);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [In] byte[] buffer, int size, out int lpNumberOfBytesWritten);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr OpenProcess(uint processAccess, bool bInheritHandle, int processId);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool CloseHandle(IntPtr hObject);

        public enum MemoryProtect
        {
            PageNoAccess = 0x00000001,
            PageReadonly = 0x00000002,
            PageReadWrite = 0x00000004,
            PageWriteCopy = 0x00000008,
            PageExecute = 0x00000010,
            PageExecuteRead = 0x00000020,
            PageExecuteReadWrite = 0x00000040,
            PageExecuteWriteCopy = 0x00000080,
            PageGuard = 0x00000100,
            PageNoCache = 0x00000200,
            PageWriteCombine = 0x00000400
        }

        public enum MemoryState
        {
            MemCommit = 0x1000,
            MemReserved = 0x2000,
            MemFree = 0x10000
        }

        public enum MemoryType
        {
            MemPrivate = 0x20000,
            MemMapped = 0x40000,
            MemImage = 0x1000000
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MEMORY_BASIC_INFORMATION
        {
            public IntPtr BaseAddress;
            public IntPtr AllocationBase;
            public uint AllocationProtect;
            public IntPtr RegionSize;
            public MemoryState State;
            public MemoryProtect Protect;
            public MemoryType Type;
        }

        [DllImport("kernel32.dll")]
        static extern int VirtualQueryEx(IntPtr hProcess, IntPtr lpAddress, out MEMORY_BASIC_INFORMATION lpBuffer, uint dwLength);

        /// <summary>
        /// Class that represents a chunk of process's structure.
        /// </summary>
        public class MemoryRegion
        {
            public MemoryRegion() { }

            public MemoryRegion(MEMORY_BASIC_INFORMATION basicInformation)
            {
                BaseAddress = basicInformation.BaseAddress;
                Size = basicInformation.RegionSize.ToInt32();
                State = basicInformation.State;
                Protect = basicInformation.Protect;
                Type = basicInformation.Type;
            }

            public MemoryRegion(ProcessModule module)
            {
                BaseAddress = module.BaseAddress;
                Size = module.ModuleMemorySize;
            }

            public IntPtr BaseAddress;
            public int Size;
            public MemoryState State;
            public MemoryProtect Protect;
            public MemoryType Type;
        }

        /// <summary>
        /// The process to read memory from.
        /// </summary>
        public Process Process { get; private set; }

        /// <summary>
        /// Temporary process handle.
        /// </summary>
        IntPtr Handle;

        public Memory(Process process)
        {
            Process = process;
        }

        /// <summary>
        /// Get all process memory regions.
        /// </summary>
        /// <returns>Memory region list.</returns>
        public List<MemoryRegion> GetMemoryRegions()
        {
            var regions = new List<MemoryRegion>();
            IntPtr address = IntPtr.Zero;

            while (VirtualQueryEx(Process.Handle, address, out MEMORY_BASIC_INFORMATION basicInformation, (uint)Marshal.SizeOf(typeof(MEMORY_BASIC_INFORMATION))) != 0)
            {
                if (basicInformation.State != MemoryState.MemFree && !basicInformation.Protect.HasFlag(MemoryProtect.PageGuard))
                    regions.Add(new MemoryRegion(basicInformation));

                address = basicInformation.BaseAddress + basicInformation.RegionSize.ToInt32();
            }

            return regions;
        }

        /// <summary>
        /// Get process module memory region by name.
        /// </summary>
        /// <param name="name">Process module name.</param>
        /// <returns><see cref="MemoryRegion"/> instance.</returns>
        public MemoryRegion GetModuleByName(string name)
        {
            foreach (ProcessModule module in Process.Modules)
                if (module.ModuleName == name)
                    return new MemoryRegion(module);

            return null;
        }

        /// <summary>
        /// Write a <see cref="byte"/> array to memory.
        /// </summary>
        /// <param name="address">Address of memory region to begin write.</param>
        /// <param name="value">Array of <see cref="byte"/> to write.</param>
        public void Write(IntPtr address, byte[] value)
        {
            WriteProcessMemory(Process.Handle, address, value, value.Length, out _);
        }

        /// <summary>
        /// Write a structure to memory.
        /// </summary>
        /// <typeparam name="T">Target structure type.</typeparam>
        /// <param name="address">Address of memory region to begin write.</param>
        /// <param name="value">Structure to write.</param>
        public void Write<T>(IntPtr address, T value) => Write(address, ToByteArray(value));

        /// <summary>
        /// Read a <see cref="byte"/> array from memory.
        /// </summary>
        /// <param name="address">The beginning of memory region to read from.</param>
        /// <param name="size">Count of bytes to read.</param>
        /// <returns>An array with specified <paramref name="size"/></returns>
        public byte[] Read(IntPtr address, int size)
        {
            byte[] buffer = new byte[size];
            int bytesRead;

            ReadProcessMemory(Process.Handle, address, buffer, size, out bytesRead);

            if (bytesRead == 0)
                return null;

            return buffer;
        }

        /// <summary>
        /// Read a structure from memory.
        /// </summary>
        /// <typeparam name="T">Target structure type.</typeparam>
        /// <param name="address">The beginning of memory region to read from.</param>
        /// <returns>Structure <typeparamref name="T"/>, decoded from bytes.</returns>
        public T Read<T>(IntPtr address) => ToStructure<T>(Read(address, Marshal.SizeOf(typeof(T))));

        /// <summary>
        /// Read and decode string from memory.
        /// </summary>
        /// <param name="address">The beginning of memory region to read from.</param>
        /// <param name="bufferSize">Count of bytes to read.</param>
        /// <param name="encoding">Target string encoding, leave <see cref="null"/> to use default.</param>
        /// <returns>A string read from memory.</returns>
        public string ReadString(IntPtr address, int bufferSize, Encoding encoding = null)
        {
            encoding = encoding ?? Encoding.UTF8;
            string text = encoding.GetString(Read(address, bufferSize));
            if (text.Contains('\0'))
                text = text.Substring(0, text.IndexOf('\0'));
            return text;
        }

        /// <summary>
        /// Read and decode string from memory by its pointer. Useful for dotnet apps.
        /// </summary>
        /// <param name="address">The beginning of memory region to read from.</param>
        /// <param name="encoding">Target string encoding, leave <see cref="null"/> to use default.</param>
        /// <returns>A string read from memory.</returns>
        public string ReadStringByPointer(IntPtr address, Encoding encoding = null)
        {
            encoding = encoding ?? Encoding.UTF8;
            address = Read<IntPtr>(address);
            return encoding.GetString(Read(address + 0x8, Read<int>(address + 0x4) * 2)).Replace("\0", "");
        }

        /// <summary>
        /// Scan for an IDA-type pattern.
        /// </summary>
        /// <param name="pattern">IDA-type pattern.</param>
        /// <param name="offset">Pattern offset.</param>
        /// <returns>Address of the first occurence of the given pattern.</returns>
        public IntPtr PatternScan(string pattern, int offset)
        {
            foreach (MemoryRegion region in GetMemoryRegions())
            {
                IntPtr address = PatternScan(pattern, offset, region);
                if (address != IntPtr.Zero)
                    return address;
            }
            return IntPtr.Zero;
        }

        /// <summary>
        /// Scan for an IDA-type pattern in target region memory.
        /// </summary>
        /// <param name="pattern">IDA-type pattern.</param>
        /// <param name="offset">Pattern offset.</param>
        /// <param name="region">A region to scan.</param>
        /// <returns>Address of the first occurence of the given pattern.</returns>
        public IntPtr PatternScan(string pattern, int offset, MemoryRegion region) => PatternScan(pattern, offset, region.BaseAddress, region.Size);

        /// <summary>
        /// Scan for an IDA-type pattern in memory chunk.
        /// </summary>
        /// <param name="pattern">IDA-type pattern.</param>
        /// <param name="offset">Pattern offset.</param>
        /// <param name="baseAddress">The beginning of memory chunk.</param>
        /// <param name="scanSize">The size of bytes to check.</param>
        /// <returns>Address of the first occurence of the given pattern.</returns>
        public IntPtr PatternScan(string pattern, int offset, IntPtr baseAddress, int scanSize)
        {
            List<byte> patternBytes = new List<byte>();
            List<bool> patternMask = new List<bool>();

            foreach (string byteString in pattern.Split(' '))
            {
                if (byteString == "?" || byteString == "00" || byteString == "??")
                {
                    patternBytes.Add(0x00);
                    patternMask.Add(false);
                }
                else
                {
                    patternBytes.Add(byte.Parse(byteString, NumberStyles.HexNumber));
                    patternMask.Add(true);
                }
            }

            byte[] moduleBytes = Read(baseAddress, scanSize);

            if (moduleBytes == null)
                return IntPtr.Zero;

            for (int i = 0; i < moduleBytes.Length; i++)
            {
                bool found = true;

                for (int l = 0; l < patternMask.Count; l++)
                {
                    if (l + i >= moduleBytes.Length) found = false;
                    else found = !patternMask[l] || moduleBytes[l + i] == patternBytes[l];

                    if (!found) break;
                }

                if (found)
                    return Read<IntPtr>((IntPtr)i + baseAddress.ToInt32() + offset);
            }

            return IntPtr.Zero;
        }

        /// <summary>
        /// Resolve a pointer chain in the region and get the last address.
        /// </summary>
        /// <param name="offsets">Pointer chain to resolve.</param>
        /// <param name="region">Target region.</param>
        /// <returns>The last pointer address from chain.</returns>
        public IntPtr ResolveAddress(int[] offsets, MemoryRegion region) => ResolveAddress(offsets, region.BaseAddress);

        /// <summary>
        /// Resolve a pointer chain and get the last address.
        /// </summary>
        /// <param name="offsets">Pointer chain to resolve.</param>
        /// <param name="baseAddress">The base address to start resolving.</param>
        /// <returns>The last pointer address from chain.</returns>
        public IntPtr ResolveAddress(int[] offsets, IntPtr baseAddress)
        {
            baseAddress += offsets[0];
            for (int offsetId = 1; offsetId < offsets.Length; offsetId++)
                baseAddress = Read<IntPtr>(baseAddress) + offsets[offsetId];
            return baseAddress;
        }

        /// <summary>
        /// Decode a structure from bytes.
        /// </summary>
        /// <typeparam name="T">Structure type.</typeparam>
        /// <param name="bytes">Bytes to decode.</param>
        /// <returns>The resulting structure.</returns>
        static T ToStructure<T>(byte[] bytes)
        {
            var handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
            var structure = (T)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(T));
            handle.Free();
            return structure;
        }

        /// <summary>
        /// Encode a structure to a byte array.
        /// </summary>
        /// <param name="obj">Target structure.</param>
        /// <returns>A resulting array of bytes.</returns>
        static byte[] ToByteArray(object obj)
        {
            int length = Marshal.SizeOf(obj);
            byte[] array = new byte[length];
            IntPtr pointer = Marshal.AllocHGlobal(length);

            Marshal.StructureToPtr(obj, pointer, true);
            Marshal.Copy(pointer, array, 0, length);
            Marshal.FreeHGlobal(pointer);

            return array;
        }
    }
}
