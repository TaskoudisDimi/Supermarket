using ClassLibrary1.Models;
using ClassLibrary1;
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
        private List<string> catIDs = new List<string>();
        public SelectedProducts(List<string> catIDs)
        {
            InitializeComponent();
            this.Icon = new System.Drawing.Icon("C:/Users/chris/Desktop/Dimitris/Tutorials/Supermarket/SupermarketTuto/Resources/supermarket.ico");
            this.catIDs = catIDs;
        }
        StringBuilder sb = new StringBuilder();
        private void SelectedProducts_Load(object sender, EventArgs e)
        {
            if(catIDs.Count > 0)
            {
                foreach(string item in catIDs)
                {
                    sb.Append($"ProdCatID = {item} or ");
                }
                string cmd = sb.ToString();
                cmd = cmd.ToString().TrimEnd(' ', 'o', 'r');
                List<ProductTbl> products = DataModel.Select<ProductTbl>(where: cmd);
                SelectedProdDGV.DataSource = products;
                SelectedProdDGV.RowHeadersVisible = false;
                SelectedProdDGV.ReadOnly = false;
            }

        }
    }
}
