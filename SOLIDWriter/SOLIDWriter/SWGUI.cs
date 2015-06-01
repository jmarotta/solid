using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOLIDWriter
{
    public partial class SWGUI : Form
    {
        public SWGUI()
        {
            InitializeComponent();
            ScriptReader reader = new ScriptReader();
            ScriptWriter writer = new ScriptWriter();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
