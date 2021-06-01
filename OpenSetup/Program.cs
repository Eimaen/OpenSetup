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

namespace OpenSetup
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter GD process name: ");
            string name = Console.ReadLine().Replace(".exe", "");
            while (!Process.GetProcessesByName(name).Any()) Thread.Sleep(100);

            Application.EnableVisualStyles();
            Application.Run(new FormMain(Process.GetProcessesByName("SDPS").First().InitializeMemory()));

            Console.ReadKey();
        }
    }
}
