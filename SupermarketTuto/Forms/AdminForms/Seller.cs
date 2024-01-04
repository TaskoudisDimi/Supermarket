using ClassLibrary1;
using ClassLibrary1.Models;
using DataClass;
using Microsoft.Office.Interop.Excel;
using SupermarketTuto.Forms.General;
using SupermarketTuto.Utils;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http.Headers;
using System.Text;
using DataTable = System.Data.DataTable;
using MenuStrip = ClassLibrary1.MenuStrip;

namespace SupermarketTuto.Forms
{
    public partial class Seller : Form
    {
        DataTable sellerTable = new DataTable();
        BindingSource bindingSource = new BindingSource();
        private DataTable originalProductTable;
        Type sellerType = typeof(SellersTbl);
        DataTable filterTable;
        DataTable tableWithoutColumns;

        public Seller()
        {
            InitializeComponent();
        }
        private void Seller_Load(object sender, EventArgs e)
        {
            display();
        }

        private void display()
        {
            try
            {
                List<SellersTbl> sellers = DataModel.Select<SellersTbl>();
                sellerTable = Utils.Utils.ToDataTable(sellers);
                sellerTable.PrimaryKey = new DataColumn[] { sellerTable.Columns["SellerId"] };
                filterTable = sellerTable.Copy();
                filterTable.Columns.Remove("Image");
                tableWithoutColumns = filterTable.Clone();
                DataRow[] filterRow = filterTable.Select("Active = 1");
                foreach (DataRow row in filterRow)
                {
                    tableWithoutColumns.ImportRow(row);
                }

                bindingSource.DataSource = tableWithoutColumns;

                SellDGV.DataSource = bindingSource;
                totalLabel.Text = $"Total: {SellDGV.RowCount}";
                SellDGV.RowHeadersVisible = false;
                SellDGV.ReadOnly = true;

                // Attach the CurrentChanged event handler to the BindingSource
                bindingSource.CurrentChanged += bindingSource_CurrentChanged;

                // Initialize the originalCategoryTable field with the same data as categoryTable
                originalProductTable = sellerTable.Copy();

                MenuStrip.Instance.Menu(SellDGV, sellerTable, null, null, false);
                //Fill combo Active
                string[] data = { "Not Set", "Active", "Inactive" };
                activeComboBox.DataSource = data;
                activeComboBox.SelectedIndex = 1;

            }
            catch (Exception ex)
            {
                Utils.Utils.Log(string.Format("Message : {0}", ex.Message), "ErrorDisplayData.txt");
            }
        }

        private void UpdateDataGridView()
        {
            try
            {
                int currentPage = bindingSource.Position / 5 + 1;
                int startIndex = (currentPage - 1) * 5;

                DataTable pageDataTable = sellerTable.Clone();
                for (int i = startIndex; i < startIndex + 5 && i < bindingSource.Count; i++)
                {
                    pageDataTable.ImportRow(sellerTable.Rows[i]);
                }
                SellDGV.DataSource = pageDataTable;
            }
            catch
            {

            }
        }

        private void bindingSource_CurrentChanged(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        #region buttons
        private void addButton_Click(object sender, EventArgs e)
        {
            addEditSeller add = new addEditSeller(sellerTable, null, true);
            add.editButton.Visible = false;
            add.SellId.Visible = false;
            add.idlabel.Visible = false;
            add.Show();
            add.ItemCreated += Add_ItemCreated;
        }

        private void Add_ItemCreated(object sender, SellerEventArgs e)
        {
            tableWithoutColumns.Rows.Add(e.CreatedSeller.SellerId, e.CreatedSeller.SellerUserName, e.CreatedSeller.SellerPass,
                e.CreatedSeller.SellerName, e.CreatedSeller.SellerAge, e.CreatedSeller.SellerPhone, e.CreatedSeller.Date,
                e.CreatedSeller.Address, e.CreatedSeller.Active);
            SellDGV.DataSource = tableWithoutColumns;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = SellDGV.CurrentRow;
            addEditSeller edit = new addEditSeller(sellerTable, currentRow, false);
            edit.SellId.ReadOnly = true;
            edit.ItemEdited += Edit_ItemEdited;
            edit.Show();
        }

        private void Edit_ItemEdited(object sender, SellerEventArgs e)
        {
            // Update the edited category in the DataTable in form
            DataRow editedRow = sellerTable.Rows.Find(e.PrimaryKeyValue);
            if (editedRow != null)
            {
                editedRow["SellerName"] = e.CreatedSeller.SellerName;
                editedRow["SellerUserName"] = e.CreatedSeller.SellerUserName;
                editedRow["SellerId"] = e.CreatedSeller.SellerId;
                editedRow["SellerPhone"] = e.CreatedSeller.SellerPhone;
                editedRow["SellerPass"] = e.CreatedSeller.SellerPass;
                editedRow["SellerAge"] = e.CreatedSeller.SellerAge;
                editedRow["Address"] = e.CreatedSeller.Address;
                editedRow["Active"] = e.CreatedSeller.Active;
                editedRow["Date"] = e.CreatedSeller.Date;
            }
            SellDGV.DataSource = tableWithoutColumns;
            SellDGV.Refresh();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Do you want to delete this item?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    List<int> sellerIdsToDelete = new List<int>();
                    // Loop over the selected rows and add their SellerIds to the list
                    foreach (DataGridViewRow selectedRow in SellDGV.SelectedRows)
                    {
                        // Retrieve the SellerId from the selected row
                        if (selectedRow.Cells["SellerId"].Value != null)
                        {
                            int sellerId = Convert.ToInt32(selectedRow.Cells["SellerId"].Value);
                            sellerIdsToDelete.Add(sellerId);
                        }
                    }
                    // Delete the sellers based on their SellerIds
                    foreach (int sellerIdToDelete in sellerIdsToDelete)
                    {
                        SellersTbl seller = DataModel.Select<SellersTbl>(where: $"sellerId = '{sellerIdToDelete}'").FirstOrDefault();
                        if (seller != null)
                        {
                            DataModel.Delete<SellersTbl>(seller);
                        }
                    }
                    // Refresh the DataGridView
                    SellDGV.Refresh();

                    // Remove the selected rows from the DataGridView
                    foreach (DataGridViewRow selectedRow in SellDGV.SelectedRows)
                    {
                        if (!selectedRow.IsNewRow)
                        {
                            SellDGV.Rows.Remove(selectedRow);
                        }
                    }
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
                var matchingRows = from row in originalProductTable.AsEnumerable()
                                   where row.ItemArray.Any(x =>
                                         StringComparer.OrdinalIgnoreCase.Equals(x.ToString(), searchTextBox.Text))
                                   select row;

                if (matchingRows.Any())
                {
                    tableWithoutColumns = matchingRows.CopyToDataTable();
                    tableWithoutColumns.Columns.Remove("Image");
                }
                else
                {
                    tableWithoutColumns = tableWithoutColumns.Clone();
                }
            }
            // If the search text is empty, assign the originalCategoryTable to the categoryTable
            else
            {
                tableWithoutColumns = originalProductTable.Copy();
                tableWithoutColumns.Columns.Remove("Image");
            }

            // Bind the categoryTable to the CatDGV DataGridView control
            SellDGV.DataSource = tableWithoutColumns;
        }


        #endregion

        #region Events

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Search with Enter 
            if (e.KeyChar == (char)13)
            {
                searchButton.PerformClick();
            }
        }

        private void SellDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //foreach (DataGridViewRow row in SellDGV.Rows)
            //{
            //    if (Convert.ToBoolean(row.Cells[8].Value.ToString()) == false)
            //    {
            //        row.DefaultCellStyle.BackColor = Color.Orange;
            //    }

            //}
            if (e.ColumnIndex == 2 && e.Value != null)
            {
                e.Value = new string('*', e.Value.ToString().Length);
            }

        }

        private void activeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (filterTable.Rows.Count > 0)
                {
                    if (activeComboBox.Text == "Not Set")
                    {
                        SellDGV.DataSource = filterTable;
                        SellDGV.RowHeadersVisible = false;
                        totalLabel.Text = $"Total: {SellDGV.RowCount}";
                    }
                    else
                    {
                        bool active = activeComboBox.Text.Equals("Active") ? true : false;
                        string filterData = "Active = " + active.ToString().ToLower();
                        DataRow[] filterRow = filterTable.Select(filterData);
                        DataTable comboTable = filterTable.Clone();
                        foreach (DataRow row in filterRow)
                        {
                            comboTable.ImportRow(row);
                        }
                        SellDGV.DataSource = comboTable;
                        SellDGV.RowHeadersVisible = false;
                        totalLabel.Text = $"Total: {SellDGV.RowCount}";
                    }
                }
            }
            catch (Exception ex)
            {

            }

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            searchButton.PerformClick();
        }

        #endregion

        #region ChechDatabase


        #endregion


    }
}


