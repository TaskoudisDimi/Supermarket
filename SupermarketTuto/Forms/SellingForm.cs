using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;
using SupermarketTuto.DataAccess;
using SupermarketTuto.Forms;

namespace SupermarketTuto
{
    public partial class SellingForm : Form
    {
        public SellingForm()
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


        private void display()
        {
            SqlConnect loaddata = new SqlConnect();
            loaddata.retrieveData("Select * From [ProductTbl] Where [ProdCat] = '" + Convert.ToString(SearchCb.SelectedValue) + "'");
            SellingDGV.DataSource = loaddata.table;
            SellingDGV.AllowUserToAddRows = false;
            SellingDGV.RowHeadersVisible = false;
            totalLabel.Text = $"Total: {SellingDGV.RowCount}";

        }

        private void displayBills()
        {
            SqlConnect loaddata2 = new SqlConnect();
            loaddata2.retrieveData("Select * From BillTbl;");
            BillsDGV.DataSource = loaddata2.table;
            BillsDGV.AllowUserToAddRows = false;
            BillsDGV.RowHeadersVisible = false;
            total3Label.Text = $"Total: {BillsDGV.RowCount}";

        }
        
        private void displayDGV()
        {
            SqlConnect loaddata7 = new SqlConnect();
            loaddata7.retrieveData("Select * From SellingProducts");
            OrderDGV.DataSource = loaddata7.table;
            OrderDGV.AllowUserToAddRows = false;
            OrderDGV.RowHeadersVisible = false;
            total2Label.Text = $"Total: {OrderDGV.RowCount}";
        }

        private void fillCombo()
        {
            SqlConnect loaddata3 = new SqlConnect();
            loaddata3.retrieveData("Select CatName From CategoryTbl");
            SearchCb.DataSource = loaddata3.table;
            SearchCb.ValueMember = "CatName";
            SearchCb.SelectedItem = null;

        }

        private void SellingForm_Load(object sender, EventArgs e)
        {
            seller_Name_Label.Text = "Name" + LogIn.sellerName;

            MainMenu();
            fillCombo();
            display();
            displayBills();
            displayDGV();
            calcSum();


            ContextMenuStrip mnu = new ContextMenuStrip();
            ToolStripMenuItem mnuDelete = new ToolStripMenuItem("Delete");
            //Assign event handlers
            mnuDelete.Click += new EventHandler(mnuDelete_Click);
            //Add to main context menu
            mnu.Items.AddRange(new ToolStripItem[] { mnuDelete });
            //Assign to datagridview
            SellingDGV.ContextMenuStrip = mnu;


        }

        private void mnuDelete_Click(object? sender, EventArgs e)
        {
            SqlConnect loaddata4 = new SqlConnect();

            loaddata4.commandExc("Delete From ProductTbl Where SellerTbl=" + SellingDGV.Text + "");

            foreach (DataGridViewRow row in SellingDGV.SelectedRows)
            {
                SellingDGV.Rows.RemoveAt(row.Index);

            }
        }

        private void SellingPanel_Paint(object sender, PaintEventArgs e)
        {
            DateLabel.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();

        }

        private void AddProductbutton_Click(object sender, EventArgs e)
        {

            if (SellingProdName.Text == "" || SellingQuantityTextBox.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {

                SqlConnect loaddata8 = new SqlConnect();
                loaddata8.commandExc("Insert Into SellingProducts Values('" + SellingProdName.Text + "'," + SellingPriceTextBox.Text + "," + SellingQuantityTextBox.Text + "," + (Convert.ToInt32(SellingPriceTextBox.Text) * Convert.ToInt32(SellingQuantityTextBox.Text)) + ")");
                OrderDGV.DataSource = loaddata8.table;
                MessageBox.Show("Success");
                displayDGV();
                calcSum();
            }

        }

        private void calcSum()
        {
            double sum = 0;
            for (int i = 0; i < OrderDGV.Rows.Count; i++)
            {
                sum += double.Parse(OrderDGV.Rows[i].Cells[3].Value.ToString());
            }
            sumLabel.Text = sum.ToString();
        }

            
        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnect loaddata4 = new SqlConnect();

                loaddata4.commandExc("Insert Into BillTbl values('" + commentsRichTextBox.Text + "','" + seller_Name_Label.Text + "','" + DateLabel.Text + "'," + sumLabel.Text + ")");
                commentsRichTextBox.Text = String.Empty;
                displayBills();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }



        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString("FamilySuperMarket", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics.DrawString("Bill ID: " + BillsDGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Blue, new Point(100, 70));
            e.Graphics.DrawString("Seller Name: " + BillsDGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Blue, new Point(100, 100));
            e.Graphics.DrawString("Date: " + BillsDGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Blue, new Point(100, 130));
            e.Graphics.DrawString("Total Amount: " + BillsDGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Blue, new Point(100, 160));
            e.Graphics.DrawString("Code Space", new Font("Century Gothic", 20, FontStyle.Italic), Brushes.Blue, new Point(230, 230));


        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            display();
        }

        private void logOutLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn login = new LogIn();
            login.Show();
        }

        private void SellingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Confirm to close", "Exit", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void SellingDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SellingProdName.Text = SellingDGV.SelectedRows[0].Cells[0].Value.ToString();
            SellingPriceTextBox.Text = SellingDGV.SelectedRows[0].Cells[3].Value.ToString();

        }

        int flag = 0;
        private void BillsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            flag = 1;
        }

        private void SearchCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SqlConnect loaddata5 = new SqlConnect();
            loaddata5.retrieveData("Select * from ProductTbl Where ProdCat='" + SearchCb.SelectedValue.ToString() + "'");
            SellingDGV.DataSource = loaddata5.table;
            display();



        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            SqlConnect loaddata6 = new SqlConnect();
            loaddata6.commandExc("Delete From BillTbl Where BillId=" + BillsDGV.CurrentRow.Cells[0].Value.ToString() + "");
            foreach (DataGridViewRow row in BillsDGV.Rows)
            {
                BillsDGV.Rows.RemoveAt(row.Index);
            }
        }

        private void sidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void refreshBillsButton_Click(object sender, EventArgs e)
        {
            displayBills();
        }

        private void refreshOrderButton_Click(object sender, EventArgs e)
        {
            displayDGV();
        }
    }
}
