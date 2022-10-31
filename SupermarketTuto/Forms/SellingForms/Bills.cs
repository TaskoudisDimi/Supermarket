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

namespace SupermarketTuto.Forms.SellingForms
{
    public partial class Bills : Form
    {
        public Bills()
        {
            InitializeComponent();
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

        private void Bills_Load(object sender, EventArgs e)
        {
            displayBills();

        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("FamilySuperMarket", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics.DrawString("Bill ID: " + BillsDGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Blue, new Point(100, 70));
            e.Graphics.DrawString("Seller Name: " + BillsDGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Blue, new Point(100, 100));
            e.Graphics.DrawString("Date: " + BillsDGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Blue, new Point(100, 130));
            e.Graphics.DrawString("Total Amount: " + BillsDGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Blue, new Point(100, 160));
            e.Graphics.DrawString("Code Space", new Font("Century Gothic", 20, FontStyle.Italic), Brushes.Blue, new Point(230, 230));

        }

        private void refreshBillsButton_Click(object sender, EventArgs e)
        {
            displayBills();

        }
    }
}
