using OpenSetup.Forms;
using MemoryHacking;
using OpenSetup.MemoryPatching;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MemoryHacking.Addons;
using System.Threading;
using OpenSetup.Special.Bruteforce;

namespace OpenSetup
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.Run(new Forms.OpenSetup());
        }
    }
}
