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
        //https://world.openfoodfacts.org/category/cheeses.json
        static readonly HttpClient client = new HttpClient();
        string url_food = "https://api.edamam.com/api/food-database/v2/parser?app_id=713fa9ba&app_key=045b112511bb6b714c5c10328c5f5aba&nutrition-type=cooking&health=alcohol-free&category=generic-foods";
        public GetFromExternalAPI()
        {
            InitializeComponent();
        }

        private async void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(url_food);
                var ProductsResponse = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    List<Products> products = new List<Products>();
                    List<Categories> categories = new List<Categories>();
                    Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(ProductsResponse);
                    if(myDeserializedClass.hints.Count > 0)
                    {
                        foreach(var pair in myDeserializedClass.hints)
                        {
                            //Category CatName
                            //KnownAs CatDesc, ProdName
                        }
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Request exception: {ex.Message}");

            }
            
        }

        private void categoryButton_Click(object sender, EventArgs e)
        {
            
        }

    }




    
    public class Food
    {
        public string foodId { get; set; }
        public string label { get; set; }
        public string knownAs { get; set; }
        public Nutrients nutrients { get; set; }
        public string category { get; set; }
        public string categoryLabel { get; set; }
        public string image { get; set; }
    }

    public class Hint
    {
        public Food food { get; set; }
        public List<Measure> measures { get; set; }
    }

    public class Links
    {
        public Next next { get; set; }
    }

    public class Measure
    {
        public string uri { get; set; }
        public string label { get; set; }
        public double weight { get; set; }
        public List<Qualified> qualified { get; set; }
    }

    public class Next
    {
        public string title { get; set; }
        public string href { get; set; }
    }

    public class Nutrients
    {
        public double ENERC_KCAL { get; set; }
        public double PROCNT { get; set; }
        public double FAT { get; set; }
        public double CHOCDF { get; set; }
        public double FIBTG { get; set; }
    }

    public class Qualified
    {
        public List<Qualifier> qualifiers { get; set; }
        public double weight { get; set; }
    }

    public class Qualifier
    {
        public string uri { get; set; }
        public string label { get; set; }
    }

    public class Root
    {
        public string text { get; set; }
        public List<object> parsed { get; set; }
        public List<Hint> hints { get; set; }
        public Links _links { get; set; }
    }



}
