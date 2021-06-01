using MemoryHacking.Addons;
using MemoryHacking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenSetup.Forms.Controls
{
    public partial class HackView : UserControl
    {
        private Memory Memory;
        private PatchInstruction Instruction;

        public HackView(Memory memory, PatchInstruction hack)
        {
            InitializeComponent();
            lblHackName.Text = hack.Name;
            lblHackDesc.Text = hack.Description;
            Instruction = hack;
            Memory = memory;
        }

        private void cbHackActive_CheckedChanged(object sender, EventArgs e) => Memory.Patch(Instruction, cbHackActive.Checked);
    }
}
