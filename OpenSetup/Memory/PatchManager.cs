using MemoryHacking.Addons;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSetup.MemoryPatching
{
    class MegahackCheatsheet
    { 
        public class MegahackHack
        {
            public class MegahackPatch
            {
                [JsonProperty("addr")]
                public string Address;

                [JsonProperty("on")]
                public string Active;

                [JsonProperty("off")]
                public string Inactive;
            }

            [JsonProperty("name")]
            public string Name;

            [JsonProperty("desc")]
            public string Description;

            [JsonProperty("opcodes")]
            public List<MegahackPatch> Patches;
        }

        [JsonProperty("hacks")]
        public List<MegahackHack> Hacks;
    }

    public static class PatchManager
    {
        private static byte[] StringToByteArray(string hex)
        {
            hex = hex.Trim();
            string[] parts = hex.Split(' ');

            List<byte> bytes = new List<byte>();
            foreach (var part in parts)
                bytes.Add(Convert.ToByte(part, 16));

            return bytes.ToArray();
        }

        public static List<PatchInstruction> LoadPatchesFromJson(string json)
        {
            List<PatchInstruction> instructions = new List<PatchInstruction>();
            MegahackCheatsheet cheatsheet = JsonConvert.DeserializeObject<MegahackCheatsheet>(json);

            foreach (var cheat in cheatsheet.Hacks)
            {
                PatchInstruction instruction = new PatchInstruction()
                {
                    Name = cheat.Name,
                    Description = cheat.Description
                };
                foreach (var patch in cheat.Patches)
                {
                    instruction.Patches.Add(new Patch
                    {
                        Address = new IntPtr(Convert.ToInt32(patch.Address.Replace("0x", ""), 16)),
                        OriginalBytes = StringToByteArray(patch.Inactive),
                        PatchBytes = StringToByteArray(patch.Active)
                    });
                }
                instructions.Add(instruction);
            }

            return instructions;
        }
    }
}
