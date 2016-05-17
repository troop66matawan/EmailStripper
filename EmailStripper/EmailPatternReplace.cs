using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace EmailStripper
{
    public class EmailPatternReplace
    {
        private string m_truncEmail;
        private string m_fixedEmail;

        public EmailPatternReplace()
        {
        }

        public EmailPatternReplace(string truncatedEmail, string fixedEmail)
        {
            m_truncEmail = truncatedEmail;
            m_fixedEmail = fixedEmail;
        }

        public string TruncatedEmail {
            get { return m_truncEmail; }
            set { m_truncEmail = value; }
        }

        public string FixedEmail
        {
            get { return m_fixedEmail; }
            set { m_fixedEmail = value; }
        }

        public override string ToString()
        {
            string value = m_truncEmail + " -> " + m_fixedEmail + "\n";
            return value;
        }
    }
}
