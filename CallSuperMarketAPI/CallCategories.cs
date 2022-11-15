using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CallSuperMarketAPI.CallProducts;

namespace CallSuperMarketAPI
{
    public partial class CallCategories : Form
    {
        public CallCategories()
        {
            InitializeComponent();
        }

        private void GetButton_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                var url = new Uri("http://localhost:8084/api/allcategories");

                //var endpoint = new Uri("http://localhost:8080/api/categories");
                //var result1 = client.GetAsync(endpoint).Result;
                //var json = result1.Content.ReadAsStringAsync().Result;
                //var result = JsonConvert.DeserializeObject<List<Products>>(json);
                client.BaseAddress = new Uri("http://localhost:8084/api/allcategories");
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

                    var Categories = readTask.Result;
                    var resultDeserialize = JsonConvert.DeserializeObject<List<Categories>>(Categories);

                    CatDGV.DataSource = resultDeserialize;
                }
            }

        }

        private void PostButton_Click(object sender, EventArgs e)
        {
            var categories = new Categories() { CatId = Convert.ToInt32(CatIdTb.Text), CatName = CatNameTb.Text, CatDesc = CatDescTb.Text, Date = Convert.ToDateTime(dateTimePicker.Value.ToString("yyyy/MM/dd")) };
            var json = JsonConvert.SerializeObject(categories);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var url = new Uri("http://localhost:8084/api/post/categories");
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
            var url = new Uri($"http://localhost:8084/api/delete/{CatIdTb.Text}");
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
            var categories = new Categories() { CatId = Convert.ToInt32(CatIdTb.Text), CatName = CatNameTb.Text, CatDesc = CatDescTb.Text, Date = Convert.ToDateTime(dateTimePicker.Value.ToString("yyyy/MM/dd"))};
            var json = JsonConvert.SerializeObject(categories);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var url = new Uri($"http://localhost:8084/api/put/{CatIdTb.Text}");
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

        public class Categories
        {
            public int CatId { get; set; }
            public string CatName { get; set; }
            public string CatDesc { get; set; }
            public DateTime Date { get; set; }
        }



    }
}
