using MemoryHacking;
using OpenSetup.Forms.Controls;
using OpenSetup.MemoryPatching;
using OpenSetup.Special.Bruteforce;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenSetup.Forms
{
    public partial class FormMain : Form
    {
        private Thread attackThread = null;

        public FormMain(Memory memory)
        {
            InitializeComponent();

            if (memory != null)
            {
                try
                {
                    WebClient client = new WebClient();
                    var patchesBypass = PatchManager.LoadPatchesFromJson(client.DownloadString("https://github.com/absoIute/Mega-Hack-v5/raw/master/bin/hacks/bypass.json"));
                    var patchesCreator = PatchManager.LoadPatchesFromJson(client.DownloadString("https://github.com/absoIute/Mega-Hack-v5/raw/master/bin/hacks/creator.json"));
                    var patchesGlobal = PatchManager.LoadPatchesFromJson(client.DownloadString("https://github.com/absoIute/Mega-Hack-v5/raw/master/bin/hacks/global.json"));
                    var patchesPlayer = PatchManager.LoadPatchesFromJson(client.DownloadString("https://github.com/absoIute/Mega-Hack-v5/raw/master/bin/hacks/player.json"));

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
                catch (Exception ex)
                {
                    MessageBox.Show($"Unexpected error occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(1);
                }
            }
            else
            {
                tcMain.TabPages.RemoveByKey("tpPlayer");
                tcMain.TabPages.RemoveByKey("tpGlobal");
                tcMain.TabPages.RemoveByKey("tpCreator");
                tcMain.TabPages.RemoveByKey("tpBypass");
            }
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

        private void btnBrowseWordlist_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
                tbWordlist.Text = openFile.FileName;
        }

        private void btnBrowseProxyList_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
                tbProxyListPath.Text = openFile.FileName;
        }

        private void btnImportProxyList_Click(object sender, EventArgs e)
        {
            var proxyList = File.ReadAllLines(tbProxyListPath.Text);
            foreach (var proxyLine in proxyList)
                lbProxyView.Items.Add(proxyLine);
        }

        private void btnAddProxyManually_Click(object sender, EventArgs e)
        {
            lbProxyView.Items.Add(tbProxyUrl.Text);
        }

        private void TerminateThread()
        {
            if (attackThread != null)
            {
                if (attackThread.IsAlive)
                    attackThread.Abort();
                attackThread = null;
            }
        }

        private void LoadProxyList()
        {
            List<string> ls = new List<string>();
            foreach (var proxy in lbProxyView.Items)
                ls.Add(proxy.ToString());
            ProxyQueue.UpdateList(ls);
        }

        private void btnAttackDictionary_Click(object sender, EventArgs e)
        {
            TerminateThread();
            LoadProxyList();
            attackThread = new Thread(() =>
            {
                var result = Bruteforce.DictionaryAttack(tbUsername.Text, File.ReadAllLines(tbWordlist.Text));
                if (result == string.Empty)
                    MessageBox.Show("None of the passwords on this list matched.", "Sorry :'c", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show($"A password for {tbUsername.Text} is \"{result}\"!", "Glorious success <_(',')_>", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            });
            attackThread.Start();
        }

        private void btnGeneratorAttack_Click(object sender, EventArgs e)
        {
            TerminateThread();
            LoadProxyList();
            attackThread = new Thread(() =>
            {
                var result = Bruteforce.GeneratorAttack(tbUsername.Text, tbCharset.Text.ToArray(), (int)nudStart.Value, (int)nudLimit.Value);
                if (result == string.Empty)
                    MessageBox.Show("None of the generated passwords matched.", "Sorry :'c", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show($"A password for {tbUsername.Text} is \"{result}\"!", "Glorious success <_(',')_>", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            });
            attackThread.Start();
        }

        private void btnHelpGenerator_Click(object sender, EventArgs e) => MessageBox.Show("Enter in the field the letters that will be in the password, also specify the starting and ending length. " +
            "A wordlist will be generated from all permutations of letters in the sequence.\n" +
            "Tip: Do not repeat letters twice, this will complicate the algorithm.", "Help <3", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        private void btnHelpWordlist_Click(object sender, EventArgs e) => MessageBox.Show("Enter the path to the list of words to check.\n" +
            "Format: one password per line.", "Help <3", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        private void btnHelpProxyList_Click(object sender, EventArgs e) => MessageBox.Show("Well, you will not use this program without a proxy (I hope). Proxy list format: one proxy per line. ONLY HTTP PROXIES are accepted.\n" +
            "Example: 127.0.0.1:8080", "Help <3", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        private void btnClearProxyList_Click(object sender, EventArgs e) => lbProxyView.Items.Clear();

        private void btnProxyShuffle_Click(object sender, EventArgs e)
        {
            ListBox.ObjectCollection list = lbProxyView.Items;
            Random rng = new Random();
            int n = list.Count;
            lbProxyView.BeginUpdate();
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                object value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
            lbProxyView.EndUpdate();
            lbProxyView.Invalidate();
        }
    }
}
