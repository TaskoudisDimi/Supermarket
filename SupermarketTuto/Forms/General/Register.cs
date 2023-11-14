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
using ClassLibrary1.Models;
using ClassLibrary1;
using Org.BouncyCastle.Crypto.Generators;

namespace SupermarketTuto
{
    public partial class Register : Form
    {

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
                    MessageBox.Show("Username and/or Password fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (PasswordTextBox.Text == ConfirmPasswordTextBox.Text)
                {
                    

                    Admins admin = new Admins();
                    admin.UserName = UsernameTextBox.Text;
                    admin.Password = PasswordTextBox.Text;
                    admin.Active = true;

                    DataModel.Create<Admins>(admin);

                    MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UsernameTextBox.Clear();
                    PasswordTextBox.Clear();
                    ConfirmPasswordTextBox.Clear();
                    LogIn login = new LogIn();
                    login.Show();
                }
                else
                {
                    MessageBox.Show("Credentials does not match, please re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UsernameTextBox.Clear();
                    PasswordTextBox.Clear();
                    ConfirmPasswordTextBox.Clear();
                    UsernameTextBox.Focus();
                }
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        #region ChechDatabase

        #endregion

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            DialogResult confirm = MessageBox.Show("Confirm to close", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}



