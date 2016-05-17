namespace EmailStripper
{
    partial class WarningDialog
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
            this.emailList = new System.Windows.Forms.ListBox();
            this.fixButton = new System.Windows.Forms.Button();
            this.ignoreButton = new System.Windows.Forms.Button();
            this.doneButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // emailList
            // 
            this.emailList.FormattingEnabled = true;
            this.emailList.Location = new System.Drawing.Point(12, 95);
            this.emailList.Name = "emailList";
            this.emailList.Size = new System.Drawing.Size(205, 212);
            this.emailList.TabIndex = 0;
            // 
            // fixButton
            // 
            this.fixButton.Location = new System.Drawing.Point(243, 124);
            this.fixButton.Name = "fixButton";
            this.fixButton.Size = new System.Drawing.Size(75, 23);
            this.fixButton.TabIndex = 1;
            this.fixButton.Text = "Fix";
            this.fixButton.UseVisualStyleBackColor = true;
            this.fixButton.Click += new System.EventHandler(this.fixButton_Click);
            // 
            // ignoreButton
            // 
            this.ignoreButton.Location = new System.Drawing.Point(243, 95);
            this.ignoreButton.Name = "ignoreButton";
            this.ignoreButton.Size = new System.Drawing.Size(75, 23);
            this.ignoreButton.TabIndex = 2;
            this.ignoreButton.Text = "Ignore";
            this.ignoreButton.UseVisualStyleBackColor = true;
            this.ignoreButton.Click += new System.EventHandler(this.ignoreButton_Click);
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(243, 153);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(75, 23);
            this.doneButton.TabIndex = 3;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(306, 77);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "TroopMaster may truncate email addresses that are longer than 30 characters.  Che" +
                "ck the following list of email addresses to see if they have been cut-off.";
            // 
            // WarningDialog
            // 
            this.AcceptButton = this.doneButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 328);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.ignoreButton);
            this.Controls.Add(this.fixButton);
            this.Controls.Add(this.emailList);
            this.Name = "WarningDialog";
            this.ShowInTaskbar = false;
            this.Text = "Check Email Address";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox emailList;
        private System.Windows.Forms.Button fixButton;
        private System.Windows.Forms.Button ignoreButton;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}