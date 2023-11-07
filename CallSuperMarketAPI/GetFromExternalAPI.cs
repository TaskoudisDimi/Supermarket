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
        //TODO: Set ProdQty when find the same product from API data

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
                HttpResponseMessage response = await client.GetAsync(url_food);
                var ProductsResponse = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    Data myDeserializedClass = JsonConvert.DeserializeObject<Data>(ProductsResponse);
                    if (myDeserializedClass.hints.Count > 0)
                    {
                        foreach (var pair in myDeserializedClass.hints)
                        {
                            string[] parts = pair.food.knownAs.Split(',');
                            if (productsCheckBox.Checked && categoriesCheckBox.Checked)
                            {
                                ProductTbl existingProducts = DataModel.Select<ProductTbl>(where: $"ProdName = '{parts[1]}'").FirstOrDefault();
                                if (existingProducts == null)
                                {
                                    string productName = parts[1].Trim();
                                    bool existInTheList = products.Any(prod => prod.ProdName == productName);
                                    if (!existInTheList)
                                    {
                                        ProductTbl product = new ProductTbl
                                        {
                                            ProdName = productName,
                                            ProdCat = parts[0].Trim(),
                                            Date = DateTime.Now
                                        };
                                        products.Add(product);
                                    }
                                }
                                else
                                {
                                    string productName = existingProducts.ProdName;
                                    bool existInTheList = products.Any(prod => prod.ProdName == productName);
                                    if (!existInTheList)
                                        products.Add(existingProducts);
                                }

                                CategoryTbl existingCategories = DataModel.Select<CategoryTbl>(where: $"CatName = '{parts[0]}'").FirstOrDefault();
                                if (existingCategories == null)
                                {
                                    string categoryName = parts[0].Trim();
                                    bool existInTheList = categories.Any(cat => cat.CatName == categoryName);
                                    if (!existInTheList)
                                    {
                                        // The category doesn't exist, so you can create a new one and add it to the list
                                        CategoryTbl category = new CategoryTbl
                                        {
                                            CatName = categoryName,
                                            CatDesc = pair.food.category,
                                            Date = DateTime.Now
                                        };
                                        categories.Add(category);
                                    }
                                }
                                else
                                {
                                    string categoryName = existingCategories.CatName;
                                    bool existInTheList = categories.Any(cat => cat.CatName == categoryName);
                                    if (!existInTheList)
                                        categories.Add(existingCategories);
                                }
                            }
                            else if (productsCheckBox.Checked && !categoriesCheckBox.Checked)
                            {
                                ProductTbl existingProducts = DataModel.Select<ProductTbl>(where: $"ProdName = '{parts[1]}'").FirstOrDefault();
                                if (existingProducts != null)
                                {
                                    string productName = parts[1].Trim();
                                    bool existInTheList = products.Any(prod => prod.ProdName == productName);
                                    if (!existInTheList)
                                    {
                                        ProductTbl product = new ProductTbl
                                        {
                                            ProdName = productName,
                                            ProdCat = parts[0].Trim(),
                                            Date = DateTime.Now
                                        };
                                        products.Add(product);
                                    }
                                }
                                else
                                {
                                    products.Add(existingProducts);
                                }
                            }
                            else if (!productsCheckBox.Checked && categoriesCheckBox.Checked)
                            {
                                CategoryTbl existingCategories = DataModel.Select<CategoryTbl>(where: $"CatName = '{parts[0]}'").FirstOrDefault();
                                if (existingCategories != null)
                                {
                                    string categoryName = parts[0].Trim();
                                    bool existInTheList = categories.Any(cat => cat.CatName == categoryName);
                                    if (!existInTheList)
                                    {
                                        // The category doesn't exist, so you can create a new one and add it to the list
                                        CategoryTbl category = new CategoryTbl
                                        {
                                            CatName = categoryName,
                                            CatDesc = pair.food.category,
                                            Date = DateTime.Now
                                        };
                                        categories.Add(category);
                                    }
                                }
                                else
                                {
                                    categories.Add(existingCategories);
                                }
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

        //TODO: Add BackgroundWorkder
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (products.Count > 0 && categories.Count > 0)
            {
                foreach (CategoryTbl item in categories)
                {
                    CategoryTbl cat = DataModel.Select<CategoryTbl>(where: $"CatName = '{item.CatName}'").FirstOrDefault();
                    if (cat == null)
                        DataModel.Create<CategoryTbl>(item);
                }
                foreach (ProductTbl item in products)
                {
                    ProductTbl prod = DataModel.Select<ProductTbl>(where: $"ProdName = '{item.ProdName}'").FirstOrDefault();
                    if (prod == null)
                    {
                        CategoryTbl catId = DataModel.Select<CategoryTbl>(where: $"CatName = '{item.ProdCat}'").FirstOrDefault();
                        if (catId != null)
                        {
                            item.ProdCatID = catId.CatId;
                            DataModel.Create<ProductTbl>(item);
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
            else if (products.Count > 0 && !(categories.Count > 0))
            {
                foreach (ProductTbl item in products)
                {
                    CategoryTbl catId = DataModel.Select<CategoryTbl>(where: $"CatName = '{item.ProdCat}'").FirstOrDefault();
                    if (catId != null)
                    {
                        item.ProdCatID = catId.CatId;
                        DataModel.Create<ProductTbl>(item);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else if (categories.Count > 0 && !(products.Count > 0))
            {
                foreach (CategoryTbl item in categories)
                {
                    CategoryTbl cat = DataModel.Select<CategoryTbl>(where: $"CatName = '{item.CatName}'").FirstOrDefault();
                    if (cat == null)
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
