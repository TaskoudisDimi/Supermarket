using DataClass;
using SupermarketTuto.Utils;
using System.Windows.Forms;

namespace SupermarketTuto.Forms.SellingForms
{
    public partial class MainSelling : Form
    {
        public MainSelling()
        {
            InitializeComponent();
            this.Icon = new System.Drawing.Icon("C:/Users/chris/Desktop/Dimitris/Tutorials/Supermarket/SupermarketTuto/Resources/supermarket.ico");
            seller_Name_Label.Text = Globals.NameOfSeller;
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
        private void MnuStripAdmins_Click(object sender, EventArgs e)
        {
            Admin admins = new Admin(null, true);
            admins.Show();

        }

        private void MnuStripAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void MnuStripDb_Click(object sender, EventArgs e)
        {

            //SqlConnect db = new SqlConnect();
            //string path = "";

            //FolderBrowserDialog dialog = new FolderBrowserDialog();
            //DialogResult result = dialog.ShowDialog();
            //if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
            //{
            //    path = dialog.SelectedPath;
            //    db.backup(path);
            //}
            //else
            //{
            //    return;
            //}
        }


        private void createBillButton_Click(object sender, EventArgs e)
        {
            CreateBillForm form = new CreateBillForm();
            ShowFormOnPanel(form);
        }

        private void billButton_Click(object sender, EventArgs e)
        {
            Bills form = new Bills();
            ShowFormOnPanel(form);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            MainMenu();
            splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Confirm to close", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (confirm == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void categoriesProductsButton_Click(object sender, EventArgs e)
        {
            Category form = new Category();
            Product form2 = new Product();
            Show2FormsOnPanel(form, form2);
        }

        private void ShowFormOnPanel(Form newForm)
        {
            // Check if there's already a form in the panel
            if (splitContainer1.Panel1.Controls.Count > 0 && splitContainer1.Panel2.Controls.Count > 0)
            {
                // Remove the previous form from the panel
                splitContainer1.Panel1.Controls.RemoveAt(0);
                splitContainer1.Panel2.Controls.RemoveAt(0);
            }
            else if(splitContainer1.Panel1.Controls.Count > 0)
            {
                splitContainer1.Panel1.Controls.RemoveAt(0);
            }
            newForm.FormBorderStyle = FormBorderStyle.None;
            // Add the new form to the panel
            newForm.TopLevel = false;
            newForm.TopMost = true;
            splitContainer1.Panel1.Controls.Add(newForm);
            
            newForm.Show();

        }

        private void Show2FormsOnPanel(Form form1, Form form2)
        {
            if (splitContainer1.Panel1.Controls.Count > 0)
            {
                splitContainer1.Panel1.Controls.RemoveAt(0);
            }
            // Set the TopLevel and TopMost properties for both forms
            form1.TopLevel = false;
            form2.TopLevel = false;
            form1.TopMost = true;
            form2.TopMost = true;


            // Add both forms to the panel
            splitContainer1.Panel1.Controls.Add(form1);
            splitContainer1.Panel2.Controls.Add(form2);
            
            // Show both forms
            form1.Show();
            form2.Show();

        }

    }
}
