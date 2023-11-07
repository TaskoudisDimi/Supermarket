using ClassLibrary1;
using ClassLibrary1.Models;
using DataClass;
using Microsoft.Office.Interop.Excel;
using SupermarketTuto.Forms.General;
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
using Font = System.Drawing.Font;
using Point = System.Drawing.Point;

namespace SupermarketTuto.Forms.SellingForms
{
    public partial class Bills : Form
    {

        ExcelFile excel = new ExcelFile();
        DataTable billTable = new DataTable();
        BindingSource billBindingSource = new BindingSource();
        private DataTable originalBillTable;
        Type billType = typeof(BillTbl);

        public Bills()
        {
            InitializeComponent();
        }

        private void Bills_Load(object sender, EventArgs e)
        {
            displayBills();
        }


        private void displayBills()
        {
            DataGridViewCheckBoxColumn Select = new DataGridViewCheckBoxColumn();
            Select.Name = "Select";
            Select.ReadOnly = false;

            BillsDGV.Columns.Add(Select);
            BillsDGV.Columns["Select"].DisplayIndex = 0;


            List<BillTbl> billsData = DataModel.Select<BillTbl>();
            billTable = Utils.Utils.ToDataTable(billsData);
            billTable.PrimaryKey = new DataColumn[] { billTable.Columns[name: "BillId"] };
            billBindingSource.DataSource = billTable;

            BillsDGV.DataSource = billBindingSource;

            BillsDGV.AllowUserToAddRows = false;
            BillsDGV.RowHeadersVisible = false;
            total3Label.Text = $"Total: {BillsDGV.RowCount}";

            // Attach the CurrentChanged event handler to the BindingSource
            billBindingSource.CurrentChanged += bindingSource_CurrentChanged;

            originalBillTable = billTable.Copy();

            exportCombobox.Items.Add("Csv");
            exportCombobox.Items.Add("Xlsx");

            importCombobox.Items.Add("Csv");
            importCombobox.Items.Add("Xlsx");
        }

        private void bindingSource_CurrentChanged(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            try
            {
                int currentPage = billBindingSource.Position / 5 + 1;
                int startIndex = (currentPage - 1) * 5;

                DataTable pageDataTable = billTable.Clone();
                for (int i = startIndex; i < startIndex + 5 && i < billBindingSource.Count; i++)
                {
                    pageDataTable.ImportRow(billTable.Rows[i]);
                }

                BillsDGV.DataSource = pageDataTable;
            }
            catch
            {

            }

        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("FamilySuperMarket", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics.DrawString("Bill ID: " + BillsDGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Blue, new Point(100, 70));
            e.Graphics.DrawString("Seller Name: " + BillsDGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Blue, new Point(100, 100));
            e.Graphics.DrawString("Date: " + BillsDGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Blue, new Point(100, 130));
            e.Graphics.DrawString("Total Amount: " + BillsDGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Blue, new Point(100, 160));
            e.Graphics.DrawString("Code Space", new Font("Century Gothic", 20, FontStyle.Italic), Brushes.Blue, new Point(230, 230));

        }

        private void importCombobox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                Type product = typeof(BillTbl);
                DataTable tableNew = new DataTable();
                var item = ((ComboBox)sender).SelectedItem.ToString();

                if (item.Contains("Csv"))
                {
                    tableNew = excel.import<BillTbl>(product);
                }
                else if (item.Contains("Xlsx"))
                {
                    List<BillTbl> list = excel.ImportExcel<BillTbl>();
                    tableNew = Utils.Utils.ToDataTable(list);
                }
                List<BillTbl> listProducts = DataModel.GetListFromDataTable<BillTbl>(tableNew);
                foreach (BillTbl prod in listProducts)
                {
                    DataModel.Create(prod);
                }
                BillsDGV.DataSource = tableNew;

                DialogResult result = MessageBox.Show("Do you want to save the extra data to Database?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    excel.SaveToDB(tableNew, product);
                }
            }
            catch
            {

            }
        }

        private void exportCombobox_SelectedValueChanged(object sender, EventArgs e)
        {
            Type product = typeof(BillTbl);
            var item = ((ComboBox)sender).SelectedItem.ToString();
            if (item.Contains("Csv"))
            {
                excel.exportCsv(BillsDGV, true);
            }
            else if (item.Contains("Xlsx"))
            {
                excel.ExportExcel<BillTbl>(BillsDGV, billType.Name);
            }
        }

        #region Excel (csv && xlsx)

        

       

        #endregion



        private void editButton_Click(object sender, EventArgs e)
        {
            //DataGridViewRow currentRow = BillsDGV.CurrentRow;
            //addEditCategory edit = new addEditCategory(billTable, currentRow, false);
            //edit.CatIdTb.ReadOnly = true;
            //edit.ItemEdited += Edit_ItemEdited;

            ////edit.DataChanged += Edit_DataChanged;

            //edit.Show();
        }


        private void Edit_ItemEdited(object sender, CategoryEventArgs e)
        {
            // Update the edited category in the DataTable in form

            DataRow editedRow = billTable.Rows.Find(e.PrimaryKeyValue);
            if (editedRow != null)
            {
                editedRow["Comments"] = e.CreatedCategory.CatName;
                editedRow["SellerName"] = e.CreatedCategory.CatDesc;
                editedRow["TotAmt"] = e.CreatedCategory.CatDesc;
                editedRow["ProductIDs"] = e.CreatedCategory.CatDesc;
                editedRow["CategoryIDs"] = e.CreatedCategory.CatDesc;
                editedRow["Date"] = e.CreatedCategory.Date;
            }
            BillsDGV.Refresh();
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure to delete this data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                    List<DataRow> rowsToDelete = new List<DataRow>();
                    DataRow row = null;
                    // loop over the selected rows and add them to the list
                    foreach (DataGridViewRow selectedRow in BillsDGV.SelectedRows)
                    {
                        //Convert DataGridViewRow -> DataRow
                        row = ((DataRowView)selectedRow.DataBoundItem).Row;
                        string BillId = Convert.ToInt32(row["BillId"]).ToString();
                        BillTbl category = DataModel.Select<BillTbl>(where: $"BillId = '{BillId}' ").FirstOrDefault();
                        DataModel.Delete<BillTbl>(category);
                        rowsToDelete.Add(row);
                    }

                    foreach (DataRow rowToDelete in rowsToDelete)
                    {
                        billTable.Rows.Remove(rowToDelete);
                    }
                    BillsDGV.DataSource = billTable;
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
                var matchingRows = from row in originalBillTable.AsEnumerable()
                                   where row.ItemArray.Any(x =>
                                         StringComparer.OrdinalIgnoreCase.Equals(x.ToString(), searchTextBox.Text))
                                   select row;

                if (matchingRows.Any())
                {
                    billTable = matchingRows.CopyToDataTable();
                }
                else
                {
                    billTable = billTable.Clone();
                }
            }
            // If the search text is empty, assign the originalCategoryTable to the categoryTable
            else
            {
                billTable = originalBillTable.Copy();
            }

            // Bind the categoryTable to the CatDGV DataGridView control
            BillsDGV.DataSource = billTable;
        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                searchButton.PerformClick();
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            searchButton.PerformClick();
        }

        private void fromDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (billTable.Rows.Count > 0)
            {
                DateTime dateTimePicker = fromDateTimePicker.Value.Date;
                string filterDate = "Date >= #" + dateTimePicker.ToString("yyyy/MM/dd") + "#";
                DataRow[] filteredRows = billTable.Select(filterDate);

                DataTable filterTable = billTable.Clone();
                foreach (DataRow row in filteredRows)
                {
                    filterTable.ImportRow(row);
                }
                BillsDGV.DataSource = filterTable;
            }
        }

        private void toDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (billTable.Rows.Count > 0)
            {
                DateTime dateTimePicker = toDateTimePicker.Value.Date;
                string filterDate = "Date <= #" + dateTimePicker.ToString("yyyy/MM/dd") + "#";
                DataRow[] filteredRows = billTable.Select(filterDate);

                DataTable filterTable = billTable.Clone();
                foreach (DataRow row in filteredRows)
                {
                    filterTable.ImportRow(row);
                }
                BillsDGV.DataSource = filterTable;
            }
        }

        private void selectAllCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (selectAllCheckBox.Checked)
            {
                foreach (DataGridViewRow row in BillsDGV.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                    chk.Value = !(chk.Value == null ? false : (bool)chk.Value);
                }
            }
            else
            {
                foreach (DataGridViewRow row in BillsDGV.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                    chk.Value = !(chk.Value == null ? true : (bool)chk.Value);
                }

            }
        }
    }
}
