﻿using ClassLibrary1;
using ClassLibrary1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SupermarketTuto.Forms.General
{
    public partial class addEditAdmin : Form
    {
        DataTable adminTable = new DataTable();
        DataGridViewRow selected = new DataGridViewRow();
        Admins admin = new Admins();
        public event EventHandler<AdminsEventArgs> ItemCreated;
        public event EventHandler<AdminsEventArgs> ItemEdited;
        

        public addEditAdmin(DataTable adminTable_, DataGridViewRow selected_, bool add)
        {
            InitializeComponent();
            adminTable = adminTable_;
            selected = selected_;
            superAdminCheckBox.Enabled = false;
            if (add)
            {
                editButton.Enabled = false;
            }
            else
            {
                AdminIdTb.Text = selected.Cells["Id"].Value.ToString();
                AdminNameTb.Text = selected.Cells["UserName"].Value.ToString();
                AdminPassTb.Text = selected.Cells["Password"].Value.ToString();
                activeCheckBox.Checked = (bool)selected.Cells["Active"].Value;
                superAdminCheckBox.Checked = (bool)selected.Cells["isSuperAdmin"].Value;
                addButton.Visible = false;
            }

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                admin.UserName = AdminNameTb.Text;
                admin.Password = AdminPassTb.Text;
                if (activeCheckBox.Checked)
                {
                    admin.Active = true;
                }
                else
                {
                    admin.Active = false;
                }
                admin.isSuperAdmin = false;

                DataModel.Create<Admins>(admin);
                OnItemCreated(new AdminsEventArgs(admin, admin.Id));

                MessageBox.Show($"Successfully inserted Admin {admin.UserName}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        protected virtual void OnItemCreated(AdminsEventArgs e)
        {
            ItemCreated?.Invoke(this, e);

        }

        private void editButton_Click(object senr, EventArgs e)
        {
            try
            {
                if (AdminIdTb.Text == "" || AdminNameTb.Text == "" || AdminPassTb.Text == "")
                {
                    MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    admin.Id = Convert.ToInt32(AdminIdTb.Text);
                    admin.UserName = AdminNameTb.Text;
                    admin.Password = AdminPassTb.Text;
                    if (activeCheckBox.Checked)
                        admin.Active = true;
                    else
                        admin.Active = false;
                    //if (superAdminCheckBox.Checked)
                    //    admin.isSuperAdmin = true;
                    //else
                    //    admin.isSuperAdmin = false;

                    DataModel.Update<Admins>(admin);
                    OnItemEdited(new AdminsEventArgs(admin, admin.Id));

                    MessageBox.Show($"Successfully inserted Category {admin.UserName}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        protected virtual void OnItemEdited(AdminsEventArgs e)
        {
            ItemEdited?.Invoke(this, e);
        }


    }

    public class AdminsEventArgs : EventArgs
    {
        public Admins CreatedAdmin { get; private set; }
        public int PrimaryKeyValue { get; private set; }

        public AdminsEventArgs(Admins admin, int primaryKeyValue)
        {
            CreatedAdmin = admin;
            PrimaryKeyValue = primaryKeyValue;
        }
    }
}
