
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

namespace SupermarketTuto.Forms.General
{
    public partial class addEditCategory : Form
    {
        SqlConnect loaddata = new SqlConnect();
        public addEditCategory(SqlConnect loaddata_, bool add = true)
        {
            InitializeComponent();
            loaddata = loaddata_;
            if (add)
            {
                editButton.Enabled = false;
            }
            else
            {
                addButton.Visible = false;
                DataRow row = loaddata.table.Rows.Cast<DataRow>().Where(r => r.Field<int>("CatId") == Int32.Parse(CatIdTb.Text)).FirstOrDefault();
                row["CatName"] = CatNameTb.Text;
                row["CatDesc"] = CatDescTb.Text;
                row["Date"] = dateTimePicker.Value.ToString("MM-dd-yyyy");
                //CatIdTb.Text = 
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                loaddata.execCom("Insert Into CategoryTbl values('" + CatNameTb.Text + "','" + CatDescTb.Text + "','" + dateTimePicker.Value.ToString("MM-dd-yyyy") + "')");
                loaddata.table.Columns["CatId"].AutoIncrement = true;
                DataRow row = loaddata.table.NewRow();
                row["CatName"] = CatNameTb.Text;
                row["CatDesc"] = CatDescTb.Text;
                row["Date"] = dateTimePicker.Value.ToString("yyyy-MM-dd");
                loaddata.table.Rows.Add(row);
                if(loaddata.table.Rows.Cast<DataRow>().Any(r => r.RowState == DataRowState.Unchanged))
                {
                    loaddata.table.AcceptChanges();
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
                    loaddata.execCom("Update CategoryTbl set CatName='" + CatNameTb.Text + "',CatDesc='" + CatDescTb.Text + "', Date = '" + dateTimePicker.Value.ToString("MM-dd-yyyy") + "' where CatId=" + CatIdTb.Text);
                    DataRow row = loaddata.table.Rows.Cast<DataRow>().Where(r => r.Field<int>("CatId") == Int32.Parse(CatIdTb.Text)).FirstOrDefault();
                    row["CatName"] = CatNameTb.Text;
                    row["CatDesc"] = CatDescTb.Text;
                    row["Date"] = dateTimePicker.Value.ToString("MM-dd-yyyy");
                    if (loaddata.table.Rows.Cast<DataRow>().Any(r => r.RowState == DataRowState.Unchanged))
                    {
                        loaddata.table.AcceptChanges();
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
