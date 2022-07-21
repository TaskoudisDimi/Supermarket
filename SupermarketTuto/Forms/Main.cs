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
        private System.Windows.Forms.TabControl tabControl;
        Image closeImage;
        Point imagelocation = new Point(20,4);
        Point imageHitArea = new Point(20,4);

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

            MainMenu();

            closeImage = Properties.Resources.Close;

            //tabControl
            this.tabControl = new TabControl();
            this.SuspendLayout();
            this.tabControl.Location = new System.Drawing.Point(50, 50);
            this.tabControl.Name = "TestName";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new Size(900, 500);
            this.tabControl.TabIndex = 0;
            this.tabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            //Form
            this.Controls.Add(tabControl);


            TabPage sellers = new TabPage("Sellers");
            tabControl.Controls.Add(sellers);
            TabPage products = new TabPage("Products");
            tabControl.Controls.Add(products);
            TabPage categories = new TabPage("Categories");
            tabControl.Controls.Add(categories);

            this.tabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl_DrawItem);
            //this.tabControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl_MouseClick);




        }

        private void tabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            Image img;
            img = new Bitmap(closeImage);
            Rectangle r = e.Bounds;
            r = this.tabControl.GetTabRect(e.Index);
            r.Offset(2, 2);
            Brush TitleBrush = new SolidBrush(Color.Black);
            Font f = this.Font;
            string title = this.tabControl.TabPages[e.Index].Text;
            e.Graphics.DrawString(title, f, TitleBrush, new PointF(r.X, r.Y));
            e.Graphics.DrawImage(img, new Point(r.X + (this.tabControl.GetTabRect(e.Index).Width - imagelocation.X), imagelocation.Y));



        }

        //private void tabControl_MouseClick(object sender, MouseEventArgs e)
        //{
        //    TabControl tabControl = (TabControl)sender;
        //    Point p = e.Location;
        //    int tabWidth = 0;
        //    tabWidth = this.tabControl.GetTabRect(tabControl.SelectedIndex).Width - (imageHitArea.X);
        //    Rectangle r = this.tabControl.GetTabRect(tabControl.SelectedIndex);
        //    r.Offset(tabWidth, imageHitArea.Y);
        //    r.Width = 16;
        //    r.Height = 16;
        //    if (tabControl.SelectedIndex != this.tabControl.TabCount - 1)
        //    {
        //        if (r.Contains(p))
        //        {
        //            TabPage tabPage = (TabPage)tabControl.TabPages[tabControl.SelectedIndex];
        //            tabControl.TabPages.Remove(tabPage);

        //        }
        //    }
        //}



        private void MainMenu()
        {
            MenuStrip menu = new MenuStrip();

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

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Confirm to close", "Exit", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {

        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
