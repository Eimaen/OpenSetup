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
using System.Runtime.InteropServices;
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
                flowBypass.Controls.Add(new HackView(memory, patch)
                {
                    Width = flowBypass.Width - 24
                });
            foreach (var patch in patchesCreator)
                flowCreator.Controls.Add(new HackView(memory, patch)
                {
                    Width = flowCreator.Width - 24
                });
            foreach (var patch in patchesGlobal)
                flowGlobal.Controls.Add(new HackView(memory, patch)
                {
                    Width = flowGlobal.Width - 24
                });
            foreach (var patch in patchesPlayer)
                flowPlayer.Controls.Add(new HackView(memory, patch)
                {
                    Width = flowPlayer.Width - 24
                });
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void DragForm(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
