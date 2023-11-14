using ClassLibrary1;
using ClassLibrary1.Models;
using DataClass;
using SupermarketTuto.Forms.SellingForms;
using SupermarketTuto.Utils;
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
    public partial class AddEditBill : Form
    {

        Type BillType = typeof(BillTbl);
        string SellerName = "";
        List<ProductTbl> productsList = new List<ProductTbl>();
        List<CategoryTbl> categoriesList = new List<CategoryTbl>();
        BillTbl bill = new BillTbl();
        StringBuilder productIDs = new StringBuilder();
        StringBuilder categoryIDs = new StringBuilder();
        bool isFirstItemProd = true;
        bool isFirstItemCat = true;
        DataTable billTable = new DataTable();
        DataGridViewRow selected = new DataGridViewRow();

        public AddEditBill(DataTable billTable_, DataGridViewRow selected_, bool add, string TotalAmount_, string SellerName_, List<ProductTbl> productsList_)
        {
            InitializeComponent();
            this.Icon = new System.Drawing.Icon("C:/Users/chris/Desktop/Dimitris/Tutorials/Supermarket/SupermarketTuto/Resources/supermarket.ico");
            billTable = billTable_;
            selected = selected_;
            productsList = productsList_;

            if (add)
            {
                totalAmountTextBox.Text = TotalAmount_;
                dateTextBox.Text = DateTime.Now.Date.ToString("dd-MM-yyyy");
                nameTextBox.Text = SellerName_;
            }
            else
            {
                totalAmountTextBox.Text = selected.Cells["TotAmt"].Value.ToString();
                dateTextBox.Text = selected.Cells["Date"].Value.ToString();
                nameTextBox.Text = selected.Cells["SellerName"].Value.ToString();
                commentsTextBox.Text = selected.Cells["Comments"].Value.ToString();
                catListBox.Items.Add(selected.Cells["CategoryIDs"].Value.ToString());
                prodListBox.Items.Add(selected.Cells["ProductIDs"].Value.ToString());
            }
        }

        private void addProduct_Load(object sender, EventArgs e)
        {
            if(productsList != null)
            {
                foreach (ProductTbl prod in productsList)
                {
                    prodListBox.DisplayMember = "ProdName";
                    prodListBox.Items.Add(prod);
                    if (!isFirstItemProd)
                    {
                        productIDs.Append(", ");
                    }
                    productIDs.Append(prod.ProdId);

                    CategoryTbl category = DataModel.Select<CategoryTbl>(where: $"CatId = {prod.ProdCatID}").FirstOrDefault();
                    if(category != null)
                    {
                        categoriesList.Add(category);
                    }
                   
                    if (category != null && !isFirstItemCat)
                    {
                        categoryIDs.Append(", ");
                        categoryIDs.Append(category.CatId);
                    }     
                    else if (category != null)
                    {
                        categoryIDs.Append(category.CatId);
                    }
                    isFirstItemProd = false;
                    isFirstItemCat = false;
                }

                if (categoriesList != null)
                {
                    foreach (CategoryTbl cat in categoriesList)
                    {
                        catListBox.DisplayMember = "CatName";
                        catListBox.Items.Add(cat);
                    }
                }
            }
            
        }


        private void billButton_Click(object sender, EventArgs e)
        {
            //TODO: Create Android app and verification Bill with signature by User/Seller
            try
            {
                if(commentsTextBox.Text == "" || nameTextBox.Text == "" || totalAmountTextBox.Text == "" || dateTextBox.Text == "")
                {
                    MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    bill.Comments = commentsTextBox.Text;
                    bill.SellerName = nameTextBox.Text;
                    bill.TotAmt = Convert.ToInt32(totalAmountTextBox.Text);
                    bill.Date = Convert.ToDateTime(dateTextBox.Text);
                    bill.ProductIDs = productIDs.ToString();
                    bill.CategoryIDs = categoryIDs.ToString();
                    DataModel.Create<BillTbl>(bill);
                    MessageBox.Show($"Successfully inserted Bill", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        #region ChechDatabase
      

        #endregion
    }
}
