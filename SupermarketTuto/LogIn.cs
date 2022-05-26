﻿using System;
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
    public partial class LogIn : Form
    {


        SqlConnect loaddata = new SqlConnect();

        
        public LogIn()
        {
            InitializeComponent();

            selectRoleCombobox.Items.AddRange(new string[] { "Admin", "Seller"});
            selectRoleCombobox.Items.Insert(0, "Select Role");
            selectRoleCombobox.SelectedIndex = 0;


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


            loaddata.retrieveData("Select * From [smarketdb].[dbo].[Users] Where Username= '" + UserNameTextBox.Text + "' and Password= '" + PasswordTextBox.Text + "' and Role= '" + selectRoleCombobox.SelectedItem + "'");
            
            if (loaddata.table.Rows.Count == 1 && selectRoleCombobox.SelectedItem != "Select Role")
            {
                if (selectRoleCombobox.SelectedItem == "Admin")
                {

                    ProductsForm products = new ProductsForm();
                    products.Show();
                    this.Hide();
                }
                if (selectRoleCombobox.SelectedItem == "Seller")
                {
                    SellingForm selling = new SellingForm();
                    selling.Show();
                    this.Hide();
                }
            }
            else if (selectRoleCombobox.SelectedItem == "Select Role")
            {
                MessageBox.Show("Select Role!");
            }
            else
            {
                MessageBox.Show("Error!");
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
    }
}