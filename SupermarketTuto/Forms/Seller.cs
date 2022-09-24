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

namespace SupermarketTuto.Forms
{
    public partial class Seller : Form
    {
        public Seller()
        {
            InitializeComponent();
            display();
        }

        SqlConnection con = new SqlConnection();
        private void display()
        {
            SqlConnect loaddata1 = new SqlConnect();

            SqlConnect loaddata20 = new SqlConnect();
            loaddata1.retrieveData("Select SellerId, SellerName, SellerAge, SellerPhone, Date From SellerTbl where Date between '" + fromDateTimePicker.Value.ToString("MM-dd-yyyy") + "' and '" + toDateTimePicker.Value.ToString("MM-dd-yyyy") + "'");

            SellDGV.DataSource = loaddata1.table;
            totalLabel.Text = $"Total: {SellDGV.RowCount}";

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
                if (SellId.Text == "" || SellName.Text == "" || SellAge.Text == "" || SellPhone.Text == "" || SellPass.Text == "" && imageTextBox.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    string FileName = imageTextBox.Text;
                    byte[] ImageData;
                    fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                    br = new BinaryReader(fs);
                    ImageData = br.ReadBytes((int)fs.Length);
                    br.Close();
                    fs.Close();
                    loaddata5.commandExc("Insert Into SellerTbl values(" + SellId.Text + ",'" + SellName.Text + "'," + SellAge.Text + "," + SellPhone.Text + ",'" + SellPass.Text + "','" + dateTimePicker.Value.ToString("MM-dd-yyyy") + "','" + ImageData + "')");


                    SellId.Text = String.Empty;
                    SellName.Text = String.Empty;
                    SellAge.Text = String.Empty;
                    SellPhone.Text = String.Empty;
                    SellPass.Text = String.Empty;
                    pictureBox.Image = null;
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

        private void uploadButton_Click_1(object sender, EventArgs e)
        {
            Stream myStream = null;

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG (.JPG)|*.jpg";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = dialog.OpenFile()) != null)
                    {
                        //file = Image.FromFile(dialog.FileName);
                        //pictureBox.Image = file;
                        string FileName = dialog.FileName;
                        if (myStream.Length > 512000)
                        {
                            MessageBox.Show("File Size limit exceeded");
                        }
                        else
                        {
                            //pictureBox.Load(FileName);
                            pictureBox.Image = Image.FromFile(dialog.FileName);
                            imageTextBox.Text = dialog.FileName;
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void SellDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SellId.Text = SellDGV.SelectedRows[0].Cells[0].Value.ToString();
            SellName.Text = SellDGV.SelectedRows[0].Cells[1].Value.ToString();
            SellAge.Text = SellDGV.SelectedRows[0].Cells[2].Value.ToString();
            SellPhone.Text = SellDGV.SelectedRows[0].Cells[3].Value.ToString();
            SellPass.Text = SellDGV.SelectedRows[0].Cells[4].Value.ToString();
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


        private void showButton_Click(object sender, EventArgs e)
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Supermarket"].ConnectionString;
            con.Open();
            string sql = "Select Image From SellerTbl where SellerPass=" + "'3'";
            SqlCommand sqlCommand = new SqlCommand(sql, con);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            reader.Read();
            byte[] image = (byte[])(reader[0]);
            MemoryStream ms = new MemoryStream(image);
            pictureBox.Image = Image.FromStream(ms);
            con.Close();
            
        }
    }
}

