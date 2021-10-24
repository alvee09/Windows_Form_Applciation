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

namespace FormApplication
{
    public partial class Form1 : Form
    {
        private static string username;
        private static string password;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form3 = new newUser();
            form3.Show();
        }

        private void login_Click(object sender, EventArgs e)
        {
            username = usernameField.Text;
            password = passwordField.Text;

            var logFile = File.ReadAllLines("login.txt");
            var logList = new List<string>(logFile);

            IEnumerable<string> ienum = (IEnumerable<string>)logList;

            //var firstElement = logList.First();
            LoginFunction(ienum);

            //MessageBox.Show(firstElement);
        }
        public static void LoginFunction(IEnumerable<string> users)
        {
            Boolean found = false;
            
            foreach (string user in users)
            {
                string[] items = user.Split(',');
                if (items[0].Equals(username))
                {
                    if(items[1].Equals(password))
                    {
                        var form2 = new Form2(items[0], items[2]);
                        found = true;
                        form2.Show();
                        
                    }
           
                }
            }
            if(!found)
            {
                MessageBox.Show("Invalid Username or passowrd", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //MessageBox.Show("Invalid Username or passowrd", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
