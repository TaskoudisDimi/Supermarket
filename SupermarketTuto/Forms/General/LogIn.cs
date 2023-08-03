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
using System.Diagnostics;
using SupermarketTuto.Forms;
using SupermarketTuto.Forms.AdminForms;
using System.Configuration;
using System.Reflection;
using DataClass;
using SupermarketTuto.Utils;
using Constants = DataClass.Constants;
using SupermarketTuto.Forms.SellingForms;
using DataTable = System.Data.DataTable;

namespace SupermarketTuto
{
    public partial class LogIn : Form
    {
        //SqlConnect loaddata = new SqlConnect();
        public LogIn()
        {
            InitializeComponent();
            selectRoleCombobox.Items.AddRange(new string[] { "Admin", "Seller" });
            selectRoleCombobox.Items.Insert(0, "Select Role");
            selectRoleCombobox.SelectedIndex = 0;
            CheckForUpdates();
            AddVersionNumber();
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
            //using (var manager = new UpdateManager(@"C:\Temp\Releases"))
            //{
            //    await manager.UpdateApp();
            //}
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            UserNameTextBox.Clear();
            PasswordTextBox.Clear();
            UserNameTextBox.Focus();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (UserNameTextBox.Text == String.Empty && PasswordTextBox.Text == String.Empty)
            //    {
            //        MessageBox.Show("Misiing Data!");
            //    }
            //    else
            //    {
            //        if (selectRoleCombobox.SelectedItem != "Select Role")
            //        {
            //            if (selectRoleCombobox.SelectedItem == "Admin")
            //            {
            //                loaddata.getData("Select * From [smarketdb].[dbo].[Admins] Where UserName = '" + UserNameTextBox.Text + "' and Password = CONVERT(varbinary,'" + PasswordTextBox.Text + "')");
            //                if (loaddata.table.Rows.Count == 1)
            //                {
            //                    MainAdmin products = new MainAdmin();
            //                    products.Show();
            //                    this.Hide();
            //                }
            //                else
            //                {
            //                    MessageBox.Show("Opps! Wrong Credentials!");
            //                }
            //            }
            //            if (selectRoleCombobox.SelectedItem == "Seller")
            //            {
            //                loaddata.getData("Select * From [smarketdb].[dbo].[SellersTbl] Where SellerUserName = '" + UserNameTextBox.Text + $"' and SellerPass = CONVERT(varbinary,'{PasswordTextBox.Text}')");
            //                if (loaddata.table.Rows.Count == 1)
            //                {

            //                    Globals.NameOfSeller = loaddata.table.Rows[0][1].ToString();

            //                    MainSelling selling = new MainSelling();
            //                    selling.Show();
            //                    this.Hide();
            //                }
            //                else
            //                {
            //                    MessageBox.Show("Opps! Wrong Credentials!");
            //                }
            //            }
            //        }
            //        else if (selectRoleCombobox.SelectedItem == "Select Role")
            //        {
            //            MessageBox.Show("Select Role!");
            //        }

            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error", Constants.Error, MessageBoxButtons.OK);
            //    Utlis.Log(string.Format("Message : {0}", ex.Message), "ErrorLogIn.txt");
            //}
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
            DialogResult confirm = MessageBox.Show("Confirm to close", Constants.Exit, MessageBoxButtons.YesNo);
            if (confirm == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

        }

        public void changeDB()
        {

        }
    }
}
