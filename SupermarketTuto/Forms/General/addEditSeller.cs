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
        Map.Northeast coor = new Map.Northeast();
        string address = string.Empty;
        string url = "https://maps.googleapis.com/maps/api/geocode/json?address={0}&key=AIzaSyA6xRZPHBhRuVErZgLtseHnB6heQFiyo3g";
        string imageName = "";
        byte[] imageData;
        List<SqlParameter> para = new List<SqlParameter>();

        public addEditSeller(DataTable sellersTable_, DataGridViewRow selected_, bool add)
        {
            InitializeComponent();
            this.Icon = new System.Drawing.Icon("C:/Users/chris/Desktop/Dimitris/Tutorials/Supermarket/SupermarketTuto/Resources/supermarket.ico");
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
                seller = DataModel.Select<SellersTbl>(where: $"SellerId = {selected.Cells["SellerId"].Value.ToString()}").FirstOrDefault();
                
                if (seller.image != null)
                {
                    MemoryStream ms = new MemoryStream(seller.image);
                    Image image = Image.FromStream(ms);
                    pictureBox.Image = image;
                }
                addButton.Visible = false;
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

        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (SellName.Text == "" || SellAge.Text == "" || SellPhone.Text == "" || passwordTextBox.Text == "" || addressTextBox.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    SqlParameter SellerId = new SqlParameter("@SellerId", SqlDbType.Int);
                    SqlParameter paramUsername = new SqlParameter("@SellerUserName", SqlDbType.NVarChar, -1);
                    SqlParameter paramPass = new SqlParameter("@SellerPass", SqlDbType.NVarChar, -1);
                    SqlParameter paramName = new SqlParameter("@SellerName", SqlDbType.NVarChar, -1);
                    SqlParameter paramAge = new SqlParameter("@SellerAge", SqlDbType.Int, -1);
                    SqlParameter paramPhone = new SqlParameter("@SellerPhone", SqlDbType.Int, -1);
                    SqlParameter paramDate = new SqlParameter("@Date", SqlDbType.DateTime, -1);
                    SqlParameter paramAddress = new SqlParameter("@Address", SqlDbType.NVarChar, -1);
                    SqlParameter paramActive = new SqlParameter("@Active", SqlDbType.Bit, -1);
                    SqlParameter paramImage = new SqlParameter("@Image", SqlDbType.VarBinary, -1);
                    paramImage.Value = seller.image;
                    paramAge.Value = Convert.ToInt32(SellAge.Text);
                    paramName.Value = SellName.Text;
                    paramUsername.Value = usernameTextBox.Text;
                    // Hash password
                    string hashPass = Utils.Utils.HashPassword(passwordTextBox.Text);
                    paramPass.Value = hashPass;
                    paramPhone.Value = Convert.ToInt32(SellPhone.Text);
                    paramDate.Value = (DateTime)dateTimePicker.Value.Date;
                    seller.Date = (DateTime)dateTimePicker.Value.Date;
                    seller.SellerAge = Convert.ToInt32(SellAge.Text);
                    seller.SellerName = SellName.Text;
                    seller.SellerUserName = usernameTextBox.Text;
                    seller.SellerPass = hashPass;
                    seller.Address = addressTextBox.Text;
                    seller.SellerPhone = Convert.ToInt32(SellPhone.Text);
                    paramAddress.Value = addressTextBox.Text;
                    SellerId.Value = Convert.ToInt32(SellId.Text);

                    if (checkBox.Checked)
                    {
                        paramActive.Value = true;
                    }
                    else
                    {
                        paramActive.Value = false;
                    }
                    para.Add(SellerId);
                    para.Add(paramUsername);
                    para.Add(paramPass);
                    para.Add(paramName);
                    para.Add(paramAge);
                    para.Add(paramPhone);
                    para.Add(paramDate);
                    para.Add(paramAddress);
                    para.Add(paramActive);
                    para.Add(paramImage);
                    
                    // Update the record using the SQL query
                    DataContext.Instance.ExecuteNQ(
                        "Update SellersTbl " +
                        "set SellerUserName = @SellerUserName, " +
                        "SellerPass = @SellerPass, " +
                        "SellerName = @SellerName, " +
                        "SellerAge = @SellerAge, " +
                        "SellerPhone = @SellerPhone, " +
                        "Date = @Date, " +
                        "Address = @Address, " +
                        "Active = @Active, " +
                        "Image = @Image " +
                        "where SellerId = @SellerId", para);

                    OnItemEdited(new SellerEventArgs(seller, seller.SellerId));

                    MessageBox.Show($"Seller {SellName.Text} edited successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (imageName != "")
                {
                    imageData = File.ReadAllBytes(imageName);
                }
                SqlParameter paramUsername = new SqlParameter("@SellerUserName", SqlDbType.NVarChar, -1);
                SqlParameter paramPass = new SqlParameter("@SellerPass", SqlDbType.NVarChar, -1);
                SqlParameter paramName = new SqlParameter("@SellerName", SqlDbType.NVarChar, -1);
                SqlParameter paramAge = new SqlParameter("@SellerAge", SqlDbType.Int, -1);
                SqlParameter paramPhone = new SqlParameter("@SellerPhone", SqlDbType.Int, -1);
                SqlParameter paramDate = new SqlParameter("@Date", SqlDbType.DateTime, -1);
                SqlParameter paramAddress = new SqlParameter("@Address", SqlDbType.NVarChar, -1);
                SqlParameter paramActive = new SqlParameter("@Active", SqlDbType.Bit, -1);
                SqlParameter paramImage = new SqlParameter("@Image", SqlDbType.VarBinary, -1);
                paramImage.Value = imageData;
                paramAge.Value = Convert.ToInt32(SellAge.Text);
                paramName.Value = SellName.Text;
                paramUsername.Value = usernameTextBox.Text;
                // Hash password
                string hashPass = Utils.Utils.HashPassword(passwordTextBox.Text);
                paramPass.Value = hashPass;
                paramPhone.Value = Convert.ToInt32(SellPhone.Text);
                paramDate.Value = (DateTime)dateTimePicker.Value.Date;
                paramAddress.Value = addressTextBox.Text;
                seller.image = imageData;
                seller.Date = (DateTime)dateTimePicker.Value.Date;
                seller.SellerAge = Convert.ToInt32(SellAge.Text);
                seller.SellerName = SellName.Text;
                seller.SellerUserName = usernameTextBox.Text;
                seller.SellerPass = hashPass;
                seller.Address = addressTextBox.Text;
                seller.SellerPhone = Convert.ToInt32(SellPhone.Text);
                if (checkBox.Checked)
                {
                    paramActive.Value = true;
                    seller.Active = true;
                }
                else
                {
                    paramActive.Value = false;
                    seller.Active = false;
                }
                para.Add(paramUsername);
                para.Add(paramPass);
                para.Add(paramName);
                para.Add(paramAge);
                para.Add(paramPhone);
                para.Add(paramDate);
                para.Add(paramAddress);
                para.Add(paramActive);
                para.Add(paramImage);
                DataContext.Instance.ExecuteNQ("Insert Into SellersTbl (SellerUserName, SellerPass, SellerName, " +
                    "SellerAge, SellerPhone, Date, Address, Active, Image) VALUES (@SellerUserName, @SellerPass, @SellerName," +
                    "@SellerAge, @SellerPhone, @Date, @Address, @Active, @Image)", para);

                OnItemCreated(new SellerEventArgs(seller, seller.SellerId));

                MessageBox.Show($"Seller {SellName.Text} added successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private async void addressTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                var response = await client.GetAsync(string.Format(url, addressTextBox.Text));
                string result = await response.Content.ReadAsStringAsync();
                Map.Root root = JsonConvert.DeserializeObject<Map.Root>(result);
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

        protected virtual void OnItemCreated(SellerEventArgs e)
        {
            ItemCreated?.Invoke(this, e);

        }


        protected virtual void OnItemEdited(SellerEventArgs e)
        {
            ItemEdited?.Invoke(this, e);

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
