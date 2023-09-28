using ClassLibrary1;
using ClassLibrary1.Models;
using DataClass;
using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic.FileIO;
using Microsoft.VisualBasic.Logging;
using Newtonsoft.Json;
using OfficeOpenXml;
using SupermarketTuto.Forms.General;
using SupermarketTuto.Interfaces;
using SupermarketTuto.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using Button = System.Windows.Forms.Button;
using ComboBox = System.Windows.Forms.ComboBox;
using DataTable = System.Data.DataTable;
using MenuStrip = ClassLibrary1.MenuStrip;
using Rectangle = System.Drawing.Rectangle;
using Timer = System.Windows.Forms.Timer;

namespace SupermarketTuto.Forms
{
    public partial class Product : Form
    {
        ExcelFile excel = new ExcelFile();
        private Timer timer = new Timer();
        public delegate void UpdateDataHandler(object sender, EventArgs e);
        public event UpdateDataHandler UpdateData;
        DataTable productTable = new DataTable();
        private DataTable originalProductTable;
        private DataTable productTableCombobox;
        Type productType = typeof(ProductTbl);
        DataTable categoryTable = new DataTable();
        BindingSource bindingSource = new BindingSource();

        public Product()
        {
            InitializeComponent();

            // Set the interval of the Timer to 60 seconds (60000 milliseconds)
            timer.Interval = 30000;

            // Subscribe to the Timer's Tick event
            timer.Tick += Timer_Tick;

            exportCombobox.Items.Add("Csv");
            exportCombobox.Items.Add("Xlsx");

            importCombobox.Items.Add("Csv");
            importCombobox.Items.Add("Xlsx");


        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Raise the UpdateData event
            UpdateData?.Invoke(this, EventArgs.Empty);
        }
        private void Product_Load(object sender, EventArgs e)
        {
            // Start the Timer
            timer.Start();

            // Subscribe to the DataGridView's UpdateData event
            UpdateData += MyDataGridView_UpdateData;

            //BackgroundWorker();
            fillCombo();
            display();

            //Fill Combobox of paging
            List<int> pageCombo = new List<int>();
            pageCombo.Add(5);
            pageCombo.Add(10);
            pageCombo.Add(20);
            pagingComboBox.DataSource = pageCombo;

            MenuStrip.Instance.Menu(ProdDGV, productTable, categoryTable, productType, false);

        }       

        private void MyDataGridView_UpdateData(object sender, EventArgs e)
        {
            // Refresh the DataGridView
            ProdDGV.Refresh();
        }

        private void display()
        {
            try
            {
                fromDateTimePicker.Value = DateTime.Now.AddMonths(-2);

                List<ProductTbl> products = DataModel.Select<ProductTbl>();
                productTable = Utils.Utils.ToDataTable(products);
                productTable.PrimaryKey = new DataColumn[] { productTable.Columns["ProdId"] };

                //Create column Select
                DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn();
                checkboxColumn.Name = "Select";
                ProdDGV.Columns.Add(checkboxColumn);
                ProdDGV.Columns["Select"].DisplayIndex = 0;

                bindingSource.DataSource = productTable;
                ProdDGV.DataSource = bindingSource;

                ProdDGV.RowHeadersVisible = false;
                ProdDGV.AllowUserToAddRows = false;
                ProdDGV.ReadOnly = false;
                totalLabel.Text = $"Total: {ProdDGV.RowCount}";
                ProdDGV.Columns[6].HeaderText = "Date";

                // Attach the CurrentChanged event handler to the BindingSource
                bindingSource.CurrentChanged += bindingSource_CurrentChanged;

                // Initialize the originalCategoryTable field with the same data as categoryTable
                originalProductTable = productTable.Copy();

            }
            catch (Exception ex)
            {
                Utils.Utils.Log(string.Format("Message : {0}", ex.Message), "ErrorPdoduct.txt");
            }
        }
        private void fillCombo()
        {
            List<string> catNames = new List<string>();
            List<CategoryTbl> categories = DataModel.Select<CategoryTbl>();
            categoryTable = Utils.Utils.ToDataTable(categories);
            foreach (DataRow row in categoryTable.Rows)
            {
                catNames.Add(row["CatName"].ToString());
            }
            catComboBox.DataSource = catNames;
            catComboBox.SelectedItem = null;
            catComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            catComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        #region BackgroundWorker
  

        #endregion

        #region Buttons
        private void addButton_Click(object sender, EventArgs e)
        {
            addEditProduct add = new addEditProduct(productTable, null, categoryTable, true);
            add.editButton.Visible = false;
            add.ProdId.Visible = false;
            add.idLabel.Visible = false;
            add.ItemCreated += Add_ItemCreated;
            add.Show();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = ProdDGV.CurrentRow;
            addEditProduct edit = new addEditProduct(productTable, currentRow, categoryTable, false);
            edit.addButton.Visible = false;
            edit.ProdId.ReadOnly = true;
            edit.ItemEdited += Edit_ItemEdited;
            edit.Show();

            
        }

        private void Add_ItemCreated(object sender, ProductEventArgs e)
        {
            productTable.Rows.Add(e.CreatedProduct.ProdId, e.CreatedProduct.ProdName, e.CreatedProduct.ProdQty, e.CreatedProduct.ProdPrice, e.CreatedProduct.ProdCatID, e.CreatedProduct.ProdCat, e.CreatedProduct.Date);
            ProdDGV.Refresh();
        }

        private void Edit_ItemEdited(object sender, ProductEventArgs e)
        {
            // Update the edited category in the DataTable in form

            DataRow editedRow = productTable.Rows.Find(e.PrimaryKeyValue);
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


        private void deleteButton_Click(object sender, EventArgs e)
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
                    string ProdId = Convert.ToInt32(row["ProdId"]).ToString();
                    ProductTbl products = DataModel.Select<ProductTbl>(where: $"ProdId = '{ProdId}' ").FirstOrDefault();
                    DataModel.Delete<ProductTbl>(products);
                    rowsToDelete.Add(row);
                }

                // loop over the rows to delete and remove them from the DataTable
                foreach (DataRow rowToDelete in rowsToDelete)
                {
                    productTable.Rows.Remove(rowToDelete);
                }
                ProdDGV.DataSource = productTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Utils.Utils.Log(string.Format("Message : {0}", ex.Message), "ErrorDeleteProduct.txt");
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

        #endregion

        #region API
        //First, we have created an object of HttpClient and assigned the base address of our Web API.
        //The GetAsync() method sends an http GET request to the specified url.The GetAsync() method is asynchronous and returns a Task.
        //Task.wait() suspends the execution until GetAsync() method completes the execution and returns a result.
        //Once the execution completes, we get the result from Task using Task.result which is HttpResponseMessage.
        //Now, you can check the status of an http response using IsSuccessStatusCode. Read the content of the result using ReadAsAsync() method.
        private void GetButton_Click(object sender, EventArgs e)
        {
            //using (var client = new HttpClient())
            //{
            //    var url = new Uri("http://localhost:52465/api/allproducts");

            //    //var endpoint = new Uri("http://localhost:8083/api/products");
            //    //var result1 = client.GetAsync(endpoint).Result;
            //    //var json = result1.Content.ReadAsStringAsync().Result;
            //    //var result = JsonConvert.DeserializeObject<List<Products>>(json);
            //    client.BaseAddress = new Uri("http://localhost:52465/api/allproducts");
            //    // Add an Accept header for JSON format.
            //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //    //HTTP GET
            //    var responseTask = client.GetAsync(url.PathAndQuery);
            //    responseTask.Wait();

            //    var result = responseTask.Result;
            //    if (result.IsSuccessStatusCode)
            //    {

            //        var readTask = result.Content.ReadAsStringAsync();
            //        readTask.Wait();

            //        var Products = readTask.Result;
            //        var resultDeserialize = JsonConvert.DeserializeObject<List<Products>>(Products);

            //        ProdDGV.DataSource = resultDeserialize;

            //    }
            //}
        }

        private void PostButton_Click(object sender, EventArgs e)
        {
            //var product = new Products() { Prodid = Convert.ToInt32(ProdId.Text), ProdName = ProdName.Text, ProdQty = Convert.ToInt32(ProdQty.Text), ProdPrice = Convert.ToInt32(ProdPrice.Text), ProdCat = addCatCombobox.Text };

            //var json = JsonConvert.SerializeObject(product);
            //var data = new StringContent(json, Encoding.UTF8, "application/json");

            //var url = new Uri("http://localhost:52465/api/products");
            //using var client = new HttpClient();

            //var response = client.PostAsync(url, data);
            //response.Wait();
            //var result = response.Result;
            //if (result.IsSuccessStatusCode)
            //{
            //    var readTask = result.Content.ReadAsStringAsync();

            //}
        }

        private void DeleteApiButton_Click(object sender, EventArgs e)
        {

            //var url = new Uri($"http://localhost:52465/api/delete/{ProdId.Text}");
            //using var client = new HttpClient();

            //var response = client.DeleteAsync(url);
            //response.Wait();
            //var result = response.Result;
            //if (result.IsSuccessStatusCode)
            //{
            //    var readTask = result.Content.ReadAsStringAsync();

            //}
        }

        private void putButton_Click(object sender, EventArgs e)
        {
            //var product = new Products() { Prodid = Convert.ToInt32(ProdId.Text), ProdName = ProdName.Text, ProdQty = Convert.ToInt32(ProdQty.Text), ProdPrice = Convert.ToInt32(ProdPrice.Text), ProdCat = addCatCombobox.Text };

            //var json = JsonConvert.SerializeObject(product);
            //var data = new StringContent(json, Encoding.UTF8, "application/json");

            //var url = new Uri($"http://localhost:52465/api/put/{ProdId.Text}");
            //using var client = new HttpClient();

            //var response = client.PutAsync(url, data);
            //response.Wait();
            //var result = response.Result;
            //if (result.IsSuccessStatusCode)
            //{
            //    var readTask = result.Content.ReadAsStringAsync();

            //}
        }

        #endregion API

        #region Events
        private void bindingSource_CurrentChanged(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private void catComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productTable.Rows.Count > 0)
            {
                productTableCombobox = productTable.Clone();
                foreach (DataRow row in productTable.Rows)
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
        private void ProdDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //foreach (DataGridViewRow row in ProdDGV.Rows)
            //{
            //    if (DateTime.Parse(row.Cells[6].Value.ToString()) >= DateTime.Now.AddMonths(-1)
            //        && DateTime.Parse(row.Cells[6].Value.ToString()) <= DateTime.Now)
            //    {
            //        row.DefaultCellStyle.BackColor = Color.Orange;
            //    }
            //    else
            //    {
            //        row.DefaultCellStyle.BackColor = Color.DarkSeaGreen;
            //    }
            //}
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
        #endregion 

        #region DateTimePicker
        private void fromDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (productTable.Rows.Count > 0)
            {
                DateTime dateTimePicker = fromDateTimePicker.Value.Date;
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

        private void toDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (productTable.Rows.Count > 0)
            {
                DateTime dateTimePicker = toDateTimePicker.Value.Date;
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

        #endregion

        #region Paging

        private void UpdateDataGridView()
        {
            try
            {
                int currentPage = bindingSource.Position / 5 + 1;
                int startIndex = (currentPage - 1) * 5;

                DataTable pageDataTable = productTable.Clone();
                for (int i = startIndex; i < startIndex + 5 && i < bindingSource.Count; i++)
                {
                    pageDataTable.ImportRow(productTable.Rows[i]);
                }

                ProdDGV.DataSource = pageDataTable;
            }
            catch
            {

            }

        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            if (bindingSource.Position > 0)
            {
                bindingSource.Position -= 5;
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (bindingSource.Position + 5 < bindingSource.Count)
            {
                bindingSource.Position += 5;
            }
        }


        private void pagingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (pagingCheckBox.Checked)
            {
                prevButton.Visible = true;
                nextButton.Visible = true;
                pagingComboBox.Visible = true;
                // Update the DataGridView with the rows for the initial page
                UpdateDataGridView();
            }
            else
            {
                prevButton.Visible = false;
                nextButton.Visible = false;
                pagingComboBox.Visible = false;
                ProdDGV.DataSource = bindingSource;
            }
        }
        #endregion

        #region ChechDatabase
        private void check()
        {
            //SqlConnect sql = new SqlConnect();
            //var customerType = typeof(ProductsTbl);
            //sql.checkTable(Products: customerType);
        }

        #endregion

        #region Excel (csv && xlsx)

        private void exportCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Type product = typeof(ProductTbl);
            var item = ((ComboBox)sender).SelectedItem.ToString();
            if (item.Contains("Csv"))
            {
                excel.export(ProdDGV);
            }
            else if (item.Contains("Xlsx"))
            {

                excel.Save(ProdDGV, product);
            }
        }

        private void importCombobox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                Type product = typeof(ProductTbl);
                DataTable tableNew = new DataTable();
                var item = ((ComboBox)sender).SelectedItem.ToString();

                if (item.Contains("Csv"))
                {
                    tableNew = excel.import(product);

                }
                else if (item.Contains("Xlsx"))
                {
                    tableNew = excel.ImportExcelAsync(ProdDGV, product);
                }
                //DataTable table3 = loaddata1.table.Clone();
                //var differenceQuery = tableNew.AsEnumerable().Except(loaddata1.table.AsEnumerable(), DataRowComparer.Default);
                
                //foreach (DataRow row in differenceQuery)
                //{
                //    table3.Rows.Add(row.ItemArray);
                //}
                //loaddata1.table.Merge(tableNew);
                //ProdDGV.DataSource = loaddata1.table;
                //ProdDGV.RowHeadersVisible = false;
                //ProdDGV.AllowUserToAddRows = false;
                //DialogResult result = MessageBox.Show("Do you want to save the extra data to Database?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //if (result == DialogResult.Yes)
                //{
                //    excel.SaveToDB(table3, product);
                //}
            }
            catch
            {

            }

        }




        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            //DataAccess.Instance.UpdateTable("ProductTbl");
        }
    }

}

