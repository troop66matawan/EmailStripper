using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmailStripper
{
    public partial class WarningDialog : Form
    {
        EmailStripper emailStripperForm;

        public WarningDialog(List<String> emails, EmailStripper form)
        {
            InitializeComponent();

            emailList.BeginUpdate();
            foreach (String email in emails)
            {
                emailList.Items.Add(email);
            }
            if (emailList.Items.Count > 0)
                emailList.SetSelected(0, true);
            emailList.EndUpdate();
            emailStripperForm = form;

        }

        private void ignoreButton_Click(object sender, EventArgs e)
        {
            String selectedEmail = (String)emailList.SelectedItem;

            RemoveAndAdvance(selectedEmail);
        }

        private void RemoveAndAdvance(String selectedEmail)
        {
            emailList.Items.Remove(selectedEmail);
            if (emailList.Items.Count > 0)
            {
                emailList.SetSelected(0, true);
            }
            else if (emailList.Items.Count == 0)
            {
                this.Close();
            }
        }

        private void fixButton_Click(object sender, EventArgs e)
        {
            String selectedEmail = (String)emailList.SelectedItem;

            FixEmail fixDlg = new FixEmail(selectedEmail , emailStripperForm);
            if (fixDlg.ShowDialog() == DialogResult.OK)
            {
                RemoveAndAdvance(selectedEmail);
            }
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}