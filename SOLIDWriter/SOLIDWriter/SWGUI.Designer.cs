namespace SOLIDWriter
{
    partial class SWGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lv_DisplayScript = new System.Windows.Forms.ListView();
            this.col_StepNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Step = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ms_AllMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cb_selectType = new System.Windows.Forms.ComboBox();
            this.cb_SelectCommand = new System.Windows.Forms.ComboBox();
            this.bt_AddLine = new System.Windows.Forms.Button();
            this.fd_SelScript = new System.Windows.Forms.OpenFileDialog();
            this.fd_SaveScript = new System.Windows.Forms.SaveFileDialog();
            this.fd_GetConfig = new System.Windows.Forms.OpenFileDialog();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_AllMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_DisplayScript
            // 
            this.lv_DisplayScript.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lv_DisplayScript.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_StepNum,
            this.col_Step});
            this.lv_DisplayScript.GridLines = true;
            this.lv_DisplayScript.Location = new System.Drawing.Point(13, 153);
            this.lv_DisplayScript.MultiSelect = false;
            this.lv_DisplayScript.Name = "lv_DisplayScript";
            this.lv_DisplayScript.Size = new System.Drawing.Size(390, 178);
            this.lv_DisplayScript.TabIndex = 0;
            this.lv_DisplayScript.UseCompatibleStateImageBehavior = false;
            this.lv_DisplayScript.View = System.Windows.Forms.View.Details;
            // 
            // col_StepNum
            // 
            this.col_StepNum.Text = "Step Number";
            this.col_StepNum.Width = 119;
            // 
            // col_Step
            // 
            this.col_Step.Text = "Step";
            this.col_Step.Width = 266;
            // 
            // ms_AllMenu
            // 
            this.ms_AllMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.ms_AllMenu.Location = new System.Drawing.Point(0, 0);
            this.ms_AllMenu.Name = "ms_AllMenu";
            this.ms_AllMenu.Size = new System.Drawing.Size(415, 24);
            this.ms_AllMenu.TabIndex = 1;
            this.ms_AllMenu.Text = "menuStrip1";
            this.ms_AllMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configureSettingsToolStripMenuItem,
            this.loadConfigurationToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // configureSettingsToolStripMenuItem
            // 
            this.configureSettingsToolStripMenuItem.Name = "configureSettingsToolStripMenuItem";
            this.configureSettingsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.configureSettingsToolStripMenuItem.Text = "Configure Settings";
            // 
            // loadConfigurationToolStripMenuItem
            // 
            this.loadConfigurationToolStripMenuItem.Name = "loadConfigurationToolStripMenuItem";
            this.loadConfigurationToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.loadConfigurationToolStripMenuItem.Text = "Load Configuration";
            this.loadConfigurationToolStripMenuItem.Click += new System.EventHandler(this.loadConfigurationToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.instructionsToolStripMenuItem.Text = "Instructions";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // cb_selectType
            // 
            this.cb_selectType.FormattingEnabled = true;
            this.cb_selectType.Location = new System.Drawing.Point(12, 48);
            this.cb_selectType.Name = "cb_selectType";
            this.cb_selectType.Size = new System.Drawing.Size(117, 21);
            this.cb_selectType.TabIndex = 2;
            this.cb_selectType.SelectedIndexChanged += new System.EventHandler(this.cb_selectType_SelectedIndexChanged);
            // 
            // cb_SelectCommand
            // 
            this.cb_SelectCommand.FormattingEnabled = true;
            this.cb_SelectCommand.Location = new System.Drawing.Point(206, 48);
            this.cb_SelectCommand.Name = "cb_SelectCommand";
            this.cb_SelectCommand.Size = new System.Drawing.Size(156, 21);
            this.cb_SelectCommand.TabIndex = 3;
            // 
            // bt_AddLine
            // 
            this.bt_AddLine.Location = new System.Drawing.Point(273, 108);
            this.bt_AddLine.Name = "bt_AddLine";
            this.bt_AddLine.Size = new System.Drawing.Size(75, 23);
            this.bt_AddLine.TabIndex = 4;
            this.bt_AddLine.Text = "Add Line";
            this.bt_AddLine.UseVisualStyleBackColor = true;
            this.bt_AddLine.Click += new System.EventHandler(this.bt_AddLine_Click);
            // 
            // fd_SelScript
            // 
            this.fd_SelScript.FileName = "fName";
            this.fd_SelScript.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // fd_GetConfig
            // 
            this.fd_GetConfig.FileName = "openFileDialog1";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // SWGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 343);
            this.Controls.Add(this.bt_AddLine);
            this.Controls.Add(this.cb_SelectCommand);
            this.Controls.Add(this.cb_selectType);
            this.Controls.Add(this.lv_DisplayScript);
            this.Controls.Add(this.ms_AllMenu);
            this.MainMenuStrip = this.ms_AllMenu;
            this.Name = "SWGUI";
            this.Text = "SOLiD Script Writer";
            this.ms_AllMenu.ResumeLayout(false);
            this.ms_AllMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_DisplayScript;
        private System.Windows.Forms.ColumnHeader col_StepNum;
        private System.Windows.Forms.ColumnHeader col_Step;
        private System.Windows.Forms.MenuStrip ms_AllMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ComboBox cb_selectType;
        private System.Windows.Forms.ComboBox cb_SelectCommand;
        private System.Windows.Forms.Button bt_AddLine;
        private System.Windows.Forms.OpenFileDialog fd_SelScript;
        private System.Windows.Forms.SaveFileDialog fd_SaveScript;
        private System.Windows.Forms.ToolStripMenuItem loadConfigurationToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog fd_GetConfig;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;




    }
}

