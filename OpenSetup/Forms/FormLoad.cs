using MemoryHacking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenSetup.Forms
{
    public partial class OpenSetup : Form
    {
        public OpenSetup()
        {
            InitializeComponent();
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

        private void btnLoad_Click(object sender, EventArgs e)
        {
            tbProcess.Text = tbProcess.Text.Replace(".exe", "");

            if (!Process.GetProcessesByName(tbProcess.Text).Any())
            {
                MessageBox.Show("There are no processes with such name", "Process not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Process process = Process.GetProcessesByName(tbProcess.Text).First();
            Hide();
            new FormMain(process.InitializeMemory()).ShowDialog();
            Close();
        }

        private void btnNoMemoryMode_Click(object sender, EventArgs e)
        {
            Hide();
            new FormMain(null).ShowDialog();
            Close();
        }
    }
}
