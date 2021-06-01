using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryHacking.Addons
{
    public struct Patch
    {
        public IntPtr Address;
        public byte[] PatchBytes;
        public byte[] OriginalBytes;
    }

    public class PatchInstruction
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Patch> Patches { get; private set; }
        public PatchInstruction() => Patches = new List<Patch>();
    }

    public static class PatchExtension
    {
        public static void Patch(this Memory memory, PatchInstruction patchInstruction, bool enable)
        {
            if (enable)
                foreach (var patch in patchInstruction.Patches)
                    memory.Write(memory.Process.MainModule.BaseAddress + patch.Address.ToInt32(), patch.PatchBytes);
            else
                foreach (var patch in patchInstruction.Patches)
                    memory.Write(memory.Process.MainModule.BaseAddress + patch.Address.ToInt32(), patch.OriginalBytes);
        }
    }
}
