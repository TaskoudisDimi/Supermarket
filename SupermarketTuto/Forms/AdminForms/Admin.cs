using ClassLibrary1;
using ClassLibrary1.Models;
using DataClass;
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
using MenuStrip = ClassLibrary1.MenuStrip;

namespace SupermarketTuto.Forms
{
    public partial class Admin : Form
    {
        DataTable adminTable = new DataTable();
        DataTable filterTable = new DataTable();
        Admins admins = new Admins();
        BindingSource bindingSource = new BindingSource();
        private DataTable originalAdminTable;

        public Admin(Admins admins_ = null, bool displayFromMainSelling = false)
        {
            InitializeComponent();
            
            admins = admins_;
            if (displayFromMainSelling)
            {
                addButton.Enabled = false;
                editButton.Enabled = false;
                deleteButton.Enabled = false;
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            try
            {
                //Fill combo Active
                string[] dataCombo = { "Not Set", "Active", "Inactive" };
                activeComboBox.DataSource = dataCombo;
                activeComboBox.SelectedIndex = 1;

                List<Admins> data = DataModel.Select<Admins>();
                adminTable = Utils.Utils.ToDataTable(data);
                adminTable.PrimaryKey = new DataColumn[] { adminTable.Columns[name: "Id"] };
                filterTable = adminTable.Clone();
                DataRow[] filterRow = adminTable.Select("Active = 1");
                foreach (DataRow row in filterRow)
                {
                    filterTable.ImportRow(row);
                }
                bindingSource.DataSource = filterTable;
                usersDataGridView.DataSource = bindingSource;
                usersDataGridView.RowHeadersVisible = false;

                // Attach the CurrentChanged event handler to the BindingSource
                bindingSource.CurrentChanged += bindingSource_CurrentChanged;

                totalLabel.Text = $"Total: {usersDataGridView.RowCount}";

                MenuStrip.Instance.Menu(usersDataGridView, adminTable, null, null, false);

                // Initialize the originalCategoryTable field with the same data as categoryTable
                originalAdminTable = adminTable.Copy();

            }
            catch
            {

            } 
        }

        private void UpdateDataGridView()
        {
            try
            {
                int currentPage = bindingSource.Position / 5 + 1;
                int startIndex = (currentPage - 1) * 5;

                DataTable pageDataTable = adminTable.Clone();
                for (int i = startIndex; i < startIndex + 5 && i < bindingSource.Count; i++)
                {
                    pageDataTable.ImportRow(adminTable.Rows[i]);
                }
                usersDataGridView.DataSource = pageDataTable;
            }
            catch
            {

            }
        }

        private void bindingSource_CurrentChanged(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private void usersDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.Value != null)
            {
                e.Value = new string('*', e.Value.ToString().Length);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addEditAdmin add = new addEditAdmin(adminTable, null, true);
            add.editButton.Visible = false;
            add.AdminIdTb.Visible = false;
            add.idlabel.Visible = false;

            add.ItemCreated += Add_ItemCreated;
            add.ShowDialog();
        }

        private void Add_ItemCreated(object sender, AdminsEventArgs e)
        {
            adminTable.Rows.Add(e.CreatedAdmin.Id, e.CreatedAdmin.UserName,e.CreatedAdmin.Password ,e.CreatedAdmin.Active, e.CreatedAdmin.isSuperAdmin);
            usersDataGridView.Refresh();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = usersDataGridView.CurrentRow;
            addEditAdmin edit = new addEditAdmin(adminTable, currentRow, false);
            edit.AdminIdTb.ReadOnly = true;
            edit.ItemEdited += Edit_ItemEdited;

            edit.Show();
        }

        private void Edit_ItemEdited(object sender, AdminsEventArgs e)
        {
            // Update the edited category in the DataTable in form

            DataRow editedRow = adminTable.Rows.Find(e.PrimaryKeyValue);
            if (editedRow != null)
            {
                editedRow["UserName"] = e.CreatedAdmin.UserName;
                editedRow["Password"] = e.CreatedAdmin.Password;
                editedRow["Active"] = e.CreatedAdmin.Active;
                editedRow["isSuperAdmin"] = e.CreatedAdmin.isSuperAdmin;
            }
            usersDataGridView.Refresh();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<DataRow> rowsToDelete = new List<DataRow>();
                DataRow row = null;
                // loop over the selected rows and add them to the list
                foreach (DataGridViewRow selectedRow in usersDataGridView.SelectedRows)
                {
                    //Convert DataGridViewRow -> DataRow
                    row = ((DataRowView)selectedRow.DataBoundItem).Row;
                    string CatId = Convert.ToInt32(row["Id"]).ToString();
                    Admins adminToDelete = DataModel.Select<Admins>(where: $"Id = '{CatId}' ").FirstOrDefault();
                    DataModel.Delete<Admins>(adminToDelete);
                    rowsToDelete.Add(row);
                }

                foreach (DataRow rowToDelete in rowsToDelete)
                {
                    filterTable.Rows.Remove(rowToDelete);
                }
                usersDataGridView.DataSource = filterTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Utils.Utils.Log(string.Format("Message : {0}", ex.Message), "ErrorDeleteCategory.txt");
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
                        usersDataGridView.DataSource = filterTable;
                        usersDataGridView.RowHeadersVisible = false;
                        totalLabel.Text = $"Total: {usersDataGridView.RowCount}";
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
                        usersDataGridView.DataSource = comboTable;
                        usersDataGridView.RowHeadersVisible = false;
                        totalLabel.Text = $"Total: {usersDataGridView.RowCount}";
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // If the search text is not empty, filter the originalCategoryTable and assign the filtered result to the categoryTable
            if (!string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                var matchingRows = from row in originalAdminTable.AsEnumerable()
                                   where row.ItemArray.Any(x =>
                                         StringComparer.OrdinalIgnoreCase.Equals(x.ToString(), searchTextBox.Text))
                                   select row;

                if (matchingRows.Any())
                {
                    adminTable = matchingRows.CopyToDataTable();
                }
                else
                {
                    adminTable = adminTable.Clone();
                }
            }
            // If the search text is empty, assign the originalCategoryTable to the categoryTable
            else
            {
                adminTable = originalAdminTable.Copy();
            }

            // Bind the categoryTable to the CatDGV DataGridView control
            usersDataGridView.DataSource = adminTable;
        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Search with Enter 
            if (e.KeyChar == (char)13)
            {
                searchButton.PerformClick();
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            searchButton.PerformClick();
        }

    }
}
