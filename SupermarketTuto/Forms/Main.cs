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

namespace SupermarketTuto.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MainMenu();

            //closeImage = Properties.Resources.Close;

            //List<string> language = new List<string>();
            //language.Add("Greek");
            //language.Add("English");

            //languageComboBox.DataSource = language;
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

        private void categoriesButton_Click(object sender, EventArgs e)
        {
            Category form = new Category();
            form.TopLevel = false;
            form.TopMost = true;
            mainPanel.Controls.Add(form);
            form.BringToFront();

            form.Show();
        }

        private void productsButton_Click(object sender, EventArgs e)
        {
            Product form = new Product();
            form.TopLevel = false;
            form.TopMost = true;
            mainPanel.Controls.Add(form);
            form.BringToFront();

            form.Show();
        }

        private void sellersButton_Click(object sender, EventArgs e)
        {
            Seller form = new Seller();
            form.TopLevel = false;
            form.TopMost = true;
            mainPanel.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Confirm to close", "Exit", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
