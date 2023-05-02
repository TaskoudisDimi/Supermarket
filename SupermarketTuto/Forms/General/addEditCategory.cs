
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

namespace SupermarketTuto.Forms.General
{
    public partial class addEditCategory : Form
    {
        DataTable categoryTable = new DataTable();
        DataGridViewRow selected = new DataGridViewRow();
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
                categoryTable.Columns["CatId"].AutoIncrement = true;
                DataRow row = categoryTable.NewRow();
                row["CatName"] = CatNameTb.Text;
                row["CatDesc"] = CatDescTb.Text;
                row["Date"] = dateTimePicker.Value.ToString("yyyy-MM-dd");
                categoryTable.Rows.Add(row);
                if(categoryTable.Rows.Cast<DataRow>().Any(r => r.RowState == DataRowState.Unchanged))
                {
                    //categoryTable.AcceptChanges();
                    DataAccess.Instance.InsertData(categoryTable);
                }
                MessageBox.Show($"Successfully inserted Category {row["CatName"]}","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                    DateTime Date = dateTimePicker.Value.Date;
                    DataRow row = categoryTable.Rows.Cast<DataRow>().Where(r => r.Field<int>("CatId") == Int32.Parse(CatIdTb.Text)).FirstOrDefault();
                    row["CatName"] = CatNameTb.Text;
                    row["CatDesc"] = CatDescTb.Text;
                    row["Date"] = Date;
                    if (categoryTable.Rows.Cast<DataRow>().Any(r => r.RowState == DataRowState.Unchanged))
                    {
                        //categoryTable.AcceptChanges();
                        DataAccess.Instance.UpdateData(categoryTable);
                    }
                    MessageBox.Show($"Category {row["CatName"]} Successfully Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
