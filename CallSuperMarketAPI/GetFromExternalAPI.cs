using ClassLibrary1;
using ClassLibrary1.Models;
using Newtonsoft.Json;
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


        public GetFromExternalAPI()
        {
            InitializeComponent();
        }

        private async void getButton_Click(object sender, EventArgs e)
        {
            try
            {
                statusLabel.Text = "Start getting the data";
                ProductTbl product = new ProductTbl();
                CategoryTbl category = new CategoryTbl();
                HttpResponseMessage response = await client.GetAsync(url_food);
                var ProductsResponse = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(ProductsResponse);   
                    if (myDeserializedClass.hints.Count > 0)
                    {
                        foreach (var pair in myDeserializedClass.hints)
                        {
                            string[] parts = pair.food.knownAs.Split(',');
                            if (productsCheckBox.Checked && categoriesCheckBox.Checked)
                            {
                                product.ProdName = parts[1];
                                product.ProdCat = parts[0];
                                product.Date = DateTime.Now;
                                category.CatName = parts[0];
                                category.CatDesc = pair.food.category;
                                category.Date = DateTime.Now;
                                categories.Add(category);
                                products.Add(product);
                            }
                            else if(productsCheckBox.Checked && !categoriesCheckBox.Checked)
                            {
                                product.ProdName = parts[1];
                                product.ProdCat = parts[0];
                                product.Date = DateTime.Now;
                                products.Add(product);
                            }
                            else if(!productsCheckBox.Checked && categoriesCheckBox.Checked)
                            {
                                category.CatName = parts[0];
                                category.CatDesc = pair.food.category;
                                category.Date = DateTime.Now;
                                categories.Add(category);
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    productsLabel.Text = $"Total Products: {products.Count}";
                    categoriesLabel.Text = $"Total Categories: {categories.Count}";
                    statusLabel.Text = $"End of getting, Total Result: {myDeserializedClass.hints.Count}";
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Request exception: {ex.Message}");

            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(products.Count > 0 && categories.Count > 0)
            {
                foreach(ProductTbl item in products)
                {
                    DataModel.Create<ProductTbl>(item);
                }
                foreach (CategoryTbl item in categories)
                {
                    DataModel.Create<CategoryTbl>(item);
                }
            }
            else if(products.Count > 0 && !(categories.Count > 0))
            {
                foreach (ProductTbl item in products)
                {
                    DataModel.Create<ProductTbl>(item);
                }
            }
            else if (categories.Count > 0 && !(products.Count > 0))
            {
                foreach (CategoryTbl item in categories)
                {
                    DataModel.Create<CategoryTbl>(item);
                }
            }
            else
            {
                MessageBox.Show("There are no data to sate", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

      
    }


}
