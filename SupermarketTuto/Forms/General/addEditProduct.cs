using SupermarketTuto.DataAccess;
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
        public addEditProduct()
        {
            InitializeComponent();
        }

        private void addEditProduct_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch
            {

            }

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            SqlConnect loaddata5 = new SqlConnect();

            try
            {
                if (ProdId.Text == "" || ProdName.Text == "" || ProdQty.Text == "" || ProdPrice.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    loaddata5.commandExc("Insert Into ProductTbl values(" + ProdId.Text + ",'" + ProdName.Text + "'," + ProdQty.Text + "," + ProdPrice.Text + ",'" + catCombobox.SelectedValue.ToString() + "', '" + DateTimePicker.Value.ToString("MM-dd-yyyy") + "')");
                    MessageBox.Show("Product Successfully Insert");
                    this.Close();
                }

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

                loaddata6.commandExc("Update ProductTbl set ProdName = '" + ProdName.Text + "', ProdCat = '" + catCombobox.Text + "', ProdQty = '" + ProdQty.Text + "', ProdPrice = '" + ProdPrice.Text + "', Date = '" + DateTimePicker.Value.ToString("yyyy-MM-dd") + "' where ProdId = " + ProdId.Text);
                MessageBox.Show("Product Successfully Updated");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
