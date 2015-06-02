using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SOLIDWriter
{
    public partial class SWGUI : Form
    {
        ScriptReader reader = new ScriptReader();
        ScriptWriter writer = new ScriptWriter();
        SWMiddleLayer swml = new SWMiddleLayer();
        private string cfp;
        public string configPath
        {
            get {return String.Concat(Path.GetDirectoryName(Application.ExecutablePath), "configuration.xml"); }
            set { cfp = value; }
        }

        public SWGUI()
        {

            InitializeComponent();
            this.populateSelectType();
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = fd_SelScript.ShowDialog();
            List<string> lvPop = new List<string>();
            //string dictPath = String.Concat(Path.GetDirectoryName(Application.ExecutablePath),"configuration.xml");
            if (result == DialogResult.OK)
            {
                // Populate the listview.
                lvPop = swml.ListViewFormat(result.ToString(), configPath);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void populateSelectType()
        {
            cb_selectType.Items.Add("pump");
            cb_selectType.Items.Add("set_temp");
            cb_selectType.Items.Add("wait");
        }

        private void bt_AddLine_Click(object sender, EventArgs e)
        {
            string cmd = cb_SelectCommand.SelectedItem.ToString();
            int currLineIdx = lv_DisplayScript.SelectedIndices[0];
            lv_DisplayScript.Items.Insert(currLineIdx, cmd);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult svres = fd_SaveScript.ShowDialog();
            if (svres == DialogResult.OK)
            {
                List<string> scriptItems = new List<string>();
                foreach (ListViewItem lvi in lv_DisplayScript.Items) scriptItems.Add(lvi.ToString());
                swml.WriteToFile(scriptItems, svres.ToString());
            }
        }

        private void loadConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult configDat = fd_GetConfig.ShowDialog();
            if (configDat == DialogResult.OK)
            {
                cfp = configDat.ToString();
            }            
        }

    }
}
