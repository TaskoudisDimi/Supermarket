using ClassLibrary1;
using ClassLibrary1.Models;
using DataClass;
using SupermarketTuto.Utils;
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
    public partial class AddBill : Form
    {
        string TotalAmount = "";
        DataTable billTable = new DataTable();
        BindingSource billBindingSource = new BindingSource();
        Type BillType = typeof(Bills);
        string SellerName = "";

        public AddBill(string TotalAmount_, string SellerName_)
        {
            InitializeComponent();
            TotalAmount = TotalAmount_;
            SellerName = SellerName_;
            totalAmountTextBox.Text = TotalAmount_;
            dateTextBox.Text = DateTime.Now.Date.ToString("dd-MM-yyyy");
            nameTextBox.Text = SellerName_;
        }

        private void addProduct_Load(object sender, EventArgs e)
        {
            displayBills();
            
        }

        private void displayBills()
        {
            billTable = DataAccess.Instance.GetTable("BillTbl");
            billBindingSource.DataSource = billTable;
            BillsDGV.DataSource = billBindingSource;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<DataRow> rowsToDelete = new List<DataRow>();
                DataRow row = null;
                // loop over the selected rows and add them to the list
                foreach (DataGridViewRow selectedRow in BillsDGV.SelectedRows)
                {
                    //Convert DataGridViewRow -> DataRow
                    row = ((DataRowView)selectedRow.DataBoundItem).Row;
                    rowsToDelete.Add(row);
                }

                DataAccess.Instance.DeleteData(row, BillType);
                // loop over the rows to delete and remove them from the DataTable
                foreach (DataRow rowToDelete in rowsToDelete)
                {
                    billTable.Rows.Remove(rowToDelete);
                }
                BillsDGV.DataSource = billTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Utlis.Log(string.Format("Message : {0}", ex.Message), "ErrorDeleteProduct.txt");
            }
        }

        private void billButton_Click(object sender, EventArgs e)
        {
            try
            {
                billTable.Columns["BillId"].AutoIncrement = true;
                DataRow row = billTable.NewRow();
                row["SellerName"] = nameTextBox.Text;
                row["TotAmt"] = totalAmountTextBox.Text;
                row["Date"] = dateTextBox.Text;
                row["Comments"] = commentsTextBox.Text;

                billTable.Rows.Add(row);
                if (billTable.Rows.Cast<DataRow>().Any(r => r.RowState == DataRowState.Added))
                {
                    DataAccess.Instance.InsertData(billTable);
                }
                MessageBox.Show($"Successfully inserted Category {row["SellerName"]}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region ChechDatabase
        private void check()
        {
            SqlConnect sql = new SqlConnect();
            var customerType = typeof(Bills);
            sql.checkTable(Categories: customerType);
        }

        #endregion
    }
}
