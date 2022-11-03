using SupermarketTuto.DataAccess;
using SupermarketTuto.Forms.General;

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
            display();
            display2();
        }


        private void display()
        {
            SqlConnect loaddata = new SqlConnect();
            loaddata.retrieveData("Select * From CategoryTbl where Date between '" + from2DateTimePicker.Value.ToString("MM-dd-yyyy") + "' and '" + to2DateTimePicker.Value.ToString("MM-dd-yyyy") + "'");
            CatDGV.DataSource = loaddata.table;
            CatDGV.RowHeadersVisible = false;
        }



        private void display2()
        {

            SqlConnect loaddata1 = new SqlConnect();
            loaddata1.retrieveData("Select * from ProductTbl");
            ProdDGV.DataSource = loaddata1.table;
            ProdDGV.RowHeadersVisible = false;

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addEditProduct add = new addEditProduct();
            add.Show();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            addEditProduct edit = new addEditProduct();
            edit.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void add2Button_Click(object sender, EventArgs e)
        {

        }
    }
}
