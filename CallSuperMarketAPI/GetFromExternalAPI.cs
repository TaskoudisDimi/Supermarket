using Newtonsoft.Json;
using SupermarketTuto.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public GetFromExternalAPI()
        {
            InitializeComponent();
        }

        private async void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                var Products = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    var ListProducts = JsonConvert.DeserializeObject<List<Products>>(Products);
                    Console.WriteLine($"Data: {ListProducts}");
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



    public class Products
    {
        public int prodid { get; set; }
        public string ProdName { get; set; }
        public int ProdQty { get; set; }
        public int ProdPrice { get; set; }
        public string ProdCat { get; set; }
        public DateTime Date { get; set; }
    }
}
