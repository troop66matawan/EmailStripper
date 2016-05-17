namespace EmailStripper
{
    partial class EmailStripper
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTroopMasterEmailReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.automaticallyReplaceMatchingEmailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForTruncatedAddressesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automaticEmailReplacementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.createOutputForGoogleGroups25MaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadTroopMasterEmailReportToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadTroopMasterEmailReportToolStripMenuItem
            // 
            this.loadTroopMasterEmailReportToolStripMenuItem.Name = "loadTroopMasterEmailReportToolStripMenuItem";
            this.loadTroopMasterEmailReportToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.loadTroopMasterEmailReportToolStripMenuItem.Text = "Load TroopMaster Email Report";
            this.loadTroopMasterEmailReportToolStripMenuItem.Click += new System.EventHandler(this.loadTroopMasterEmailReportToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.toolStripSeparator1,
            this.automaticallyReplaceMatchingEmailsToolStripMenuItem,
            this.createOutputForGoogleGroups25MaxToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(295, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(295, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(292, 6);
            // 
            // automaticallyReplaceMatchingEmailsToolStripMenuItem
            // 
            this.automaticallyReplaceMatchingEmailsToolStripMenuItem.Checked = true;
            this.automaticallyReplaceMatchingEmailsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.automaticallyReplaceMatchingEmailsToolStripMenuItem.Name = "automaticallyReplaceMatchingEmailsToolStripMenuItem";
            this.automaticallyReplaceMatchingEmailsToolStripMenuItem.Size = new System.Drawing.Size(295, 22);
            this.automaticallyReplaceMatchingEmailsToolStripMenuItem.Text = "Automatically Replace Matching Emails";
            this.automaticallyReplaceMatchingEmailsToolStripMenuItem.Click += new System.EventHandler(this.automaticallyReplaceMatchingEmailsToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkForTruncatedAddressesToolStripMenuItem,
            this.automaticEmailReplacementsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // checkForTruncatedAddressesToolStripMenuItem
            // 
            this.checkForTruncatedAddressesToolStripMenuItem.Name = "checkForTruncatedAddressesToolStripMenuItem";
            this.checkForTruncatedAddressesToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.checkForTruncatedAddressesToolStripMenuItem.Text = "Check for Truncated addresses";
            this.checkForTruncatedAddressesToolStripMenuItem.Click += new System.EventHandler(this.checkForTruncatedAddressesToolStripMenuItem_Click);
            // 
            // automaticEmailReplacementsToolStripMenuItem
            // 
            this.automaticEmailReplacementsToolStripMenuItem.Name = "automaticEmailReplacementsToolStripMenuItem";
            this.automaticEmailReplacementsToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.automaticEmailReplacementsToolStripMenuItem.Text = "Automatic Email Replacements";
            this.automaticEmailReplacementsToolStripMenuItem.Click += new System.EventHandler(this.automaticEmailReplacementsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailTextBox.Location = new System.Drawing.Point(0, 24);
            this.emailTextBox.Multiline = true;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(284, 238);
            this.emailTextBox.TabIndex = 1;
            // 
            // createOutputForGoogleGroups25MaxToolStripMenuItem
            // 
            this.createOutputForGoogleGroups25MaxToolStripMenuItem.Checked = true;
            this.createOutputForGoogleGroups25MaxToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.createOutputForGoogleGroups25MaxToolStripMenuItem.Name = "createOutputForGoogleGroups25MaxToolStripMenuItem";
            this.createOutputForGoogleGroups25MaxToolStripMenuItem.Size = new System.Drawing.Size(295, 22);
            this.createOutputForGoogleGroups25MaxToolStripMenuItem.Text = "Create output for Google Groups (25 max)";
            this.createOutputForGoogleGroups25MaxToolStripMenuItem.Click += new System.EventHandler(this.createOutputForGoogleGroups25MaxToolStripMenuItem_Click);
            // 
            // EmailStripper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EmailStripper";
            this.Text = "EmailStripper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmailStripper_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadTroopMasterEmailReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForTruncatedAddressesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem automaticEmailReplacementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem automaticallyReplaceMatchingEmailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createOutputForGoogleGroups25MaxToolStripMenuItem;
    }
}

