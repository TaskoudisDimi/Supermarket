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
        DataGridViewRow selected = new DataGridViewRow();
        public addEditProduct(DataTable productTable_, DataGridViewRow selected_, bool add)
        {
            InitializeComponent();
            ComboCat();
            productTable = productTable_;
            selected = selected_;

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
                categoryID.Text = selected.Cells["ProdCatID"].Value.ToString();
                catCombobox.Text = selected.Cells["ProdCat"].Value.ToString();
                addButton.Visible = false;
            }
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            SqlConnect loaddata5 = new SqlConnect();

            try
            {
                loaddata5.execCom("Insert Into ProductTbl values('" + ProdName.Text + "'," + ProdQty.Text + "," + ProdPrice.Text + "," + catIDTextBox.Text +  ",'" + catCombobox.SelectedValue.ToString() + "', '" + DateTimePicker.Value.ToString("MM-dd-yyyy") + "')");
                MessageBox.Show(Constants.MessageInsertData);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            SqlConnect loaddata6 = new SqlConnect();

            try
            {
                loaddata6.execCom("Update ProductTbl set ProdName = '" + ProdName.Text + "', ProdCat = '" + catCombobox.Text + "', ProdQty = '" + ProdQty.Text + "', ProdPrice = '" + ProdPrice.Text + "', ProdCatID = " + catIDTextBox.Text + ", Date = '" + DateTimePicker.Value.ToString("yyyy-MM-dd") + "' where ProdId = " + ProdId.Text);
                MessageBox.Show("Product Successfully Updated");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ComboCat()
        {
            catIDTextBox.Enabled = false;
            catIDTextBox.Text = String.Empty;
            SqlConnect loaddata7 = new SqlConnect();
            loaddata7.getData("Select CatId, CatName From CategoryTbl");
            catCombobox.DataSource = loaddata7.table;
            catCombobox.ValueMember = "CatName";
            catCombobox.SelectedItem = null;
            catCombobox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            catCombobox.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void catCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnect loaddata8 = new SqlConnect();
                loaddata8.getData("Select CatId From CategoryTbl where CatName = '" + catCombobox.Text + "'");
                if (loaddata8.table.Rows.Count != 0)
                {
                    catIDTextBox.Text = loaddata8.table.Rows[0]["CatId"].ToString();
                }
            }
            catch
            {

            }
        }

       
    }
}
