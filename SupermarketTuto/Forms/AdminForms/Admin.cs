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

namespace SupermarketTuto.Forms
{
    public partial class Admin : Form
    {
        DataTable adminTable = new DataTable();
        DataTable filterTable = new DataTable();
        Admins admins = new Admins();
        public Admin(Admins admins_ = null)
        {
            InitializeComponent();
            admins = admins_;
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
                
                DataRow[] filterRow = adminTable.Select("Active = 1");
                foreach (DataRow row in filterRow)
                {
                    filterTable.ImportRow(row);
                }

                usersDataGridView.DataSource = filterTable;
                usersDataGridView.RowHeadersVisible = false;

                //if(admins != null)
                //{
                //    if (admins.isSuperAdmin)
                //    {
                //        addButton.Enabled = true;
                //        editButton.Enabled = true;
                //        deleteButton.Enabled = true;
                //    }
                //}
            }
            catch
            {

            } 
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
            adminTable.Rows.Add(e.CreatedAdmin.UserName,e.CreatedAdmin.Password ,e.CreatedAdmin.Active, e.CreatedAdmin.isSuperAdmin);
            usersDataGridView.Refresh();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            //DataGridViewRow currentRow = CatDGV.CurrentRow;
            //addEditCategory edit = new addEditCategory(categoryTable, currentRow, false);
            //edit.CatIdTb.ReadOnly = true;
            //edit.ItemEdited += Edit_ItemEdited;

            ////edit.DataChanged += Edit_DataChanged;

            //edit.Show();
        }

        //private void Edit_ItemEdited(object sender, AdminsEventArgs e)
        //{
        //    // Update the edited category in the DataTable in form

        //    DataRow editedRow = categoryTable.Rows.Find(e.PrimaryKeyValue);
        //    if (editedRow != null)
        //    {
        //        editedRow["CatName"] = e.CreatedCategory.CatName;
        //        editedRow["CatDesc"] = e.CreatedCategory.CatDesc;
        //        editedRow["Date"] = e.CreatedCategory.Date;
        //    }
        //    CatDGV.Refresh();
        //}


        private void deleteButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    List<DataRow> rowsToDelete = new List<DataRow>();
            //    DataRow row = null;
            //    // loop over the selected rows and add them to the list
            //    foreach (DataGridViewRow selectedRow in CatDGV.SelectedRows)
            //    {
            //        //Convert DataGridViewRow -> DataRow
            //        row = ((DataRowView)selectedRow.DataBoundItem).Row;
            //        string CatId = Convert.ToInt32(row["CatId"]).ToString();
            //        CategoryTbl category = DataModel.Select<CategoryTbl>(where: $"CatId = '{CatId}' ").FirstOrDefault();
            //        DataModel.Delete<CategoryTbl>(category);
            //        rowsToDelete.Add(row);
            //    }

            //    foreach (DataRow rowToDelete in rowsToDelete)
            //    {
            //        categoryTable.Rows.Remove(rowToDelete);
            //    }
            //    CatDGV.DataSource = categoryTable;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    Utils.Utils.Log(string.Format("Message : {0}", ex.Message), "ErrorDeleteCategory.txt");
            //}
        }


        private void activeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
