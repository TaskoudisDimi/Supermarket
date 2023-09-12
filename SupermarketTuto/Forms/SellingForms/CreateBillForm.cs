using ClassLibrary1;
using ClassLibrary1.Models;
using DataClass;
using Microsoft.Office.Interop.Excel;
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
using DataTable = System.Data.DataTable;

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
        private double total = 0;
        List<ProductTbl> selectedProd;

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

                DataGridViewCheckBoxColumn Select = new DataGridViewCheckBoxColumn();
                Select.Name = "Select";
                Select.ReadOnly = false;

                ProdDGV.Columns.Add(Select);
                ProdDGV.Columns["Select"].DisplayIndex = 0;

                ClassLibrary1.MenuStrip.Instance.Menu(ProdDGV, categoryTable, null, productType, true);


                var products = DataModel.Select<ProductTbl>();
                productDataTable = Utils.Utils.ToDataTable(products);
                productDataTable.PrimaryKey = new DataColumn[] { productDataTable.Columns["ProdId"] };
                bindingSourceProducts.DataSource = productDataTable;
                ProdDGV.DataSource = bindingSourceProducts;

                ProdDGV.RowHeadersVisible = false;
                ProdDGV.AllowUserToAddRows = false;
                ProdDGV.ReadOnly = false;
                //ProdDGV.Columns["Select"].ReadOnly = false;
                totalLabel.Text = $"Total: {ProdDGV.RowCount}";
                ProdDGV.Columns[6].HeaderText = "Date";

                // Attach the CurrentChanged event handler to the BindingSource
                bindingSourceProducts.CurrentChanged += bindingSource_CurrentChanged;

                // Initialize the originalCategoryTable field with the same data as categoryTable
                originalProductTable = productDataTable.Copy();
                
                foreach (DataRow row in productDataTable.Rows)
                {
                    int qty = Convert.ToInt32(row["ProdQty"]);
                    int price = Convert.ToInt32(row["ProdPrice"]);
                    total += qty * price;
                }
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

        private void SellingDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string SellerName = "";
            FindProducts();
            AddBill bill = new AddBill(totalAmountTextBox.Text, SellerName, selectedProd);
            bill.Show();
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

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            searchButton.PerformClick();
        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                searchButton.PerformClick();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // If the search text is not empty, filter the originalCategoryTable and assign the filtered result to the categoryTable
            if (!string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                var matchingRows = from row in originalProductTable.AsEnumerable()
                                   where row.ItemArray.Any(x =>
                                         StringComparer.OrdinalIgnoreCase.Equals(x.ToString(), searchTextBox.Text))
                                   select row;

                if (matchingRows.Any())
                {
                    productDataTable = matchingRows.CopyToDataTable();
                }
                else
                {
                    productDataTable = productDataTable.Clone();
                }
            }
            // If the search text is empty, assign the originalCategoryTable to the categoryTable
            else
            {
                productDataTable = originalProductTable.Copy();
            }

            // Bind the categoryTable to the CatDGV DataGridView control
            ProdDGV.DataSource = productDataTable;
        }
  
        private void fromDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (productDataTable.Rows.Count > 0)
            {
                DateTime dateTimePicker = fromDateTimePicker.Value.Date;
                string filterDate = "Date >= #" + dateTimePicker.ToString("yyyy/MM/dd") + "#";
                DataRow[] filteredRows = productDataTable.Select(filterDate);

                DataTable filterTable = productDataTable.Clone();
                foreach (DataRow row in filteredRows)
                {
                    filterTable.ImportRow(row);
                }
                ProdDGV.DataSource = filterTable;
            }
        }

        private void toDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (productDataTable.Rows.Count > 0)
            {
                DateTime dateTimePicker = toDateTimePicker.Value.Date;
                string filterDate = "Date <= #" + dateTimePicker.ToString("yyyy/MM/dd") + "#";
                DataRow[] filteredRows = productDataTable.Select(filterDate);

                DataTable filterTable = productDataTable.Clone();
                foreach (DataRow row in filteredRows)
                {
                    filterTable.ImportRow(row);
                }
                ProdDGV.DataSource = filterTable;
            }
        }

        private void selectAllCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (selectAllCheckBox.Checked)
            {
                foreach (DataGridViewRow row in ProdDGV.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                    chk.Value = !(chk.Value == null ? false : (bool)chk.Value);
                }
            }
            else
            {
                foreach (DataGridViewRow row in ProdDGV.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                    chk.Value = !(chk.Value == null ? true : (bool)chk.Value);
                }

            }
        }

        private void recalculateButton_Click(object sender, EventArgs e)
        {
            total = 0;
            FindProducts();

            if (selectedProd != null)
            {
                foreach (ProductTbl item in selectedProd)
                {
                    int qty = item.ProdQty;
                    int price = item.ProdPrice;
                    total += qty * price;
                }
            }
            
            totalAmountTextBox.Text = total.ToString();
        }

        private void FindProducts()
        {
            selectedProd = new List<ProductTbl>();
            for (int i = 0; i < ProdDGV.Rows.Count; i++)
            {
                if (Convert.ToBoolean(ProdDGV.Rows[i].Cells[0].Value))
                {
                    ProductTbl products = DataModel.Select<ProductTbl>(where: $"ProdId = {(int)ProdDGV.Rows[i].Cells[1].Value}").FirstOrDefault();
                    selectedProd.Add(products);
                }
            }
        }
    }
}
