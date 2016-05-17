using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmailStripper
{
    public partial class AutomaticReplacementDlg : Form
    {
        EmailStripper emailStripperForm;
        public AutomaticReplacementDlg(EmailStripper form)
        {
            InitializeComponent();
            emailStripperForm = form;

        }

        public object DataSource 
        {
            get { return dataGridView1.DataSource; }
            set { dataGridView1.DataSource = value; dataGridView1.AutoResizeColumns(); }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            EmailPatternReplace data = (EmailPatternReplace)row.DataBoundItem;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            List<EmailPatternReplace> ds = emailStripperForm.RemoveEmailReplaceRow(data);

            if (ds != null)
            {
                dataGridView1.DataSource = ds;
            }
            dataGridView1.Refresh();
            //dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }
        
        
    }
}