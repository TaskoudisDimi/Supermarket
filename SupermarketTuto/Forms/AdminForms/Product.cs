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
using Rectangle = System.Drawing.Rectangle;
using Timer = System.Windows.Forms.Timer;

namespace SupermarketTuto.Forms
{
    public partial class Product : Form
    {
        int startRecord;

        
        WaitBar Form_ProgressBar = new WaitBar();
        SqlConnect loaddata1 = new SqlConnect();
        ExcelFile excel = new ExcelFile();
        private Timer timer = new Timer();
        public delegate void UpdateDataHandler(object sender, EventArgs e);
        public event UpdateDataHandler UpdateData;

        Type productType = typeof(Products);


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
            display();
            fillCombo();
            menu();
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
                //loaddata1.getData("Select * from ProductTbl where Date between '" + fromDateTimePicker.Value.ToString("MM-dd-yyyy") + "' and '" + toDateTimePicker.Value.ToString("MM-dd-yyyy") + "'");
   
                ProdDGV.DataSource = loaddata1.getDataTest("Select * from ProductTbl where Date between '" + fromDateTimePicker.Value.ToString("MM-dd-yyyy") + "' and '" + toDateTimePicker.Value.ToString("MM-dd-yyyy") + "'", productType); ;
                ProdDGV.RowHeadersVisible = false;
                ProdDGV.AllowUserToAddRows = false;
                totalLabel.Text = $"Total: {ProdDGV.RowCount}";
                ProdDGV.Columns[6].HeaderText = "Date";

            }
            catch (Exception ex)
            {

                Utlis.Log(string.Format("Message : {0}", ex.Message), "ErrorPdoduct.txt");
            }

        }
        private void fillCombo()
        {
            SqlConnect loaddata2 = new SqlConnect();

            //This method will bind the Combobox with the Database
            loaddata2.getData("Select CatName From CategoryTbl");
            catComboBox.DataSource = loaddata2.table;
            catComboBox.ValueMember = "CatName";
            catComboBox.SelectedItem = null;
            catComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            catComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        #region BackgroundWorker
        private void ImportTrips_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            SqlConnect loaddata11 = new SqlConnect();
            loaddata11.getData("Select * from ProductTbl");
            int data = loaddata11.table.Rows.Count;
            for (int i = 0; i <= data; i++)
            {
                (sender as BackgroundWorker).ReportProgress(i);
            }

        }

        private void BackgroundWorker()
        {
            try
            {

                System.ComponentModel.BackgroundWorker BackgroundWorker = new System.ComponentModel.BackgroundWorker
                {
                    WorkerReportsProgress = true
                };
                BackgroundWorker.DoWork += ImportTrips_DoWork;
                BackgroundWorker.ProgressChanged += (s, e2) =>
                {
                    Form_ProgressBar.waitProgressBar.Value = e2.ProgressPercentage;
                };
                BackgroundWorker.RunWorkerCompleted += (s, e3) =>
                {
                    Thread.Sleep(5000);
                    if (e3.Error != null)
                        throw e3.Error;
                    Form_ProgressBar.Close();

                    //ProdDGV.DataSource = loaddata1.table;
                };

                BackgroundWorker.RunWorkerAsync();
                Form_ProgressBar.ShowDialog();
            }
            catch
            {

            }
        }

        #endregion

        #region MenuStrip
        private void menu()
        {
            ContextMenuStrip mnu = new ContextMenuStrip();
            ToolStripMenuItem mnuEdit = new ToolStripMenuItem("Edit");
            ToolStripMenuItem mnuDelete = new ToolStripMenuItem("Delete");
            //Assign event handlers
            mnuDelete.Click += new EventHandler(mnuDelete_Click);
            mnuEdit.Click += new EventHandler(mnuEdit_Click);
            //Add to main context menu
            mnu.Items.AddRange(new ToolStripItem[] { mnuEdit, mnuDelete });
            //Assign to datagridview
            ProdDGV.ContextMenuStrip = mnu;
        }

        private void mnuEdit_Click(object? sender, EventArgs e)
        {
            SqlConnect loaddata2 = new SqlConnect();
            addEditProduct edit = new addEditProduct();
            ////This method will bind the Combobox with the Database
            loaddata2.getData("Select CatName From CategoryTbl");
            edit.catCombobox.DataSource = loaddata2.table;
            edit.catCombobox.ValueMember = "CatName";
            //catCombobox.SelectedItem = null;
            edit.catCombobox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            edit.catCombobox.AutoCompleteSource = AutoCompleteSource.ListItems;
            edit.ProdId.Text = ProdDGV.CurrentRow.Cells[0].Value.ToString();
            edit.ProdName.Text = ProdDGV.CurrentRow.Cells[1].Value.ToString();
            edit.ProdPrice.Text = ProdDGV.CurrentRow.Cells[2].Value.ToString();
            edit.ProdQty.Text = ProdDGV.CurrentRow.Cells[3].Value.ToString();
            edit.catCombobox.SelectedValue = ProdDGV.CurrentRow.Cells[5].Value.ToString();
            edit.catIDTextBox.Text = ProdDGV.CurrentRow.Cells[4].Value.ToString();
            edit.DateTimePicker.Text = ProdDGV.CurrentRow.Cells[6].Value.ToString();
            edit.addButton.Visible = false;
            edit.ProdId.ReadOnly = true;
            edit.Show();
        }

        private void mnuDelete_Click(object? sender, EventArgs e)
        {
            SqlConnect loaddata4 = new SqlConnect();

            loaddata4.execCom("Delete From ProductTbl Where ProdId=" + ProdDGV.CurrentRow.Cells[0].Value.ToString());

            foreach (DataGridViewRow row in ProdDGV.SelectedRows)
            {
                ProdDGV.Rows.RemoveAt(row.Index);

            }
        }
        #endregion

        #region Buttons
        private void addButton_Click(object sender, EventArgs e)
        {
            //check();
            addEditProduct add = new addEditProduct();
            SqlConnect loaddata2 = new SqlConnect();
            loaddata2.getData("Select CatName From CategoryTbl");
            add.catCombobox.DataSource = loaddata2.table;
            add.catCombobox.ValueMember = "CatName";
            add.catCombobox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            add.catCombobox.AutoCompleteSource = AutoCompleteSource.ListItems;
            add.editButton.Visible = false;
            add.ProdId.Visible = false;
            add.idLabel.Visible = false;
            add.Show();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            //check();
            SqlConnect loaddata2 = new SqlConnect();
            SqlConnect loaddata3 = new SqlConnect();
            addEditProduct edit = new addEditProduct();
            ////This method will bind the Combobox with the Database
            loaddata2.getData("Select CatName From CategoryTbl");
            edit.catCombobox.DataSource = loaddata2.table;
            edit.catCombobox.ValueMember = "CatName";
            edit.catCombobox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            edit.catCombobox.AutoCompleteSource = AutoCompleteSource.ListItems;
            edit.ProdId.Text = ProdDGV.CurrentRow.Cells[0].Value.ToString();
            string query = $"Select * From ProductTbl where ProdId = {edit.ProdId.Text}";
            loaddata3.getData(query);
            foreach (DataRow row in loaddata3.table.Rows)
            {
                edit.ProdName.Text = row["ProdName"].ToString();
                edit.ProdPrice.Text = row["ProdPrice"].ToString();
                edit.ProdQty.Text = row["ProdQty"].ToString();
                edit.catCombobox.SelectedValue = row["ProdCat"].ToString();
                edit.catIDTextBox.Text = row["ProdCatID"].ToString();
                edit.DateTimePicker.Text = row["Date"].ToString();
            }
            edit.addButton.Visible = false;
            edit.ProdId.ReadOnly = true;
            edit.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            SqlConnect loaddata7 = new SqlConnect();
            try
            {
                //check();
                loaddata7.execCom("Delete From ProductTbl Where ProdId=" + ProdDGV.CurrentRow.Cells[0].Value.ToString());
                display();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Utlis.Log(string.Format("Message : {0}", ex.Message), "ErrorDeleteProduct.txt");
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            display();
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnect db = new SqlConnect();
                string query = "Select * From ProductTbl where ProdId like '%" + searchTextBox.Text + "%'" + "or ProdName like '%" + searchTextBox.Text + "%'" + "or ProdQty like '%" + searchTextBox.Text + "%'" + "or ProdPrice like '%" + searchTextBox.Text + "%'" + "or ProdCat like '%" + searchTextBox.Text + "%'";
                db.search(searchTextBox.Text, query);
                ProdDGV.DataSource = db.table;
                totalLabel.Text = $"Total: {ProdDGV.RowCount}";
            }
            catch (Exception ex)
            {
                Utlis.Log(string.Format("Message : {0}", ex.Message), "ErrorDeleteProduct.txt");

            }

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
        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                searchButton.PerformClick();
            }
        }

        private void catComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SqlConnect loaddata10 = new SqlConnect();
            loaddata10.getData("Select * from ProductTbl where ProdCat='" + catComboBox.SelectedValue + "'");
            ProdDGV.DataSource = loaddata10.table;
            ProdDGV.RowHeadersVisible = false;
            totalLabel.Text = $"Total: {ProdDGV.RowCount}";
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
            try
            {
                SqlConnect db = new SqlConnect();
                string query = "Select * From ProductTbl where ProdId like '%" + searchTextBox.Text + "%'" + "or ProdName like '%" + searchTextBox.Text + "%'" + "or ProdQty like '%" + searchTextBox.Text + "%'" + "or ProdPrice like '%" + searchTextBox.Text + "%'" + "or ProdCat like '%" + searchTextBox.Text + "%'";
                db.search(searchTextBox.Text, query);
                ProdDGV.DataSource = db.table;
                totalLabel.Text = $"Total: {ProdDGV.RowCount}";
            }
            catch (Exception ex)
            {
                Utlis.Log(string.Format("Message : {0}", ex.Message), "ErrorSearchData.txt");
            }

        }
        #endregion 

        #region DateTimePicker
        private void fromDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void toDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
           
        }

        #endregion

        #region Paging
        SqlConnect loaddata20 = new SqlConnect();

        private void prevButton_Click(object sender, EventArgs e)
        {

            startRecord = startRecord - 5;
            if (startRecord <= 0)
            {
                startRecord = 0;
            }
            loaddata20.pagingData("Select * from ProductTbl where Date between '" + fromDateTimePicker.Value.ToString("MM-dd-yyyy") + "' and '" + toDateTimePicker.Value.ToString("MM-dd-yyyy") + "'", startRecord, 5);
            ProdDGV.DataSource = loaddata20.table;
            if (ProdDGV.Rows.Count > 1)
            {
                nextButton.Enabled = true;
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (ProdDGV.Rows.Count > 0)
            {
                startRecord = startRecord + 5;
                if (startRecord <= 0)
                {
                    startRecord = 10;
                }
                loaddata20.pagingData("Select * from ProductTbl where Date between '" + fromDateTimePicker.Value.ToString("MM-dd-yyyy") + "' and '" + toDateTimePicker.Value.ToString("MM-dd-yyyy") + "'", startRecord, 5);
                ProdDGV.DataSource = loaddata20.table;
            }
            else
            {
                nextButton.Enabled = false;
            }
        }

        

        private void selectAllCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pagingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnect loaddata8 = new SqlConnect();
            if (pagingCheckBox.Checked)
            {
                prevButton.Visible = true;
                nextButton.Visible = true;
                pagingComboBox.Visible = true;
                loaddata8.pagingData("Select * from ProductTbl where Date between '" + fromDateTimePicker.Value.ToString("MM-dd-yyyy") + "' and '" + toDateTimePicker.Value.ToString("MM-dd-yyyy") + "'", 0, 5);
                ProdDGV.DataSource = loaddata8.table;
                pagingCheckBox.Checked = true;
            }
            else
            {
                prevButton.Visible = false;
                nextButton.Visible = false;
                pagingComboBox.Visible = false;
                pagingCheckBox.Checked = false;
                display();
            }
        }
        #endregion

        #region ChechDatabase
        private void check()
        {
            SqlConnect sql = new SqlConnect();
            var customerType = typeof(Products);
            sql.checkTable(Products: customerType);
        }

        #endregion

        #region Excel (csv && xlsx)

        private void exportCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Type product = typeof(Products);
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
                Type product = typeof(Products);
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
                DataTable table3 = loaddata1.table.Clone();
                var differenceQuery = tableNew.AsEnumerable().Except(loaddata1.table.AsEnumerable(), DataRowComparer.Default);
                
                foreach (DataRow row in differenceQuery)
                {
                    table3.Rows.Add(row.ItemArray);
                }
                loaddata1.table.Merge(tableNew);
                ProdDGV.DataSource = loaddata1.table;
                ProdDGV.RowHeadersVisible = false;
                ProdDGV.AllowUserToAddRows = false;
                DialogResult result = MessageBox.Show("Do you want to save the extra data to Database?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    excel.SaveToDB(table3, product);
                }
            }
            catch
            {

            }
            
        }


        #endregion

       
    }
   
}

