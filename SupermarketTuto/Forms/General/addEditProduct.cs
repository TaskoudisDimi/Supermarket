using ClassLibrary1;
using DataClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketTuto.Forms.General
{
    public partial class addEditProduct : Form
    {
        DataTable productTable = new DataTable();
        DataTable categoryTable = new DataTable();
        DataGridViewRow selected = new DataGridViewRow();
        public addEditProduct(DataTable productTable_, DataGridViewRow selected_, DataTable categoryTable_ ,bool add)
        {
            InitializeComponent();
            
            productTable = productTable_;
            selected = selected_;
            categoryTable = categoryTable_ ;

            ComboCat();

            if (add)
            {
                editButton.Enabled = false;
            }
            else
            {
                ProdId.Text = selected.Cells["ProdId"].Value.ToString();
                ProdName.Text = selected.Cells["ProdName"].Value.ToString();
                ProdQty.Text = selected.Cells["ProdQty"].Value.ToString();
                ProdPrice.Text = selected.Cells["ProdPrice"].Value.ToString();
                DateTimePicker.Value = (DateTime)selected.Cells["Date"].Value;
                catIDTextBox.Text = selected.Cells["ProdCatID"].Value.ToString();
                catCombobox.Text = selected.Cells["ProdCat"].Value.ToString();
                addButton.Visible = false;
            }
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                productTable.Columns["ProdId"].AutoIncrement = true;
                DataRow row = productTable.NewRow();
                row["ProdName"] = ProdName.Text;
                row["ProdQty"] = ProdQty.Text;
                row["ProdPrice"] = ProdPrice.Text;
                row["ProdCatID"] = catIDTextBox.Text;
                row["ProdCat"] = catCombobox.Text;
                row["Date"] = DateTimePicker.Value.ToString("yyyy-MM-dd");
                productTable.Rows.Add(row);
                if(productTable.Rows.Cast<DataRow>().Any(r => r.RowState == DataRowState.Added))
                {
                    //DataAccess.Instance.InsertData(productTable);
                }
                MessageBox.Show($"Successfully inserted Category {row["ProdName"]}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (ProdName.Text == "" || ProdQty.Text == "" || ProdPrice.Text == "" || catCombobox.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    DateTime Date = DateTimePicker.Value.Date;
                    DataRow row = productTable.Rows.Cast<DataRow>().Where(r => r.Field<int>("ProdId") == Int32.Parse(ProdId.Text)).FirstOrDefault();
                    row["ProdName"] = ProdName.Text;
                    row["ProdQty"] = ProdQty.Text;
                    row["ProdPrice"] = ProdPrice.Text;
                    row["Date"] = Date;
                    row["ProdCatID"] = catIDTextBox.Text;
                    row["ProdCat"] = catCombobox.Text;
                    if (productTable.Rows.Cast<DataRow>().Any(r => r.RowState == DataRowState.Modified))
                    {
                        //DataAccess.Instance.UpdateData(productTable);
                    }
                    MessageBox.Show($"Category {row["ProdName"]} Successfully Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ComboCat()
        {
            List<string> catNames = new List<string>();
            foreach (DataRow row in categoryTable.Rows)
            {
                catNames.Add(row["CatName"].ToString());
            }
            catCombobox.DataSource = catNames;
            catCombobox.SelectedItem = null;
            catCombobox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            catCombobox.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void catCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    SqlConnect loaddata8 = new SqlConnect();
            //    loaddata8.getData("Select CatId From CategoryTbl where CatName = '" + catCombobox.Text + "'");
            //    if (loaddata8.table.Rows.Count != 0)
            //    {
            //        catIDTextBox.Text = loaddata8.table.Rows[0]["CatId"].ToString();
            //    }
            //}
            //catch
            //{

            //}
        }

       
    }
}
