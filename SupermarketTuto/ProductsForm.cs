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
       

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fillCombo()
        {
            //This method will bind the Combobox with the Database
            loaddata.retrieveData("Select CatName From CategoryTbl");
            CatCb.DataSource = loaddata.table;
            CatCb.ValueMember = "catName";

            selectCategory2ComboBox.DataSource = loaddata.table;
            selectCategory2ComboBox.ValueMember = "catName";

        }

        private void display()
        {

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
                    loaddata.commandExc("Insert Into ProductTbl values(" + ProdId.Text + ",'" + ProdName.Text + "'," + ProdQty.Text + "," + ProdPrice.Text + ",'" + CatCb.SelectedValue.ToString() + "')");
                    MessageBox.Show("Product Successfully Insert");
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

                    loaddata.commandExc("Update ProductTbl set ProdName='" + ProdName.Text + "',ProdQty='" + ProdQty.Text + "',ProdPrice='" + ProdPrice.Text + "' where ProdId=" + ProdId.Text + ";");
                    MessageBox.Show("Product Successfully Updated");
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

            loaddata.retrieveData("Select * from ProductTbl Where ProdCat='" + selectCategory2ComboBox.SelectedValue.ToString());
            ProdDGV.DataSource = loaddata.table;


        }

        private void CatCb_SelectionChangeCommitted(object sender, EventArgs e)
        {

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

        private void ProductsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Confirm to close", "Exit", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (confirm == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        //TODO export excel
        //TODO import txt, excel
        //TODO right click in datagridview


    }
}


