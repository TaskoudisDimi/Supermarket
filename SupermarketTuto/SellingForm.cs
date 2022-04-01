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

        private void SellingForm_Load(object sender, EventArgs e)
        {
            display();
        }

        private void SellingDGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SellingProdName.Text = SellingDGV.SelectedRows[0].Cells[0].Value.ToString();
            SellingPrice.Text = SellingDGV.SelectedRows[0].Cells[1].Value.ToString();
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
                RsLabel.Text = "Rs " + GrdTotal;
            }

        }
    }
}
