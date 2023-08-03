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

namespace SupermarketTuto.Forms.AdminForms
{
    public partial class SelectedProducts : Form
    {
        public string selectedCatIDs;
        public SelectedProducts(List<int> CatIds)
        {
            InitializeComponent();
            List<string> strings = CatIds.ConvertAll<string>(x => x.ToString());
            selectedCatIDs = String.Join(", ", strings);
        }

        private void SelectedProducts_Load(object sender, EventArgs e)
        {
            //SqlConnect loaddata2 = new SqlConnect();
            //loaddata2.getData("Select * From ProductTbl where ProdCatID in (" + selectedCatIDs + ")");
            //selectedDGV.DataSource = loaddata2.table;
            //selectedDGV.RowHeadersVisible = false;

        }
    }
}
