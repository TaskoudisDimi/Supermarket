using DataClass;
using SupermarketTuto.Forms.General;
using SupermarketTuto.Utils;
using System.Data;
using System.Data.SqlClient;
using System.Text;



namespace SupermarketTuto.Forms
{
    public partial class Seller : Form
    {
        SqlConnection con = new SqlConnection();

        public Seller()
        {
            InitializeComponent();
            display();
        }

        private void display()
        {
            try
            {
                SqlConnect loaddata1 = new SqlConnect();
                loaddata1.retrieveData("Select [SellerId],[SellerUserName],cast([SellerPass] as varchar(MAX)) as Password,[SellerName],[SellerAge],[SellerPhone],[Address],[Date],[Active] From SellersTbl where Date between '" + fromDateTimePicker.Value.ToString("MM-dd-yyyy") + "' and '" + toDateTimePicker.Value.ToString("MM-dd-yyyy") + "'");
               
                SellDGV.DataSource = loaddata1.table;
                totalLabel.Text = $"Total: {SellDGV.RowCount}";
                SellDGV.RowHeadersVisible = false;
                SellDGV.Columns[5].HeaderText = "Date of Birth";
            }
            catch(Exception ex)
            {
                Utlis.Log(string.Format("Message : {0}", ex.Message), "ErrorDisplayData.txt");
            }
        }

        private void Seller_Load(object sender, EventArgs e)
        {
            display();
            ContextMenuStrip mnu = new ContextMenuStrip();
            ToolStripMenuItem mnuDelete = new ToolStripMenuItem("Delete");
            //Assign event handlers
            mnuDelete.Click += new EventHandler(mnuDelete_Click);
            //Add to main context menu
            mnu.Items.AddRange(new ToolStripItem[] { mnuDelete });
            //Assign to datagridview
            SellDGV.ContextMenuStrip = mnu;


        }
        private void mnuDelete_Click(object? sender, EventArgs e)
        {
            //SqlConnect loaddata2 = new SqlConnect();

            //loaddata2.commandExc("Delete From SellerTbl Where SellerId=" + SellId.Text + "");

            //foreach (DataGridViewRow row in SellDGV.SelectedRows)
            //{
            //    SellDGV.Rows.RemoveAt(row.Index);

            //}
        }

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
                addEditSeller edit = new addEditSeller();
                edit.SellId.Text = SellDGV.CurrentRow.Cells[0].Value.ToString();
                edit.SellName.Text = SellDGV.CurrentRow.Cells[1].Value.ToString();
                edit.SellAge.Text = SellDGV.CurrentRow.Cells[2].Value.ToString();
                edit.SellPhone.Text = SellDGV.CurrentRow.Cells[3].Value.ToString();
                edit.passwordTextBox.Text = SellDGV.CurrentRow.Cells[4].Value.ToString();
                edit.dateTimePicker.Text = SellDGV.CurrentRow.Cells[5].Value.ToString();
                edit.addressTextBox.Text = SellDGV.CurrentRow.Cells[6].Value.ToString();
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
                loaddata4.commandExc("Delete From SellerTbl Where SellerId=" + SellDGV.CurrentRow.Cells[0].Value.ToString());

                MessageBox.Show("Seller Deleted Successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

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
            ContextMenuStrip menu = new ContextMenuStrip();
            ToolStripMenuItem sellerDelete = new ToolStripMenuItem("Delete");
            sellerDelete.Click += new EventHandler(mnuDelete_Click);
            menu.Items.AddRange(new ToolStripItem[] { sellerDelete });
            SellDGV.ContextMenuStrip = menu;
            SellDGV.AllowUserToAddRows = false;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SqlConnect db_sellers = new SqlConnect();
            string query = "Select * From SellerTbl where SellerId like '%" + searchTextBox.Text + "%'" + "or SellerName like '%" + searchTextBox.Text + "%'" + "or SellerAge like '%" + searchTextBox.Text + "%'" + "or SellerPhone like '%" + searchTextBox.Text + "%'" + "or SellerPass like '%" + searchTextBox.Text + "%'";
            db_sellers.search(searchTextBox.Text, query);
            SellDGV.DataSource = db_sellers.table;
            totalLabel.Text = $"Total: {SellDGV.RowCount}";

        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                searchButton.PerformClick();
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            display();
        }

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
            //    loaddata20.commandExc("Insert Into ProductTbl values('" + SellDGV.Rows[i].Cells[0].Value + "','" + SellDGV.Rows[i].Cells[1].Value + "','" + SellDGV.Rows[i].Cells[2].Value + "','" + SellDGV.Rows[i].Cells[3].Value + "','" + SellDGV.Rows[i].Cells[4].Value + "')");
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

        private void SellDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.Value != null)
            {
                e.Value = new string('*', e.Value.ToString().Length);
            }
        }

        //public Image ConvertByteToImage(byte[] data)
        //{
        //    using (MemoryStream ms = new MemoryStream(data))
        //    {
        //        return Image.FromStream(ms);
        //    }
        //}

        //byte[] ConvertImageToByte(Image image)
        //{
        //    using (MemoryStream ms = new MemoryStream())
        //    {
        //        image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
        //        return ms.ToArray();
        //    }
        //}


    }
}


