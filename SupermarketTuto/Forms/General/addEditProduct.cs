using ClassLibrary1;
using ClassLibrary1.Models;
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
        public event EventHandler<ProductEventArgs> ItemCreated;
        public event EventHandler<ProductEventArgs> ItemEdited;
        ProductTbl product = new ProductTbl();

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
                product.ProdName = ProdName.Text;
                product.ProdQty = Convert.ToInt32(ProdQty.Text);
                product.ProdPrice = Convert.ToInt32(ProdPrice.Text);
                product.ProdCatID = Convert.ToInt32(catIDTextBox.Text);
                product.ProdCat = catCombobox.Text;
                product.Date = DateTimePicker.Value;
                DataModel.Create<ProductTbl>(product);
                OnItemCreated(new ProductEventArgs(product, product.ProdId));
                MessageBox.Show($"Successfully inserted Category {product.ProdName}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected virtual void OnItemCreated(ProductEventArgs e)
        {
            ItemCreated?.Invoke(this, e);
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
                    product.ProdId = Convert.ToInt32(ProdId.Text);
                    product.ProdName = ProdName.Text;
                    product.ProdCat = catCombobox.Text;
                    product.ProdQty = Convert.ToInt32(ProdQty.Text);
                    product.ProdCatID = Convert.ToInt32(catIDTextBox.Text);
                    product.ProdPrice = Convert.ToInt32(ProdPrice.Text);
                    product.Date = (DateTime)DateTimePicker.Value.Date;
                    DataModel.Update<ProductTbl>(product);
                    OnItemEdited(new ProductEventArgs(product, product.ProdId));
                    MessageBox.Show($"Successfully inserted Category {product.ProdName}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            catIDTextBox.Text = null;
            catCombobox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            catCombobox.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void catCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CategoryTbl Cat = DataModel.Select<CategoryTbl>(where: $"CatName = '{catCombobox.Text}'").FirstOrDefault();
                if (Cat != null)
                {
                    catIDTextBox.Text = Cat.CatId.ToString();
                }
            }
            catch
            {

            }
        }

        protected virtual void OnItemEdited(ProductEventArgs e)
        {
            ItemEdited?.Invoke(this, e);

        }


    }
    public class ProductEventArgs : EventArgs
    {
        public ProductTbl CreatedProduct { get; private set; }
        public int PrimaryKeyValue { get; private set; }

        public ProductEventArgs(ProductTbl product, int primaryKeyValue)
        {
            CreatedProduct = product;
            PrimaryKeyValue = primaryKeyValue;
        }
    }
}
