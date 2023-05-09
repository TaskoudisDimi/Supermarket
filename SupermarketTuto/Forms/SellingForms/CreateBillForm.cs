using ClassLibrary1.Models;
using DataClass;
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

        }

        private void display()
        {
            
            SellingDGV.AllowUserToAddRows = false;
            SellingDGV.RowHeadersVisible = false;
            totalLabel.Text = $"Total: {SellingDGV.RowCount}";

        }

        private void displayDGV()
        {
            
            OrderDGV.AllowUserToAddRows = false;
            OrderDGV.RowHeadersVisible = false;
            total2Label.Text = $"Total: {OrderDGV.RowCount}";
        }

        private void fillCombo()
        {
            
            SearchCb.ValueMember = "CatName";
            SearchCb.SelectedItem = null;

        }


        private void refreshButton_Click(object sender, EventArgs e)
        {
            display();
        }

        private void AddProductbutton_Click(object sender, EventArgs e)
        {
            //if (SellingProdName.Text == "" || SellingQuantityTextBox.Text == "")
            //{
            //    MessageBox.Show("Missing Data");
            //}
            //else
            //{
            //    MessageBox.Show("Success");
            //    displayDGV();
            //    calcSum();
            //}
        }

        private void calcSum()
        {
            double sum = 0;
            for (int i = 0; i < OrderDGV.Rows.Count; i++)
            {
                sum += double.Parse(OrderDGV.Rows[i].Cells[4].Value.ToString());
            }
            AmountLabel.Text = "Total Amount : " + sum.ToString();
        }

        private void SellingDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //SellingProdName.Text = SellingDGV.SelectedRows[0].Cells[1].Value.ToString();
            //SellingPriceTextBox.Text = SellingDGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void SearchCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            
        }

        private void refreshOrderButton_Click(object sender, EventArgs e)
        {
           
        }

        private void addButton_Click(object sender, EventArgs e)
        {
           AddBill bill = new AddBill();
           bill.AmountLabel.Text = AmountLabel.Text;
           bill.Show();
           
        }

        private void delete2Button_Click(object sender, EventArgs e)
        {
            
        }

        #region ChechDatabase
        private void check()
        {
            SqlConnect sql = new SqlConnect();
            var customerType = typeof(BillingProducts);
            sql.checkTable(Categories: customerType);
        }

        #endregion

    }
}
