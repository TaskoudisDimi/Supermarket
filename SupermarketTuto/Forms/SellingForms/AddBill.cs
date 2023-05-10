using ClassLibrary1;
using ClassLibrary1.Models;
using DataClass;
using SupermarketTuto.Utils;
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
    public partial class AddBill : Form
    {
        string TotalAmount = "";
        DataTable billTable = new DataTable();
        BindingSource billBindingSource = new BindingSource();
        Type BillType = typeof(Bills);


        public AddBill(string TotalAmount_)
        {
            InitializeComponent();
            TotalAmount = TotalAmount_;
        }

        private void addProduct_Load(object sender, EventArgs e)
        {
            displayBills();
            LabelDate.Text = DateTime.Now.ToString();
            seller_Name_Label.Text = Globals.NameOfSeller;
        }

        private void displayBills()
        {
            billTable = DataAccess.Instance.GetTable("BillTbl");


        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            
        }

       

        private void billButton_Click(object sender, EventArgs e)
        {
            try
            {
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region ChechDatabase
        private void check()
        {
            SqlConnect sql = new SqlConnect();
            var customerType = typeof(Bills);
            sql.checkTable(Categories: customerType);
        }

        #endregion
    }
}
