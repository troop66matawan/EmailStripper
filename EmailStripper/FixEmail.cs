using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmailStripper
{
    public partial class FixEmail : Form
    {
        EmailStripper emailStripperForm;
        public FixEmail(String email, EmailStripper form)
        {
            InitializeComponent();
            emailStripperForm = form;
            fromEmailTextBox.Text = email;
            toEmailTextBox.Text = email;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (!emailStripperForm.Replace(fromEmailTextBox.Text, toEmailTextBox.Text))
            {
                MessageBox.Show("Error fixing email");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}