using ClassLibrary1;
using ClassLibrary1.Models;
using Newtonsoft.Json;
using SupermarketTuto.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallSuperMarketAPI
{
    public partial class GetFromExternalAPI : Form
    {
        //TODO: Check if existing products and categories thought ID
        //https://world.openfoodfacts.org/category/cheeses.json
        static readonly HttpClient client = new HttpClient();
        string url_food = "https://api.edamam.com/api/food-database/v2/parser?app_id=713fa9ba&app_key=045b112511bb6b714c5c10328c5f5aba&nutrition-type=cooking&health=alcohol-free&category=generic-foods";
        List<ProductTbl> products = new List<ProductTbl>();
        List<CategoryTbl> categories = new List<CategoryTbl>();
        DataTable productsTable = new DataTable();
        DataTable categoriesTable = new DataTable();


        public GetFromExternalAPI()
        {
            InitializeComponent();
        }

        private async void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                statusLabel.Text = "Start getting the data";
                HttpResponseMessage response = await client.GetAsync(url_food);
                var ProductsResponse = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(ProductsResponse);
                    if (myDeserializedClass.hints.Count > 0)
                    {
                        foreach (var pair in myDeserializedClass.hints)
                        {
                            ProductTbl product = new ProductTbl();
                            CategoryTbl category = new CategoryTbl();
                            string[] parts = pair.food.knownAs.Split(',');
                            product.ProdName = parts[1];
                            product.ProdCat = parts[0];
                            product.Date = DateTime.Now;
                            category.CatName = parts[0];
                            category.CatDesc = pair.food.category;
                            category.Date = DateTime.Now;
                            categories.Add(category);
                            products.Add(product);
                        }
                    }
                    statusLabel.Text = $"End of getting, Result: {myDeserializedClass.hints.Count}";
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Request exception: {ex.Message}");

            }

        }



        private void InsertProducts()
        {
            productsTable.Columns.Add("ProdId");
            productsTable.Columns.Add("ProdName");
            productsTable.Columns.Add("ProdQty");
            productsTable.Columns.Add("ProdPrice");
            productsTable.Columns.Add("ProdCatID");
            productsTable.Columns.Add("ProdCat");
            productsTable.Columns.Add("Date");


            foreach (var prod in products)
            {
                DataRow row = productsTable.NewRow();
                row["ProdName"] = prod.ProdName;
                row["ProdCat"] = prod.ProdCat;
                row["Date"] = prod.Date;
                productsTable.Rows.Add(row);
            }
            DataAccess.Instance.GetTable("ProductTbl");
            DataAccess.Instance.InsertData(productsTable);
        }

        private void categoryButton_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            InsertProducts();
            InsertCategories();
        }

        private void InsertCategories()
        {
            categoriesTable.Columns.Add("CatId");
            categoriesTable.Columns.Add("CatName");
            categoriesTable.Columns.Add("CatDesc");
            categoriesTable.Columns.Add("Date");


            foreach (var cat in categories)
            {
                DataRow row = categoriesTable.NewRow();
                row["CatName"] = cat.CatName;
                row["CatDesc"] = cat.CatDesc;
                row["Date"] = cat.Date;
                categoriesTable.Rows.Add(row);
            }
            DataAccess.Instance.GetTable("CategoryTbl");
            DataAccess.Instance.InsertData(categoriesTable);
        }
    }







}
