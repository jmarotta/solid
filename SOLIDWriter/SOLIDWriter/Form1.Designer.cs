namespace SOLIDWriter
{
    partial class Form1
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 343);
            this.Controls.Add(this.lv_DisplayScript);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_DisplayScript;
        private System.Windows.Forms.ColumnHeader col_StepNum;
        private System.Windows.Forms.ColumnHeader col_Step;




    }
}

