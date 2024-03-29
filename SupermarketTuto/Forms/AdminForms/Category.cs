﻿using CallSuperMarketAPI;
using ClassLibrary1;
using ClassLibrary1.Models;
using DataClass;
using Microsoft.Office.Interop.Excel;
using Newtonsoft.Json;
using SupermarketTuto.Forms.AdminForms;
using SupermarketTuto.Forms.General;
using SupermarketTuto.Interfaces;
using SupermarketTuto.Utils;
using System.ComponentModel;
using System.Data;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;
using MenuStrip = ClassLibrary1.MenuStrip;

namespace SupermarketTuto.Forms
{
    public partial class Category : Form
    {
        ExcelFile excel = new ExcelFile();
        DataTable categoryTable = new DataTable();
        public DataTable originalCategoryTable;
        BindingSource bindingSource = new BindingSource();
        Type categoryType = typeof(CategoryTbl);
        TCPClient ClientTCP = new TCPClient();
        UDPClient ClientUDP = new UDPClient();
        List<CategoryTbl> categories;

        public Category()
        {
            InitializeComponent();
            // You might obtain local IP addresses using System.Net.NetworkInformation.NetworkInterface
            // For demonstration, here's a sample code to get the first IPv4 address associated with an interface
            string clientIpAddress = "";
            foreach (var networkInterface in System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces())
            {
                var properties = networkInterface.GetIPProperties();
                foreach (var ipAddress in properties.UnicastAddresses)
                {
                    if (ipAddress.Address.AddressFamily == AddressFamily.InterNetwork)
                    {
                        clientIpAddress = ipAddress.Address.ToString();
                        break;
                    }
                }
                if (!string.IsNullOrEmpty(clientIpAddress))
                {
                    break;
                }
            }

            // Use clientIpAddress and a specified clientPort (or '0' to allow the OS to select a port)
            int clientPort = 0; // Set to '0' to allow OS to select an available port
            //ClientTCP.ConnectTCPClient(clientIpAddress, clientPort);
            //ClientTCP.DataReceived += HandleReceivedDataTCP;
            //ClientUDP.ConnectUDPClient();
            //ClientUDP.DataReceived += HandleReceivedDataUDP;

        }

        private void HandleReceivedDataTCP(object sender, string jsonData)
        {
            try
            {
                List<CategoryTbl> Newcategories = JsonConvert.DeserializeObject<List<CategoryTbl>>(jsonData);
                // Add received categories to the existing list
                categories.AddRange(Newcategories);

                // Update DataGridView with the merged list of categories
                UpdateDataGridView(categories);
            }
            catch
            {

            }
        }

        private void HandleReceivedDataUDP(object sender, string jsonData)
        {
            try
            {
                List<CategoryTbl> Newcategories = JsonConvert.DeserializeObject<List<CategoryTbl>>(jsonData);
                // Add received categories to the existing list
                categories.AddRange(Newcategories);

                // Update DataGridView with the merged list of categories
                UpdateDataGridView(categories);
            }
            catch
            {

            }
        }


        // Method to update DataGridView with a list of categories
        private void UpdateDataGridView(List<CategoryTbl> categories)
        {
            try
            {
                // Update DataGridView with the merged list of categories
                if (InvokeRequired)
                {
                    Invoke((MethodInvoker)delegate
                    {
                        CatDGV.AutoGenerateColumns = true;
                        CatDGV.DataSource = categories;
                    });
                }
                else
                {
                    CatDGV.AutoGenerateColumns = true;
                    CatDGV.DataSource = categories;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating DataGridView: " + ex.Message);
            }
        }

        private void Category_Load(object sender, EventArgs e)
        {
            display();

            //ClientTCP.UpdateDataServer += UpdateDataFromServer;

            //Create column Select
            DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn();
            checkboxColumn.Name = "Select";
            CatDGV.Columns.Add(checkboxColumn);
            CatDGV.Columns["Select"].DisplayIndex = 0;

            MenuStrip.Instance.Menu(CatDGV, categoryTable, null, categoryType, true);

            exportCombobox.Items.Add("Csv");
            exportCombobox.Items.Add("Xlsx");

            importCombobox.Items.Add("Csv");
            importCombobox.Items.Add("Xlsx");

            //Fill Combobox of paging
            List<int> pageCombo = new List<int>();
            pageCombo.Add(5);
            pageCombo.Add(10);
            pageCombo.Add(20);
            pagingCombobox.DataSource = pageCombo;

        }

        private void display()
        {
            try
            {
                fromDateTimePicker.Value = DateTime.Now.AddMonths(-2);
                categories = DataModel.Select<CategoryTbl>();
                categoryTable = Utils.Utils.ToDataTable(categories);
                categoryTable.PrimaryKey = new DataColumn[] { categoryTable.Columns["CatId"] };
                originalCategoryTable = categoryTable.Copy();

                // Bind the data to the UI controls using the BindingSource
                bindingSource = new BindingSource();
                bindingSource.DataSource = categoryTable;
                CatDGV.DataSource = bindingSource;
                CatDGV.RowHeadersVisible = false;
                CatDGV.ReadOnly = false;

                // Attach the CurrentChanged event handler to the BindingSource
                bindingSource.CurrentChanged += bindingSource_CurrentChanged;

                totalLabel.Text = $"Total: {CatDGV.RowCount}";

                // Initialize the originalCategoryTable field with the same data as categoryTable
                if (totalLabel.Text == null)
                {
                    MessageBox.Show("Warning", "There is no data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Utils.Utils.Log(string.Format("Message : {0}", ex.Message), "ErrorImportTxt.txt");
            }
        }

        private void UpdateDataGridView()
        {
            try
            {
                int currentPage = bindingSource.Position / 5 + 1;
                int startIndex = (currentPage - 1) * 5;

                DataTable pageDataTable = categoryTable.Clone();
                for (int i = startIndex; i < startIndex + 5 && i < bindingSource.Count; i++)
                {
                    pageDataTable.ImportRow(categoryTable.Rows[i]);
                }
                CatDGV.DataSource = pageDataTable;
            }
            catch
            {

            }
        }

        private void bindingSource_CurrentChanged(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        #region Buttons

        private void addButton_Click(object sender, EventArgs e)
        {
            addEditCategory add = new addEditCategory(categoryTable, null, true);
            add.editButton.Visible = false;
            add.CatIdTb.Visible = false;
            add.idlabel.Visible = false;
            add.ItemCreated += Add_ItemCreated;
            add.ShowDialog();
        }

        private void Add_ItemCreated(object sender, CategoryEventArgs e)
        {
            categoryTable.Rows.Add(e.CreatedCategory.CatId, e.CreatedCategory.CatName, e.CreatedCategory.CatDesc, e.CreatedCategory.Date);
            CategoryTbl item = new CategoryTbl();
            item.CatName = e.CreatedCategory.CatName;
            item.CatDesc = e.CreatedCategory.CatDesc;
            item.Date = e.CreatedCategory.Date;
            List<CategoryTbl> data = new List<CategoryTbl>();
            data.Add(item);
            //ClientTCP.SendDataTCP<CategoryTbl>(data);
            //ClientUDP.SendDataUDP<CategoryTbl>(data);
            CatDGV.Refresh();
        }

        private void Edit_ItemEdited(object sender, CategoryEventArgs e)
        {
            // Update the edited category in the DataTable in form
            DataRow editedRow = categoryTable.Rows.Find(e.PrimaryKeyValue);
            if (editedRow != null)
            {
                editedRow["CatName"] = e.CreatedCategory.CatName;
                editedRow["CatDesc"] = e.CreatedCategory.CatDesc;
                editedRow["Date"] = e.CreatedCategory.Date;
            }
            CatDGV.Refresh();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = CatDGV.CurrentRow;
            addEditCategory edit = new addEditCategory(categoryTable, currentRow, false);
            edit.CatIdTb.ReadOnly = true;
            edit.ItemEdited += Edit_ItemEdited;
            edit.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Do you want to delete this item?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    List<DataRow> rowsToDelete = new List<DataRow>();
                    DataRow row = null;
                    // loop over the selected rows and add them to the list
                    foreach (DataGridViewRow selectedRow in CatDGV.SelectedRows)
                    {
                        //Convert DataGridViewRow -> DataRow
                        row = ((DataRowView)selectedRow.DataBoundItem).Row;
                        string CatId = Convert.ToInt32(row["CatId"]).ToString();
                        CategoryTbl category = DataModel.Select<CategoryTbl>(where: $"CatId = '{CatId}' ").FirstOrDefault();
                        DataModel.Delete<CategoryTbl>(category);
                        rowsToDelete.Add(row);
                    }

                    foreach (DataRow rowToDelete in rowsToDelete)
                    {
                        categoryTable.Rows.Remove(rowToDelete);
                    }
                    CatDGV.DataSource = categoryTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Utils.Utils.Log(string.Format("Message : {0}", ex.Message), "ErrorDeleteCategory.txt");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // If the search text is not empty, filter the originalCategoryTable and assign the filtered result to the categoryTable
            if (!string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                var matchingRows = from row in originalCategoryTable.AsEnumerable()
                                   where row.ItemArray.Any(x =>
                                         StringComparer.OrdinalIgnoreCase.Equals(x.ToString(), searchTextBox.Text))
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

        private void showSelectedProductsButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> rowsCategories = new List<string>();
                foreach (DataGridViewRow rowCat in CatDGV.Rows)
                {
                    if (rowCat != null)
                    {
                        DataGridViewCheckBoxCell checkBoxCell = rowCat.Cells[0] as DataGridViewCheckBoxCell;
                        if (checkBoxCell.Value != null && (bool)checkBoxCell.Value)
                        {
                            string CatId = rowCat.Cells["CatId"].Value?.ToString();
                            if (CatId != null)
                                rowsCategories.Add(CatId);
                        }
                    }

                }
                SelectedProducts formSelectedProd = new SelectedProducts(rowsCategories);
                formSelectedProd.Show();
            }
            catch
            {

            }

        }

        private void callAPIButton_Click(object sender, EventArgs e)
        {
            //Call API in order to save the incoming products
            GetFromExternalAPI callAPI = new GetFromExternalAPI();
            callAPI.Show();
        }

        #endregion

        #region DateTimePicker
        private void fromDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (categoryTable.Rows.Count > 0)
            {
                // Assuming you have a DataTable named "myDataTable"
                DateTime pickerDate = fromDateTimePicker.Value.Date;
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

        private void toDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (categoryTable.Rows.Count > 0)
            {
                // Assuming you have a DataTable named "myDataTable"
                DateTime pickerDate = toDateTimePicker.Value.Date;
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
                    if (Convert.ToBoolean(chk.Value) == true)
                        break;
                    else
                        chk.Value = true;
                }
            }
            else
            {
                foreach (DataGridViewRow row in CatDGV.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                    if (Convert.ToBoolean(chk.Value) == false)
                        break;
                    else
                        chk.Value = false;
                }

            }
        }
        #endregion

        #region Excel

        private void exportCombobox_SelectedValueChanged(object sender, EventArgs e)
        {

            var item = ((ComboBox)sender).SelectedItem.ToString();
            if (item.Contains("Csv"))
            {
                excel.exportCsv(CatDGV, true);
            }
            else if (item.Contains("Xlsx"))
            {
                excel.ExportExcel<CategoryTbl>(CatDGV, categoryType.Name);
            }
        }


        private void importCombobox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                Type category = typeof(CategoryTbl);
                DataTable tableNew = new DataTable();
                var item = ((ComboBox)sender).SelectedItem.ToString();

                if (item.Contains("Csv"))
                {
                    tableNew = excel.import<CategoryTbl>(category);

                }
                else if (item.Contains("Xlsx"))
                {
                    List<CategoryTbl> list = excel.ImportExcel<CategoryTbl>();
                    tableNew = Utils.Utils.ToDataTable(list);
                }
                DataTable table3 = categoryTable.Clone();
                var differenceQuery = tableNew.AsEnumerable().Except(categoryTable.AsEnumerable(), DataRowComparer.Default);

                foreach (DataRow row in differenceQuery)
                {
                    table3.Rows.Add(row.ItemArray);
                }
                categoryTable.Merge(tableNew);
                CatDGV.DataSource = categoryTable;
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
                pagingCombobox.Visible = true;
                // Update the DataGridView with the rows for the initial page
                UpdateDataGridView();
            }
            else
            {
                prevButton.Visible = false;
                nextButton.Visible = false;
                pagingCombobox.Visible = false;
                CatDGV.DataSource = bindingSource;
            }
        }

        #endregion

        #region Communication

        #region TCP

        #endregion

        #region UDP

        #endregion


        #endregion

    }
}
