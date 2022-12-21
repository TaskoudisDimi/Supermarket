using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DataClass;
using SupermarketTuto.Utils;

namespace SupermarketTuto
{
    public partial class Register : Form
    {

        SqlConnect loaddata = new SqlConnect();


        public Register()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (UsernameTextBox.Text == "" || PasswordTextBox.Text == String.Empty || ConfirmPasswordTextBox.Text == String.Empty)
                {
                    MessageBox.Show("Username and/or Password fields are empty", "Registration Failed", MessageBoxButtons.OK);

                }
                else if (PasswordTextBox.Text == ConfirmPasswordTextBox.Text)
                {
                    loaddata.commandExc("Insert Into Admins Values ('" + UsernameTextBox.Text + "'," + $"CONVERT(varbinary, '{PasswordTextBox.Text}')" + "," + "'True')");
                    MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButtons.OK);
                    UsernameTextBox.Clear();
                    PasswordTextBox.Clear();
                    ConfirmPasswordTextBox.Clear();

                }
                else
                {
                    MessageBox.Show("Credentials does not match, please re-enter", "Registration Failed", MessageBoxButtons.OK);
                    UsernameTextBox.Clear();
                    PasswordTextBox.Clear();
                    ConfirmPasswordTextBox.Clear();
                    UsernameTextBox.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            UsernameTextBox.Clear();
            PasswordTextBox.Clear();
            ConfirmPasswordTextBox.Clear();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
            this.Dispose();
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked)
            {
                PasswordTextBox.PasswordChar = '\0';
                ConfirmPasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                PasswordTextBox.PasswordChar = '*'; 
                ConfirmPasswordTextBox.PasswordChar = '*';
            }
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Confirm to close", "Exit", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}



