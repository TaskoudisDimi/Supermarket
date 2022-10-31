using SupermarketTuto.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketTuto.Forms
{
    public partial class CreateBill : Form
    {
        public CreateBill()
        {
            InitializeComponent();
        }

        private void addProduct_Load(object sender, EventArgs e)
        {
            displayBills();

        }


        private void displayBills()
        {
            SqlConnect loaddata2 = new SqlConnect();
            loaddata2.retrieveData("Select * From BillTbl;");
            BillsDGV.DataSource = loaddata2.table;
            BillsDGV.AllowUserToAddRows = false;
            BillsDGV.RowHeadersVisible = false;
            total3Label.Text = $"Total: {BillsDGV.RowCount}";

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            SqlConnect loaddata6 = new SqlConnect();
            loaddata6.commandExc("Delete From BillTbl Where BillId=" + BillsDGV.CurrentRow.Cells[0].Value.ToString() + "");
            foreach (DataGridViewRow row in BillsDGV.Rows)
            {
                BillsDGV.Rows.RemoveAt(row.Index);
            }
        }

        private void refreshBillsButton_Click(object sender, EventArgs e)
        {
            displayBills();

        }

        private void billButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnect loaddata4 = new SqlConnect();

                //loaddata4.commandExc("Insert Into BillTbl values('" + commentsRichTextBox.Text + "','" + seller_Name_Label.Text + "','" + LabelDate.Text + "'," + AmountLabel.Text + ")");
                commentsRichTextBox.Text = String.Empty;
                displayBills();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
