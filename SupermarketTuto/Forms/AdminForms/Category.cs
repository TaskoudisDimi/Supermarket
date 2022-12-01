
using DataClass;
using SupermarketTuto.Forms.General;
using System.Data;
using System.Text;

namespace SupermarketTuto.Forms
{
    public partial class Category : Form
    {
        
        public Category()
        {
            InitializeComponent();
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
        private void display()
        {
            try
            {
                SqlConnect loaddata = new SqlConnect();
                loaddata.retrieveData("Select * From CategoryTbl where Date between '" + fromDateTimePicker.Value.ToString("MM-dd-yyyy") + "' and '" + toDateTimePicker.Value.ToString("MM-dd-yyyy") + "'");
                CatDGV.DataSource = loaddata.table;
                CatDGV.RowHeadersVisible = false;
                totalLabel.Text = $"Total: {CatDGV.RowCount}";
                if (totalLabel.Text == null)
                {
                    MessageBox.Show("Warning", "There is no data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {

            }
           
            
        }

        private void mnuDelete_Click(object? sender, EventArgs e)
        {
            SqlConnect loaddata2 = new SqlConnect();

            loaddata2.commandExc("Delete From CategoryTbl Where CatId='" + CatDGV.CurrentRow.Cells[0].Value.ToString() + "'");

            foreach (DataGridViewRow row in CatDGV.SelectedRows)
            {
                CatDGV.Rows.RemoveAt(row.Index);

            }
        }

        private void logOutLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn login = new LogIn();
            login.Show();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            refresh_data();
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

        private void exportButton_Click(object sender, EventArgs e)
        {
            if (CatDGV.Rows.Count > 0)
            {
                SaveFileDialog dialog = new SaveFileDialog()
                {
                    Filter = "CSV (*.csv)|*.csv",
                    Title = "Csv Files",
                    RestoreDirectory = true
                };
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(dialog.FileName))
                    {
                        try
                        {
                            File.Delete(dialog.FileName);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    else
                    {
                        try
                        {
                            int colCount = CatDGV.Columns.Count;
                            string colNames = string.Empty;
                            string[] outputCSV = new string[CatDGV.Rows.Count + 1];
                            for (int i = 0; i < colCount; i++)
                            {
                                if (i == colCount - 1)
                                {
                                    colNames += CatDGV.Columns[i].HeaderText.ToString();
                                }
                                else
                                {
                                    colNames += CatDGV.Columns[i].HeaderText.ToString() + ",";
                                }
                            }
                            outputCSV[0] += colNames;

                            for (int i = 1; (i - 1) < CatDGV.Rows.Count; i++)
                            {
                                for (int j = 0; j < colCount; j++)
                                {
                                    outputCSV[i] += CatDGV.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }
                            File.WriteAllLines(dialog.FileName, outputCSV, Encoding.UTF8);
                            MessageBox.Show("Success");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
        }

        private DataTable GetData(string path)
        {
            DataTable dt = new DataTable();
            try
            {
                if (path.EndsWith(".csv"))
                {
                    //TextFieldParser csvReader = new TextFieldParser(path);
                    //csvReader.SetDelimiters(new string[] { "," });
                    //csvReader.HasFieldsEnclosedInQuotes = true;
                    //string[] colFields = csvReader.ReadFields();

                    string[] lines = System.IO.File.ReadAllLines(path);
                    if (lines.Length > 0)
                    {
                        //first line to create header
                        string firstLine = lines[0];
                        string[] headerLabels = firstLine.Split(',');
                        foreach (string headerWord in headerLabels)
                        {
                            dt.Columns.Add(new DataColumn(headerWord));
                        }
                        //For Data
                        for (int i = 1; i < lines.Length; i++)
                        {
                            string[] dataWords = lines[i].Split(',');
                            DataRow dr = dt.NewRow();
                            int columnIndex = 0;
                            foreach (string headerWord in headerLabels)
                            {
                                dr[headerWord] = dataWords[columnIndex++];
                            }
                            dt.Rows.Add(dr);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception " + ex);
            }
            return dt;
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
                    Filter = "csv files (*.csv)|*.csv",
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
                            CatDGV.DataSource = table;

                        }

                    }
                }
                refresh_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception" + ex);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SqlConnect loaddata20 = new SqlConnect();

            int count = CatDGV.RowCount;
            for (int i = 0; i < count; i++)
            {
                loaddata20.commandExc("Insert Into CategoryTbl values('" + CatDGV.Rows[i].Cells[0].Value + "','" + CatDGV.Rows[i].Cells[1].Value + "','" + CatDGV.Rows[i].Cells[2].Value + "','" + CatDGV.Rows[i].Cells[3].Value + "','" + CatDGV.Rows[i].Cells[4].Value + "')");
            }
            refresh_data();
        }

        private void CatDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {


        }
    }
}
