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
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;
using System.Runtime.Serialization.Formatters.Binary;
using ClassLibrary1;
using ClassLibrary1.Models;

namespace SupermarketTuto.Forms.General
{
    public partial class addEditSeller : Form
    {
        DataTable sellersTable = new DataTable();
        DataGridViewRow selected = new DataGridViewRow();
        SellersTbl seller = new SellersTbl();
        public event EventHandler<SellerEventArgs> ItemCreated;
        public event EventHandler<SellerEventArgs> ItemEdited;
        

        GMapControl map = new GMapControl();
        HttpClient client = new HttpClient();
        Northeast coor = new Northeast();
        string address = string.Empty;
        string url = "https://maps.googleapis.com/maps/api/geocode/json?address={0}&key=AIzaSyA6xRZPHBhRuVErZgLtseHnB6heQFiyo3g";
        string imageName = "";
        byte[] imageData;
        List<SqlParameter> para = new List<SqlParameter>();

        public addEditSeller(DataTable sellersTable_, DataGridViewRow selected_, bool add)
        {
            InitializeComponent();
            sellersTable = sellersTable_;
            selected = selected_;
            BinaryFormatter formatter = new BinaryFormatter();

            if (add)
            {
                editButton.Enabled = false;
            }
            else
            {
                SellId.Text = selected.Cells["SellerId"].Value.ToString();
                usernameTextBox.Text = selected.Cells["SellerUserName"].Value.ToString();
                passwordTextBox.Text = selected.Cells["SellerPass"].Value.ToString();
                SellName.Text = selected.Cells["SellerName"].Value.ToString();
                SellAge.Text = selected.Cells["SellerAge"].Value.ToString();
                SellPhone.Text = selected.Cells["SellerPhone"].Value.ToString();
                addressTextBox.Text = selected.Cells["Address"].Value.ToString();
                checkBox.Checked = (bool)selected.Cells["Active"].Value;
                dateTimePicker.Value = (DateTime)selected.Cells["Date"].Value;


                //if (!selected.IsNull("Image"))
                //{
                //    byte[] imageData = (byte[])selected["Image"];
                //    MemoryStream ms = new MemoryStream(imageData);
                //    Image image = Image.FromStream(ms);
                //    pictureBox.Image = image;
                //}


                addButton.Visible = false;
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (SellName.Text == "" || SellAge.Text == "" || SellPhone.Text == "" || passwordTextBox.Text == "" || addressTextBox.Text == "")
            //    {
            //        MessageBox.Show("Missing Information");
            //    }
            //    else
            //    {
            //        //byte[] imageBytes = Utils.Utils.ImageToByteArray(pictureBox.Image);
            //        byte[] imageData = File.ReadAllBytes(imageName);
            //        //seller.SellerName = SellName.Text;
            //        //byte[] asciiBytes = Encoding.ASCII.GetBytes(passwordTextBox.Text);
            //        seller.SellerPass = Utils.Utils.GetMD5Hash(passwordTextBox.Text);
            //        seller.SellerAge = Convert.ToInt32(SellAge.Text);
            //        seller.SellerUserName = usernameTextBox.Text;
            //        seller.SellerPhone = Convert.ToInt32(SellPhone.Text);
            //        seller.Address = addressTextBox.Text;
            //        seller.Active = checkBox.Checked;
            //        seller.Date = dateTimePicker.Value;
            //        seller.image = imageData;
            //        DataModel.Update<SellersTbl>(seller);
            //        MessageBox.Show("Seller Successfully Updated");
            //        this.Close();
            //    }
               
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                seller.SellerAge = Convert.ToInt32(SellAge.Text);
                seller.SellerName = SellName.Text;
                seller.SellerUserName = usernameTextBox.Text;
                seller.SellerPass = passwordTextBox.Text;
                seller.SellerPhone = Convert.ToInt32(SellPhone.Text);
                seller.Date = (DateTime)dateTimePicker.Value.Date;
                if (checkBox.Checked)
                {
                    seller.Active = true;
                }
                else
                {
                    seller.Active = false;
                }
                if(imageName != "")
                {
                    imageData = File.ReadAllBytes(imageName);
                }
                seller.image = imageData;
                
                SqlParameter param = new SqlParameter("@Image", SqlDbType.VarBinary, -1);
                param.Value = imageData;
               
                para.Add(param);
                DataModel.Create<SellersTbl>(seller, queryparams: para);
                
                MessageBox.Show("Seller added successfuly");
                this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        
        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imageName = ofd.FileName;
                pictureBox.Image = Image.FromFile(ofd.FileName);
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



    }

    public class SellerEventArgs : EventArgs
    {
        public SellersTbl CreatedSeller { get; private set; }
        public int PrimaryKeyValue { get; private set; }

        public SellerEventArgs(SellersTbl seller, int primaryKeyValue)
        {
            CreatedSeller = seller;
            PrimaryKeyValue = primaryKeyValue;
        }
    }

}
