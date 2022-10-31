using SupermarketTuto.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketTuto.Forms.SellingForms
{
    public partial class MainSelling : Form
    {
        public MainSelling()
        {
            InitializeComponent();
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
                string[] subItem = new string[] { "Users", "BackUp", "Log out", "Exit" };
                foreach (string Row in subItem)
                {
                    ToolStripMenuItem subMenuItem = new ToolStripMenuItem(Row, null);
                    SubMenu(subMenuItem, Row);
                    items.DropDownItems.Add(subMenuItem);
                    if (subMenuItem.Text == "Users")
                    {
                        subMenuItem.Click += new EventHandler(MnuStripUsers_Click);
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

        }

        private void MnuStripExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MnuStripLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn login = new LogIn();
            login.Show();
        }
        private void MnuStripUsers_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Show();
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


        private void categoryButton_Click(object sender, EventArgs e)
        {
            CategoryForm form = new CategoryForm();
            form.TopLevel = false;
            form.TopMost = true;
            mainPanel.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void billButton_Click(object sender, EventArgs e)
        {
            Bills form = new Bills();
            form.TopLevel = false;
            form.TopMost = true;
            mainPanel.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            MainMenu();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Confirm to close", "Exit", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
