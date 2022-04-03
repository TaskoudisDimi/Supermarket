namespace SupermarketTuto
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

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
                            ProductsForm productForm = new ProductsForm();
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
                        if (usernameTextBox.Text == "test" && passwordTextBox.Text == "test")
                        {
                            ProductsForm productForm = new ProductsForm();
                            productForm.Show();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("If you are the Seller, enter the correct username and password");

                        }
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
    }
}