using ClassLibrary1.Models;
using SupermarketTuto.Forms;
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
        private DataTable tableSecond = new DataTable();
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

        public void Menu(DataGridView data, DataTable table_, DataTable tableSecond_, Type type_, bool haveSelected)
        {
            dataGridView = data;
            table = table_;
            type = type_;
            tableSecond = tableSecond_;
            ContextMenuStrip menu = new ContextMenuStrip();
            ToolStripMenuItem editMenu = new ToolStripMenuItem("Edit");
            ToolStripMenuItem deleteMenu = new ToolStripMenuItem("Delete");
            if (haveSelected)
            {
                ToolStripMenuItem selectedProdctsMenu = new ToolStripMenuItem("Selected Products");
                editMenu.Click += new EventHandler(mnuEdit_Click);
                deleteMenu.Click += new EventHandler(deleteMenu_Click);
                selectedProdctsMenu.Click += new EventHandler(selectedProdctsMenu_Click);
                menu.Items.AddRange(new ToolStripItem[] { editMenu, deleteMenu, selectedProdctsMenu });
                data.ContextMenuStrip = menu;
            }
            else
            {
                editMenu.Click += new EventHandler(mnuEdit_Click);
                deleteMenu.Click += new EventHandler(deleteMenu_Click);
                menu.Items.AddRange(new ToolStripItem[] { editMenu, deleteMenu });
                data.ContextMenuStrip = menu;
            }
        }

        private void deleteMenu_Click(object sender, EventArgs e)
        {
            List<DataRow> rowsToDelete = new List<DataRow>();
            foreach (DataGridViewRow selectedRow in dataGridView.SelectedRows)
            {
                DataRow row = ((DataRowView)selectedRow.DataBoundItem).Row;
                rowsToDelete.Add(row);
            }
            foreach (DataRow row in rowsToDelete)
            {
                if (type.Name == "CategoryTbl")
                {
                    CategoryTbl item = new CategoryTbl();
                    item.CatId = Convert.ToInt32(row["CatId"]);
                    if (DataModel.Delete(item) > 0)
                    {
                        MessageBox.Show("Sucessfully deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        table.Rows.Remove(row);
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (type.Name == "ProductTbl")
                {
                    ProductTbl item = new ProductTbl();
                    item.ProdId = Convert.ToInt32(row["ProdId"]);
                    if (DataModel.Delete(item) > 0)
                    {
                        MessageBox.Show("Sucessfully deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        table.Rows.Remove(row);
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (type.Name == "SellersTbl")
                {
                    SellersTbl item = new SellersTbl();
                    item.SellerId = Convert.ToInt32(row["SellerId"]);
                    if (DataModel.Delete(item) > 0)
                    {
                        MessageBox.Show("Sucessfully deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        table.Rows.Remove(row);
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else if (type.Name == "BillTbl")
                {
                    BillTbl item = new BillTbl();
                    item.BillId = Convert.ToInt32(row["BillId"]);
                    if (DataModel.Delete(item) > 0)
                    {
                        MessageBox.Show("Sucessfully deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        table.Rows.Remove(row);
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (type.Name == "Admins")
                {
                    Admins item = new Admins();
                    item.Id = Convert.ToInt32(row["Id"]);
                    if (DataModel.Delete(item) > 0)
                    {
                        MessageBox.Show("Sucessfully deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        table.Rows.Remove(row);
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }

        }

        private void mnuEdit_Click(object sender, EventArgs e)
        {
            if (type.Name == "CategoryTbl")
            {
                DataGridViewRow currentRow = dataGridView.CurrentRow;
                addEditCategory edit = new addEditCategory(table, currentRow, false);
                edit.CatIdTb.ReadOnly = true;
                edit.Show();
            }
            else if (type.Name == "ProductTbl")
            {
                DataGridViewRow currentRow = dataGridView.CurrentRow;
                addEditProduct edit = new addEditProduct(table, currentRow, tableSecond, false);
                edit.ProdId.ReadOnly = true;
                edit.Show();
            }
            else if (type.Name == "SellersTbl")
            {
                DataGridViewRow currentRow = dataGridView.CurrentRow;
                addEditSeller edit = new addEditSeller(table, currentRow, false);
                edit.SellId.ReadOnly = true;
                edit.Show();

            }
            else if (type.Name == "BillTbl")
            {
                DataGridViewRow currentRow = dataGridView.CurrentRow;
                AddEditBill edit = new AddEditBill(table, currentRow, false, null, null, null);
                edit.Show();
            }
            else if (type.Name == "Admins")
            {
                DataGridViewRow currentRow = dataGridView.CurrentRow;
                addEditAdmin edit = new addEditAdmin(table, currentRow, false);
                edit.AdminIdTb.ReadOnly = true;
                edit.Show();
            }
        }

        private void selectedProdctsMenu_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch
            {

            }
        }

    }
}
