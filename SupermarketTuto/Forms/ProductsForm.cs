using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SupermarketTuto.DataAccess;

namespace SupermarketTuto
{
    public partial class ProductsForm : Form
    {

        SqlConnect loaddata = new SqlConnect();

        public ProductsForm()
        {
            InitializeComponent();
        }       

        private void fillCombo()
        {
            SqlConnect loaddata2 = new SqlConnect();

            //This method will bind the Combobox with the Database
            loaddata2.retrieveData("Select CatName From CategoryTbl");
            CatCb.DataSource = loaddata2.table;
            CatCb.ValueMember = "CatName";
            CatCb.SelectedItem = null;
            CatCb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CatCb.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void display()
        {
            SqlConnect loaddata1 = new SqlConnect();

            loaddata1.retrieveData("Select * From ProductTbl");
            ProdDGV.DataSource = loaddata1.table;

        }
        

        private void MainMenu()
        {
            MenuStrip menu = new MenuStrip();

            this.Controls.Add(menu);

            string[] items = new string[] { "File", "BackUp", "About" };
            foreach (string Row in items)
            {
                ToolStripMenuItem MnuStripItem = new ToolStripMenuItem(Row);
                menu.Items.Add(MnuStripItem);
                if (MnuStripItem.Text == "About")
                {
                    MnuStripItem.Click += new EventHandler(MnuStripAbout_Click);
                }
                else if (MnuStripItem.Text == "BackUp")
                {
                    MnuStripItem.Click += new EventHandler(MnuStripDb_Click);
                }
                else if (MnuStripItem.Text == "File")
                {

                }



            }

        }

        private void MnuStripAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void MnuStripDb_Click(object sender, EventArgs e)
        {

            SqlConnect db = new SqlConnect();
            string path = "";

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
            {
                path = dialog.SelectedPath;
            }



            db.backup(path);
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            fillCombo();
            display();
            MainMenu();

            ContextMenuStrip mnu = new ContextMenuStrip();
            ToolStripMenuItem mnuDelete = new ToolStripMenuItem("Delete");
            //Assign event handlers
            mnuDelete.Click += new EventHandler(mnuDelete_Click);
            //Add to main context menu
            mnu.Items.AddRange(new ToolStripItem[] { mnuDelete});
            //Assign to datagridview
            ProdDGV.ContextMenuStrip = mnu;
        }

        private void mnuDelete_Click(object? sender, EventArgs e)
        {
            SqlConnect loaddata4 = new SqlConnect();

            loaddata4.commandExc("Delete From ProductTbl Where ProdId=" + ProdId.Text + "");

            foreach (DataGridViewRow row in ProdDGV.SelectedRows)
            {
                ProdDGV.Rows.RemoveAt(row.Index);
                                    
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            SqlConnect loaddata5 = new SqlConnect();

            try
            {
                if (ProdId.Text == "" || ProdName.Text == "" || ProdQty.Text == "" || ProdPrice.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    loaddata5.commandExc("Insert Into ProductTbl values(" + ProdId.Text + ",'" + ProdName.Text + "'," + ProdQty.Text + "," + ProdPrice.Text + ",'" + CatCb.SelectedValue.ToString() + "')");
                    MessageBox.Show("Product Successfully Insert");
                    ProdId.Text = "";
                    ProdName.Text = "";
                    ProdQty.Text = "";
                    ProdPrice.Text = "";
                    CatCb.SelectedValue = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            SqlConnect loaddata6 = new SqlConnect();

            try
            {
                if (ProdId.Text == "" || ProdName.Text == "" || ProdQty.Text == "" || ProdPrice.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {

                    loaddata6.commandExc("Update ProductTbl set ProdName='" + ProdName.Text + "',ProdQty='" + ProdQty.Text + "',ProdPrice='" + ProdPrice.Text + "' where ProdId=" + ProdId.Text + ";");
                    MessageBox.Show("Product Successfully Updated");
                    ProdId.Text = "";
                    ProdName.Text = "";
                    ProdQty.Text = "";
                    ProdPrice.Text = "";
                    CatCb.SelectedValue = "";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            SqlConnect loaddata7 = new SqlConnect();


            try
            {
                if (ProdId.Text == "")
                {
                    MessageBox.Show("Select The Category to Delete");
                }
                else
                {

                    loaddata7.commandExc("Delete From ProductTbl Where ProdId=" + ProdId.Text + "");

                    ProdId.Text = "";
                    ProdName.Text = "";
                    ProdQty.Text = "";
                    ProdPrice.Text = "";
                    CatCb.SelectedValue = "";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProdDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void selectCategory2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CatCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SqlConnect loaddata9 = new SqlConnect();

            loaddata9.retrieveData("Select * from ProductTbl Where ProdCat='" + CatCb.SelectedValue.ToString() + "'");
            ProdDGV.DataSource = loaddata9.table;


        }

        private void sellerButton_Click(object sender, EventArgs e)
        {
            SellerForm sellerForm = new SellerForm();
            sellerForm.Show();
            this.Hide();

        }


        private void logOutLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn login = new LogIn();
            login.Show();
        }

        private void categoriesButton_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.Show();
            this.Hide();
        }

        private void ProductsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Confirm to close", "Exit", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void ProdDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdId.Text = ProdDGV.SelectedRows[0].Cells[0].Value.ToString();
            ProdName.Text = ProdDGV.SelectedRows[0].Cells[1].Value.ToString();
            ProdQty.Text = ProdDGV.SelectedRows[0].Cells[2].Value.ToString();
            ProdPrice.Text = ProdDGV.SelectedRows[0].Cells[3].Value.ToString();
            CatCb.SelectedValue = ProdDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            SqlConnect loaddata10 = new SqlConnect();
            loaddata10.retrieveData("Select * From ProductTbl");

        }

        private void CatCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


