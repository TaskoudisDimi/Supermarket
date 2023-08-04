using DataClass;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data;
using System.Linq;
using DataTable = System.Data.DataTable;
using ClassLibrary1;
using ClassLibrary1.Models;

namespace SupermarketTuto.Forms.General
{
    public partial class addEditCategory : Form
    {
        DataTable categoryTable = new DataTable();
        DataGridViewRow selected = new DataGridViewRow();
        public event EventHandler<DataGridViewCellChange> DataChanged;
        CategoryTbl category = new CategoryTbl();
        public event EventHandler<CategoryEventArgs> ItemCreated;
        public event EventHandler<CategoryEventArgs> ItemEdited;

        public addEditCategory(DataTable categoryTable_, DataGridViewRow selected_, bool add)
        {
            InitializeComponent();

            categoryTable = categoryTable_;
            selected = selected_;

            if (add)
            {
                editButton.Enabled = false;
            }
            else
            {
                CatIdTb.Text = selected.Cells["CatId"].Value.ToString();
                CatNameTb.Text = selected.Cells["CatName"].Value.ToString();
                CatDescTb.Text = selected.Cells["CatDesc"].Value.ToString();
                dateTimePicker.Value = (DateTime)selected.Cells["Date"].Value;
                addButton.Visible = false;               
            }
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                category.CatDesc = CatNameTb.Text;
                category.CatName = CatNameTb.Text;
                category.Date = (DateTime)dateTimePicker.Value.Date;
                var CreateCategory = DataModel.Create<CategoryTbl>(category);
                OnItemCreated(new CategoryEventArgs(category, category.CatId));

                MessageBox.Show($"Successfully inserted Category {category.CatName}","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected virtual void OnItemCreated(CategoryEventArgs e)
        {
            ItemCreated?.Invoke(this, e);

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatIdTb.Text == "" || CatNameTb.Text == "" || CatDescTb.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    category.CatId = Convert.ToInt32(CatIdTb.Text);
                    category.CatDesc = CatNameTb.Text;
                    category.CatName = CatNameTb.Text;
                    category.Date = (DateTime)dateTimePicker.Value.Date;
                    var CreateCategory = DataModel.Update<CategoryTbl>(category);
                    OnItemEdited(new CategoryEventArgs(category, category.CatId));

                    //GetChanges(table, row);

                    MessageBox.Show($"Successfully inserted Category {category.CatName}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected virtual void OnItemEdited(CategoryEventArgs e)
        {
            ItemEdited?.Invoke(this, e);

        }


        int columnIndex;
        int rowIndex;
        private void GetChanges(DataTable table, DataRow row)
        {
            if (table != null)
            {
                foreach (DataRow changedRow in table.Rows)
                {
                    if (changedRow.RowState == DataRowState.Modified)
                    {
                        foreach (DataColumn column in changedRow.Table.Columns)
                        {
                            if (!Equals(changedRow[column, DataRowVersion.Original], changedRow[column, DataRowVersion.Current]))
                            {
                                columnIndex = table.Columns.IndexOf(column.ColumnName);
                                break;
                            }
                        }
                    }
                }
            }
            if (selected != null)
            {
                rowIndex = selected.Index;
            }
            object cellValue = table.Rows[0].ItemArray[columnIndex];

            var change = new DataGridViewCellChange()
            {
                RowIndex = rowIndex,
                ColumnIndex = columnIndex,
                NewValue = cellValue.ToString()
            };

            // Raise the DataChanged event in order to send to the Client through TCP/UDP
            DataChanged?.Invoke(this, change);
        }
    }

    public class CategoryEventArgs : EventArgs
    {
        public CategoryTbl CreatedCategory { get; private set; }
        public int PrimaryKeyValue { get; private set; }

        public CategoryEventArgs(CategoryTbl category, int primaryKeyValue)
        {
            CreatedCategory = category;
            PrimaryKeyValue = primaryKeyValue;
        }
    }

}
