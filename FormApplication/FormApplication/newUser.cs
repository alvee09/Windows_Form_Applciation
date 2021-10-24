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
    public partial class newUser : Form
    {
        //public static string username;
        //public static string password;
        //public static string password2;
        //public static string firstName;
        //public static string lastName;
        //public static string dob;
        //public static string userType;
        public newUser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //dob = dobInput.Text();
            if ( passwordInput.Text != passwordInput2.Text)
            {
                MessageBox.Show("Passwords does not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string addUser = usernameInput.Text + ",";
                addUser = addUser + passwordInput.Text + ",";
                addUser = addUser + userTypeInput.Text + "," + firstNameInput.Text + "," + lastNameInput.Text + ",";
                addUser = addUser + dobInput.Value.ToString();


                var logFile = File.ReadAllLines("login.txt");
                var logList = new List<string>(logFile);

                IEnumerable<string> ienum = (IEnumerable<string>)logList;
                //MessageBox.Show(userTypeInput.Text);
                ienum = ienum.Append(addUser);
                //MessageBox.Show(ienum.Last());
                File.WriteAllLines("login.txt", ienum);
                MessageBox.Show("New user Created!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //MessageBox.Show(dobInput.Value.ToString());
        }
    }

}
