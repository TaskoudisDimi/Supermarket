using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using Newtonsoft.Json;
using OfficeOpenXml;
using SupermarketTuto.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.WindowsForms.Markers;

namespace SupermarketTuto.Forms
{
    public partial class Seller : Form
    {
        public Seller()
        {
            InitializeComponent();
            display();
        }
        GMapControl map = new GMapControl();
        SqlConnection con = new SqlConnection();
        HttpClient client = new HttpClient();
        Northeast coor = new Northeast();

        string address = string.Empty;

        string url = "https://maps.googleapis.com/maps/api/geocode/json?address={0}&key=AIzaSyA6xRZPHBhRuVErZgLtseHnB6heQFiyo3g";




        private void display()
        {
            SqlConnect loaddata1 = new SqlConnect();
            SqlConnect loaddata20 = new SqlConnect();
            loaddata1.retrieveData("Select SellerId, SellerName, SellerAge, SellerPhone, SellerPass, Date, Address From SellerTbl where Date between '" + fromDateTimePicker.Value.ToString("MM-dd-yyyy") + "' and '" + toDateTimePicker.Value.ToString("MM-dd-yyyy") + "'");
            SellDGV.DataSource = loaddata1.table;
            totalLabel.Text = $"Total: {SellDGV.RowCount}";
            SellDGV.RowHeadersVisible = false;

        }

        private void Seller_Load(object sender, EventArgs e)
        {
            display();
            ContextMenuStrip mnu = new ContextMenuStrip();
            ToolStripMenuItem mnuDelete = new ToolStripMenuItem("Delete");
            //Assign event handlers
            mnuDelete.Click += new EventHandler(mnuDelete_Click);
            //Add to main context menu
            mnu.Items.AddRange(new ToolStripItem[] { mnuDelete });
            //Assign to datagridview
            SellDGV.ContextMenuStrip = mnu;

            this.Controls.Add(map);
            map.Dock = DockStyle.Fill;
            map.MapProvider = GoogleMapProvider.Instance;
            panel1.Controls.Add(map);
            map.Position = new PointLatLng(40.629269, 22.947412); 
            map.MinZoom = 0;
            map.MaxZoom = 24;
            map.Zoom = 12;
        }
        private void mnuDelete_Click(object? sender, EventArgs e)
        {
            SqlConnect loaddata2 = new SqlConnect();

            loaddata2.commandExc("Delete From SellerTbl Where SellerId=" + SellId.Text + "");

            foreach (DataGridViewRow row in SellDGV.SelectedRows)
            {
                SellDGV.Rows.RemoveAt(row.Index);

            }
        }

        private void add2Button_Click(object sender, EventArgs e)
        {
            FileStream fs;
            BinaryReader br;

            SqlConnect loaddata5 = new SqlConnect();
            try
            {
                if (SellId.Text == "" || SellName.Text == "" || SellAge.Text == "" || SellPhone.Text == "" || SellPass.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {

                    loaddata5.commandExc("Insert Into SellerTbl values(" + SellId.Text + ",'" + SellName.Text + "'," + SellAge.Text + "," + SellPhone.Text + ",'" + SellPass.Text + "','" + dateTimePicker.Value.ToString("MM-dd-yyyy") + "','" + address + "'," + coor.lat + "," + coor.lng + ")");
                    SellId.Text = String.Empty;
                    SellName.Text = String.Empty;
                    SellAge.Text = String.Empty;
                    SellPhone.Text = String.Empty;
                    SellPass.Text = String.Empty;
                    MessageBox.Show("Seller added successfuly");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void editButton_Click_1(object sender, EventArgs e)
        {
            SqlConnect loaddata3 = new SqlConnect();
            try
            {
                if (SellId.Text == "" || SellName.Text == "" || SellAge.Text == "" || SellPhone.Text == "" || SellPass.Text == "")
                {
                    MessageBox.Show("Missing Information");

                }
                else
                {
                    loaddata3.commandExc("Update SellerTbl set SellerName='" + SellName.Text + "',SellerAge='" + SellAge.Text + "',SellerPhone='" + SellPhone.Text + "',SellerPass='" + SellPass.Text + "' where SellerId=" + SellId.Text + ";");
                    MessageBox.Show("Product Successfully Updated");

                    display();
                    SellId.Text = "";
                    SellName.Text = "";
                    SellAge.Text = "";
                    SellPhone.Text = "";
                    SellPass.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delete2Button_Click(object sender, EventArgs e)
        {
            SqlConnect loaddata4 = new SqlConnect();

            try
            {
                if (SellId.Text == "" || SellName.Text == "" || SellAge.Text == "" || SellPhone.Text == "" || SellPass.Text == "")
                {
                    MessageBox.Show("Select The Category to Delete");
                }
                else
                {

                    loaddata4.commandExc("Delete From SellerTbl Where SellerId=" + SellId.Text + "");

                    MessageBox.Show("Seller Deleted Successfully");
                    SellId.Text = "";
                    SellName.Text = "";
                    SellAge.Text = "";
                    SellPhone.Text = "";
                    SellPass.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fromDateTimePicker_ValueChanged_1(object sender, EventArgs e)
        {
            display();
        }

        private void toDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            display();
        }

        private void SellDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SellId.Text = SellDGV.SelectedRows[0].Cells[0].Value.ToString();
            SellName.Text = SellDGV.SelectedRows[0].Cells[1].Value.ToString();
            SellAge.Text = SellDGV.SelectedRows[0].Cells[2].Value.ToString();
            SellPhone.Text = SellDGV.SelectedRows[0].Cells[3].Value.ToString();
            SellPass.Text = SellDGV.SelectedRows[0].Cells[4].Value.ToString();
            dateTimePicker.Value = (DateTime)SellDGV.SelectedRows[0].Cells[5].Value;
            addressTextBox.Text = SellDGV.SelectedRows[0].Cells[6].Value.ToString();

        }

        private void SellDGV_MouseDown(object sender, MouseEventArgs e)
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            ToolStripMenuItem sellerDelete = new ToolStripMenuItem("Delete");
            sellerDelete.Click += new EventHandler(mnuDelete_Click);
            menu.Items.AddRange(new ToolStripItem[] { sellerDelete });
            SellDGV.ContextMenuStrip = menu;
            SellDGV.AllowUserToAddRows = false;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SqlConnect db_sellers = new SqlConnect();
            string query = "Select * From SellerTbl where SellerId like '%" + searchTextBox.Text + "%'" + "or SellerName like '%" + searchTextBox.Text + "%'" + "or SellerAge like '%" + searchTextBox.Text + "%'" + "or SellerPhone like '%" + searchTextBox.Text + "%'" + "or SellerPass like '%" + searchTextBox.Text + "%'";
            db_sellers.search(searchTextBox.Text, query);
            SellDGV.DataSource = db_sellers.table;
            totalLabel.Text = $"Total: {SellDGV.RowCount}";

        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                searchButton.PerformClick();
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            display();
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


        //public Image ConvertByteToImage(byte[] data)
        //{
        //    using (MemoryStream ms = new MemoryStream(data))
        //    {
        //        return Image.FromStream(ms);
        //    }
        //}

        //byte[] ConvertImageToByte(Image image)
        //{
        //    using (MemoryStream ms = new MemoryStream())
        //    {
        //        image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
        //        return ms.ToArray();
        //    }
        //}


    }
}


