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


namespace SupermarketTuto
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }

        //SqlConnection Con = new SqlConnection(@"Data Source=DIMITRISTASKOUD\DIMITRIS_TASKOUD;Initial Catalog=smarketdb;Integrated Security=True");
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-FF268DF\SQLEXPRESS;Initial Catalog=smarketdb;Integrated Security=True");

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            CatCb.ValueMember = "catName";
            CatCb.DataSource = dt;
            Con.Close();

        }

        private void display()
        {
            Con.Open();
            string query = "Select * from ProductTbl;";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var table = new DataSet();
            adapter.Fill(table);
            ProdDGV.DataSource = table.Tables[0];
            Con.Close();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            fillCombo();
            display();
        }

        private void categoriesButton_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.Show();
            this.Hide();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProdId.Text == "" || ProdName.Text == "" || ProdQty.Text == "" || ProdPrice.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "Insert Into ProductTbl values(" + ProdId.Text + ",'" + ProdName.Text + "'," + ProdQty.Text + "," + ProdPrice.Text + ",'" + CatCb.SelectedValue.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.BeginExecuteNonQuery();
                    MessageBox.Show("Product added successfuly");
                    Con.Close();
                    ProdId.Text = "";
                    ProdName.Text = "";
                    ProdQty.Text = "";
                    ProdPrice.Text = "";
                    CatCb.SelectedValue = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProdId.Text == "" || ProdName.Text == "" || ProdQty.Text == "" || ProdPrice.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "Update ProductTbl set ProdName='" + ProdName.Text + "',ProdQty='" + ProdQty.Text + "',ProdPrice='" + ProdPrice.Text + "' where ProdId=" + ProdId.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Successfully Updated");
                    Con.Close();
                    ProdId.Text = "";
                    ProdName.Text = "";
                    ProdQty.Text = "";
                    ProdPrice.Text = "";
                    CatCb.SelectedValue = "";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProdId.Text == "")
                {
                    MessageBox.Show("Select The Category to Delete");
                }
                else
                {
                    Con.Open();
                    string query = "Delete From ProductTbl Where ProdId=" + ProdId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted Successfully");
                    Con.Close();
                    ProdId.Text = "";
                    ProdName.Text = "";
                    ProdQty.Text = "";
                    ProdPrice.Text = "";
                    CatCb.SelectedValue = "";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProdDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdId.Text = ProdDGV.SelectedRows[0].Cells[0].Value.ToString();
            ProdName.Text = ProdDGV.SelectedRows[0].Cells[1].Value.ToString();
            ProdQty.Text = ProdDGV.SelectedRows[0].Cells[2].Value.ToString();
            ProdPrice.Text = ProdDGV.SelectedRows[0].Cells[3].Value.ToString();
            CatCb.SelectedValue = ProdDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void selectCategory2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sellerButton_Click(object sender, EventArgs e)
        {
            SellerForm sellerForm = new SellerForm();
            sellerForm.Show();
            this.Hide();

        }

        private void sellingButton_Click(object sender, EventArgs e)
        {
            SellingForm selling = new SellingForm();
            selling.Show();
            this.Hide();
        }

        private void CatCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void selectCategory2ComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Con.Open();
            string query = "Select * from ProductTbl Where ProdCat='" + selectCategory2ComboBox.SelectedValue.ToString();
            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var table = new DataSet();
            adapter.Fill(table);
            ProdDGV.DataSource = table.Tables[0];
            Con.Close();
        }

        private void CatCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Con.Open();
            string query = "Select * from ProductTbl Where ProdCat='" + CatCb.SelectedValue.ToString() + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var table = new DataSet();
            adapter.Fill(table);
            ProdDGV.DataSource = table.Tables[0];
            Con.Close();
        }

        private void logOutLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomeForm login = new WelcomeForm();
            login.Show();
        }
    }
}


