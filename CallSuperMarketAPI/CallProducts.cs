using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using SupermarketTuto.DataAccess;

namespace CallSuperMarketAPI
{
    public partial class CallProducts : Form
    {
        public CallProducts()
        {
            InitializeComponent();
        }

        private void GetButton_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                var url = new Uri("http://localhost:8084/api/allproducts");

                //var endpoint = new Uri("http://localhost:8080/api/products");
                //var result1 = client.GetAsync(endpoint).Result;
                //var json = result1.Content.ReadAsStringAsync().Result;
                //var result = JsonConvert.DeserializeObject<List<Products>>(json);
                client.BaseAddress = new Uri("http://localhost:8084/api/allproducts");
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
            var product = new Products() { prodid = Convert.ToInt32(ProdId.Text), ProdName = ProdName.Text, ProdQty = Convert.ToInt32(ProdQty.Text), ProdPrice = Convert.ToInt32(ProdPrice.Text), ProdCat = catCombobox.Text, Date = Convert.ToDateTime(DateTimePicker.Value.ToString("yyyy/MM/dd")) };


            var json = JsonConvert.SerializeObject(product);

            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var url = new Uri("http://localhost:8084/api/post/products");
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.PostAsync(url, data);
                response.Wait();
                var result = response.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync();
                }
            };

        }

        private void DeleteApiButton_Click(object sender, EventArgs e)
        {
            var url = new Uri($"http://localhost:8084/api/delete/{ProdId.Text}");
            using (var client = new HttpClient())
            {
                var response = client.DeleteAsync(url);
                response.Wait();
                var result = response.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readtask = result.Content.ReadAsStringAsync();

                }
            };
        }

        private void putButton_Click(object sender, EventArgs e)
        {
            var product = new Products() { prodid = Convert.ToInt32(ProdId.Text), ProdName = ProdName.Text, ProdQty = Convert.ToInt32(ProdQty.Text), ProdPrice = Convert.ToInt32(ProdPrice.Text), ProdCat = catCombobox.Text };

            var json = JsonConvert.SerializeObject(product);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var url = new Uri($"http://localhost:8084/api/put/{ProdId.Text}");
            using (var client = new HttpClient())
            {
                var response = client.PutAsync(url, data);
                response.Wait();
                var result = response.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync();

                }
            };
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

        private void fillCombo()
        {
            SqlConnect loaddata20 = new SqlConnect();
            loaddata20.retrieveData("Select CatName From CategoryTbl");
            catCombobox.DataSource = loaddata20.table;
            catCombobox.ValueMember = "CatName";
            catCombobox.SelectedItem = null;
            catCombobox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            catCombobox.AutoCompleteSource = AutoCompleteSource.ListItems;
        }


        private void CallProducts_Load(object sender, EventArgs e)
        {
            fillCombo();
        }

    }
}
