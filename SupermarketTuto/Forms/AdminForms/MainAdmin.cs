﻿using ClassLibrary1;
using ClassLibrary1.Models;
using DataClass;
using MenuStrip = System.Windows.Forms.MenuStrip;

namespace SupermarketTuto.Forms.AdminForms
{
    public partial class MainAdmin : Form
    {

        TCPClient ClientTCP = new TCPClient();
        Admins admin = new Admins();

        public MainAdmin(Admins admin_ = null)
        {
            InitializeComponent();
            admin = admin_;
        }

        private void MainAdmin_Load(object sender, EventArgs e)
        {
            MainMenu();
            if(admin != null)
                adminLabel.Text = admin.UserName;
            //ClientTCP.ConnectClient();
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
       
        private void SubMenu(ToolStripMenuItem items, string var)
        {
            if (var == "File")
            {
                string[] subItem = new string[] { "Admins", "Database", "Log out", "Exit" };
                foreach (string Row in subItem)
                {
                    ToolStripMenuItem subMenuItem = new ToolStripMenuItem(Row, null);
                    SubMenu(subMenuItem, Row);
                    items.DropDownItems.Add(subMenuItem);
                    if (subMenuItem.Text == "Admins")
                    {
                        subMenuItem.Click += new EventHandler(MnuStripAdmins_Click);
                    }
                    else if (subMenuItem.Text == "Database")
                    {
                        SubSubMenu(subMenuItem);
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

        }

        private void SubSubMenu(ToolStripMenuItem items)
        {
            string[] subSubItem = new string[] { "Backup", "Restore", "Clean Database" };
            foreach(string Row in subSubItem)
            {
                ToolStripMenuItem subSubMenuItem = new ToolStripMenuItem(Row, null);
                SubMenu(subSubMenuItem, Row);
                items.DropDownItems.Add(subSubMenuItem);
                if(subSubMenuItem.Text == "Backup")
                {
                    subSubMenuItem.Click += new EventHandler(MnuStripBackupDB_Click);
                }
                else if(subSubMenuItem.Text == "Restore")
                {
                    subSubMenuItem.Click += new EventHandler(MnuStripRestoreDB_Click);
                }
                else if(subSubMenuItem.Text == "Clean Database")
                {
                    subSubMenuItem.Click += new EventHandler(MnuStripCleanDB_Click);
                }
                else if (subSubMenuItem.Text == "Check Database")
                {
                    subSubMenuItem.Click += new EventHandler(MnuStripCheckDB_Click);
                }
            }
        }

        private void MnuStripRestoreDB_Click(object sender, EventArgs e)
        {
            RestoreDB form = new RestoreDB();
            form.Show();

        }

        private void MnuStripCleanDB_Click(object sender, EventArgs e)
        {
            if (DataModel.CleanDB())
            {
                MessageBox.Show("Sucessfully clean the db","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Something went wrong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MnuStripCheckDB_Click(object sender, EventArgs e)
        {
            return;
        }

        private void MnuStripAdmins_Click(object sender, EventArgs e)
        {
            Admin admins = new Admin(admin);
            admins.Show();
        }

        private void MnuStripLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn login = new LogIn();
            login.Show();
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

        private void MnuStripBackupDB_Click(object sender, EventArgs e)
        {
            string path = "";
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
            {
                path = dialog.SelectedPath;
                DataModel.backup(path);
            }
        }

        private void sellersButton_Click(object sender, EventArgs e)
        {
            Seller form = new Seller();
            ShowFormOnPanel(form);
        }

        public void categoriesButton_Click(object sender, EventArgs e)
        {
            Category form = new Category();
            ShowFormOnPanel(form);
        }

        private void productsButton_Click(object sender, EventArgs e)
        {
            Product form = new Product();
            ShowFormOnPanel(form);
        }

        public void MainAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            DialogResult confirm = MessageBox.Show("Confirm to close", Constants.Exit, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No)
            {
                //ClientTCP.StopClient();
                e.Cancel = true; 
            }
            

        }

        private void ShowFormOnPanel(Form newForm)
        {
            // Check if there's already a form in the panel
            if (splitContainer1.Panel1.Controls.Count > 0)
            {
                // Remove the previous form from the panel
                splitContainer1.Panel1.Controls.RemoveAt(0);
            }
            newForm.FormBorderStyle = FormBorderStyle.None;
            // Add the new form to the panel
            newForm.TopLevel = false;
            newForm.TopMost = true;
            splitContainer1.Panel1.Controls.Add(newForm);
            newForm.Show();

        }
    }
}
