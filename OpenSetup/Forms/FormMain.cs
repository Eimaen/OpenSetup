using MemoryHacking;
using OpenSetup.Forms.Controls;
using OpenSetup.MemoryPatching;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenSetup.Forms
{
    public partial class FormMain : Form
    {
        private Memory Memory;

        public FormMain(Memory memory)
        {
            InitializeComponent();

            WebClient client = new WebClient();
            var patchesBypass = PatchManager.LoadPatchesFromJson(client.DownloadString("https://github.com/absoIute/Mega-Hack-v5/raw/master/bin/hacks/bypass.json"));
            var patchesCreator = PatchManager.LoadPatchesFromJson(client.DownloadString("https://github.com/absoIute/Mega-Hack-v5/raw/master/bin/hacks/creator.json"));
            var patchesGlobal = PatchManager.LoadPatchesFromJson(client.DownloadString("https://github.com/absoIute/Mega-Hack-v5/raw/master/bin/hacks/global.json"));
            var patchesPlayer = PatchManager.LoadPatchesFromJson(client.DownloadString("https://github.com/absoIute/Mega-Hack-v5/raw/master/bin/hacks/player.json"));

            Memory = memory;

            foreach (var patch in patchesBypass)
                flowBypass.Controls.Add(new HackView(memory, patch));
            foreach (var patch in patchesCreator)
                flowCreator.Controls.Add(new HackView(memory, patch));
            foreach (var patch in patchesGlobal)
                flowGlobal.Controls.Add(new HackView(memory, patch));
            foreach (var patch in patchesPlayer)
                flowPlayer.Controls.Add(new HackView(memory, patch));
        }
    }
}
