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
using Squirrel;
using System.Diagnostics;
using SupermarketTuto.Forms;
using SupermarketTuto.Forms.AdminForms;

namespace SupermarketTuto
{
    public partial class LogIn : Form
    {


        SqlConnect loaddata = new SqlConnect();
        public static string sellerName = "";

        public LogIn()
        {
            InitializeComponent();

            selectRoleCombobox.Items.AddRange(new string[] { "Admin", "Seller" });
            selectRoleCombobox.Items.Insert(0, "Select Role");
            selectRoleCombobox.SelectedIndex = 0;

            CheckForUpdates();
            AddVersionNumber();
        }

        private void AddVersionNumber()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            versionLabel.Text = $"Version v.{versionInfo.FileVersion}";
        }

        private async Task CheckForUpdates()
        {
            using (var manager = new UpdateManager(@"C:\Temp\Releases"))
            {
                await manager.UpdateApp();
            }
        }

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
            try
            {
                if (UserNameTextBox.Text == String.Empty && PasswordTextBox.Text == String.Empty)
                {
                    MessageBox.Show("Misiing Data!");
                }
                else
                {
                    loaddata.retrieveData("Select * From [smarketdb].[dbo].[Users] Where Username= '" + UserNameTextBox.Text + "' and Password= '" + PasswordTextBox.Text + "' and Role= '" + selectRoleCombobox.SelectedItem + "'");
                    sellerName = UserNameTextBox.Text;

                    if (loaddata.table.Rows.Count == 1 && selectRoleCombobox.SelectedItem != "Select Role")
                    {
                        if (selectRoleCombobox.SelectedItem == "Admin")
                        {

                            MainAdmin products = new MainAdmin();
                            products.Show();
                            this.Hide();
                        }
                        if (selectRoleCombobox.SelectedItem == "Seller")
                        {
                            //SellingForm selling = new SellingForm();
                            //selling.Show();
                            this.Hide();
                        }
                    }
                    else if (selectRoleCombobox.SelectedItem == "Select Role")
                    {
                        MessageBox.Show("Select Role!");
                    }
                    else
                    {
                        MessageBox.Show("Opps! Wrong Credentials!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK);
            }

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


        private void LogIn_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Confirm to close", "Exit", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

        }
    }
}
