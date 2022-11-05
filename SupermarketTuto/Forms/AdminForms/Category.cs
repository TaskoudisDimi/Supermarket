using SupermarketTuto.DataAccess;
using SupermarketTuto.Forms.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketTuto.Forms
{
    public partial class Category : Form
    {

        private int rowIndex = 0;

        public Category()
        {
            InitializeComponent();
        }


        private void display()
        {

            SqlConnect loaddata = new SqlConnect();

            loaddata.retrieveData("Select * From CategoryTbl where Date between '" + fromDateTimePicker.Value.ToString("MM-dd-yyyy") + "' and '" + toDateTimePicker.Value.ToString("MM-dd-yyyy") + "'");
            //loaddata.retrieveData("Select * From CategoryTbl");
            CatDGV.DataSource = loaddata.table;
            CatDGV.RowHeadersVisible = false;
            totalLabel.Text = $"Total: {CatDGV.RowCount}";
        }

        private void mnuDelete_Click(object? sender, EventArgs e)
        {
            //SqlConnect loaddata2 = new SqlConnect();

            //loaddata2.commandExc("Delete From CategoryTbl Where CatId='" + CatIdTb.Text + "'");

            //foreach (DataGridViewRow row in CatDGV.SelectedRows)
            //{
            //    CatDGV.Rows.RemoveAt(row.Index);

            //}
        }

        private void logOutLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn login = new LogIn();
            login.Show();
        }

        private void Category_Load(object sender, EventArgs e)
        {
            display();
            ContextMenuStrip mnu = new ContextMenuStrip();
            ToolStripMenuItem mnuDelete = new ToolStripMenuItem("Delete");
            mnuDelete.Click += new EventHandler(mnuDelete_Click);
            mnu.Items.AddRange(new ToolStripItem[] { mnuDelete });
            CatDGV.ContextMenuStrip = mnu;
        }

        private void CatDGV_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Right)
            //{
            //    this.CatDGV.Rows[e.RowIndex].Selected = true;
            //    this.rowIndex = e.RowIndex;
            //    this.CatDGV.CurrentCell = this.CatDGV.Rows[e.RowIndex].Cells[1];
            //    this.contextMenuStrip1.Show(this.CatDGV, e.Location);
            //    contextMenuStrip1.Show(Cursor.Position);
            //}
        }

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



        private void refreshButton_Click(object sender, EventArgs e)
        {
            display();

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addEditCategory add = new addEditCategory();
            add.editButton.Visible = false;
            add.CatIdTb.Visible = false;
            add.idlabel.Visible = false;
            add.Show();
            refresh_data();


        }

        private void editButton_Click(object sender, EventArgs e)
        {
            addEditCategory edit = new addEditCategory();
            edit.CatIdTb.Text = CatDGV.CurrentRow.Cells[0].Value.ToString();
            edit.CatNameTb.Text = CatDGV.CurrentRow.Cells[1].Value.ToString();
            edit.CatDescTb.Text = CatDGV.CurrentRow.Cells[2].Value.ToString();
            edit.dateTimePicker.Text = CatDGV.CurrentRow.Cells[3].Value.ToString();
            edit.addButton.Visible = false;
            edit.CatIdTb.ReadOnly = true;
            edit.Show();
            refresh_data();

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            SqlConnect loaddata5 = new SqlConnect();
            try
            {

                loaddata5.commandExc("Delete From CategoryTbl Where CatId=" + CatDGV.CurrentRow.Cells[0].Value.ToString());
                refresh_data();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SqlConnect db_sellers = new SqlConnect();
            string query = "Select * From CategoryTbl where CatId like '%" + searchTextBox.Text + "%'" + "or CatName like '%" + searchTextBox.Text + "%'" + "or CatDesc like '%" + searchTextBox.Text + "%'";
            db_sellers.search(searchTextBox.Text, query);
            CatDGV.DataSource = db_sellers.table;
            totalLabel.Text = $"Total: {CatDGV.RowCount}";
        }


        private void fromDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            refresh_data();
        }

        private void refresh_data()
        {
            SqlConnect loaddata21 = new SqlConnect();
            loaddata21.retrieveData("Select * from CategoryTbl");
            CatDGV.DataSource = loaddata21.table;
            CatDGV.RowHeadersVisible = false;
        }

        private void toDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            refresh_data();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            SqlConnect db_sellers = new SqlConnect();
            string query = "Select * From CategoryTbl where CatId like '%" + searchTextBox.Text + "%'" + "or CatName like '%" + searchTextBox.Text + "%'" + "or CatDesc like '%" + searchTextBox.Text + "%'";
            db_sellers.search(searchTextBox.Text, query);
            CatDGV.DataSource = db_sellers.table;
            totalLabel.Text = $"Total: {CatDGV.RowCount}";
        }
    }
}
