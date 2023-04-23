using ClassLibrary1.Models;
using DataClass;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public class ExcelFile
    {

        #region Csv files
        public DataTable import()
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
                            return table;
                        }
                        else
                        {
                            return null;
                        }

                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception" + ex);
                return null;
            }
        }

        private DataTable GetData(string path)
        {
            DataTable dt = new DataTable();
            try
            {
                if (path.EndsWith(".csv"))
                {
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
                        dt.Columns["ProdId"].DataType = typeof(int);
                        dt.Columns["ProdQty"].DataType = typeof(int);
                        dt.Columns["ProdPrice"].DataType = typeof(int);
                        dt.Columns["ProdCatID"].DataType = typeof(int);
                        dt.Columns["Date"].DataType = typeof(DateTime);

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

        public void export(DataGridView table)
        {
            if (table.Rows.Count > 0)
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
                            int colCount = table.Columns.Count;
                            string colNames = string.Empty;
                            string[] outputCSV = new string[table.Rows.Count + 1];
                            for (int i = 0; i < colCount; i++)
                            {
                                if (i == colCount - 1)
                                {
                                    colNames += table.Columns[i].HeaderText.ToString();
                                }
                                else
                                {
                                    colNames += table.Columns[i].HeaderText.ToString() + ",";
                                }
                            }
                            outputCSV[0] += colNames;

                            for (int i = 1; (i - 1) < table.Rows.Count; i++)
                            {
                                for (int j = 0; j < colCount; j++)
                                {
                                    outputCSV[i] += table.Rows[i - 1].Cells[j].Value.ToString() + ",";
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

        #endregion

        public void SaveToDB(DataTable table, Type type)
        {
            SqlConnect loaddata20 = new SqlConnect();
            foreach(DataRow row in table.Rows)
            {
                if (type.Name == "Products")
                {
                    loaddata20.execCom("Insert Into ProductTbl values('" + row["ProdName"] + "','" + row["ProdQty"] + "','" + row["ProdPrice"] + "','" + row["ProdCatID"] + "','" + row["ProdCat"] + "','" + row["Date"] + "')");
                }
            }
        }


        #region Xlsx files

        List<object> productsExcel = new List<object>();
        
        //Import
        public DataTable ImportExcelAsync(DataGridView dataGridView, Type typeOfClass)
        {
            try
            {
                 string path = null;
                OpenFileDialog dialog = new OpenFileDialog()
                {
                    Filter = "xlsx (*.xlsx)|*.xlsx",
                    Title = "xlsx Files",
                    RestoreDirectory = true
                };  
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    path = dialog.FileName;

                    using (var package = new ExcelPackage(new FileInfo(path)))
                    {
                        ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                        package.LoadAsync(path);
                        var ws = package.Workbook.Worksheets[0]; // assuming your data is in the first worksheet 
                        DataTable dataTable = new DataTable();

                        if (typeOfClass.Name.Equals("Products"))
                        {
                            dataTable.Columns.Add("ProdId", typeof(int));
                            dataTable.Columns.Add("ProdName");
                            dataTable.Columns.Add("ProdQty", typeof(int));
                            dataTable.Columns.Add("ProdPrice", typeof(int));
                            dataTable.Columns.Add("ProdCatID", typeof(int));
                            dataTable.Columns.Add("ProdCat");
                            dataTable.Columns.Add("Date", typeof(DateTime));

                            int rowAdd = 5;
                            int col = 1;
                            double date;

                            // Loop through the rows in the worksheet and add them to the DataTable
                            while (string.IsNullOrWhiteSpace(ws.Cells[rowAdd, col].Value?.ToString()) == false)
                            {
                                DataRow row = dataTable.Rows.Add();
                                row["ProdId"] = int.Parse(ws.Cells[rowAdd, col].Value.ToString());
                                row["ProdName"] = ws.Cells[rowAdd, col + 1].Value.ToString();
                                row["ProdQty"] = int.Parse(ws.Cells[rowAdd, col + 2].Value.ToString());
                                row["ProdPrice"] = int.Parse(ws.Cells[rowAdd, col + 3].Value.ToString());
                                row["ProdCatID"] = int.Parse(ws.Cells[rowAdd, col + 4].Value.ToString());
                                row["ProdCat"] = ws.Cells[rowAdd, col + 5].Value.ToString();
                                ExcelRange range = ws.Cells[rowAdd, col + 6];
                                date = Convert.ToDouble(range.Value);
                                row["Date"] = DateTime.FromOADate(date);
                                rowAdd += 1;
                            }

                        }
                        else if (typeOfClass.Name.Equals("Categories"))
                        {

                        }
                        else if (typeOfClass.Name.Equals("Bills"))
                        {

                        }
                        else if (typeOfClass.Name.Equals("BillingProducts"))
                        {

                        }
                        return dataTable;
                    }
                }
                return null;
            }
            catch
            {
                return null;
            }
            
        }



        //Save
        public async void Save(DataGridView dataGridView, Type typeOfClass)
        {
            string path = "";
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            try
            {
                SaveFileDialog dialog = new SaveFileDialog()
                {
                    Filter = "xlsx (*.xlsx)|*.xlsx",
                    Title = "xlsx Files",
                    RestoreDirectory = true
                };
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    path = dialog.FileName;
                    var file = new FileInfo(path);
                    if (typeOfClass.Name.Equals("Products"))
                    {
                        var products = GetSetupDataProd(dataGridView);
                        await SaveExcelFile(products, file, typeOfClass);
                    }
                    else if (typeOfClass.Equals("Categories"))
                    {
                        var categories = GetSetupDataProd(dataGridView);
                        await SaveExcelFile(categories, file, typeOfClass);
                    }
                }
                else
                {
                    return;
                }
            }
            catch
            {
                return;
            }
           
            
        }

        private List<object> GetSetupDataProd(DataGridView dataGridView)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    Products prod = new Products();
                    prod.ProdId = Convert.ToInt32(row.Cells["ProdId"].Value);
                    prod.ProdCat = row.Cells["ProdCat"].Value.ToString();
                    prod.ProdName = row.Cells["ProdName"].Value.ToString();
                    prod.ProdPrice = Convert.ToInt32(row.Cells["ProdPrice"].Value);
                    prod.ProdQty = Convert.ToInt32(row.Cells["ProdQty"].Value);
                    prod.ProdCatID = Convert.ToInt32(row.Cells["ProdCatID"].Value);
                    prod.Date = DateTime.Parse(row.Cells["Date"].Value.ToString());
                    productsExcel.Add(prod);
                }

                return productsExcel;
            }
            catch
            {
                return null;
            }
        }

        private static async Task SaveExcelFile(List<object> data, FileInfo file, Type type)
        {
            if (type.Name.Equals("Products"))
            {
                try
                {
                    List<Products> products = new List<Products>();
                    products = data.Cast<Products>().ToList();
                    DeleteIfExists(file);
                    using (var package = new ExcelPackage(file))
                    {
                        var ws = package.Workbook.Worksheets.Add("MainReport");

                        var range = ws.Cells["A3"].LoadFromCollection(products, true);
                        range.AutoFitColumns();
                        // Formats the header
                        ws.Cells["A1"].Value = "Report Products";
                        ws.Cells["A1:C1"].Merge = true;
                        ws.Column(1).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        ws.Row(1).Style.Font.Size = 24;
                        ws.Row(1).Style.Border.BorderAround(ExcelBorderStyle.Dashed);
                        ws.Row(1).Style.Font.Color.SetColor(Color.Black);
                        ws.Row(1).Style.Font.Bold = true;

                        ws.Row(2).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        ws.Row(2).Style.Font.Bold = true;
                        ws.Column(3).Width = 20;

                        await package.SaveAsync();
                    };
                }
                catch
                {

                }
            }
        }

        private static void DeleteIfExists(FileInfo file)
        {
            if (file.Exists)
            {
                file.Delete();
            }

        }

        #endregion


    }
}
