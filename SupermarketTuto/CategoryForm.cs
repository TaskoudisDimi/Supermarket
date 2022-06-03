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

        SqlConnect loaddata = new SqlConnect();


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

        //Method 
        private void display()
        {
            //COMMENTS//
            //Con.Open();
            //string query = "Select * From CategoryTbl;";
            ////A SqlDataReader is a type that is good for reading data in the most efficient manner possible
            //SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            ////The SqlCommandBuilder can be used to build and execute SQL queries based on the select command that you will supply.
            ////It provides the feature of reflecting the changes made to a DataSet or an instance of the SQL server data.
            //SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            ////DataSet is a disconnected architecture it represents the data in table structure which means the data into rows and columns.
            ////Dataset is the local copy of your database which exists in the local system and makes the application execute faster and reliable.
            //var table = new DataSet();
            //sda.Fill(table);
            ////The DataSource property allows data binding on Windows Forms controls. With it we bind an array to a ListBox on the screen—and display all the strings.
            ////As changes are made to the List, we update the control on the screen.
            //CatDGV.DataSource = table.Tables[0];
            //Con.Close();


            loaddata.retrieveData("Select * From CategoryTbl");
            CatDGV.DataSource = loaddata.table;


        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            display();

        }

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



                    loaddata.commandExc("Insert Into CategoryTbl values(" + CatIdTb.Text + ",'" + CatNameTb.Text + "','" + CatDescTb.Text + "')");
                    MessageBox.Show("Success!");
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
                    //Con.Open();
                    //string query = "Delete From CategoryTbl Where CatId=" + CatIdTb.Text + "";
                    ////A SqlCommand object allows you to query and send commands to a database.
                    ////It has methods that are specialized for different commands.
                    ////The ExecuteReader method returns a SqlDataReader object for viewing the results of a select query.
                    ////For insert, update, and delete SQL commands, you use the ExecuteNonQuery method.
                    //SqlCommand cmd = new SqlCommand(query, Con);
                    ////Use this operation to execute any arbitrary SQL statements in SQL Server if you do not want any result set to be returned.
                    ////You can use this operation to create database objects or change data in a database by executing UPDATE, INSERT, or DELETE statements.
                    //cmd.ExecuteNonQuery();

                    //Con.Close();
                    //display();
                    //Con.Close();
                    loaddata.commandExc("Delete From CategoryTbl Where CatId='" + CatIdTb.Text + "'");

                    MessageBox.Show("Category Deleted Successfully");
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

        private void logOutLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn login = new LogIn();
            login.Show();
        }

        private int rowIndex = 0;
        private void CatDGV_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.CatDGV.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.CatDGV.CurrentCell = this.CatDGV.Rows[e.RowIndex].Cells[1];
                this.contextMenuStrip1.Show(this.CatDGV, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            if (!this.CatDGV.Rows[this.rowIndex].IsNewRow)
            {
                this.CatDGV.Rows.RemoveAt(this.rowIndex);
            }
        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!this.CatDGV.Rows[this.rowIndex].IsNewRow)
            {
                this.CatDGV.Rows.RemoveAt(this.rowIndex);
            }
        }

        //Show dialogResult after press X button on Form
        private void CategoryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Confirm to close", "Exit", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


        //Εμφανίζεται όταν ένα κελί χάνει την εστίαση εισόδου, επιτρέποντας την επικύρωση περιεχομένου.
        private void CatDGV_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //CatDGV.Rows[e.RowIndex].ErrorText = "";
            //int newInteger;

            //// Don't try to validate the 'new row' until finished 
            //// editing since there
            //// is not any point in validating its initial value.
            //if (CatDGV.Rows[e.RowIndex].IsNewRow) { return; }
            //if (!int.TryParse(e.FormattedValue.ToString(),
            //    out newInteger) || newInteger < 0)
            //{
            //    e.Cancel = true;
            //    CatDGV.Rows[e.RowIndex].ErrorText = "the value must be a non-negative integer";
            //}
        }

        private void CatDGV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            display();
        }

        private void CatDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CatIdTb.Text = CatDGV.SelectedRows[0].Cells[0].Value.ToString();
            CatNameTb.Text = CatDGV.SelectedRows[0].Cells[1].Value.ToString();
            CatDescTb.Text = CatDGV.SelectedRows[0].Cells[2].Value.ToString();
        }
    }
}



