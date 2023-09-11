using ClassLibrary1;
using ClassLibrary1.Models;
using DataClass;
using SupermarketTuto.Forms.General;
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

namespace SupermarketTuto.Forms.SellingForms
{
    public partial class CreateBillForm : Form
    {

        DataTable productDataTable = new DataTable();
        DataTable originalProductDataTable = new DataTable();
        DataTable productTableCombobox = new DataTable();
        Type productType = typeof(ProductTbl);
        BindingSource bindingSourceProducts = new BindingSource();
        private DataTable originalProductTable;
        DataTable categoryTable = new DataTable();
        

        public CreateBillForm()
        {
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            fillCombo();
            displayProducts();
        }

        private void displayProducts()
        {
            try
            {
                totalAmountTextBox.Enabled = false;

                if (productDataTable.Columns["Total"] == null)
                {
                    productDataTable.Columns.Add("Total", typeof(int));
                }

                var products = DataModel.Select<ProductTbl>();
                productDataTable = Utils.Utils.ToDataTable(products);
                productDataTable.PrimaryKey = new DataColumn[] { productDataTable.Columns["ProdId"] };
                bindingSourceProducts.DataSource = productDataTable;
                ProdDGV.DataSource = bindingSourceProducts;

                ProdDGV.RowHeadersVisible = false;
                ProdDGV.AllowUserToAddRows = false;
                ProdDGV.ReadOnly = true;
                totalLabel.Text = $"Total: {ProdDGV.RowCount}";
                ProdDGV.Columns[6].HeaderText = "Date";

                // Attach the CurrentChanged event handler to the BindingSource
                bindingSourceProducts.CurrentChanged += bindingSource_CurrentChanged;

                // Initialize the originalCategoryTable field with the same data as categoryTable
                originalProductTable = productDataTable.Copy();
                double total = 0;
                foreach (DataRow row in productDataTable.Rows)
                {
                    int qty = Convert.ToInt32(row["ProdQty"]);
                    int price = Convert.ToInt32(row["ProdPrice"]);
                    //row["Total"] = qty * price;
                    total += qty * price;
                }
                //double totAmount = productDataTable.AsEnumerable().Sum(row => row.Field<int>("Total"));
                totalAmountTextBox.Text = total.ToString();
            }
            catch (Exception ex)
            {
                Utils.Utils.Log(string.Format("Message : {0}", ex.Message), "ErrorPdoduct.txt");
            }

            //All Products
            productDataTable = DataAccess.Instance.GetTable("ProductTbl");
            
            

        }

        private void bindingSource_CurrentChanged(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            try
            {
                int currentPage = bindingSourceProducts.Position / 5 + 1;
                int startIndex = (currentPage - 1) * 5;

                DataTable pageDataTable = productDataTable.Clone();
                for (int i = startIndex; i < startIndex + 5 && i < bindingSourceProducts.Count; i++)
                {
                    pageDataTable.ImportRow(productDataTable.Rows[i]);
                }
               
                ProdDGV.DataSource = pageDataTable;
            }
            catch
            {

            }

        }

        private void fillCombo()
        {
            List<string> catNames = new List<string>();
            categoryTable = DataAccess.Instance.GetTable("CategoryTbl");
            foreach (DataRow row in categoryTable.Rows)
            {
                catNames.Add(row["CatName"].ToString());
            }
            catComboBox.DataSource = catNames;
            catComboBox.SelectedItem = null;
            catComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            catComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void catComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productDataTable.Rows.Count > 0)
            {
                productTableCombobox = productDataTable.Clone();
                foreach (DataRow row in productDataTable.Rows)
                {
                    if (catComboBox.Text == row["ProdCat"].ToString())
                    {
                        productTableCombobox.ImportRow(row);
                    }
                }
                ProdDGV.DataSource = productTableCombobox;
                ProdDGV.RowHeadersVisible = false;
                totalLabel.Text = $"Total: {ProdDGV.RowCount}";
            }
        }

        
        private void SellingDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void SearchCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            string SellerName = "";
            AddBill bill = new AddBill(totalAmountTextBox.Text, SellerName);

            bill.Show();

        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<DataRow> rowsToDelete = new List<DataRow>();
                DataRow row = null;
                // loop over the selected rows and add them to the list
                foreach (DataGridViewRow selectedRow in ProdDGV.SelectedRows)
                {
                    //Convert DataGridViewRow -> DataRow
                    row = ((DataRowView)selectedRow.DataBoundItem).Row;
                    rowsToDelete.Add(row);
                }

                //DataAccess.Instance.DeleteData(row, productType);
                //// loop over the rows to delete and remove them from the DataTable
                //foreach (DataRow rowToDelete in rowsToDelete)
                //{
                //    productDataTable.Rows.Remove(rowToDelete);
                //}
                //ProdDGV.DataSource = productDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Utils.Utils.Log(string.Format("Message : {0}", ex.Message), "ErrorDeleteProduct.txt");
            }
        }

       
        private void addProductButton_Click(object sender, EventArgs e)
        {
            addEditProduct add = new addEditProduct(productDataTable, null, categoryTable, true);
            add.editButton.Visible = false;
            add.ProdId.Visible = false;
            add.idLabel.Visible = false;
            add.ItemCreated += Add_ItemCreated;
            add.Show();
        }

        private void editProductButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = ProdDGV.CurrentRow;
            addEditProduct edit = new addEditProduct(productDataTable, currentRow, categoryTable, false);
            edit.addButton.Visible = false;
            edit.ProdId.ReadOnly = true;
            edit.ItemEdited += Edit_ItemEdited;
            edit.Show();
        }

        private void Add_ItemCreated(object sender, ProductEventArgs e)
        {
            productDataTable.Rows.Add(e.CreatedProduct.ProdId, e.CreatedProduct.ProdName, e.CreatedProduct.ProdQty, e.CreatedProduct.ProdPrice, e.CreatedProduct.ProdCatID, e.CreatedProduct.ProdCat, e.CreatedProduct.Date);
            ProdDGV.Refresh();
        }

        private void Edit_ItemEdited(object sender, ProductEventArgs e)
        {
            // Update the edited category in the DataTable in form

            DataRow editedRow = productDataTable.Rows.Find(e.PrimaryKeyValue);
            if (editedRow != null)
            {
                editedRow["ProdName"] = e.CreatedProduct.ProdName;
                editedRow["ProdPrice"] = e.CreatedProduct.ProdPrice;
                editedRow["ProdCat"] = e.CreatedProduct.ProdCat;
                editedRow["ProdCatID"] = e.CreatedProduct.ProdCatID;
                editedRow["ProdQty"] = e.CreatedProduct.ProdQty;
                editedRow["Date"] = e.CreatedProduct.Date;
            }
            ProdDGV.Refresh();

        }



        #region ChechDatabase

        #endregion

    }
}
