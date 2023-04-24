using ClassLibrary1;
using ClassLibrary1.Models;
using DataClass;
using SupermarketTuto.Forms.General;
using SupermarketTuto.Utils;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http.Headers;
using System.Text;



namespace SupermarketTuto.Forms
{
    public partial class Seller : Form
    {
        public Seller()
        {
            InitializeComponent();
            display();
        }
        private void display()
        {
            try
            {
                
                if (activeComboBox.Text == "Active")
                {
                    SqlConnect loaddata1 = new SqlConnect();
                    loaddata1.pagingData("Select [SellerId],[SellerUserName],cast([SellerPass] as varchar(MAX)) as Password,[SellerName],[SellerAge],[SellerPhone],[Date],[Address],[Active] From SellersTbl where Active = 'true'", 0, 5);
                    SellDGV.DataSource = loaddata1.table;
                    totalLabel.Text = $"Total: {SellDGV.RowCount}";
                    SellDGV.RowHeadersVisible = false;
                    //SellDGV.Columns[6].HeaderText = "Date of Birth";
                }
                
                else if (activeComboBox.Text == "Inactive")
                {
                    SqlConnect loaddata1 = new SqlConnect();
                    loaddata1.getData("Select [SellerId],[SellerUserName],cast([SellerPass] as varchar(MAX)) as Password,[SellerName],[SellerAge],[SellerPhone],[Date],[Address],[Active] From SellersTbl where Active = 'False'");
                    SellDGV.DataSource = loaddata1.table;
                    totalLabel.Text = $"Total: {SellDGV.RowCount}";
                    SellDGV.RowHeadersVisible = false;
                    //SellDGV.Columns[6].HeaderText = "Date of Birth";
                }
                else
                {
                    SqlConnect loaddata1 = new SqlConnect();
                    loaddata1.getData("Select [SellerId],[SellerUserName],cast([SellerPass] as varchar(MAX)) as Password,[SellerName],[SellerAge],[SellerPhone],[Date],[Address],[Active] From SellersTbl");
                    SellDGV.DataSource = loaddata1.table;
                    totalLabel.Text = $"Total: {SellDGV.RowCount}";
                    SellDGV.RowHeadersVisible = false;
                    //SellDGV.Columns[6].HeaderText = "Date of Birth";
                }
            }
            catch (Exception ex)
            {
                Utlis.Log(string.Format("Message : {0}", ex.Message), "ErrorDisplayData.txt");
            }
        }

        private void Seller_Load(object sender, EventArgs e)
        {
            display();
            fillcombo();
        }

        private void fillcombo()
        {
            //Fill combo Active
            string[] test2 = { "Not Set", "Active", "Inactive" };
            activeComboBox.DataSource = test2;
        }

        #region buttons
        private void add2Button_Click(object sender, EventArgs e)
        {
            //check();
            addEditSeller add = new addEditSeller();
            add.editButton.Visible = false;
            add.SellId.Visible = false;
            add.idlabel.Visible = false;
            add.Show();
        }

        private void editButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                //check();
                SqlConnect loaddata60 = new SqlConnect();
                addEditSeller edit = new addEditSeller();
                edit.SellId.Text = SellDGV.CurrentRow.Cells[0].Value.ToString();
                string query = $"Select * From SellersTbl where SellerId = {edit.SellId.Text}";
                loaddata60.getData(query);
                DataTable sellers = loaddata60.table;
                foreach (DataRow row in sellers.Rows)
                {
                    edit.usernameTextBox.Text = row["SellerUserName"].ToString();
                    byte[] imageData = (byte[])row["Image"];
                    MemoryStream ms = new MemoryStream(imageData);
                    edit.pictureBox.Image = Image.FromStream(ms);
                    edit.passwordTextBox.Text = row["SellerPass"].ToString();
                    edit.SellName.Text = row["SellerName"].ToString();
                    edit.SellAge.Text = row["SellerAge"].ToString();
                    edit.SellPhone.Text = row["SellerPhone"].ToString();
                    edit.addressTextBox.Text = row["Address"].ToString();
                    edit.dateTimePicker.Text = row["Date"].ToString();
                    edit.checkBox.Checked = (bool)row["Active"];
                }
                edit.addButton.Visible = false;
                edit.SellId.ReadOnly = true;
                edit.Show();
            }
            catch (Exception ex)
            {
                Utlis.Log(string.Format("Message : {0}", ex.Message), "ErrorDisplayData.txt");
            }

        }

        private void delete2Button_Click(object sender, EventArgs e)
        {
            SqlConnect loaddata4 = new SqlConnect();

            try
            {
                //check();
                loaddata4.execCom("Delete From SellersTbl Where SellerId=" + SellDGV.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("Seller Deleted Successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            SqlConnect db_sellers = new SqlConnect();
            string query = "Select [SellerId],[SellerUserName],cast([SellerPass] as varchar(MAX)) as Password,[SellerName],[SellerAge],[SellerPhone],[Date],[Address],[Active] From SellersTbl where SellerId like '%" + searchTextBox.Text + "%'" + "or SellerName like '%" + searchTextBox.Text + "%'" + "or SellerAge like '%" + searchTextBox.Text + "%'" + "or SellerPhone like '%" + searchTextBox.Text + "%'" + "or SellerPass like '%" + searchTextBox.Text + "%'";
            db_sellers.search(searchTextBox.Text, query);
            SellDGV.DataSource = db_sellers.table;
            totalLabel.Text = $"Total: {SellDGV.RowCount}";
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            display();
        }
        #endregion

        #region MenuStrip
        private void menu()
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            ToolStripMenuItem mnuDelete = new ToolStripMenuItem("Delete");
            ToolStripMenuItem mnuEdit = new ToolStripMenuItem("Edit");
            mnuDelete.Click += new EventHandler(mnuDelete_Click);
            mnuEdit.Click += new EventHandler(mnuEdit_Click);
            menu.Items.AddRange(new ToolStripItem[] { mnuEdit, mnuDelete });
            SellDGV.ContextMenuStrip = menu;
            SellDGV.AllowUserToAddRows = false;
        }

        private void mnuEdit_Click(object? sender, EventArgs e)
        {
            try
            {
                SqlConnect loaddata50 = new SqlConnect();
                addEditSeller edit = new addEditSeller();
                edit.SellId.Text = SellDGV.CurrentRow.Cells[0].Value.ToString();
                string query = $"Select * From SellersTbl where SellerId = {edit.SellId.Text}";
                loaddata50.getData(query);
                DataTable sellers = loaddata50.table;
                foreach (DataRow row in sellers.Rows)
                {
                    edit.usernameTextBox.Text = row["SellerUserName"].ToString();
                    byte[] imageData = (byte[])row["Image"];
                    MemoryStream ms = new MemoryStream(imageData);
                    edit.pictureBox.Image = Image.FromStream(ms);
                    edit.passwordTextBox.Text = row["SellerPass"].ToString();
                    edit.SellName.Text = row["SellerName"].ToString();
                    edit.SellAge.Text = row["SellerAge"].ToString();
                    edit.SellPhone.Text = row["SellerPhone"].ToString();
                    edit.addressTextBox.Text = row["Address"].ToString();
                    edit.dateTimePicker.Text = row["Date"].ToString();
                    edit.checkBox.Checked = (bool)row["Active"];
                }
                edit.addButton.Visible = false;
                edit.SellId.ReadOnly = true;
                edit.Show();
            }
            catch (Exception ex)
            {
                Utlis.Log(string.Format("Message : {0}", ex.Message), "ErrorDisplayData.txt");
            }
        }
        private void mnuDelete_Click(object? sender, EventArgs e)
        {
            SqlConnect loaddata2 = new SqlConnect();
            loaddata2.execCom("Delete From SellerTbl Where SellerId = " + SellDGV.CurrentRow.Cells[0].Value.ToString());
            foreach (DataGridViewRow row in SellDGV.SelectedRows)
            {
                SellDGV.Rows.RemoveAt(row.Index);

            }
        }
        #endregion


        #region Events
       
        private void SellDGV_MouseDown(object sender, MouseEventArgs e)
        {
            menu();
        }
        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Search with Enter 
            if (e.KeyChar == (char)13)
            {
                searchButton.PerformClick();
            }
        }

        private void SellDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in SellDGV.Rows)
            {
                if (Convert.ToBoolean(row.Cells[8].Value.ToString()) == false)
                {
                    row.DefaultCellStyle.BackColor = Color.Orange;
                }

            }
            if (e.ColumnIndex == 2 && e.Value != null)
            {
                e.Value = new string('*', e.Value.ToString().Length);
            }

        }

        private void activeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                display();

            }
            catch (Exception ex)
            {

            }

        }
        #endregion

        #region ChechDatabase
        private void check()
        {
            SqlConnect sql = new SqlConnect();
            var customerType = typeof(Sellers);
            sql.checkTable(Categories: customerType);
        }

        #endregion

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            searchButton.PerformClick();
        }
    }
}


