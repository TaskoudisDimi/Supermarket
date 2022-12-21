
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using SupermarketTuto.Forms.General;
using System.Data.SqlClient;
using static SupermarketTuto.Forms.Seller;
using Newtonsoft.Json;
using System.Security.Policy;
using DataClass;

namespace SupermarketTuto.Forms.General
{
    public partial class addEditSeller : Form
    {
        GMapControl map = new GMapControl();
        SqlConnection con = new SqlConnection();
        HttpClient client = new HttpClient();
        Northeast coor = new Northeast();
        string address = string.Empty;
        string url = "https://maps.googleapis.com/maps/api/geocode/json?address={0}&key=AIzaSyA6xRZPHBhRuVErZgLtseHnB6heQFiyo3g";

        public addEditSeller()
        {
            InitializeComponent();
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            SqlConnect loaddata5 = new SqlConnect();
            try
            {
                if (checkBox.Checked)
                {
                    if(address == null)
                    {
                        loaddata5.commandExc("Insert Into SellersTbl values('" + SellName.Text + "'," + "CONVERT(varbinary,'" + passwordTextBox.Text + "'), '" + SellName.Text + "'," + SellAge.Text + "," + SellPhone.Text + ",'" + dateTimePicker.Value.ToString("MM-dd-yyyy") + "','" + addressTextBox.Text + "','True')");
                        MessageBox.Show("Seller added successfuly");
                        this.Close();
                    }
                    else
                    {
                        loaddata5.commandExc("Insert Into SellersTbl values('" + SellName.Text + "'," + "CONVERT(varbinary,'" + passwordTextBox.Text + "'), '" + SellName.Text + "'," + SellAge.Text + "," + SellPhone.Text + ",'" + dateTimePicker.Value.ToString("MM-dd-yyyy") + "','" + address + "','True')");
                        MessageBox.Show("Seller added successfuly");
                        this.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            SqlConnect loaddata3 = new SqlConnect();
            try
            {
                if (checkBox.Checked)
                {
                    loaddata3.commandExc("Update SellersTbl set SellerUserName='" + SellName.Text + $"SellerPass = Convert(varbinary, '{passwordTextBox.Text}')" + ", SellerName = " + SellName.Text + "SellerAge='" + SellAge.Text + "', SellerPhone='" + SellPhone.Text + "', Address='" + addressTextBox.Text + "', Date='" + dateTimePicker.Value.ToString("yyyy-MM-dd") + "Active = 'True'" +  "where SellerId=" + SellId.Text);
                }
                else
                {
                    loaddata3.commandExc("Update SellersTbl set SellerUserName='" + SellName.Text + $"SellerPass = Convert(varbinary, '{passwordTextBox.Text}')" + ", SellerName = " + SellName.Text + "SellerAge='" + SellAge.Text + "', SellerPhone='" + SellPhone.Text + "', Address='" + addressTextBox.Text + "', Date='" + dateTimePicker.Value.ToString("yyyy-MM-dd") + "Active = 'False'" + "where SellerId=" + SellId.Text);
                }
                MessageBox.Show("Product Successfully Updated");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addEditSeller_Load(object sender, EventArgs e)
        {
            this.Controls.Add(map);
            map.Dock = DockStyle.Fill;
            map.MapProvider = GoogleMapProvider.Instance;
            panel1.Controls.Add(map);
            map.Position = new PointLatLng(40.629269, 22.947412);
            map.MinZoom = 0;
            map.MaxZoom = 24;
            map.Zoom = 12;
        }

        private async void addressTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                var response = await client.GetAsync(string.Format(url, addressTextBox.Text));
                string result = await response.Content.ReadAsStringAsync();
                Root root = JsonConvert.DeserializeObject<Root>(result);
                foreach (var item in root.results)
                {
                    coor.lat = item.geometry.location.lat;
                    coor.lng = item.geometry.location.lng;
                    address = item.formatted_address;
                }
                map.Position = new PointLatLng(coor.lat, coor.lng);
                GMap.NET.WindowsForms.GMapMarker marker = new GMapMarkerGoogleRed(map.Position);
                GMapOverlay markers = new GMapOverlay(map, "markers");
                markers.Markers.Add(marker);
                map.Overlays.Add(markers);
                map.Zoom = 18;

            }
        }


        public class AddressComponent
        {
            public string long_name { get; set; }
            public string short_name { get; set; }
            public List<string> types { get; set; }
        }

        public class Bounds
        {
            public Northeast northeast { get; set; }
            public Southwest southwest { get; set; }
        }

        public class Geometry
        {
            public Bounds bounds { get; set; }
            public Location location { get; set; }
            public string location_type { get; set; }
            public Viewport viewport { get; set; }
        }

        public class Location
        {
            public double lat { get; set; }
            public double lng { get; set; }
        }

        public class Northeast
        {
            public double lat { get; set; }
            public double lng { get; set; }
        }

        public class Result
        {
            public List<AddressComponent> address_components { get; set; }
            public string formatted_address { get; set; }
            public Geometry geometry { get; set; }
            public string place_id { get; set; }
            public List<string> types { get; set; }
        }

        public class Root
        {
            public List<Result> results { get; set; }
            public string status { get; set; }
        }

        public class Southwest
        {
            public double lat { get; set; }
            public double lng { get; set; }
        }

        public class Viewport
        {
            public Northeast northeast { get; set; }
            public Southwest southwest { get; set; }
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked)
            {
                passwordTextBox.PasswordChar = '\0';
            }
            else
            {
                passwordTextBox.PasswordChar = '*';
            }
        }
    }
}
