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
using ClassLibrary1.Models;
using ClassLibrary1;

namespace SupermarketTuto
{
    public partial class LogIn : Form
    {
        private bool logInSuccess = false;
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
            try
            {
                if (UserNameTextBox.Text == String.Empty && PasswordTextBox.Text == String.Empty)
                {
                    MessageBox.Show("Misiing Data!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (selectRoleCombobox.SelectedItem != "Select Role")
                    {
                        if (selectRoleCombobox.SelectedItem == "Admin")
                        {
                            bool findUserAdmin = false;
                            List<Admins> admins = DataModel.Select<Admins>(where: $"UserName = '{UserNameTextBox.Text}'");
                            foreach (Admins item in admins)
                            {
                                if (Utils.Utils.VerifyPassword(PasswordTextBox.Text, item.Password))
                                {
                                    logInSuccess = true;
                                    findUserAdmin = true;

                                    MainAdmin adminForms = new MainAdmin(item);
                                    adminForms.Show();

                                    // Close the LoginForm
                                    this.Hide();
                                    break;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            if (!findUserAdmin)
                            {
                                MessageBox.Show("Opps! Wrong Credentials!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        if (selectRoleCombobox.SelectedItem == "Seller")
                        {
                            bool findUser = false;
                            List<SellersTbl> sellers = DataModel.Select<SellersTbl>(where: $"SellerUserName = '{UserNameTextBox.Text}'");
                            foreach(SellersTbl item in sellers)
                            {
                                if (Utils.Utils.VerifyPassword(PasswordTextBox.Text, item.SellerPass))
                                {
                                    logInSuccess = true;
                                    Globals.NameOfSeller = item.SellerName;
                                    findUser = true;
                                    MainSelling sellingForms = new MainSelling();
                                    sellingForms.Show();
                                    // Close the LoginForm
                                    this.Hide();
                                    break;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            if (!findUser)
                            {
                                MessageBox.Show("Opps! Wrong Credentials!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    else if (selectRoleCombobox.SelectedItem == "Select Role")
                    {
                        MessageBox.Show("Select Role!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong", Constants.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void updateButton_Click(object sender, EventArgs e)
        {

        }

        public void changeDB()
        {

        }

        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            if (!logInSuccess)
            {
                DialogResult confirm = MessageBox.Show("Confirm to close", Constants.Exit, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }


        }
    }
}
