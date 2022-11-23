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
    public partial class CreateBillForm : Form
    {
        public CreateBillForm()
        {
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            fillCombo();
            display();
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
        private void display()
        {
            SqlConnect loaddata = new SqlConnect();
            loaddata.retrieveData("Select * From [ProductTbl] Where [ProdCat] = '" + Convert.ToString(SearchCb.SelectedValue) + "'");
            SellingDGV.DataSource = loaddata.table;
            SellingDGV.AllowUserToAddRows = false;
            SellingDGV.RowHeadersVisible = false;
            totalLabel.Text = $"Total: {SellingDGV.RowCount}";

        }

        private void displayDGV()
        {
            SqlConnect loaddata7 = new SqlConnect();
            loaddata7.retrieveData("Select * From BillingProducts");
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

        private void mnuDelete_Click(object? sender, EventArgs e)
        {
            SqlConnect loaddata4 = new SqlConnect();

            loaddata4.commandExc("Delete From ProductTbl Where SellerTbl=" + SellingDGV.Text + "");

            foreach (DataGridViewRow row in SellingDGV.SelectedRows)
            {
                SellingDGV.Rows.RemoveAt(row.Index);

            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            display();
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
                loaddata8.commandExc("Insert Into BillingProducts Values('" + SellingProdName.Text + "'," + SellingPriceTextBox.Text + "," + SellingQuantityTextBox.Text + "," + (Convert.ToInt32(SellingPriceTextBox.Text) * Convert.ToInt32(SellingQuantityTextBox.Text)) + ")");
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
                sum += double.Parse(OrderDGV.Rows[i].Cells[4].Value.ToString());
            }
            AmountLabel.Text = sum.ToString();
        }

        private void SellingDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SellingProdName.Text = SellingDGV.SelectedRows[0].Cells[1].Value.ToString();
            SellingPriceTextBox.Text = SellingDGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void SearchCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SqlConnect loaddata5 = new SqlConnect();
            loaddata5.retrieveData("Select * from ProductTbl Where ProdCat='" + SearchCb.SelectedValue.ToString() + "'");
            SellingDGV.DataSource = loaddata5.table;
            display();
        }

        private void refreshOrderButton_Click(object sender, EventArgs e)
        {
            displayDGV();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
           CreateBill bill = new CreateBill();
           bill.AmountLabel.Text = AmountLabel.Text;
           bill.Show();
           
        }
    }
}
