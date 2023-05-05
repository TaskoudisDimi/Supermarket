using ClassLibrary1.Models;
using DataClass;
using SupermarketTuto.Forms.General;
using System.Windows.Forms;

namespace SupermarketTuto.Forms.SellingForms
{
    public partial class Categories_Products : Form
    {
        public Categories_Products()
        {
            InitializeComponent();
        }

        private void Categories_Products_Load(object sender, EventArgs e)
        {
            fromDateTimePicker.Value = DateTime.Today.AddDays(-7);
            from2DateTimePicker.Value = DateTime.Today.AddDays(-7);

        }

       
        private void fillCombo()
        {
            
            catComboBox.ValueMember = "CatName";
            catComboBox.SelectedItem = null;
            catComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            catComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

        }




        private void addButton_Click(object sender, EventArgs e)
        {
            
            //addEditProduct add = new addEditProduct();
            //SqlConnect loaddata21 = new SqlConnect();
            //////This method will bind the Combobox with the Database
            //loaddata21.getData("Select CatName From CategoryTbl");
            //add.catCombobox.DataSource = loaddata21.table;
            //add.catCombobox.ValueMember = "CatName";
            ////catCombobox.SelectedItem = null;
            //add.catCombobox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //add.catCombobox.AutoCompleteSource = AutoCompleteSource.ListItems;
            //add.editButton.Visible = false;
            //add.ProdId.Visible = false;
            //add.idLabel.Visible = false;
            //add.Show();
            //refresh_products();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            //addEditProduct edit = new addEditProduct();
            //edit.catCombobox.ValueMember = "CatName";
            ////catCombobox.SelectedItem = null;
            //edit.catCombobox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //edit.catCombobox.AutoCompleteSource = AutoCompleteSource.ListItems;
            //edit.addButton.Visible = false;
            //edit.ProdId.ReadOnly = true;
            //edit.Show();
            //refresh_products();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            
        }

        private void add2Button_Click(object sender, EventArgs e)
        {
            //addEditCategory add = new addEditCategory();
            //add.editButton.Visible = false;
            //add.CatIdTb.Visible = false;
            //add.idlabel.Visible = false;
            //add.Show();
        }

        private void catComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
            ProdDGV.RowHeadersVisible = false;
            totalLabel.Text = $"Total: {ProdDGV.RowCount}";
        }

        private void fromDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void toDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void from2DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void to2DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            
        }

        private void refresh2Button_Click(object sender, EventArgs e)
        {
            
        }

        private void edit2Button_Click(object sender, EventArgs e)
        {
            
            //addEditCategory edit = new addEditCategory();
            //edit.addButton.Visible = false;
            //edit.CatIdTb.ReadOnly = true;
            //edit.Show();
        }

        private void delete2Button_Click(object sender, EventArgs e)
        {
           
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
           
            //ProdDGV.DataSource = ;
            totalLabel.Text = $"Total: {ProdDGV.RowCount}";
        }

        private void search2TextBox_TextChanged(object sender, EventArgs e)
        {

            //CatDGV.DataSource = ;
            totalLabel.Text = $"Total: {CatDGV.RowCount}";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
           
            
        }

        private void search2Button_Click(object sender, EventArgs e)
        {
            
        }


        #region ChechDatabase
        private void checkCat()
        {
            SqlConnect sql = new SqlConnect();
            var customerType = typeof(Categories);
            sql.checkTable(Categories: customerType);
        }

        private void checkProd()
        {
            SqlConnect sql = new SqlConnect();
            var customerType = typeof(Products);
            sql.checkTable(Categories: customerType);
        }
        #endregion


    }
}
