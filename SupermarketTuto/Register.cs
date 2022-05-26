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
using SupermarketTuto.DataAccess;

namespace SupermarketTuto
{
    public partial class Register : Form
    {

        SqlConnect loaddata = new SqlConnect();


        public Register()
        {
            InitializeComponent();

            chooseRoleCombobox.Items.AddRange(new string[] { "Admin", "Seller" });
            chooseRoleCombobox.Items.Insert(0, "Select Role");
            chooseRoleCombobox.SelectedIndex = 0;


        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmPasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text == "" || PasswordTextBox.Text == String.Empty || ConfirmPasswordTextBox.Text == String.Empty)
            {
                MessageBox.Show("Username and/or Password fields are empty", "Registration Failed", MessageBoxButtons.OK);

            }
            else if(PasswordTextBox.Text == ConfirmPasswordTextBox.Text && chooseRoleCombobox.SelectedItem != null)
            {
                
                loaddata.commandExc("Insert Into Users Values ('" + UsernameTextBox.Text + "','" + PasswordTextBox.Text + "','" + chooseRoleCombobox.SelectedItem + "')");


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
            this.Close();

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


    }
}
