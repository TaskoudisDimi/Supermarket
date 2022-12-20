using DataClass;
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
    public partial class SellersForm : Form
    {
        public SellersForm()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            SqlConnect loaddata = new SqlConnect();
            loaddata.retrieveData("Select * From SellerTbl");
            usersDataGridView.DataSource = loaddata.table;
            usersDataGridView.RowHeadersVisible = false;
        }

       
    }
}
