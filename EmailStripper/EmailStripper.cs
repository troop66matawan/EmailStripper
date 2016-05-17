using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace EmailStripper
{
    public partial class EmailStripper : Form
    {
        List<String> emails;
        List<String> mightBeTooLong;
        List<EmailPatternReplace> emailsReplaced;
        List<EmailPatternReplace> replacements;
        String inFileName;
        bool needsSave = false;

        public EmailStripper()
        {
            InitializeComponent();
            emails = new List<string>();
            mightBeTooLong = new List<string>();
            emailsReplaced = new List<EmailPatternReplace>();
            replacements = new List<EmailPatternReplace>();
            automaticallyReplaceMatchingEmailsToolStripMenuItem.Checked = (bool)Properties.Settings.Default["UseAutoReplace"];
            createOutputForGoogleGroups25MaxToolStripMenuItem.Checked = (bool)Properties.Settings.Default["GoogleGroup"];
            DeserializeEmailReplace();
        }

        public bool Replace(String fromEmail, String toEmail)
        {
            bool retval = false;
            if (emails.Contains(fromEmail))
            {
                retval = emails.Remove(fromEmail);
                emails.Add(toEmail);
                EmailPatternReplace epr = new EmailPatternReplace(fromEmail, toEmail);
                if (!replacements.Contains(epr))
                {
                    replacements.Add(epr);
                    SerializeEmailReplace();
                }
                ShowEmails();
            }
            return retval;
        }

        public List<EmailPatternReplace> RemoveEmailReplaceRow(EmailPatternReplace row)
        {
            List<EmailPatternReplace> val = null;

            if (replacements.Remove(row))
            {
                SerializeEmailReplace();
                val = replacements;
            }

            return val;
        }

        private void SerializeEmailReplace()
        {
            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(replacements.GetType());
            StringWriter sw = new StringWriter();
            x.Serialize(sw, replacements);
            Properties.Settings.Default["EmailReplaceXML"] = sw.ToString();
            Properties.Settings.Default.Save();
        }

        private void DeserializeEmailReplace()
        {
            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(replacements.GetType());
            string xmlString = (string)Properties.Settings.Default["EmailReplaceXML"];
            if (xmlString.Length > 0)
            {
                StringReader sr = new StringReader(xmlString);
                replacements = (List<EmailPatternReplace>)x.Deserialize(sr);
            }

        }
        private void loadTroopMasterEmailReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckIfSaveFirst(); 
            
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            ofd.FilterIndex = 1;

            DialogResult result = ofd.ShowDialog();

            if (result == DialogResult.OK)
            {
                System.IO.Stream infile = ofd.OpenFile();
                StreamReader sr = new StreamReader(infile);
                inFileName = ofd.FileName;

                emails.Clear();
                mightBeTooLong.Clear();
                emailsReplaced.Clear();
                String line;
                char[] seps = { ' ', ',' };
                while ((line = sr.ReadLine()) != null)
                {
                    String[] tokens = line.Split(seps);

                    foreach (String token in tokens)
                    {
                        if (token.Contains("@") && !emails.Contains(token))
                        {
                            string email = token;
                            if (email.Length >= 30)
                            {
                                bool isReplaced = false;
                                if (automaticallyReplaceMatchingEmailsToolStripMenuItem.Checked)
                                {
                                    foreach (EmailPatternReplace emailMatch in replacements)
                                    {
                                        if (emailMatch.TruncatedEmail.Equals(email))
                                        {
                                            email = emailMatch.FixedEmail;
                                            emailsReplaced.Add(emailMatch);
                                            isReplaced = true;
                                            break;
                                        }
                                    }
                                }
                                if (!isReplaced)
                                {
                                    mightBeTooLong.Add(email);
                                }
                            }
                            emails.Add(email);
                        }
                    }
                }

                Int32 numberOfUniqueEmails = ShowEmails();
                String message = "Number of Unique Emails: " + numberOfUniqueEmails.ToString();
                if (emailsReplaced.Count > 0)
                {
                    message += "\nAutomatically Replaced:\n";
                    foreach (EmailPatternReplace replaced in emailsReplaced)
                    {
                        message += replaced.ToString();
                    }
                }
                if (mightBeTooLong.Count > 0)
                {
                    message += "\nWarning: Some emails might be truncated.  Check these emails:\n";
                    foreach (String email in mightBeTooLong)
                    {
                        message += email + "\n";
                    }
                    MessageBox.Show(message, "Warninng", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    WarningDialog dlg = new WarningDialog(mightBeTooLong, this);
                    dlg.ShowDialog();
                }
                else
                {
                    MessageBox.Show(message);
                }
            }

        }

        private void CheckIfSaveFirst()
        {
            if (needsSave)
            {
                DialogResult yesno = MessageBox.Show("Do you want to save first?", "File Not Saved", MessageBoxButtons.YesNo);
                if (yesno == DialogResult.Yes)
                    SaveFile();
            }

        }

        private Int32 ShowEmails()
        {
            emailTextBox.Clear();
            emails.Sort();
            bool first = true;
            Int32 numberOfUniqueEmails = 0;
            bool groupIn25 = createOutputForGoogleGroups25MaxToolStripMenuItem.Checked;
            foreach (String email in emails)
            {
                if (first)
                {
                    first = false;
                }
                else
                {
                    if (groupIn25 && numberOfUniqueEmails % 25 == 0)
                    {
                        emailTextBox.AppendText("\r\n\r\n");
                    }
                    else
                    {
                        emailTextBox.AppendText(", ");
                    }
                }
                emailTextBox.AppendText(email);
                numberOfUniqueEmails++;
            }
            needsSave = true;
            return numberOfUniqueEmails;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();

        }

        private void SaveFile()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.FilterIndex = 1;
            sfd.AddExtension = true;

            String outFileName = inFileName;
            int lastDotIndex = outFileName.LastIndexOf(".");
            sfd.FileName = outFileName.Insert(lastDotIndex, "_emails");

            DialogResult res = sfd.ShowDialog();

            if (res == DialogResult.OK)
            {
                Stream outFile = sfd.OpenFile();
                if (outFile != null)
                {
                    StreamWriter writer = new StreamWriter(outFile);
                    writer.WriteLine(emailTextBox.Text);
                    writer.Close();
                    needsSave = false;
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkForTruncatedAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mightBeTooLong.Clear();
            foreach (String email in emails)
            {
                if (email.Length >= 30)
                {
                    mightBeTooLong.Add(email);
                }
            }
            if (mightBeTooLong.Count > 0)
            {
                WarningDialog dlg = new WarningDialog(mightBeTooLong, this);
                dlg.ShowDialog();
            }
            else
            {
                MessageBox.Show("No truncated email addresses found.");
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            emailTextBox.SelectAll();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            emailTextBox.Copy();
        }

        private void EmailStripper_FormClosing(object sender, FormClosingEventArgs e)
        {
            CheckIfSaveFirst();
        }

        private void automaticEmailReplacementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutomaticReplacementDlg dlg = new AutomaticReplacementDlg(this);
            dlg.DataSource = replacements;
            dlg.Show();
        }

        private void automaticallyReplaceMatchingEmailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isChecked = automaticallyReplaceMatchingEmailsToolStripMenuItem.Checked;
            bool newValue;

            if (isChecked)
            {
                newValue  = false;
            }
            else
            {
                newValue = true;
            }
            Properties.Settings.Default["UseAutoReplace"] = newValue;
            automaticallyReplaceMatchingEmailsToolStripMenuItem.Checked = newValue;
            Properties.Settings.Default.Save();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 abtDlg = new AboutBox1();
            abtDlg.Show();
        }

        private void createOutputForGoogleGroups25MaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isChecked = this.createOutputForGoogleGroups25MaxToolStripMenuItem.Checked;
            bool newValue;

            if (isChecked)
            {
                newValue = false;
            }
            else
            {
                newValue = true;
            }
            Properties.Settings.Default["GoogleGroup"] = newValue;
            createOutputForGoogleGroups25MaxToolStripMenuItem.Checked = newValue;
            Properties.Settings.Default.Save();

        }
    }
}