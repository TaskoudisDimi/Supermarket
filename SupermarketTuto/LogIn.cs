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


namespace SupermarketTuto
{
    public partial class LogIn : Form
    {
        
        public LogIn()
        {
            InitializeComponent();
        }

        //SqlConnection Con = new SqlConnection(@"Data Source=DIMITRISTASKOUD\DIMITRIS_TASKOUD;Initial Catalog=smarketdb;Integrated Security=True");

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-FF268DF\SQLEXPRESS;Initial Catalog=smarketdb;Integrated Security=True");

        private void UserNameTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            UserNameTextBox.Clear();
            PasswordTextBox.Clear(); 
            UserNameTextBox.Focus();

        }

        private void LogInButton_Click(object sender, EventArgs e)
        {

            Con.Open();
            string login = "Select * From Users Where Username= '" + UserNameTextBox.Text + "' and Password= '" + PasswordTextBox.Text + "'";
            SqlCommand cmd = new SqlCommand(login, Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();


            if (rdr.Read())
            {
                ProductsForm products = new ProductsForm();
                products.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Password or Username, Please try again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserNameTextBox.Clear();
                PasswordTextBox.Clear();
                UserNameTextBox.Focus();

            }
            Con.Close();




        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();

        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked)
            {
                PasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                PasswordTextBox.PasswordChar = '*';
            }
        }
    }
}
