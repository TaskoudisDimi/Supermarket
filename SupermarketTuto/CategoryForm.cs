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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void exit2Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Ορίζω το connectrion string
        //SqlConnection Con = new SqlConnection(@"Data Source=DIMITRISTASKOUD\DIMITRIS_TASKOUD;Initial Catalog=smarketdb;Integrated Security=True");
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-FF268DF\SQLEXPRESS;Initial Catalog=smarketdb;Integrated Security=True");


        private void add3Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatIdTb.Text == "" || CatNameTb.Text == "" || CatDescTb.Text == "")
                {
                    MessageBox.Show("Select The Category to Delete");
                }
                else
                {
                    //Open connection
                    Con.Open();
                    //Set squery to execute 
                    string query = "Insert Into CategoryTbl values(" + CatIdTb.Text + ",'" + CatNameTb.Text + "','" + CatDescTb.Text + "')";
                    //
                    SqlCommand cmd = new SqlCommand(query, Con);
                    //
                    cmd.BeginExecuteNonQuery();
                    MessageBox.Show("Category added successfuly");
                    //Close connection
                    Con.Close();
                    //display();
                    CatIdTb.Text = "";
                    CatNameTb.Text = "";
                    CatDescTb.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Method 
        private void display()
        {
            Con.Open();
            string query = "Select * From CategoryTbl;";
            //A SqlDataReader is a type that is good for reading data in the most efficient manner possible
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            //The SqlCommandBuilder can be used to build and execute SQL queries based on the select command that you will supply.
            //It provides the feature of reflecting the changes made to a DataSet or an instance of the SQL server data.
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            //DataSet is a disconnected architecture it represents the data in table structure which means the data into rows and columns.
            //Dataset is the local copy of your database which exists in the local system and makes the application execute faster and reliable.
            var table = new DataSet();
            sda.Fill(table);
            //The DataSource property allows data binding on Windows Forms controls. With it we bind an array to a ListBox on the screen—and display all the strings.
            //As changes are made to the List, we update the control on the screen.
            CatDGV.DataSource = table.Tables[0];
            Con.Close();

        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            display();
        }

        private void CatDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CatIdTb.Text = CatDGV.SelectedRows[0].Cells[0].Value.ToString();
            CatNameTb.Text = CatDGV.SelectedRows[0].Cells[1].Value.ToString();
            CatDescTb.Text = CatDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void delete3Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatIdTb.Text == "" || CatNameTb.Text == "" || CatDescTb.Text == "")
                {
                    MessageBox.Show("Select The Category to Delete");
                }
                else
                {
                    Con.Open();
                    string query = "Delete From CategoryTbl Where CatId=" + CatIdTb.Text + "";
                    //A SqlCommand object allows you to query and send commands to a database.
                    //It has methods that are specialized for different commands.
                    //The ExecuteReader method returns a SqlDataReader object for viewing the results of a select query.
                    //For insert, update, and delete SQL commands, you use the ExecuteNonQuery method.
                    SqlCommand cmd = new SqlCommand(query, Con);
                    //Use this operation to execute any arbitrary SQL statements in SQL Server if you do not want any result set to be returned.
                    //You can use this operation to create database objects or change data in a database by executing UPDATE, INSERT, or DELETE statements.
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted Successfully");
                    Con.Close();
                    display();
                    Con.Close();
                    display();
                    CatIdTb.Text = "";
                    CatNameTb.Text = "";
                    CatDescTb.Text = "";


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void edit3Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatIdTb.Text == "" || CatNameTb.Text == "" || CatDescTb.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    SqlConnect loaddata = new SqlConnect();

                    loaddata.commandExc("Update CategoryTbl set CatName='" + CatNameTb.Text + "',CatDesc='" + CatDescTb.Text + "' where CatId=" + CatIdTb.Text + ";");

                   
                    display();
                    CatIdTb.Text = "";
                    CatNameTb.Text = "";
                    CatDescTb.Text = "";


                    
                   


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void productsButton_Click(object sender, EventArgs e)
        {
            //Show() method shows a windows form in a non-modal state.
            //ShowDialog() method shows a window in a modal state and stops execution of the calling context
            //until a result is returned from the windows form open by the method.
            ProductsForm productForm = new ProductsForm();
            productForm.Show();
            this.Hide();
        }

        private void sellersButton_Click(object sender, EventArgs e)
        {
            SellerForm sellerForm = new SellerForm();
            sellerForm.Show();
            this.Hide();

        }

        private void selling2Button_Click(object sender, EventArgs e)
        {
            SellingForm selling = new SellingForm();
            selling.Show();
            this.Hide();
        }

        private void logOutLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomeForm login = new WelcomeForm();
            login.Show();
        }
    }
}



