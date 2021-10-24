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
        public static string fileLoc;
        public static Boolean fileExist = false;
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
            if(userType.Equals("View"))
            {
                richTextBox1.ReadOnly = true;
            }
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
                fileLoc = openFileDialog1.FileName;
                fileExist = true;
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
            if (userType.Equals("Edit"))
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold);
            }
            else
            {
                richTextBox1.ReadOnly = true;
            }
            //Control.SelectionFont = new Font(control.Font, FontStyle.Bold);
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if(userType.Equals("Edit"))
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Italic);
            }
            else
            {
                richTextBox1.ReadOnly = true;
            }
            
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if(userType.Equals("Edit"))
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Underline);
            }
            else
            {
                richTextBox1.ReadOnly = true;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            if (userType.Equals("Edit"))
            {
                richTextBox1.Cut();
            }
            else
            {
                richTextBox1.ReadOnly = true;
            }
            
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            if (userType.Equals("Edit"))
            {
                richTextBox1.Copy();
            }
            else
            {
                richTextBox1.ReadOnly = true;
            }
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            if (userType.Equals("Edit"))
            {
                richTextBox1.Paste();
            }
            else
            {
                richTextBox1.ReadOnly = true;
            }
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            if (userType.Equals("Edit"))
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, toolStripComboBox1.SelectedIndex + 10, richTextBox1.SelectionFont.Style);
            }
            else
            {
                richTextBox1.ReadOnly = true;
            }
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            newToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            openToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            saveAsToolStripMenuItem_Click(sender, e);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fileExist)
            {
                File.WriteAllText(fileLoc, richTextBox1.Text);
            }
            else
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton8_Click(sender, e);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton9_Click(sender, e);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton10_Click(sender, e);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form3 = new about();
            form3.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
