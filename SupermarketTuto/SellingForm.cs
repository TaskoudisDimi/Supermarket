using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;


namespace SupermarketTuto
{
    public partial class SellingForm : Form
    {
        public SellingForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //SqlConnection Con = new SqlConnection(@"Data Source=DIMITRISTASKOUD\DIMITRIS_TASKOUD;Initial Catalog=smarketdb;Integrated Security=True");
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-FF268DF\SQLEXPRESS;Initial Catalog=smarketdb;Integrated Security=True");

        private void display()  
        {
            Con.Open();
            string query = "Select ProdName, ProdQty From ProductTbl;";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var table = new DataSet();
            adapter.Fill(table);
            SellingDGV.DataSource = table.Tables[0];
            Con.Close();
        }

        private void displayBills()
        {
            Con.Open();
            string query = "Select * From BillTbl;";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var table = new DataSet();
            adapter.Fill(table);
            BillsDGV.DataSource = table.Tables[0];
            Con.Close();
        }

        private void SellingForm_Load(object sender, EventArgs e)
        {
            display();
            displayBills();
            fillCombo();
            SellerNameLabel.Text = WelcomeForm.Sellername;
        }

        private void SellingDGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SellingProdName.Text = SellingDGV.SelectedRows[0].Cells[0].Value.ToString();
            SellingPrice.Text = SellingDGV.SelectedRows[0].Cells[1].Value.ToString();
            display();
        }

        private void SellingPanel_Paint(object sender, PaintEventArgs e)
        {
            DateLabel.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();

        }

        private void AddProductbutton_Click(object sender, EventArgs e)
        {

            if (SellingProdName.Text == "" || SellingQuantity.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                int n = 0, total = Convert.ToInt32(SellingPrice.Text) * Convert.ToInt32(SellingQuantity.Text), GrdTotal = 0;
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(OrderDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = SellingProdName.Text;
                newRow.Cells[2].Value = SellingPrice.Text;
                newRow.Cells[3].Value = SellingQuantity.Text;
                newRow.Cells[4].Value = Convert.ToInt32(SellingPrice.Text) * Convert.ToInt32(SellingQuantity.Text);
                OrderDGV.Rows.Add(newRow);
                n++;
                GrdTotal = GrdTotal + total;
                AmtLabel.Text = "" + GrdTotal;
            }

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {

                Con.Open();
                string query = "Insert Into BillTbl values(" + BillId.Text + ",'" + SellerNameLabel.Text + "','" + DateLabel.Text + "'," + AmtLabel.Text + ")";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.BeginExecuteNonQuery();
                MessageBox.Show("Order added successfuly");
                Con.Close();
                displayBills();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void PrintButton_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        int flag = 0;
        private void BillsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            flag = 1;
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString("FamilySuperMarket", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics.DrawString("Bill ID: " + BillsDGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Blue, new Point(100,70));
            e.Graphics.DrawString("Seller Name: " + BillsDGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Blue, new Point(100, 100));
            e.Graphics.DrawString("Date: " + BillsDGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Blue, new Point(100, 130));
            e.Graphics.DrawString("Total Amount: " + BillsDGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Blue, new Point(100, 160));
            e.Graphics.DrawString("Code Space", new Font("Century Gothic", 20, FontStyle.Italic), Brushes.Blue, new Point(230, 230));




        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            displayBills();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Con.Open();
            string query = "Select ProdName, ProdQty From ProductTbl Where ProdCat='" + SearchCb.SelectedValue.ToString() + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var table = new DataSet();
            adapter.Fill(table);
            SellingDGV.DataSource = table.Tables[0];
            Con.Close();
        }


        private void fillCombo()
        {
            //This method will bind the Combobox with the Database
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select CatName From CategoryTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatName", typeof(string));
            dt.Load(rdr);
            SearchCb.ValueMember = "catName";
            SearchCb.DataSource = dt;
            Con.Close();

        }

        private void logOutLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomeForm login = new WelcomeForm();
            login.Show();
        }

        private void productsButton_Click(object sender, EventArgs e)
        {
            ProductsForm products = new ProductsForm();
            products.Show();
            this.Hide();
        }

        private void sellersButton_Click(object sender, EventArgs e)
        {
            SellerForm seller = new SellerForm();
            seller.Show();
            this.Hide();
        }

        private void categories2Button_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            category.Show();
            this.Hide();

        }
    }
}
