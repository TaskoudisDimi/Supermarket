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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallSuperMarketAPI
{
    public partial class GetFromExternalAPI : Form
    {
        //https://world.openfoodfacts.org/category/cheeses.json
        static readonly HttpClient client = new HttpClient();
        string url = "https://world.openfoodfacts.org/?json=true";
        string url_food = "https://api.nal.usda.gov/fdc/v1/foods/list?api_key=73bN4czbGpmlsow5zNXFUEfhcbkDxg1QWfVqT2m5";
        public GetFromExternalAPI()
        {
            InitializeComponent();
        }

        private async void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(url_food);
                var Products = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    var myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(Products);
                    string path = "";
                    
                    Console.WriteLine($"Data: {myDeserializedClass}");
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



    
    public class FoodNutrient
    {
        public string number { get; set; }
        public string name { get; set; }
        public double amount { get; set; }
        public string unitName { get; set; }
        public string derivationCode { get; set; }
        public string derivationDescription { get; set; }
    }

    public class Root
    {
        public int fdcId { get; set; }
        public string description { get; set; }
        public string dataType { get; set; }
        public string publicationDate { get; set; }
        public List<FoodNutrient> foodNutrients { get; set; }
        public string foodCode { get; set; }
        public string ndbNumber { get; set; }
    }
}
