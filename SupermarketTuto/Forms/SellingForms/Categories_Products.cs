using SupermarketTuto.DataAccess;
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
            display();
            display2();
            fillCombo();
        }


        private void display()
        {
            SqlConnect loaddata = new SqlConnect();
            loaddata.retrieveData("Select * From CategoryTbl where Date between '" + from2DateTimePicker.Value.ToString("MM-dd-yyyy") + "' and '" + to2DateTimePicker.Value.ToString("MM-dd-yyyy") + "'");
            CatDGV.DataSource = loaddata.table;
            CatDGV.RowHeadersVisible = false;
            total2Label.Text = $"Total: {CatDGV.RowCount}";
        }
        private void display2()
        {
            SqlConnect loaddata1 = new SqlConnect();
            loaddata1.retrieveData("Select * from ProductTbl where Date between '" + fromDateTimePicker.Value.ToString("MM-dd-yyyy") + "' and '" + toDateTimePicker.Value.ToString("MM-dd-yyyy") + "'");
            ProdDGV.DataSource = loaddata1.table;
            ProdDGV.RowHeadersVisible = false;
            totalLabel.Text = $"Total: {ProdDGV.RowCount}";
        }
        private void fillCombo()
        {
            SqlConnect loaddata2 = new SqlConnect();
            loaddata2.retrieveData("Select CatName From CategoryTbl");
            catComboBox.DataSource = loaddata2.table;
            catComboBox.ValueMember = "CatName";
            catComboBox.SelectedItem = null;
            catComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            catComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void refresh_products()
        {
            SqlConnect loaddata21 = new SqlConnect();
            loaddata21.retrieveData("Select * from ProductTbl");
            ProdDGV.DataSource = loaddata21.table;
            ProdDGV.RowHeadersVisible = false;
            totalLabel.Text = $"Total: {ProdDGV.RowCount}";
        }

        private void refresh_categories()
        {
            SqlConnect loaddata21 = new SqlConnect();
            loaddata21.retrieveData("Select * from CategoryTbl");
            CatDGV.DataSource = loaddata21.table;
            CatDGV.RowHeadersVisible = false;
            total2Label.Text = $"Total: {CatDGV.RowCount}";
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            addEditProduct add = new addEditProduct();
            SqlConnect loaddata21 = new SqlConnect();
            ////This method will bind the Combobox with the Database
            loaddata21.retrieveData("Select CatName From CategoryTbl");
            add.catCombobox.DataSource = loaddata21.table;
            add.catCombobox.ValueMember = "CatName";
            //catCombobox.SelectedItem = null;
            add.catCombobox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            add.catCombobox.AutoCompleteSource = AutoCompleteSource.ListItems;
            add.editButton.Visible = false;
            add.ProdId.Visible = false;
            add.idLabel.Visible = false;
            add.Show();
            refresh_products();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            //addEditProduct edit = new addEditProduct();
            //edit.Show();
            SqlConnect loaddata33 = new SqlConnect();
            addEditProduct edit = new addEditProduct();
            ////This method will bind the Combobox with the Database
            loaddata33.retrieveData("Select CatName From CategoryTbl");
            edit.catCombobox.DataSource = loaddata33.table;
            edit.catCombobox.ValueMember = "CatName";
            //catCombobox.SelectedItem = null;
            edit.catCombobox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            edit.catCombobox.AutoCompleteSource = AutoCompleteSource.ListItems;
            edit.ProdId.Text = ProdDGV.CurrentRow.Cells[0].Value.ToString();
            edit.ProdName.Text = ProdDGV.CurrentRow.Cells[1].Value.ToString();
            edit.ProdPrice.Text = ProdDGV.CurrentRow.Cells[2].Value.ToString();
            edit.ProdQty.Text = ProdDGV.CurrentRow.Cells[3].Value.ToString();
            edit.catCombobox.SelectedValue = ProdDGV.CurrentRow.Cells[4].Value.ToString();
            edit.DateTimePicker.Text = ProdDGV.CurrentRow.Cells[5].Value.ToString();
            edit.addButton.Visible = false;
            edit.ProdId.ReadOnly = true;
            edit.Show();
            refresh_products();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            SqlConnect loaddata7 = new SqlConnect();
            try
            {
                loaddata7.commandExc("Delete From ProductTbl Where ProdId=" + ProdDGV.CurrentRow.Cells[0].Value.ToString());
                refresh_products();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void add2Button_Click(object sender, EventArgs e)
        {
            //addEditCategory add = new addEditCategory();
            //add.Show();
            addEditCategory add = new addEditCategory();
            add.editButton.Visible = false;
            add.CatIdTb.Visible = false;
            add.idlabel.Visible = false;
            add.Show();
            refresh_categories();
        }

        private void catComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SqlConnect loaddata10 = new SqlConnect();
            loaddata10.retrieveData("Select * from ProductTbl where ProdCat='" + catComboBox.SelectedValue + "'");
            ProdDGV.DataSource = loaddata10.table;
            ProdDGV.RowHeadersVisible = false;
            totalLabel.Text = $"Total: {ProdDGV.RowCount}";
        }

        private void fromDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            display2();
        }

        private void toDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            display2();
        }

        private void from2DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            display();
        }

        private void to2DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            display();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            refresh_products();
        }

        private void refresh2Button_Click(object sender, EventArgs e)
        {
            refresh_categories();
        }

        private void edit2Button_Click(object sender, EventArgs e)
        {
            addEditCategory edit = new addEditCategory();
            edit.CatIdTb.Text = CatDGV.CurrentRow.Cells[0].Value.ToString();
            edit.CatNameTb.Text = CatDGV.CurrentRow.Cells[1].Value.ToString();
            edit.CatDescTb.Text = CatDGV.CurrentRow.Cells[2].Value.ToString();
            edit.dateTimePicker.Text = CatDGV.CurrentRow.Cells[3].Value.ToString();
            edit.addButton.Visible = false;
            edit.CatIdTb.ReadOnly = true;
            edit.Show();
            refresh_categories();
        }

        private void delete2Button_Click(object sender, EventArgs e)
        {
            SqlConnect loaddata5 = new SqlConnect();
            try
            {
                loaddata5.commandExc("Delete From CategoryTbl Where CatId=" + CatDGV.CurrentRow.Cells[0].Value.ToString());
                refresh_categories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            SqlConnect db = new SqlConnect();
            string query = "Select * From ProductTbl where ProdId like '%" + searchTextBox.Text + "%'" + "or ProdName like '%" + searchTextBox.Text + "%'" + "or ProdQty like '%" + searchTextBox.Text + "%'" + "or ProdPrice like '%" + searchTextBox.Text + "%'" + "or ProdCat like '%" + searchTextBox.Text + "%'";
            db.search(searchTextBox.Text, query);
            ProdDGV.DataSource = db.table;
            totalLabel.Text = $"Total: {ProdDGV.RowCount}";
        }

        private void search2TextBox_TextChanged(object sender, EventArgs e)
        {
            SqlConnect db_categories = new SqlConnect();
            string query = "Select * From CategoryTbl where CatId like '%" + searchTextBox.Text + "%'" + "or CatName like '%" + searchTextBox.Text + "%'" + "or CatDesc like '%" + searchTextBox.Text + "%'";
            db_categories.search(searchTextBox.Text, query);
            CatDGV.DataSource = db_categories.table;
            totalLabel.Text = $"Total: {CatDGV.RowCount}";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SqlConnect db2 = new SqlConnect();
            string query = "Select * From ProductTbl where ProdId like '%" + searchTextBox.Text + "%'" + "or ProdName like '%" + searchTextBox.Text + "%'" + "or ProdQty like '%" + searchTextBox.Text + "%'" + "or ProdPrice like '%" + searchTextBox.Text + "%'" + "or ProdCat like '%" + searchTextBox.Text + "%'";
            db2.search(searchTextBox.Text, query);
            ProdDGV.DataSource = db2.table;
            totalLabel.Text = $"Total: {ProdDGV.RowCount}";
        }

        private void search2Button_Click(object sender, EventArgs e)
        {
            SqlConnect db_categories2 = new SqlConnect();
            string query = "Select * From CategoryTbl where CatId like '%" + searchTextBox.Text + "%'" + "or CatName like '%" + searchTextBox.Text + "%'" + "or CatDesc like '%" + searchTextBox.Text + "%'";
            db_categories2.search(searchTextBox.Text, query);
            CatDGV.DataSource = db_categories2.table;
            totalLabel.Text = $"Total: {CatDGV.RowCount}";
        }
    }
}
