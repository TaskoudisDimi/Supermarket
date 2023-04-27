using ClassLibrary1;
using ClassLibrary1.Models;
using DataClass;
using Microsoft.Office.Interop.Excel;
using NuGet;
using SupermarketTuto.Forms.AdminForms;
using SupermarketTuto.Forms.General;
using SupermarketTuto.Interfaces;
using SupermarketTuto.Utils;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;

namespace SupermarketTuto.Forms
{
    public partial class Category : Form
    {
        int startRecord;
        SqlConnect loaddata = new SqlConnect();
        ExcelFile excel = new ExcelFile();
        DataTable keepTable = new DataTable();
        Type categoryType = typeof(Categories);


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

            exportCombobox.Items.Add("Csv");
            exportCombobox.Items.Add("Xlsx");

            importCombobox.Items.Add("Csv");
            importCombobox.Items.Add("Xlsx");
        }
        private void display()
        {
            try
            {
                fromDateTimePicker.Value = DateTime.Now.AddMonths(-2);
                //CatDGV.DataSource = loaddata.getData("Select * From CategoryTbl where Date between '" + fromDateTimePicker.Value.ToString("MM-dd-yyyy") + "' and '" + toDateTimePicker.Value.ToString("MM-dd-yyyy") + "'");
                CatDGV.DataSource = loaddata.getDataTest("Select * From CategoryTbl where Date between '" + fromDateTimePicker.Value.ToString("MM-dd-yyyy") + "' and '" + toDateTimePicker.Value.ToString("MM-dd-yyyy") + "'", categoryType);
                CatDGV.RowHeadersVisible = false;
                keepTable = loaddata.table.Copy();
                CatDGV.Columns[3].HeaderText = "Date";
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
            //addEditCategory edit = new addEditCategory();
            //edit.CatIdTb.Text = CatDGV.CurrentRow.Cells[1].Value.ToString();
            //edit.CatNameTb.Text = CatDGV.CurrentRow.Cells[2].Value.ToString();
            //edit.CatDescTb.Text = CatDGV.CurrentRow.Cells[3].Value.ToString();
            //edit.dateTimePicker.Text = CatDGV.CurrentRow.Cells[4].Value.ToString();
            //edit.addButton.Visible = false;
            //edit.CatIdTb.ReadOnly = true;
            //edit.Show();
            //display();
        }

        private void mnuDelete_Click(object? sender, EventArgs e)
        {
            try
            {
                SqlConnect loaddata2 = new SqlConnect();
                loaddata2.execCom("Delete From CategoryTbl Where CatId='" + CatDGV.CurrentRow.Cells[1].Value.ToString() + "'");
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
            CatDGV.DataSource = loaddata.table;
            //loaddata.UpdateData();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //check();
            addEditCategory add = new addEditCategory(loaddata);
            add.editButton.Visible = false;
            add.CatIdTb.Visible = false;
            add.idlabel.Visible = false;
            add.ShowDialog();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            //check();
            addEditCategory edit = new addEditCategory(loaddata);
            foreach (DataRow row in loaddata.table.Rows)
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
                //check();
                loaddata5.execCom("Delete From CategoryTbl Where CatId = " + CatDGV.CurrentRow.Cells[1].Value.ToString());
                //display();
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
                BackgroundWorker.DoWork += Import_DoWork;
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
        private void Import_DoWork(object sender, DoWorkEventArgs e)
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
            if (loaddata.table.Columns.Count > 0)
            {

                DateTime pickerDate = fromDateTimePicker.Value.Date;
                DataRow[] rowsToRemove = loaddata.table.Select("Date < #" + pickerDate + "#");
                DataRow[] rowsToAdd = keepTable.Select("Date > #" + pickerDate + "#");
                if (rowsToRemove.Count() > 0)
                {
                    foreach (DataRow row in rowsToRemove)
                    {
                        loaddata.table.Rows.Remove(row);
                    }
                    CatDGV.DataSource = loaddata.table;
                }
                else
                {
                    if(rowsToAdd.Count() == 0)
                    {
                        foreach (DataRow row in rowsToAdd)
                        {
                            loaddata.table.Rows.Add(row);
                        }
                        
                    }
                    CatDGV.DataSource = keepTable;
                }
            }
        }

        private void toDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
           
        }
        #endregion

        #region Events
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            searchButton.PerformClick();
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

        private void selectAllCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (selectAllCheckBox.Checked)
            {
                foreach (DataGridViewRow row in CatDGV.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                    chk.Value = !(chk.Value == null ? false : (bool)chk.Value);
                }
            }
            else
            {
                foreach (DataGridViewRow row in CatDGV.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                    chk.Value = !(chk.Value == null ? true : (bool)chk.Value);
                }

            }
        }
        #endregion

        #region Excel

        private void exportCombobox_SelectedValueChanged(object sender, EventArgs e)
        {
            Type category = typeof(Categories);
            var item = ((ComboBox)sender).SelectedItem.ToString();
            if (item.Contains("Csv"))
            {
                excel.export(CatDGV,true);
            }
            else if (item.Contains("Xlsx"))
            {
                excel.Save(CatDGV, category);
            }
        }


        private void importCombobox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                Type category = typeof(Categories);
                DataTable tableNew = new DataTable();
                var item = ((ComboBox)sender).SelectedItem.ToString();

                if (item.Contains("Csv"))
                {
                    tableNew = excel.import(category);

                }
                else if (item.Contains("Xlsx"))
                {
                    tableNew = excel.ImportExcelAsync(CatDGV, category);
                }
                DataTable table3 = loaddata.table.Clone();
                var differenceQuery = tableNew.AsEnumerable().Except(loaddata.table.AsEnumerable(), DataRowComparer.Default);

                foreach (DataRow row in differenceQuery)
                {
                    table3.Rows.Add(row.ItemArray);
                }
                loaddata.table.Merge(tableNew);
                CatDGV.DataSource = loaddata.table;
                CatDGV.RowHeadersVisible = false;
                CatDGV.AllowUserToAddRows = false;
                DialogResult result = MessageBox.Show("Do you want to save the extra data to Database?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    excel.SaveToDB(table3, category);
                }
            }
            catch
            {

            }
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
                //display();
            }
        }

        #endregion

        #region ChechDatabase
        private void check()
        {
            SqlConnect sql = new SqlConnect();
            var customerType = typeof(Categories);
            sql.checkTable(Categories: customerType);
        }


        #endregion

        
    }
}
