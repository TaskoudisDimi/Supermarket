using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketTuto
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            label1.Text = "This is an application for the management of people and products, categories, " +
                "and bills of a Supermarket.\r\nIncludes two different types of forms. " +
                "Those used by administrators and those used by sellers:\r\nAdministrators can do some operations " +
                "in the database (cleaning, restoring, etc.), create/update/delete sellers, and monitor products " +
                "and categories.\r\nSellers can manage products, categories, and bill products.\r\nAlso, most forms have " +
                "the ability to export and import files (csv, xlsx). For data entry an API is called so that some products are " +
                "entered automatically.\r\nFinally, the API has been created so that it can receive or " +
                "send information to some third party software.";
        }
    }
}
