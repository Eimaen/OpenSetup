using OpenSetup.Forms;
using OpenSetup.MemoryPatching;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenSetup
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.Run(new FormMain());
            Console.ReadKey();
        }
    }
}
