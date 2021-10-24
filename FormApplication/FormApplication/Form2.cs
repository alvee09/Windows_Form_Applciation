using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using DocumentFormat.OpenXml.Presentation;
using Font = System.Drawing.Font;

namespace FormApplication
{
    public partial class Form2 : Form
    {
        public static string username;
        public static string userType;
        public Form2(string userneme, string user_type)
        {
            username = userneme;
            userType = user_type;
            InitializeComponent();
            MessageBox.Show(userneme);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            userLabel.Text = "Username: " + username;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ResetText();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog()== DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            //Control.SelectionFont = new Font(control.Font, FontStyle.Bold);
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Italic);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Underline);
        }
    }
}
