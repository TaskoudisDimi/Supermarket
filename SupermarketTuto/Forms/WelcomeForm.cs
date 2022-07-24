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
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }


        //SqlConnection Con = new SqlConnection(@"Data Source=DIMITRISTASKOUD\DIMITRIS_TASKOUD;Initial Catalog=smarketdb;Integrated Security=True");
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-FF268DF\SQLEXPRESS;Initial Catalog=smarketdb;Integrated Security=True");

        public static string Sellername = "";

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearLabel_Click(object sender, EventArgs e)
        {
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show("Enter the Username and Password");
            }
            else
            {
                if (RoleCb.SelectedIndex > -1)
                {
                    if (RoleCb.SelectedItem.ToString() == "ADMIN")
                    {
                        if (usernameTextBox.Text == "admin" && passwordTextBox.Text == "admin")
                        {
                            Products productForm = new Products();
                            productForm.Show();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("If you are the Amdin, Enter the correct username and password");

                        }
                    }
                    else
                    {
                        Con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("Select count (8) From SellerTbl Where SellerName='" + usernameTextBox.Text + "' and SellerPass='" + passwordTextBox.Text + "'", Con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if(dt.Rows[0][0].ToString() == "1")
                        {
                            Sellername = usernameTextBox.Text;
                            SellingForm sell = new SellingForm();
                            sell.Show();
                            this.Hide();
                            Con.Close();
                        }
                        else
                        {
                            MessageBox.Show("Wrong Username or Password");
                        }
                        Con.Close();
                        
                        
                        
                        
                        //if (usernameTextBox.Text == "test" && passwordTextBox.Text == "test")
                        //{
                        //    ProductsForm productForm = new ProductsForm();
                        //    productForm.Show();
                        //    this.Hide();

                        //}
                        //else
                        //{
                        //    MessageBox.Show("If you are the Seller, enter the correct username and password");

                        //}
                    }


                }
                else
                {
                    MessageBox.Show("Select a role");
                }


            }
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }

        private void Connection_Click(object sender, EventArgs e)
        {
            //SqlConnect connect = new SqlConnect();
            Con.Open();
            MessageBox.Show("Connection succed!");
            Con.Close();

        }
    }
}