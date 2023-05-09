using ClassLibrary1;
using ClassLibrary1.Models;
using DataClass;
using SupermarketTuto.Forms.General;
using SupermarketTuto.Utils;
using System.Data;
using System.Windows.Forms;

namespace SupermarketTuto.Forms.SellingForms
{
    public partial class Categories_Products : Form
    {
        ExcelFile excel = new ExcelFile();
        BindingSource bindingSourceCategory = new BindingSource();
        DataTable categoryTable = new DataTable();
        Type categoryType = typeof(Categories);
        private DataTable originalCategoryTable;

        BindingSource bindingSourceProduct = new BindingSource();
        DataTable productTable = new DataTable();
        Type productType = typeof(Categories);
        private DataTable originalProductTable;



        public Categories_Products()
        {
            InitializeComponent();
        }

        private void Categories_Products_Load(object sender, EventArgs e)
        {
            fromProductDateTimePicker.Value = DateTime.Today.AddDays(-7);
            fromCategoryDateTimePicker.Value = DateTime.Today.AddDays(-7);

            fillCombo();
            displayProducts();
            
            displayCategories();

        }

        private void displayCategories()
        {
            try
            {
                fromProductDateTimePicker.Value = DateTime.Now.AddMonths(-2);

                categoryTable = DataAccess.Instance.GetTable("CategoryTbl");
                // Bind the data to the UI controls using the BindingSource
                bindingSourceCategory = new BindingSource();
                bindingSourceCategory.DataSource = categoryTable;

                CatDGV.DataSource = bindingSourceCategory;

                CatDGV.RowHeadersVisible = false;

                CatDGV.Columns[3].HeaderText = "Date";


                // Attach the CurrentChanged event handler to the BindingSource
                bindingSourceCategory.CurrentChanged += bindingSource_CurrentChangedCategories;

                totalLabel.Text = $"Total: {CatDGV.RowCount}";

                // Initialize the originalCategoryTable field with the same data as categoryTable
                originalCategoryTable = categoryTable.Copy();

                if (totalLabel.Text == null)
                {
                    MessageBox.Show("Warning", "There is no data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Utlis.Log(string.Format("Message : {0}", ex.Message), "ErrorImportTxt.txt");
            }
        }

        private void bindingSource_CurrentChangedCategories(object sender, EventArgs e)
        {
            UpdateDataGridViewCategories();
        }

        private void UpdateDataGridViewCategories()
        {
            try
            {
                int currentpage = bindingSourceCategory.Position / 5 + 1;
                int startIndex = (currentpage - 1) * 5;
                DataTable pageDataTable = categoryTable.Clone();
                for (int i = startIndex; i < startIndex + 5 && i < bindingSourceCategory.Count; i++)
                {
                    pageDataTable.ImportRow(categoryTable.Rows[i]);
                }
                CatDGV.DataSource = pageDataTable;
            }
            catch
            {

            }
            
        }

        private void displayProducts()
        {
            try
            {
                fromProductDateTimePicker.Value = DateTime.Now.AddMonths(-2);
                productTable = DataAccess.Instance.GetTable("ProductTbl");

                bindingSourceProduct.DataSource = productTable;
                ProdDGV.DataSource = bindingSourceProduct;

                ProdDGV.RowHeadersVisible = false;
                ProdDGV.AllowUserToAddRows = false;
                ProdDGV.ReadOnly = true;
                totalLabel.Text = $"Total: {ProdDGV.RowCount}";
                ProdDGV.Columns[6].HeaderText = "Date";

                // Attach the CurrentChanged event handler to the BindingSource
                bindingSourceProduct.CurrentChanged += bindingSource_CurrentChangedProducts;

                // Initialize the originalCategoryTable field with the same data as categoryTable
                originalProductTable = productTable.Copy();

            }
            catch (Exception ex)
            {
                Utlis.Log(string.Format("Message : {0}", ex.Message), "ErrorPdoduct.txt");
            }
        }

        private void bindingSource_CurrentChangedProducts(object sender, EventArgs e)
        {
            UpdateDataGridViewProducts();
        }

        private void UpdateDataGridViewProducts()
        {
            try
            {
                int currentPage = bindingSourceProduct.Position / 5 + 1;
                int startIndex = (currentPage - 1) * 5;

                DataTable pageDataTable = productTable.Clone();
                for (int i = startIndex; i < startIndex + 5 && i < bindingSourceProduct.Count; i++)
                {
                    pageDataTable.ImportRow(productTable.Rows[i]);
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

        #region DateTimePickers
        #endregion

        #region Events
        #endregion

        #region Buttons
        #endregion

        #region Excel
        #endregion

        #region Paging
        #endregion

        private void addProductButton_Click(object sender, EventArgs e)
        {

        }

        private void editProductButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            
        }

        private void add2Button_Click(object sender, EventArgs e)
        {
            //addEditCategory add = new addEditCategory();
            //add.editButton.Visible = false;
            //add.CatIdTb.Visible = false;
            //add.idlabel.Visible = false;
            //add.Show();
        }

        private void catComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }

        private void fromProductDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (categoryTable.Rows.Count > 0)
            {
                // Assuming you have a DataTable named "myDataTable"
                DateTime pickerDate = fromProductDateTimePicker.Value.Date;
                string filterExpression = "Date >= #" + pickerDate.ToString("yyyy/MM/dd") + "#";
                DataRow[] filteredRows = categoryTable.Select(filterExpression);

                // Create a new DataTable from the filtered rows
                DataTable filteredTable = categoryTable.Clone();
                foreach (DataRow row in filteredRows)
                {
                    filteredTable.ImportRow(row);
                }

                // Bind the new DataTable to a DataGridView
                CatDGV.DataSource = filteredTable;
            }
        }

        private void toProductDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (categoryTable.Rows.Count > 0)
            {
                // Assuming you have a DataTable named "myDataTable"
                DateTime pickerDate = toProductDateTimePicker.Value.Date;
                string filterExpression = "Date <= #" + pickerDate.ToString("yyyy/MM/dd") + "#";
                DataRow[] filteredRows = categoryTable.Select(filterExpression);

                // Create a new DataTable from the filtered rows
                DataTable filteredTable = categoryTable.Clone();
                foreach (DataRow row in filteredRows)
                {
                    filteredTable.ImportRow(row);
                }

                // Bind the new DataTable to a DataGridView
                CatDGV.DataSource = filteredTable;
            }
        }

        private void from2DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (productTable.Rows.Count > 0)
            {
                DateTime dateTimePicker = fromProductDateTimePicker.Value.Date;
                string filterDate = "Date >= #" + dateTimePicker.ToString("yyyy/MM/dd") + "#";
                DataRow[] filteredRows = productTable.Select(filterDate);

                DataTable filterTable = productTable.Clone();
                foreach (DataRow row in filteredRows)
                {
                    filterTable.ImportRow(row);
                }
                ProdDGV.DataSource = filterTable;
            }
        }

        private void to2DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (productTable.Rows.Count > 0)
            {
                DateTime dateTimePicker = toProductDateTimePicker.Value.Date;
                string filterDate = "Date <= #" + dateTimePicker.ToString("yyyy/MM/dd") + "#";
                DataRow[] filteredRows = productTable.Select(filterDate);

                DataTable filterTable = productTable.Clone();
                foreach (DataRow row in filteredRows)
                {
                    filterTable.ImportRow(row);
                }
                ProdDGV.DataSource = filterTable;
            }
        }

        private void edit2Button_Click(object sender, EventArgs e)
        {
            
            //addEditCategory edit = new addEditCategory();
            //edit.addButton.Visible = false;
            //edit.CatIdTb.ReadOnly = true;
            //edit.Show();
        }

        private void delete2Button_Click(object sender, EventArgs e)
        {
           
        }

        private void searchProductTextBox_TextChanged(object sender, EventArgs e)
        {
            searchProductButton.PerformClick();
        }
        private void searchProductButton_Click(object sender, EventArgs e)
        {
            // If the search text is not empty, filter the originalCategoryTable and assign the filtered result to the categoryTable
            if (!string.IsNullOrWhiteSpace(searchProductTextBox.Text))
            {
                var matchingRows = from row in originalProductTable.AsEnumerable()
                                   where row.ItemArray.Any(x =>
                                         StringComparer.OrdinalIgnoreCase.Equals(x.ToString(), searchProductTextBox.Text))
                                   select row;

                if (matchingRows.Any())
                {
                    productTable = matchingRows.CopyToDataTable();
                }
                else
                {
                    productTable = productTable.Clone();
                }
            }
            // If the search text is empty, assign the originalCategoryTable to the categoryTable
            else
            {
                productTable = originalProductTable.Copy();
            }

            // Bind the categoryTable to the CatDGV DataGridView control
            ProdDGV.DataSource = productTable;

        }
        private void search2TextBox_TextChanged(object sender, EventArgs e)
        {
            searchCategoryButton.PerformClick();
        }
        private void search2Button_Click(object sender, EventArgs e)
        {
            // If the search text is not empty, filter the originalCategoryTable and assign the filtered result to the categoryTable
            if (!string.IsNullOrWhiteSpace(searchProductTextBox.Text))
            {
                var matchingRows = from row in originalCategoryTable.AsEnumerable()
                                   where row.ItemArray.Any(x =>
                                         StringComparer.OrdinalIgnoreCase.Equals(x.ToString(), searchProductTextBox.Text))
                                   select row;

                if (matchingRows.Any())
                {
                    categoryTable = matchingRows.CopyToDataTable();
                }
                else
                {
                    categoryTable = categoryTable.Clone();
                }
            }
            // If the search text is empty, assign the originalCategoryTable to the categoryTable
            else
            {
                categoryTable = originalCategoryTable.Copy();
            }

            // Bind the categoryTable to the CatDGV DataGridView control
            CatDGV.DataSource = categoryTable;
        }


        #region ChechDatabase
        private void checkCat()
        {
            SqlConnect sql = new SqlConnect();
            var customerType = typeof(Categories);
            sql.checkTable(Categories: customerType);
        }

        private void checkProd()
        {
            SqlConnect sql = new SqlConnect();
            var customerType = typeof(Products);
            sql.checkTable(Categories: customerType);
        }

        #endregion

        private void prevButton_Click(object sender, EventArgs e)
        {

        }

        private void nextButton_Click(object sender, EventArgs e)
        {

        }
    }
}
