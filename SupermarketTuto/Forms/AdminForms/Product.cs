﻿using DataClass;
using Microsoft.VisualBasic.FileIO;
using Microsoft.VisualBasic.Logging;
using Newtonsoft.Json;
using SupermarketTuto.Forms.General;
using SupermarketTuto.Interfaces;
using SupermarketTuto.Utils;
using System;
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


namespace SupermarketTuto.Forms
{
    public partial class Product : Form, excelFiles
    {
        int startRecord;
        int allRecords;
        SqlConnect loaddata1 = new SqlConnect();
        WaitBar Form_ProgressBar = new WaitBar();


        public Product()
        {
            InitializeComponent();
        }


        private void Product_Load(object sender, EventArgs e)
        {
            //BackgroundWorker();
            display();
            fillCombo();
            menu();
        }
        private void ImportTrips_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            loaddata1.retrieveData("Select * from ProductTbl");
            int data = loaddata1.table.Rows.Count;
            for(int i = 0; i <= data; i++)
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

                    ProdDGV.DataSource = loaddata1.table;
                };

                BackgroundWorker.RunWorkerAsync();
                Form_ProgressBar.ShowDialog();
            }
            catch
            {

            }
        }

        private void display()
        {
            try
            {
                loaddata1.pagingData("Select * from ProductTbl where Date between '" + fromDateTimePicker.Value.ToString("MM-dd-yyyy") + "' and '" + toDateTimePicker.Value.ToString("MM-dd-yyyy") + "'", 0, 5);
                ProdDGV.DataSource = loaddata1.table;
                fromDateTimePicker.Value = DateTime.Now.AddMonths(-2);
                ProdDGV.RowHeadersVisible = false;
                totalLabel.Text = $"Total: {ProdDGV.RowCount}";
                ProdDGV.Columns[6].HeaderText = "Date Created";

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
            loaddata2.retrieveData("Select CatName From CategoryTbl");
            catComboBox.DataSource = loaddata2.table;
            catComboBox.ValueMember = "CatName";
            catComboBox.SelectedItem = null;
            catComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            catComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

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
            loaddata2.retrieveData("Select CatName From CategoryTbl");
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

            loaddata4.commandExc("Delete From ProductTbl Where ProdId=" + ProdDGV.CurrentRow.Cells[0].Value.ToString());

            foreach (DataGridViewRow row in ProdDGV.SelectedRows)
            {
                ProdDGV.Rows.RemoveAt(row.Index);

            }
        }
        #endregion

        #region Buttons
        private void addButton_Click(object sender, EventArgs e)
        {
            addEditProduct add = new addEditProduct();
            SqlConnect loaddata2 = new SqlConnect();
            loaddata2.retrieveData("Select CatName From CategoryTbl");
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
            SqlConnect loaddata2 = new SqlConnect();
            addEditProduct edit = new addEditProduct();
            ////This method will bind the Combobox with the Database
            loaddata2.retrieveData("Select CatName From CategoryTbl");
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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            SqlConnect loaddata7 = new SqlConnect();
            try
            {
                loaddata7.commandExc("Delete From ProductTbl Where ProdId=" + ProdDGV.CurrentRow.Cells[0].Value.ToString());
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

        #region Excel
        private void importButton_Click(object sender, EventArgs e)
        {
            import();
        }

        private DataTable GetData(string path)
        {
            DataTable dt = new DataTable();
            try
            {
                if (path.EndsWith(".csv"))
                {
                    //TextFieldParser csvReader = new TextFieldParser(path);
                    //csvReader.SetDelimiters(new string[] { "," });
                    //csvReader.HasFieldsEnclosedInQuotes = true;
                    //string[] colFields = csvReader.ReadFields();

                    string[] lines = System.IO.File.ReadAllLines(path);
                    if (lines.Length > 0)
                    {
                        //first line to create header
                        string firstLine = lines[0];
                        //Devide each data of column
                        string[] headerLabels = firstLine.Split(',');
                        foreach (string headerWord in headerLabels)
                        {
                            //add data column
                            dt.Columns.Add(new DataColumn(headerWord));
                        }
                        //For Data
                        for (int i = 1; i < lines.Length; i++)
                        {
                            //devide each data of rows
                            string[] dataWords = lines[i].Split(',');
                            //create new row of DataTable
                            DataRow dr = dt.NewRow();
                            int columnIndex = 0;
                            foreach (string headerWord in headerLabels)
                            {
                                //Corresponde each Column name with coresponding Row
                                dr[headerWord] = dataWords[columnIndex++];
                            }
                            //Add all rows to DataTable
                            dt.Rows.Add(dr);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception " + ex);
            }
            return dt;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            save();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            export();
        }

        public void export()
        {
            try
            {
                if (ProdDGV.Rows.Count > 0)
                {
                    SaveFileDialog dialog = new SaveFileDialog()
                    {
                        Filter = "CSV (*.csv)|*.csv",
                        Title = "Csv Files",
                        RestoreDirectory = true
                    };

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(dialog.FileName))
                        {
                            try
                            {
                                File.Delete(dialog.FileName);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                            }
                        }
                        else
                        {
                            try
                            {
                                int colCount = ProdDGV.Columns.Count;
                                string colNames = string.Empty;
                                string[] outputCSV = new string[ProdDGV.Rows.Count + 1];
                                //Keep all columns from excel
                                for (int i = 0; i < colCount; i++)
                                {
                                    if (i == colCount - 1)
                                    {
                                        colNames += ProdDGV.Columns[i].HeaderText.ToString();
                                    }
                                    else
                                    {
                                        colNames += ProdDGV.Columns[i].HeaderText.ToString() + ",";
                                    }
                                }
                                //Set Columns to first set of outputCSV
                                outputCSV[0] += colNames;

                                //Set all rows to outputCSV
                                for (int i = 1; (i - 1) < ProdDGV.Rows.Count; i++)
                                {
                                    for (int j = 0; j < colCount; j++)
                                    {
                                        outputCSV[i] += ProdDGV.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                    }
                                }
                                //Write all data to outputCSV
                                File.WriteAllLines(dialog.FileName, outputCSV, Encoding.UTF8);
                                MessageBox.Show("Success");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error :" + ex.Message);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Utlis.Log(string.Format("Message : {0}", ex.Message), "ErrorExportData.txt");
            }

        }
        public void import()
        {
            try
            {
                int ImportedRecord = 0, inValidItem = 0;
                string SourceURl = "";
                OpenFileDialog dialog = new OpenFileDialog()
                {
                    Title = "Browse csv File",
                    CheckFileExists = true,
                    CheckPathExists = true,
                    Filter = "csv files (*.csv)|*.csv",
                    FilterIndex = 2,
                    RestoreDirectory = true,
                    ReadOnlyChecked = true,
                    ShowReadOnly = true

                };
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    if (dialog.FileName.EndsWith(".csv"))
                    {
                        DataTable table = new DataTable();
                        table = GetData(dialog.FileName);
                        SourceURl = dialog.FileName;
                        if (table.Rows != null && table.Rows.ToString() != String.Empty)
                        {
                            ProdDGV.DataSource = table;
                        }
                    }
                }
                display();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception" + ex);
                Utlis.Log(string.Format("Message : {0}", ex.Message), "ErrorImportTxt.txt");

            }
        }
        public void save()
        {
            try
            {
                SqlConnect loaddata20 = new SqlConnect();
                int count = ProdDGV.RowCount;
                for (int i = 0; i < count; i++)
                {
                    loaddata20.commandExc("Insert Into ProductTbl values('" + ProdDGV.Rows[i].Cells[0].Value + "','" + ProdDGV.Rows[i].Cells[1].Value + "','" + ProdDGV.Rows[i].Cells[2].Value + "','" + ProdDGV.Rows[i].Cells[3].Value + "','" + ProdDGV.Rows[i].Cells[4].Value + "')");
                }
                display();
            }
            catch (Exception ex)
            {
                Utlis.Log(string.Format("Message : {0}", ex.Message), "ErrorSaveData.txt");
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
            loaddata10.retrieveData("Select * from ProductTbl where ProdCat='" + catComboBox.SelectedValue + "'");
            ProdDGV.DataSource = loaddata10.table;
            ProdDGV.RowHeadersVisible = false;
            totalLabel.Text = $"Total: {ProdDGV.RowCount}";
        }
        private void ProdDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in ProdDGV.Rows)
            {
                if (DateTime.Parse(row.Cells[6].Value.ToString()) >= DateTime.Now.AddMonths(-1)
                    && DateTime.Parse(row.Cells[6].Value.ToString()) <= DateTime.Now)
                {
                    row.DefaultCellStyle.BackColor = Color.Orange;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.DarkSeaGreen;
                }
            }
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
            display();
        }

        private void toDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            display();
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



        #endregion


    }
}

