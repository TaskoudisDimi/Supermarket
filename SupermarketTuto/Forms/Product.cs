using Microsoft.VisualBasic.FileIO;
using Newtonsoft.Json;
using SupermarketTuto.DataAccess;
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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
            display();

        }
        private void Product_Load(object sender, EventArgs e)
        {
            fillCombo();


            ContextMenuStrip mnu = new ContextMenuStrip();
            ToolStripMenuItem mnuDelete = new ToolStripMenuItem("Delete");
            //Assign event handlers
            mnuDelete.Click += new EventHandler(mnuDelete_Click);
            //Add to main context menu
            mnu.Items.AddRange(new ToolStripItem[] { mnuDelete });
            //Assign to datagridview
            ProdDGV.ContextMenuStrip = mnu;
        }
        private void fillCombo()
        {
            SqlConnect loaddata2 = new SqlConnect();

            //This method will bind the Combobox with the Database
            loaddata2.retrieveData("Select CatName From CategoryTbl");
            addCatCombobox.DataSource = loaddata2.table;
            addCatCombobox.ValueMember = "CatName";
            addCatCombobox.SelectedItem = null;
            addCatCombobox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            addCatCombobox.AutoCompleteSource = AutoCompleteSource.ListItems;


            catComboBox.DataSource = loaddata2.table;
            catComboBox.ValueMember = "CatName";
            catComboBox.SelectedItem = null;
            catComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            catComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void display()
        {

            ProgressBar frm = new ProgressBar();

            BackgroundWorker bgw = new BackgroundWorker()
            {
                WorkerReportsProgress = true
            };

            bgw.DoWork += (s, e) =>
            {
                SqlConnect loaddata1 = new SqlConnect();
                loaddata1.retrieveData("Select * from ProductTbl");
                ProdDGV.DataSource = loaddata1.table;
                ProdDGV.RowHeadersVisible = false;
                int Count = loaddata1.table.Rows.Count;
                for (int i = 0; i < Count; i++)
                {
                    totalLabel.Text = $"Total: {ProdDGV.RowCount}";
                    ((BackgroundWorker)s).ReportProgress(i, "Loading:" + i);
                }

            };

            bgw.ProgressChanged += (s, e) =>
            {
                frm.SetProgress(e.ProgressPercentage, e.UserState.ToString());
            };

            bgw.RunWorkerCompleted += (s, e) =>
            {
                frm.Close();

                if (e.Error != null)
                    throw e.Error;
            };
            bgw.RunWorkerAsync();

            frm.ShowDialog();
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


        private void CatCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SqlConnect loaddata9 = new SqlConnect();

            loaddata9.retrieveData("Select * from ProductTbl Where ProdCat='" + addCatCombobox.SelectedValue.ToString() + "'");
            ProdDGV.DataSource = loaddata9.table;
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
                    loaddata5.commandExc("Insert Into ProductTbl values(" + ProdId.Text + ",'" + ProdName.Text + "'," + ProdQty.Text + "," + ProdPrice.Text + ",'" + addCatCombobox.SelectedValue.ToString() + "')");
                    MessageBox.Show("Product Successfully Insert");
                    ProdId.Text = String.Empty;
                    ProdName.Text = String.Empty;
                    ProdQty.Text = String.Empty;
                    ProdPrice.Text = String.Empty;
                    addCatCombobox.SelectedValue = String.Empty;
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
                    ProdId.Text = String.Empty;
                    ProdName.Text = String.Empty;
                    ProdQty.Text = String.Empty;
                    ProdPrice.Text = String.Empty;
                    addCatCombobox.SelectedValue = String.Empty;

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
                    addCatCombobox.SelectedValue = "";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProdDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdId.Text = ProdDGV.SelectedRows[0].Cells[0].Value.ToString();
            ProdName.Text = ProdDGV.SelectedRows[0].Cells[1].Value.ToString();
            ProdQty.Text = ProdDGV.SelectedRows[0].Cells[2].Value.ToString();
            ProdPrice.Text = ProdDGV.SelectedRows[0].Cells[3].Value.ToString();
            addCatCombobox.SelectedValue = ProdDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            SqlConnect loaddata11 = new SqlConnect();
            loaddata11.retrieveData("Select * From ProductTbl");
        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                searchButton.PerformClick();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SqlConnect db = new SqlConnect();
            string query = "Select * From ProductTbl where ProdId like '%" + searchTextBox.Text + "%'" + "or ProdName like '%" + searchTextBox.Text + "%'" + "or ProdQty like '%" + searchTextBox.Text + "%'" + "or ProdPrice like '%" + searchTextBox.Text + "%'" + "or ProdCat like '%" + searchTextBox.Text + "%'";
            db.search(searchTextBox.Text, query);
            ProdDGV.DataSource = db.table;
            totalLabel.Text = $"Total: {ProdDGV.RowCount}";
        }

        private void catComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SqlConnect loaddata10 = new SqlConnect();
            loaddata10.retrieveData("Select * from ProductTbl where ProdCat='" + catComboBox.SelectedValue + "'");
            ProdDGV.DataSource = loaddata10.table;
            ProdDGV.RowHeadersVisible = false;
            totalLabel.Text = $"Total: {ProdDGV.RowCount}";
        }

        private void APIButton_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                var endpoint = new Uri("http://localhost:52465/api/products");
                var result1 = client.GetAsync(endpoint).Result;
                var json = result1.Content.ReadAsStringAsync().Result;
                var result = JsonConvert.DeserializeObject<List<Products>>(json);
                ProdDGV.DataSource = result;
            }
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            try
            {
                int ImportedRecord = 0, inValidItem = 0;
                string SourceURl = "";
                OpenFileDialog dialog = new OpenFileDialog()
                {
                    Title = "Browse Text File",
                    CheckFileExists = true,
                    CheckPathExists = true,
                    Filter = "txt files (*.csv)|*.csv",
                    FilterIndex = 2,
                    RestoreDirectory = true,
                    ReadOnlyChecked = true,
                    ShowReadOnly = true

                };
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    if (dialog.FileName.EndsWith(".csv"))
                    {
                        DataTable table = new DataTable();
                        table = GetData(dialog.FileName);
                        SourceURl = dialog.FileName;
                        if (table.Rows != null && table.Rows.ToString() != String.Empty)
                        {
                            ProdDGV.DataSource = table;

                        }

                    }
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("Exception" + ex);
            }
        }

        private DataTable GetData(string path)
        {
            DataTable table = new DataTable();
            try
            {
                if (path.EndsWith(".csv"))
                {
                    TextFieldParser csvReader = new TextFieldParser(path);
                    csvReader.SetDelimiters(new string[] { "," });
                    csvReader.HasFieldsEnclosedInQuotes = true;
                    string[] colFields = csvReader.ReadFields();
                    foreach (string column in colFields)
                    {
                        DataColumn datecolumn = new DataColumn(column);
                        datecolumn.AllowDBNull = true;
                        table.Columns.Add(datecolumn);
                    }
                    while (!csvReader.EndOfData)
                    {
                        string[] fieldData = csvReader.ReadFields();
                        for (int i = 0; i < fieldData.Length; i++)
                        {
                            if (fieldData[i] == "")
                            {
                                fieldData[i] = null;
                            }
                        }
                        table.Rows.Add(fieldData);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception " + ex);
            }
            return table;
        }

    }



    public class Products
    {
        public int Productid { get; set; }
        public string ProdName { get; set; }
        public int ProdQty { get; set; }
        public int ProdPrice { get; set; }
        public string ProdCat { get; set; }
        public DateTime ProdDate { get; set; }
    }

    
}

