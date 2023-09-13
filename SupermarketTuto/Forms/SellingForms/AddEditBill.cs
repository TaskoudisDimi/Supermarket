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
        string TotalAmount = "";
        DataTable billTable = new DataTable();
        BindingSource billBindingSource = new BindingSource();
        Type BillType = typeof(BillTbl);
        string SellerName = "";
        List<ProductTbl> productsList = new List<ProductTbl>();
        List<CategoryTbl> categoriesList = new List<CategoryTbl>();
        BillTbl bill = new BillTbl();
        StringBuilder productIDs = new StringBuilder();
        StringBuilder categoryIDs = new StringBuilder();
        bool isFirstItem = true;
        public AddEditBill(string TotalAmount_, string SellerName_, List<ProductTbl> productsList_)
        {
            InitializeComponent();
            TotalAmount = TotalAmount_;
            SellerName = SellerName_;
            totalAmountTextBox.Text = TotalAmount_;
            dateTextBox.Text = DateTime.Now.Date.ToString("dd-MM-yyyy");
            nameTextBox.Text = SellerName_;
            productsList = productsList_;
        }

        private void addProduct_Load(object sender, EventArgs e)
        {
            if(productsList != null)
            {
                foreach (ProductTbl prod in productsList)
                {
                    prodListBox.DisplayMember = "ProdName";
                    prodListBox.Items.Add(prod);
                    if (!isFirstItem)
                    {
                        productIDs.Append(", ");
                    }
                    productIDs.Append(prod.ProdId);

                    CategoryTbl category = DataModel.Select<CategoryTbl>(where: $"CatId = {prod.ProdCatID}").FirstOrDefault();
                    if(category != null)
                    {
                        categoriesList.Add(category);
                    }
                   
                    if (category != null && !isFirstItem)
                        categoryIDs.Append(category.CatId);
                    else if (category != null)
                        categoryIDs.Append(category.CatId);

                    isFirstItem = false;
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
