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
        Type sellerType = typeof(Sellers);
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
                
                sellerTable = DataAccess.Instance.GetTable("SellersTbl");

                filterTable = sellerTable.Copy();
                filterTable.Columns.Remove("SellerPass");
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

                // Initialize the originalCategoryTable field with the same data as categoryTable
                originalProductTable = sellerTable.Copy();

                MenuStrip.Instance.Menu(SellDGV, sellerTable, null, null, false);
                //Fill combo Active
                string[] test2 = { "Not Set", "Active", "Inactive" };
                activeComboBox.DataSource = test2;

                activeComboBox.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                //Utils.Log(string.Format("Message : {0}", ex.Message), "ErrorDisplayData.txt");
            }
        }

        #region buttons
        private void addButton_Click(object sender, EventArgs e)
        {
            addEditSeller add = new addEditSeller(sellerTable, null, true);
            add.editButton.Visible = false;
            add.SellId.Visible = false;
            add.idlabel.Visible = false;
            add.Show();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow currentRow = SellDGV.CurrentRow;
                if (currentRow != null)
                {
                    DataRow rowOfSellDGV = ((DataRowView)currentRow.DataBoundItem).Row;
                    string filterData = "SellerId = " + rowOfSellDGV["SellerId"];
                    DataRow filterRow = sellerTable.Select(filterData).FirstOrDefault();
                    addEditSeller edit = new addEditSeller(sellerTable, filterRow, false);
                    edit.addButton.Visible = false;
                    edit.SellId.ReadOnly = true;
                    edit.Show();
                }

            }
            catch (Exception ex)
            {
                //Utlis.Log(string.Format("Message : {0}", ex.Message), "ErrorDisplayData.txt");
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<DataRow> rowsToDelete = new List<DataRow>();
                DataRow row = null;
                // loop over the selected rows and add them to the list
                foreach (DataGridViewRow selectedRow in SellDGV.SelectedRows)
                {
                    //Convert DataGridViewRow -> DataRow
                    row = ((DataRowView)selectedRow.DataBoundItem).Row;
                    rowsToDelete.Add(row);
                }
                //DataAccess.Instance.DeleteData(row, sellerType);
                //// loop over the rows to delete and remove them from the DataTable
                //foreach (DataRow rowDelete in rowsToDelete)
                //{
                //    tableWithoutColumns.Rows.Remove(rowDelete);
                //}
                SellDGV.DataSource = filterTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                    sellerTable = matchingRows.CopyToDataTable();
                }
                else
                {
                    sellerTable = sellerTable.Clone();
                }
            }
            // If the search text is empty, assign the originalCategoryTable to the categoryTable
            else
            {
                sellerTable = originalProductTable.Copy();
            }

            // Bind the categoryTable to the CatDGV DataGridView control
            SellDGV.DataSource = sellerTable;
        }

        #endregion

        #region MenuStrip
        private void menu()
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            ToolStripMenuItem mnuDelete = new ToolStripMenuItem("Delete");
            ToolStripMenuItem mnuEdit = new ToolStripMenuItem("Edit");
            mnuDelete.Click += new EventHandler(mnuDelete_Click);
            mnuEdit.Click += new EventHandler(mnuEdit_Click);
            menu.Items.AddRange(new ToolStripItem[] { mnuEdit, mnuDelete });
            SellDGV.ContextMenuStrip = menu;
            SellDGV.AllowUserToAddRows = false;
        }

        private void mnuEdit_Click(object? sender, EventArgs e)
        {
            try
            {
                //SqlConnect loaddata50 = new SqlConnect();
                //addEditSeller edit = new addEditSeller();
                //edit.SellId.Text = SellDGV.CurrentRow.Cells[0].Value.ToString();
                //string query = $"Select * From SellersTbl where SellerId = {edit.SellId.Text}";
                //loaddata50.getData(query);
                //DataTable sellers = loaddata50.table;
                //foreach (DataRow row in sellers.Rows)
                //{
                //    edit.usernameTextBox.Text = row["SellerUserName"].ToString();
                //    byte[] imageData = (byte[])row["Image"];
                //    MemoryStream ms = new MemoryStream(imageData);
                //    edit.pictureBox.Image = Image.FromStream(ms);
                //    edit.passwordTextBox.Text = row["SellerPass"].ToString();
                //    edit.SellName.Text = row["SellerName"].ToString();
                //    edit.SellAge.Text = row["SellerAge"].ToString();
                //    edit.SellPhone.Text = row["SellerPhone"].ToString();
                //    edit.addressTextBox.Text = row["Address"].ToString();
                //    edit.dateTimePicker.Text = row["Date"].ToString();
                //    edit.checkBox.Checked = (bool)row["Active"];
                //}
                //edit.addButton.Visible = false;
                //edit.SellId.ReadOnly = true;
                //edit.Show();
            }
            catch (Exception ex)
            {
                //Utlis.Log(string.Format("Message : {0}", ex.Message), "ErrorDisplayData.txt");
            }
        }
        private void mnuDelete_Click(object? sender, EventArgs e)
        {
            //SqlConnect loaddata2 = new SqlConnect();
            //loaddata2.execCom("Delete From SellerTbl Where SellerId = " + SellDGV.CurrentRow.Cells[0].Value.ToString());
            //foreach (DataGridViewRow row in SellDGV.SelectedRows)
            //{
            //    SellDGV.Rows.RemoveAt(row.Index);

            //}
        }
        #endregion

        #region Events

        private void SellDGV_MouseDown(object sender, MouseEventArgs e)
        {
            menu();
        }
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
            //if (e.ColumnIndex == 2 && e.Value != null)
            //{
            //    e.Value = new string('*', e.Value.ToString().Length);
            //}

        }

        private void activeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(filterTable.Rows.Count > 0)
                {
                    if(activeComboBox.Text == "Not Set")
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
        #endregion

        #region ChechDatabase
       

        #endregion

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            searchButton.PerformClick();
        }

    }
}


