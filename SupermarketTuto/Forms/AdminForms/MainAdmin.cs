﻿using DataClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketTuto.Forms.AdminForms
{
    public partial class MainAdmin : Form
    {
        public MainAdmin()
        {
            InitializeComponent();
        }

        private void MainAdmin_Load(object sender, EventArgs e)
        {
            MainMenu();
        }
        
        private void MainMenu()
        {
            MenuStrip menu = new MenuStrip();
            menu.Dock = DockStyle.Top;
            menu.Font = new Font("Segoe UI", 16);
            this.Controls.Add(menu);
            string[] items = new string[] { "File", "About" };
            foreach (string Row in items)
            {
                ToolStripMenuItem MnuStripItem = new ToolStripMenuItem(Row);
                menu.Items.Add(MnuStripItem);
                SubMenu(MnuStripItem, Row);
                if (MnuStripItem.Text == "About")
                {
                    MnuStripItem.Click += new EventHandler(MnuStripAbout_Click);
                }

            }
        }
        public void SubMenu2(ToolStripMenuItem MnuItems, string var)
        {
            if (var == "File")
            {
                string[] row = new string[] { "New", "Open", "Add", "Close", "Close Solution" };
                foreach (string rw in row)
                {
                    ToolStripMenuItem SSMenu = new ToolStripMenuItem(rw, null);
                    SubMenu(SSMenu, rw);
                    MnuItems.DropDownItems.Add(SSMenu);
                }
            }

            if (var == "New")
            {
                string[] row = new string[] { "Project", "Web Site", "File..", "Project From Existing Code" };
                foreach (string rw in row)
                {
                    ToolStripMenuItem SSSMenu = new ToolStripMenuItem(rw, null);
                    MnuItems.DropDownItems.Add(SSSMenu);
                }
            }
        }
        private void SubMenu(ToolStripMenuItem items, string var)
        {
            if (var == "File")
            {
                string[] subItem = new string[] { "Admins", "BackUp", "Log out", "Exit" };
                foreach (string Row in subItem)
                {
                    ToolStripMenuItem subMenuItem = new ToolStripMenuItem(Row, null);
                    SubMenu(subMenuItem, Row);
                    items.DropDownItems.Add(subMenuItem);
                    if (subMenuItem.Text == "Admins")
                    {
                        subMenuItem.Click += new EventHandler(MnuStripAdmins_Click);
                    }
                    else if (subMenuItem.Text == "BackUp")
                    {
                        subMenuItem.Click += new EventHandler(MnuStripDb_Click);
                    }
                    else if (subMenuItem.Text == "Log out")
                    {
                        subMenuItem.Click += new EventHandler(MnuStripLogOut_Click);
                    }
                    else if (subMenuItem.Text == "Exit")
                    {
                        subMenuItem.Click += new EventHandler(MnuStripExit_Click);
                    }
                }
            }
            //if (var == "AllUsers")
            //{
            //    string[] row = new string[] { "Sellers", "Admins"};
            //    foreach (string rw in row)
            //    {
            //        ToolStripMenuItem SSSMenu = new ToolStripMenuItem(rw, null);
            //        items.DropDownItems.Add(SSSMenu);
            //        if (SSSMenu.Text == "Sellers")
            //        {
            //            SSSMenu.Click += new EventHandler(MnuStripSellers_Click);
            //        }
            //        else if (SSSMenu.Text == "Admins")
            //        {
            //            SSSMenu.Click += new EventHandler(MnuStripAdmins_Click);
            //        }
            //    }
            //}
        }

        private void MnuStripAdmins_Click(object sender, EventArgs e)
        {
            Admin admins = new Admin();
            admins.Show();
        }

        private void MnuStripLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn login = new LogIn();
            login.Show();
        }

        private void MnuStripUsers_Click(object sender, EventArgs e)
        {
            Admin users = new Admin();
            users.Show();
        }

        private void MnuStripExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MnuStripAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void MnuStripDb_Click(object sender, EventArgs e)
        {

            SqlConnect db = new SqlConnect();
            string path = "";
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
            {
                path = dialog.SelectedPath;
                db.backup(path);
            }
            else
            {
                return;
            }
        }

        private void sellersButton_Click(object sender, EventArgs e)
        {
            Seller form = new Seller();
            form.TopLevel = false;
            form.TopMost = true;
            splitContainer1.Panel1.Controls.Add(form);
            form.Show();
        }

        

        public void categoriesButton_Click(object sender, EventArgs e)
        {
            Category form = new Category();
            form.TopLevel = false;
            form.TopMost = true; 
            splitContainer1.Panel1.Controls.Add(form);
            form.checkBoxProducts.CheckedChanged += new System.EventHandler(this.checkBoxProducts_CheckedChanged);
            form.Show();
        }

        public void checkBoxProducts_CheckedChanged(object sender, EventArgs e)
        {
            //splitContainer1.Panel2Collapsed = !form22.checkBoxProducts.Checked;
            displayProducts();
        }
        public void displayProducts()
        {
            Product form = new Product();
            form.TopLevel = false;
            form.TopMost = true;
            splitContainer1.Panel2.Controls.Add(form);
            form.Show();
        }

        private void productsButton_Click(object sender, EventArgs e)
        {
            Product form = new Product();
            form.TopLevel = false;
            form.TopMost = true;
            splitContainer1.Panel1.Controls.Add(form);
            form.Show();
        }
        public void MainAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Confirm to close", Constants.Exit, MessageBoxButtons.YesNo);
            if (confirm == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        


    }
}
