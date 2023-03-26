

using DataClass;
using SupermarketTuto.Forms.AdminForms;
using SupermarketTuto.Forms.General;
using SupermarketTuto.Interfaces;
using SupermarketTuto.Utils;
using System.ComponentModel;
using System.Data;
using System.Text;

namespace SupermarketTuto.Forms
{
    public partial class Category : Form, excelFiles
    {
        int startRecord;
        int allRecords;
        public Category()
        {
            InitializeComponent();
        }

        private void Category_Load(object sender, EventArgs e)
        {
            display();

            //Create column Select
            DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn();
            checkboxColumn.Name = "Select";
            CatDGV.Columns.Add(checkboxColumn);
            CatDGV.Columns["Select"].DisplayIndex = 0;
            menu();
        }
        private void display()
        {
            try
            {
                fromDateTimePicker.Value = DateTime.Now.AddMonths(-2);
                SqlConnect loaddata = new SqlConnect();
                loaddata.retrieveData("Select * From CategoryTbl where Date between '" + fromDateTimePicker.Value.ToString("MM-dd-yyyy") + "' and '" + toDateTimePicker.Value.ToString("MM-dd-yyyy") + "'");
                CatDGV.DataSource = loaddata.table;
                CatDGV.RowHeadersVisible = false;
                CatDGV.Columns[3].HeaderText = "Date Created";
                totalLabel.Text = $"Total: {CatDGV.RowCount}";
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

        #region MenuStrip
        private void menu()
        {
            //Create right click menu
            ContextMenuStrip mnu = new ContextMenuStrip();
            ToolStripMenuItem mnuEdit = new ToolStripMenuItem("Edit");
            ToolStripMenuItem mnuDelete = new ToolStripMenuItem("Delete");
            ToolStripMenuItem mnuSelectedProducts = new ToolStripMenuItem("Show Selected Products");
            mnuEdit.Click += new EventHandler(mnuEdit_Click);
            mnuDelete.Click += new EventHandler(mnuDelete_Click);
            mnuSelectedProducts.Click += new EventHandler(mnuSelectedProducts_Click);
            mnu.Items.AddRange(new ToolStripItem[] { mnuEdit, mnuSelectedProducts, mnuDelete });
            CatDGV.ContextMenuStrip = mnu;
        }

        private void mnuEdit_Click(object? sender, EventArgs e)
        {
            addEditCategory edit = new addEditCategory();
            edit.CatIdTb.Text = CatDGV.CurrentRow.Cells[1].Value.ToString();
            edit.CatNameTb.Text = CatDGV.CurrentRow.Cells[2].Value.ToString();
            edit.CatDescTb.Text = CatDGV.CurrentRow.Cells[3].Value.ToString();
            edit.dateTimePicker.Text = CatDGV.CurrentRow.Cells[4].Value.ToString();
            edit.addButton.Visible = false;
            edit.CatIdTb.ReadOnly = true;
            edit.Show();
            display();
        }

        private void mnuDelete_Click(object? sender, EventArgs e)
        {
            try
            {
                SqlConnect loaddata2 = new SqlConnect();
                loaddata2.commandExc("Delete From CategoryTbl Where CatId='" + CatDGV.CurrentRow.Cells[1].Value.ToString() + "'");
                foreach (DataGridViewRow row in CatDGV.SelectedRows)
                {
                    CatDGV.Rows.RemoveAt(row.Index);
                }
            }
            catch
            {

            }

        }
        private void mnuSelectedProducts_Click(object? sender, EventArgs e)
        {
            try
            {
                List<int> cats = new List<int>();
                for (int i = 0; i < CatDGV.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(CatDGV.Rows[i].Cells[0].Value))
                    {
                        cats.Add((int)CatDGV.Rows[i].Cells[1].Value);
                    }
                }
                if (cats.Count != 0)
                {
                    SelectedProducts frm = new SelectedProducts(cats);
                    frm.Show();
                }
            }
            catch
            {

            }
        }
        #endregion

        #region Buttons
        private void refreshButton_Click(object sender, EventArgs e)
        {
            display();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addEditCategory add = new addEditCategory();
            add.editButton.Visible = false;
            add.CatIdTb.Visible = false;
            add.idlabel.Visible = false;
            add.Show();
            display();
        }

        private void editButton_Click(object sender, EventArgs e)
        {

            SqlConnect loaddata90 = new SqlConnect();
            addEditCategory edit = new addEditCategory();
            edit.CatIdTb.Text = CatDGV.CurrentRow.Cells[1].Value.ToString();
            string query = $"Select * From CategoryTbl where CatId = {edit.CatIdTb.Text}";
            loaddata90.retrieveData(query);
            foreach(DataRow row in loaddata90.table.Rows)
            {
                edit.CatNameTb.Text = row["CatName"].ToString();
                edit.CatDescTb.Text = row["CatDesc"].ToString();
                edit.dateTimePicker.Text = row["Date"].ToString();
            }
            edit.addButton.Visible = false;
            edit.CatIdTb.ReadOnly = true;
            edit.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            SqlConnect loaddata5 = new SqlConnect();
            try
            {
                loaddata5.commandExc("Delete From CategoryTbl Where CatId=" + CatDGV.CurrentRow.Cells[0].Value.ToString());
                display();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SqlConnect db_sellers = new SqlConnect();
            string query = "Select * From CategoryTbl where CatId like '%" + searchTextBox.Text + "%'" + "or CatName like '%" + searchTextBox.Text + "%'" + "or CatDesc like '%" + searchTextBox.Text + "%'";
            db_sellers.search(searchTextBox.Text, query);
            CatDGV.DataSource = db_sellers.table;
            totalLabel.Text = $"Total: {CatDGV.RowCount}";
        }
        private void showSelectedProductsButton_Click(object sender, EventArgs e)
        {
            try
            {
                WaitBar Form_ProgressBar = new WaitBar();
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
                    if (selectedProd.Count != 0)
                    {
                        SelectedProducts frm = new SelectedProducts(selectedProd);
                        frm.Show();
                    }
                };
                BackgroundWorker.RunWorkerAsync();
                Form_ProgressBar.Show();
            }
            catch
            {

            }

        }
        List<int> selectedProd = new List<int>();
        private void ImportTrips_DoWork(object sender, DoWorkEventArgs e)
        {
            
            for (int i = 0; i < CatDGV.Rows.Count; i++)
            {
                if (Convert.ToBoolean(CatDGV.Rows[i].Cells[0].Value))
                {
                    selectedProd.Add((int)CatDGV.Rows[i].Cells[1].Value);
                    (sender as BackgroundWorker).ReportProgress(i);
                }
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

        #region Events
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            SqlConnect db_sellers = new SqlConnect();
            string query = "Select * From CategoryTbl where CatId like '%" + searchTextBox.Text + "%'" + "or CatName like '%" + searchTextBox.Text + "%'" + "or CatDesc like '%" + searchTextBox.Text + "%'";
            db_sellers.search(searchTextBox.Text, query);
            CatDGV.DataSource = db_sellers.table;
            totalLabel.Text = $"Total: {CatDGV.RowCount}";
        }

        private void CatDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            //foreach (DataGridViewRow row in CatDGV.Rows)
            //{
            //    if (DateTime.Parse(row.Cells[4].Value.ToString()) >= DateTime.Now.AddMonths(-1)
            //        && DateTime.Parse(row.Cells[4].Value.ToString()) <= DateTime.Now)
            //    {
            //        row.DefaultCellStyle.BackColor = Color.Orange;
            //    }
            //    else
            //    {
            //        row.DefaultCellStyle.BackColor = Color.DarkSeaGreen;
            //    }
            //}


        }
        #endregion

        #region Excel
        public void import()
        {
            try
            {
                int ImportedRecord = 0, inValidItem = 0;
                string SourceURl = "";
                OpenFileDialog dialog = new OpenFileDialog()
                {
                    Title = "Browse Text File",
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
                            CatDGV.DataSource = table;

                        }

                    }
                }
                display();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception" + ex);
            }
        }
        public void export()
        {
            if (CatDGV.Rows.Count > 0)
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
                            int colCount = CatDGV.Columns.Count;
                            string colNames = string.Empty;
                            string[] outputCSV = new string[CatDGV.Rows.Count + 1];
                            for (int i = 0; i < colCount; i++)
                            {
                                if (i == colCount - 1)
                                {
                                    colNames += CatDGV.Columns[i].HeaderText.ToString();
                                }
                                else
                                {
                                    colNames += CatDGV.Columns[i].HeaderText.ToString() + ",";
                                }
                            }
                            outputCSV[0] += colNames;

                            for (int i = 1; (i - 1) < CatDGV.Rows.Count; i++)
                            {
                                for (int j = 0; j < colCount; j++)
                                {
                                    outputCSV[i] += CatDGV.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }
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
        public void save()
        {
            SqlConnect loaddata20 = new SqlConnect();

            int count = CatDGV.RowCount;
            for (int i = 0; i < count; i++)
            {
                loaddata20.commandExc("Insert Into CategoryTbl values('" + CatDGV.Rows[i].Cells[0].Value + "','" + CatDGV.Rows[i].Cells[1].Value + "','" + CatDGV.Rows[i].Cells[2].Value + "','" + CatDGV.Rows[i].Cells[3].Value + "','" + CatDGV.Rows[i].Cells[4].Value + "')");
            }
            display();
        }
        private void exportButton_Click(object sender, EventArgs e)
        {
            export();
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
                        string[] headerLabels = firstLine.Split(',');
                        foreach (string headerWord in headerLabels)
                        {
                            dt.Columns.Add(new DataColumn(headerWord));
                        }
                        //For Data
                        for (int i = 1; i < lines.Length; i++)
                        {
                            string[] dataWords = lines[i].Split(',');
                            DataRow dr = dt.NewRow();
                            int columnIndex = 0;
                            foreach (string headerWord in headerLabels)
                            {
                                dr[headerWord] = dataWords[columnIndex++];
                            }
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

        private void importButton_Click(object sender, EventArgs e)
        {
            import();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            save();
        }


        #endregion

        #region paging
        SqlConnect loaddata90 = new SqlConnect();
        private void prevButton_Click(object sender, EventArgs e)
        {
            startRecord = startRecord - 5;
            if (startRecord <= 0)
            {
                startRecord = 0;
            }
            loaddata90.pagingData("Select * from ProductTbl where Date between '" + fromDateTimePicker.Value.ToString("MM-dd-yyyy") + "' and '" + toDateTimePicker.Value.ToString("MM-dd-yyyy") + "'", startRecord, 5);
            CatDGV.DataSource = loaddata90.table;
            if (CatDGV.Rows.Count > 1)
            {
                nextButton.Enabled = true;
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (CatDGV.Rows.Count > 0)
            {
                startRecord = startRecord + 5;
                if (startRecord <= 0)
                {
                    startRecord = 10;
                }
                loaddata90.pagingData("Select * from ProductTbl where Date between '" + fromDateTimePicker.Value.ToString("MM-dd-yyyy") + "' and '" + toDateTimePicker.Value.ToString("MM-dd-yyyy") + "'", startRecord, 5);
                CatDGV.DataSource = loaddata90.table;
            }
            else
            {
                nextButton.Enabled = false;
            }
        }

        private void pagingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnect loaddata8 = new SqlConnect();
            if (pagingCheckBox.Checked)
            {
                prevButton.Visible = true;
                nextButton.Visible = true;
                pagingCombobox.Visible = true;
                loaddata8.pagingData("Select * from ProductTbl where Date between '" + fromDateTimePicker.Value.ToString("MM-dd-yyyy") + "' and '" + toDateTimePicker.Value.ToString("MM-dd-yyyy") + "'", 0, 5);
                CatDGV.DataSource = loaddata8.table;
                pagingCheckBox.Checked = true;
            }
            else
            {
                prevButton.Visible = false;
                nextButton.Visible = false;
                pagingCombobox.Visible = false;
                pagingCheckBox.Checked = false;
                display();
            }
        }

        #endregion


    }
}
