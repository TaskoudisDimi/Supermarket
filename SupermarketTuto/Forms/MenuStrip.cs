using SupermarketTuto.Forms.General;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public class MenuStrip
    {
        public static MenuStrip instance = null;
        public static readonly object padlock = new object();
        private DataGridView dataGridView = new DataGridView();
        private DataTable table = new DataTable();
        private Type type;
        public static MenuStrip Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new MenuStrip();
                    }
                }
                return instance;
            }
        }


        public void Menu(DataGridView data, DataTable table_, Type type_, bool haveSelected)
        {
            dataGridView = data;
            table = table_;
            type = type_;
            ContextMenuStrip menu = new ContextMenuStrip();
            ToolStripMenuItem editMenu = new ToolStripMenuItem("Edit");
            ToolStripMenuItem deleteMenu = new ToolStripMenuItem("Delete");
            if (haveSelected)
            {
                ToolStripMenuItem selectedProdctsMenu = new ToolStripMenuItem("Selected Products");
                editMenu.Click += new EventHandler(mnuEdit_Click);
                deleteMenu.Click += new EventHandler(deleteMenu_Click);
                deleteMenu.Click += new EventHandler(selectedProdctsMenu_Click);
                menu.Items.AddRange(new ToolStripItem[] { editMenu, deleteMenu, selectedProdctsMenu });
                data.ContextMenuStrip = menu;
            }
            else
            {
                editMenu.Click += new EventHandler(mnuEdit_Click);
                deleteMenu.Click += new EventHandler(deleteMenu_Click);
                menu.Items.AddRange(new ToolStripItem[] { editMenu });
                data.ContextMenuStrip = menu;
            }
        }


        private void deleteMenu_Click(object sender, EventArgs e)
        {
            List<DataRow> rowsToDelete = new List<DataRow>();
            // loop over the selected rows and add them to the list
            foreach (DataGridViewRow selectedRow in dataGridView.SelectedRows)
            {
                //Convert DataGridViewRow -> DataRow
                DataRow row = ((DataRowView)selectedRow.DataBoundItem).Row;
                rowsToDelete.Add(row);
            }
            // loop over the rows to delete and remove them from the DataTable
            foreach (DataRow row in rowsToDelete)
            {
                table.Rows.Remove(row);
            }
            //DataAccess.Instance.DeleteData(table);
            
        }

        private void mnuEdit_Click(object sender, EventArgs e)
        {
            if (type.Name == "Categories")
            {
                DataGridViewRow currentRow = dataGridView.CurrentRow;
                addEditCategory edit = new addEditCategory(table, currentRow, false);
                edit.CatIdTb.ReadOnly = true;
                edit.Show();
            }
            else if (type.Name == "Products")
            {
                DataGridViewRow currentRow = dataGridView.CurrentRow;
                addEditProduct edit = new addEditProduct(table, currentRow, false);
                edit.ProdId.ReadOnly = true;
                edit.Show();
            }
            else if (type.Name == "Sellers")
            {

            }
            else if (type.Name == "Bills")
            {

            }
            else if (type.Name == "Admins")
            {


            }
            else if (type.Name == "BillingProducts")
            {

            }
        }


        private void selectedProdctsMenu_Click(object sender, EventArgs e)
        {
            try
            {
                //List<int> cats = new List<int>();
                //for (int i = 0; i < CatDGV.Rows.Count; i++)
                //{
                //    if (Convert.ToBoolean(CatDGV.Rows[i].Cells[0].Value))
                //    {
                //        cats.Add((int)CatDGV.Rows[i].Cells[1].Value);
                //    }
                //}
                //if (cats.Count != 0)
                //{
                //    SelectedProducts frm = new SelectedProducts(cats);
                //    frm.Show();
                //}
            }
            catch
            {

            }
        }


    }
}
