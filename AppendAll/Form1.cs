using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppendAll
{
    public partial class appendall : Form
    {
        private const string LINE_FEED = "\r\n";

        public appendall()
        {
            InitializeComponent();
        }

        private void convert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(body.Text)) 
            {
                bodyFocus();
                return;
            }

            IList<String> bodyList = body.Text.Replace(LINE_FEED, "|").Split('|');
            StringBuilder bodys = new StringBuilder();
            foreach (string oneLine in bodyList)
            {
                bodys.Append(string.Format("{0}{1}{2}{3}", prefix.Text, oneLine, suffix.Text, LINE_FEED));
            }
            body.Text = bodys.ToString();
            Clipboard.SetText(body.Text);
            bodyFocus();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            body.Text = string.Empty;
            bodyFocus();
        }

        private void c_CheckedChanged(object sender, EventArgs e)
        {
            prefix.Text = "sql.Append(\" ";
            bodyFocus();
        }

        private void java_CheckedChanged(object sender, EventArgs e)
        {
            prefix.Text = "sql.append(\" ";
            bodyFocus();
        }

        private void bodyFocus()
        {
            body.Focus();
        }

        private void appendall_Load(object sender, EventArgs e)
        {
            java.Checked = true;
            bodyFocus();
        }
    }
}

