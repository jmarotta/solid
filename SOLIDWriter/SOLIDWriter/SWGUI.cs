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
            get {return Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "configuration.xml").ToString(); }
            set
            { cfp = value; }
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
            if (result == DialogResult.OK)
            {
                // Populate the listview.
                lvPop = swml.ListViewFormat(fd_SelScript.FileName, configPath);
                this.PopulateListView(lvPop);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void populateSelectType()
        {
            cb_selectType.Items.Add("pump");
            cb_selectType.Items.Add("temp");
            cb_selectType.Items.Add("wait");
        }

        private void bt_AddLine_Click(object sender, EventArgs e)
        {
            string cmd = cb_SelectCommand.SelectedItem.ToString();
            int currLineIdx;
            if (lv_DisplayScript.Items.Count == 0 )
            {
                currLineIdx = 0;
            }
            else if (lv_DisplayScript.SelectedIndices.Count == 0)
            {
                currLineIdx = lv_DisplayScript.Items.Count;
            }
            else
            {
                currLineIdx = lv_DisplayScript.SelectedIndices[0] + 1;
            }
            lv_DisplayScript.Items.Insert(currLineIdx, cmd);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult svres = fd_SaveScript.ShowDialog();
            if (svres == DialogResult.OK)
            {
                string svPth = fd_SaveScript.FileName;
                List<string> scriptItems = new List<string>();
                foreach (ListViewItem lvi in lv_DisplayScript.Items) scriptItems.Add(lvi.ToString());
                swml.WriteToFile(scriptItems, svPth);
            }
        }

        private void loadConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult configDat = fd_GetConfig.ShowDialog();
            if (configDat == DialogResult.OK)
            {
                cfp = fd_GetConfig.FileName;
            }            
        }

        private void PopulateListView(List<string> formattedCommands)
        {
            int i = 0;
            foreach (string str in formattedCommands)
            {
                lv_DisplayScript.Items.Add(str);
                //lv_DisplayScript.Items[1].SubItems.Add(str);
            }
            //lv_DisplayScript.Update();
            
        }

        private void cb_selectType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_SelectCommand.Items.Clear();
            cb_SelectCommand.Text = "";
            string cmdType = cb_selectType.SelectedItem.ToString();
            List<string> sortedCommands = swml.GetCommandByType(this.configPath, cmdType);
            foreach (string cmd in sortedCommands) cb_SelectCommand.Items.Add(cmd);
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

    }
}
