using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CallSuperMarketAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetButton_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                var url = new Uri("http://localhost:8083/api/allproducts");

                //var endpoint = new Uri("http://localhost:8083/api/products");
                //var result1 = client.GetAsync(endpoint).Result;
                //var json = result1.Content.ReadAsStringAsync().Result;
                //var result = JsonConvert.DeserializeObject<List<Products>>(json);
                client.BaseAddress = new Uri("http://localhost:52465/api/allproducts");
                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //HTTP GET
                var responseTask = client.GetAsync(url.PathAndQuery);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    var readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();

                    var Products = readTask.Result;
                    var resultDeserialize = JsonConvert.DeserializeObject<List<Products>>(Products);

                    ProdDGV.DataSource = resultDeserialize;
                }
            }
        }

        private void PostButton_Click(object sender, EventArgs e)
        {
            //var product = new Products() { Prodid = Convert.ToInt32(ProdId.Text), ProdName = ProdName.Text, ProdQty = Convert.ToInt32(ProdQty.Text), ProdPrice = Convert.ToInt32(ProdPrice.Text), ProdCat = addCatCombobox.Text };

            //var json = JsonConvert.SerializeObject(product);
            //var data = new StringContent(json, Encoding.UTF8, "application/json");

            //var url = new Uri("http://localhost:52465/api/products");
            //using var client = new HttpClient();

            //var response = client.PostAsync(url, data);
            //response.Wait();
            //var result = response.Result;
            //if (result.IsSuccessStatusCode)
            //{
            //    var readTask = result.Content.ReadAsStringAsync();

            //}
        }

        private void DeleteApiButton_Click(object sender, EventArgs e)
        {
            //var url = new Uri($"http://localhost:52465/api/delete/{ProdId.Text}");
            //using var client = new HttpClient();

            //var response = client.DeleteAsync(url);
            //response.Wait();
            //var result = response.Result;
            //if (result.IsSuccessStatusCode)
            //{
            //    var readTask = result.Content.ReadAsStringAsync();

            //}
        }

        private void putButton_Click(object sender, EventArgs e)
        {
            //var product = new Products() { Prodid = Convert.ToInt32(ProdId.Text), ProdName = ProdName.Text, ProdQty = Convert.ToInt32(ProdQty.Text), ProdPrice = Convert.ToInt32(ProdPrice.Text), ProdCat = addCatCombobox.Text };

            //var json = JsonConvert.SerializeObject(product);
            //var data = new StringContent(json, Encoding.UTF8, "application/json");

            //var url = new Uri($"http://localhost:52465/api/put/{ProdId.Text}");
            //using var client = new HttpClient();

            //var response = client.PutAsync(url, data);
            //response.Wait();
            //var result = response.Result;
            //if (result.IsSuccessStatusCode)
            //{
            //    var readTask = result.Content.ReadAsStringAsync();

            //}
        }



        public class Products
        {
            public int Prodid { get; set; }
            public string ProdName { get; set; }
            public int ProdQty { get; set; }
            public int ProdPrice { get; set; }
            public string ProdCat { get; set; }
        }
    }
}
