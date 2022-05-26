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
using SupermarketTuto.DataAccess;

namespace SupermarketTuto
{
    public partial class ProductsForm : Form
    {

        SqlConnect loaddata = new SqlConnect();

        public ProductsForm()
        {
            InitializeComponent();
        }

        ////SqlConnection Con = new SqlConnection(@"Data Source=DIMITRISTASKOUD\DIMITRIS_TASKOUD;Initial Catalog=smarketdb;Integrated Security=True");
        //SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-FF268DF\SQLEXPRESS;Initial Catalog=smarketdb;Integrated Security=True");

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fillCombo()
        {
            //This method will bind the Combobox with the Database
            //Con.Open();
            //SqlCommand cmd = new SqlCommand("Select CatName From CategoryTbl", Con);
            //SqlDataReader rdr;
            //rdr = cmd.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Columns.Add("CatName", typeof(string));
            //dt.Load(rdr);
            //CatCb.ValueMember = "catName";
            //CatCb.DataSource = dt;
            //Con.Close();
            loaddata.retrieveData("Select CatName From CategoryTbl");
            CatCb.DataSource = loaddata.table;
            CatCb.ValueMember = "catName";

        }

        private void display()
        {
            //Con.Open();
            //string query = "Select * from ProductTbl;";
            //SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            //SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            //var table = new DataSet();
            //adapter.Fill(table);
            //ProdDGV.DataSource = table.Tables[0];
            //Con.Close();

            loaddata.retrieveData("Select * From ProductTbl");
            ProdDGV.DataSource = loaddata.table;


        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            fillCombo();
            display();
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
                    //Con.Open();
                    //string query = "Insert Into ProductTbl values(" + ProdId.Text + ",'" + ProdName.Text + "'," + ProdQty.Text + "," + ProdPrice.Text + ",'" + CatCb.SelectedValue.ToString() + "')";
                    //SqlCommand cmd = new SqlCommand(query, Con);
                    //cmd.BeginExecuteNonQuery();
                    //MessageBox.Show("Product added successfuly");
                    //Con.Close();

                    loaddata.commandExc("Insert Into ProductTbl values(" + ProdId.Text + ",'" + ProdName.Text + "'," + ProdQty.Text + "," + ProdPrice.Text + ",'" + CatCb.SelectedValue.ToString() + "')");

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
                    //Con.Open();
                    //string query = "Update ProductTbl set ProdName='" + ProdName.Text + "',ProdQty='" + ProdQty.Text + "',ProdPrice='" + ProdPrice.Text + "' where ProdId=" + ProdId.Text + ";";
                    //SqlCommand cmd = new SqlCommand(query, Con);
                    //cmd.ExecuteNonQuery();
                    //MessageBox.Show("Product Successfully Updated");
                    //Con.Close();

                    loaddata.commandExc("Update ProductTbl set ProdName='" + ProdName.Text + "',ProdQty='" + ProdQty.Text + "',ProdPrice='" + ProdPrice.Text + "' where ProdId=" + ProdId.Text + ";");

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
                    //Con.Open();
                    //string query = "Delete From ProductTbl Where ProdId=" + ProdId.Text + "";
                    //SqlCommand cmd = new SqlCommand(query, Con);
                    //cmd.ExecuteNonQuery();
                    //MessageBox.Show("Product Deleted Successfully");
                    //Con.Close();

                    loaddata.commandExc("Delete From ProductTbl Where ProdId=" + ProdId.Text + "");

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



        private void CatCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void selectCategory2ComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Con.Open();
            //string query = "Select * from ProductTbl Where ProdCat='" + selectCategory2ComboBox.SelectedValue.ToString();
            //SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            //SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            //var table = new DataSet();
            //adapter.Fill(table);
            //ProdDGV.DataSource = table.Tables[0];
            //Con.Close();

            loaddata.retrieveData("Select * from ProductTbl Where ProdCat='" + selectCategory2ComboBox.SelectedValue.ToString());
            ProdDGV.DataSource = loaddata.table;


        }

        private void CatCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Con.Open();
            //string query = "Select * from ProductTbl Where ProdCat='" + CatCb.SelectedValue.ToString() + "'";
            //SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            //SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            //var table = new DataSet();
            //adapter.Fill(table);
            //ProdDGV.DataSource = table.Tables[0];
            //Con.Close();

            loaddata.retrieveData("Select * from ProductTbl Where ProdCat='" + CatCb.SelectedValue.ToString() + "'");
            ProdDGV.DataSource = loaddata.table;


        }

        private void sellerButton_Click(object sender, EventArgs e)
        {
            SellerForm sellerForm = new SellerForm();
            sellerForm.Show();
            this.Hide();

        }


        private void logOutLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn login = new LogIn();
            login.Show();
        }

        private void categoriesButton_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.Show();
            this.Hide();
        }

        //TODO export excel
        //TODO import txt, excel
        //TODO right click in datagridview


    }
}


