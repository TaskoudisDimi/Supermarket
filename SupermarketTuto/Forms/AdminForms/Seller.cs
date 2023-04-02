using DataClass;
using SupermarketTuto.Forms.General;
using SupermarketTuto.Utils;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http.Headers;
using System.Text;



namespace SupermarketTuto.Forms
{
    public partial class Seller : Form
    {
        public Seller()
        {
            InitializeComponent();
            display();
        }
        private void display()
        {
            try
            {
                fromDateTimePicker.Value = DateTime.Now.AddMonths(-2);
                if (activeComboBox.Text == "Active")
                {

                    SqlConnect loaddata1 = new SqlConnect();
                    //loaddata1.getData("Select [SellerId],[SellerUserName],cast([SellerPass] as varchar(MAX)) as Password,[SellerName],[SellerAge],[SellerPhone],[Address],[Date],[Active] From SellersTbl where Date between '" + fromDateTimePicker.Value.ToString("MM-dd-yyyy") + "' and '" + toDateTimePicker.Value.ToString("MM-dd-yyyy") + "' and Active = 'true'");
                    loaddata1.pagingData("Select [SellerId],[SellerUserName],cast([SellerPass] as varchar(MAX)) as Password,[SellerName],[SellerAge],[SellerPhone],[Address],[Date],[Active] From SellersTbl where Date between '" + fromDateTimePicker.Value.ToString("MM-dd-yyyy") + "' and '" + toDateTimePicker.Value.ToString("MM-dd-yyyy") + "' and Active = 'true'", 0, 5);
                    SellDGV.DataSource = loaddata1.table;
                    totalLabel.Text = $"Total: {SellDGV.RowCount}";
                    SellDGV.RowHeadersVisible = false;
                    SellDGV.Columns[5].HeaderText = "Date of Birth";
                    SellDGV.Columns[7].HeaderText = "Date Created";

                }
                else if (activeComboBox.Text == "Inactive")
                {
                    SqlConnect loaddata1 = new SqlConnect();
                    loaddata1.getData("Select [SellerId],[SellerUserName],cast([SellerPass] as varchar(MAX)) as Password,[SellerName],[SellerAge],[SellerPhone],[Address],[Date],[Active] From SellersTbl where Date between '" + fromDateTimePicker.Value.ToString("MM-dd-yyyy") + "' and '" + toDateTimePicker.Value.ToString("MM-dd-yyyy") + "' and Active = 'False'");
                    SellDGV.DataSource = loaddata1.table;
                    totalLabel.Text = $"Total: {SellDGV.RowCount}";
                    SellDGV.RowHeadersVisible = false;
                    SellDGV.Columns[5].HeaderText = "Date of Birth";
                    SellDGV.Columns[7].HeaderText = "Date Created";

                }
                else
                {
                    SqlConnect loaddata1 = new SqlConnect();
                    loaddata1.getData("Select [SellerId],[SellerUserName],cast([SellerPass] as varchar(MAX)) as Password,[SellerName],[SellerAge],[SellerPhone],[Address],[Date],[Active] From SellersTbl where Date between '" + fromDateTimePicker.Value.ToString("MM-dd-yyyy") + "' and '" + toDateTimePicker.Value.ToString("MM-dd-yyyy") + "'");
                    SellDGV.DataSource = loaddata1.table;
                    totalLabel.Text = $"Total: {SellDGV.RowCount}";
                    SellDGV.RowHeadersVisible = false;
                    SellDGV.Columns[5].HeaderText = "Date of Birth";
                    SellDGV.Columns[7].HeaderText = "Date Created";

                }

            }
            catch (Exception ex)
            {
                Utlis.Log(string.Format("Message : {0}", ex.Message), "ErrorDisplayData.txt");
            }
        }

        private void Seller_Load(object sender, EventArgs e)
        {
            display();
            fillcombo();
        }

        private void fillcombo()
        {
            //Fill combo Active
            string[] test2 = { "Not Set", "Active", "Inactive" };
            activeComboBox.DataSource = test2;
        }
        #region buttons
        private void add2Button_Click(object sender, EventArgs e)
        {
            addEditSeller add = new addEditSeller();
            add.editButton.Visible = false;
            add.SellId.Visible = false;
            add.idlabel.Visible = false;
            add.Show();
        }

        private void editButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnect loaddata60 = new SqlConnect();
                addEditSeller edit = new addEditSeller();
                edit.SellId.Text = SellDGV.CurrentRow.Cells[0].Value.ToString();
                string query = $"Select * From SellersTbl where SellerId = {edit.SellId.Text}";
                loaddata60.getData(query);
                DataTable sellers = loaddata60.table;
                foreach (DataRow row in sellers.Rows)
                {
                    edit.usernameTextBox.Text = row["SellerUserName"].ToString();
                    byte[] imageData = (byte[])row["Image"];
                    MemoryStream ms = new MemoryStream(imageData);
                    edit.pictureBox.Image = Image.FromStream(ms);
                    edit.passwordTextBox.Text = row["SellerPass"].ToString();
                    edit.SellName.Text = row["SellerName"].ToString();
                    edit.SellAge.Text = row["SellerAge"].ToString();
                    edit.SellPhone.Text = row["SellerPhone"].ToString();
                    edit.addressTextBox.Text = row["Address"].ToString();
                    edit.dateTimePicker.Text = row["Date"].ToString();
                    edit.checkBox.Checked = (bool)row["Active"];
                }
                edit.addButton.Visible = false;
                edit.SellId.ReadOnly = true;
                edit.Show();
            }
            catch (Exception ex)
            {
                Utlis.Log(string.Format("Message : {0}", ex.Message), "ErrorDisplayData.txt");
            }

        }

        private void delete2Button_Click(object sender, EventArgs e)
        {
            SqlConnect loaddata4 = new SqlConnect();

            try
            {
                loaddata4.execCom("Delete From SellerTbl Where SellerId=" + SellDGV.CurrentRow.Cells[0].Value.ToString());

                MessageBox.Show("Seller Deleted Successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            SqlConnect db_sellers = new SqlConnect();
            string query = "Select * From SellerTbl where SellerId like '%" + searchTextBox.Text + "%'" + "or SellerName like '%" + searchTextBox.Text + "%'" + "or SellerAge like '%" + searchTextBox.Text + "%'" + "or SellerPhone like '%" + searchTextBox.Text + "%'" + "or SellerPass like '%" + searchTextBox.Text + "%'";
            db_sellers.search(searchTextBox.Text, query);
            SellDGV.DataSource = db_sellers.table;
            totalLabel.Text = $"Total: {SellDGV.RowCount}";

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            display();
        }
        #endregion

        #region MenuStrip
        private void menu()
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            ToolStripMenuItem mnuDelete = new ToolStripMenuItem("Delete");
            ToolStripMenuItem mnuEdit = new ToolStripMenuItem("Edit");
            mnuDelete.Click += new EventHandler(mnuDelete_Click);
            mnuEdit.Click += new EventHandler(mnuEdit_Click);
            menu.Items.AddRange(new ToolStripItem[] { mnuEdit, mnuDelete });
            SellDGV.ContextMenuStrip = menu;
            SellDGV.AllowUserToAddRows = false;
        }

        private void mnuEdit_Click(object? sender, EventArgs e)
        {
            try
            {
                SqlConnect loaddata50 = new SqlConnect();
                addEditSeller edit = new addEditSeller();
                edit.SellId.Text = SellDGV.CurrentRow.Cells[0].Value.ToString();
                string query = $"Select * From SellersTbl where SellerId = {edit.SellId.Text}";
                loaddata50.getData(query);
                DataTable sellers = loaddata50.table;
                foreach (DataRow row in sellers.Rows)
                {
                    edit.usernameTextBox.Text = row["SellerUserName"].ToString();
                    byte[] imageData = (byte[])row["Image"];
                    MemoryStream ms = new MemoryStream(imageData);
                    edit.pictureBox.Image = Image.FromStream(ms);
                    edit.passwordTextBox.Text = row["SellerPass"].ToString();
                    edit.SellName.Text = row["SellerName"].ToString();
                    edit.SellAge.Text = row["SellerAge"].ToString();
                    edit.SellPhone.Text = row["SellerPhone"].ToString();
                    edit.addressTextBox.Text = row["Address"].ToString();
                    edit.dateTimePicker.Text = row["Date"].ToString();
                    edit.checkBox.Checked = (bool)row["Active"];
                }
                edit.addButton.Visible = false;
                edit.SellId.ReadOnly = true;
                edit.Show();
            }
            catch (Exception ex)
            {
                Utlis.Log(string.Format("Message : {0}", ex.Message), "ErrorDisplayData.txt");
            }
        }
        private void mnuDelete_Click(object? sender, EventArgs e)
        {
            SqlConnect loaddata2 = new SqlConnect();
            loaddata2.execCom("Delete From SellerTbl Where SellerId = " + SellDGV.CurrentRow.Cells[0].Value.ToString());
            foreach (DataGridViewRow row in SellDGV.SelectedRows)
            {
                SellDGV.Rows.RemoveAt(row.Index);

            }
        }
        #endregion

        #region Excel
        private void exportButton_Click(object sender, EventArgs e)
        {
            if (SellDGV.Rows.Count > 0)
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
                            int colCount = SellDGV.Columns.Count;
                            string colNames = string.Empty;
                            string[] outputCSV = new string[SellDGV.Rows.Count + 1];
                            for (int i = 0; i < colCount; i++)
                            {
                                if (i == colCount - 1)
                                {
                                    colNames += SellDGV.Columns[i].HeaderText.ToString();
                                }
                                else
                                {
                                    colNames += SellDGV.Columns[i].HeaderText.ToString() + ",";
                                }
                            }
                            outputCSV[0] += colNames;

                            for (int i = 1; (i - 1) < SellDGV.Rows.Count; i++)
                            {
                                for (int j = 0; j < colCount; j++)
                                {
                                    outputCSV[i] += SellDGV.Rows[i - 1].Cells[j].Value.ToString() + ",";
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
                            SellDGV.DataSource = table;

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception" + ex);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //SqlConnect loaddata20 = new SqlConnect();

            //int count = SellDGV.RowCount;
            //for (int i = 0; i < count; i++)
            //{
            //    loaddata20.execCom("Insert Into ProductTbl values('" + SellDGV.Rows[i].Cells[0].Value + "','" + SellDGV.Rows[i].Cells[1].Value + "','" + SellDGV.Rows[i].Cells[2].Value + "','" + SellDGV.Rows[i].Cells[3].Value + "','" + SellDGV.Rows[i].Cells[4].Value + "')");
            //}
            //refresh_data();
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
        #endregion

        #region Events
        private void fromDateTimePicker_ValueChanged_1(object sender, EventArgs e)
        {
            display();
        }

        private void toDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            display();
        }

        private void SellDGV_MouseDown(object sender, MouseEventArgs e)
        {
            menu();
        }
        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Search with Enter 
            if (e.KeyChar == (char)13)
            {
                searchButton.PerformClick();
            }
        }

        private void SellDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in SellDGV.Rows)
            {
                if (Convert.ToBoolean(row.Cells[8].Value.ToString()) == false)
                {
                    row.DefaultCellStyle.BackColor = Color.Orange;
                }

            }
            if (e.ColumnIndex == 2 && e.Value != null)
            {
                e.Value = new string('*', e.Value.ToString().Length);
            }

        }

        private void activeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                display();

            }
            catch (Exception ex)
            {

            }

        }
        #endregion

 
    }
}


