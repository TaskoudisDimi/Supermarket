
using Newtonsoft.Json;
using OfficeOpenXml;
using SupermarketTuto.DataAccess;
using SupermarketTuto.Forms.General;
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
        SqlConnection con = new SqlConnection();

        public Seller()
        {
            InitializeComponent();
            display();
        }

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


        }
        private void mnuDelete_Click(object? sender, EventArgs e)
        {
            //SqlConnect loaddata2 = new SqlConnect();

            //loaddata2.commandExc("Delete From SellerTbl Where SellerId=" + SellId.Text + "");

            //foreach (DataGridViewRow row in SellDGV.SelectedRows)
            //{
            //    SellDGV.Rows.RemoveAt(row.Index);

            //}
        }

        private void add2Button_Click(object sender, EventArgs e)
        {
            addEditSeller add = new addEditSeller();
            add.Show();

        }

        private void editButton_Click_1(object sender, EventArgs e)
        {
            addEditSeller edit = new addEditSeller();
            edit.SellId.Text = SellDGV.CurrentRow.Cells[0].Value.ToString();
            edit.SellName.Text = SellDGV.CurrentRow.Cells[1].Value.ToString();
            edit.SellAge.Text = SellDGV.CurrentRow.Cells[2].Value.ToString();
            edit.SellPhone.Text = SellDGV.CurrentRow.Cells[3].Value.ToString();
            edit.SellPass.Text = SellDGV.CurrentRow.Cells[4].Value.ToString();
            edit.dateTimePicker.Text = SellDGV.CurrentRow.Cells[5].Value.ToString();
            edit.addressTextBox.Text = SellDGV.CurrentRow.Cells[6].Value.ToString();
            edit.Show();

        }

        private void delete2Button_Click(object sender, EventArgs e)
        {
            SqlConnect loaddata4 = new SqlConnect();

            try
            {
                loaddata4.commandExc("Delete From SellerTbl Where SellerId=" + SellDGV.CurrentRow.Cells[0].Value.ToString());

                MessageBox.Show("Seller Deleted Successfully");

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


