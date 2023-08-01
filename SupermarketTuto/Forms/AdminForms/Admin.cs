using ClassLibrary1;
using ClassLibrary1.Models;
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
    public partial class Admin : Form
    {
        DataTable adminTable = new DataTable();
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            try
            {
                adminTable = DataAccess.Instance.GetTable("Admin");
                usersDataGridView.DataSource = adminTable;
                usersDataGridView.RowHeadersVisible = false;
            }
            catch
            {

            }
            
        }

        private void usersDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.Value != null)
            {
                e.Value = new string('*', e.Value.ToString().Length);
            }
        }

       


    }
}
