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
        public DataTable import(Type type)
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
                        table = GetData(dialog.FileName, type);
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

        private DataTable GetData(string path, Type type)
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
                        if (type.Name.Equals("Products"))
                        {
                            dt.Columns["ProdId"].DataType = typeof(int);
                            dt.Columns["ProdQty"].DataType = typeof(int);
                            dt.Columns["ProdPrice"].DataType = typeof(int);
                            dt.Columns["ProdCatID"].DataType = typeof(int);
                            dt.Columns["Date"].DataType = typeof(DateTime);
                        }
                        else if (type.Name.Equals("Categories"))
                        {
                            dt.Columns["CatId"].DataType = typeof(int);
                            dt.Columns["Date"].DataType = typeof(DateTime);
                        }
                        else if (type.Name.Equals("BillingProducts"))
                        {
                            dt.Columns["Id"].DataType = typeof(int);
                            dt.Columns["Price"].DataType = typeof(int);
                            dt.Columns["Qty"].DataType = typeof(int);
                            dt.Columns["Total"].DataType = typeof(int);
                        }
                        else if (type.Name.Equals("Bills"))
                        {
                            dt.Columns["Id"].DataType = typeof(int);
                            dt.Columns["TotAmt"].DataType = typeof(int);
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
            foreach (DataRow row in table.Rows)
            {
                if (type.Name == "Products")
                {
                    loaddata20.execCom("Insert Into ProductTbl values('" + row["ProdName"] + "','" + row["ProdQty"] + "','" + row["ProdPrice"] + "','" + row["ProdCatID"] + "','" + row["ProdCat"] + "','" + row["Date"] + "')");
                }
                else if (type.Name.Equals("Categories"))
                {
                    loaddata20.execCom("Insert Into CategoryTbl values('" + row["CatName"] + "','" + row["CatDesc"] + "','" + row["Date"] + "')");
                }
                else if (type.Name.Equals("Bills"))
                {
                    loaddata20.execCom("Insert Into BillTbl values('" + row["Comments"] + "','" + row["SellName"] + "','" + row["BillDate"] + "'," + row["TotAmt"] + ")");
                }
                else if (type.Name.Equals("BillingProducts"))
                {
                    loaddata20.execCom("Insert Into BillingProducts Values('" + row["ProdName"] + "'," + row["Price"] + "," + row["Qty"] + "," + row["Total"] + ")");
                }

            }
        }


        #region Xlsx files

        List<object> data = new List<object>();

        //Import
        public DataTable ImportExcelAsync(DataGridView dataGridView, Type typeOfClass)
        {
            try
            {
                string path = null;
                int rowAdd = 5;
                int col = 1;
                double date;
                DataTable dataTable = new DataTable();
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

                        if (typeOfClass.Name.Equals("Products"))
                        {
                            dataTable.Columns.Add("ProdId", typeof(int));
                            dataTable.Columns.Add("ProdName");
                            dataTable.Columns.Add("ProdQty", typeof(int));
                            dataTable.Columns.Add("ProdPrice", typeof(int));
                            dataTable.Columns.Add("ProdCatID", typeof(int));
                            dataTable.Columns.Add("ProdCat");
                            dataTable.Columns.Add("Date", typeof(DateTime));

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
                            dataTable.Columns.Add("ProdId", typeof(int));
                            dataTable.Columns.Add("ProdName");
                            dataTable.Columns.Add("ProdQty", typeof(int));
                            dataTable.Columns.Add("ProdPrice", typeof(int));
                            dataTable.Columns.Add("ProdCatID", typeof(int));
                            dataTable.Columns.Add("ProdCat");
                            dataTable.Columns.Add("Date", typeof(DateTime));

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
                        else if (typeOfClass.Name.Equals("Bills"))
                        {
                            dataTable.Columns.Add("ProdId", typeof(int));
                            dataTable.Columns.Add("ProdName");
                            dataTable.Columns.Add("ProdQty", typeof(int));
                            dataTable.Columns.Add("ProdPrice", typeof(int));
                            dataTable.Columns.Add("ProdCatID", typeof(int));
                            dataTable.Columns.Add("ProdCat");
                            dataTable.Columns.Add("Date", typeof(DateTime));

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
                        else if (typeOfClass.Name.Equals("BillingProducts"))
                        {
                            dataTable.Columns.Add("ProdId", typeof(int));
                            dataTable.Columns.Add("ProdName");
                            dataTable.Columns.Add("ProdQty", typeof(int));
                            dataTable.Columns.Add("ProdPrice", typeof(int));
                            dataTable.Columns.Add("ProdCatID", typeof(int));
                            dataTable.Columns.Add("ProdCat");
                            dataTable.Columns.Add("Date", typeof(DateTime));

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
                        var products = GetSetupDataProd(dataGridView, typeOfClass);
                        await SaveExcelFile(products, file, typeOfClass);
                    }
                    else if (typeOfClass.Equals("Categories"))
                    {
                        var categories = GetSetupDataProd(dataGridView, typeOfClass);
                        await SaveExcelFile(categories, file, typeOfClass);
                    }
                    else if (typeOfClass.Name.Equals("Bills"))
                    {
                        var bills = GetSetupDataProd(dataGridView, typeOfClass);
                        await SaveExcelFile(bills, file, typeOfClass);
                    }
                    else if (typeOfClass.Name.Equals("BillingProducts"))
                    {
                        var billProducts = GetSetupDataProd(dataGridView, typeOfClass);
                        await SaveExcelFile(billProducts, file, typeOfClass);
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

        private List<object> GetSetupDataProd(DataGridView dataGridView, Type type)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (type.Name.Equals("Products"))
                    {
                        Products prod = new Products();
                        prod.ProdId = Convert.ToInt32(row.Cells["ProdId"].Value);
                        prod.ProdCat = row.Cells["ProdCat"].Value.ToString();
                        prod.ProdName = row.Cells["ProdName"].Value.ToString();
                        prod.ProdPrice = Convert.ToInt32(row.Cells["ProdPrice"].Value);
                        prod.ProdQty = Convert.ToInt32(row.Cells["ProdQty"].Value);
                        prod.ProdCatID = Convert.ToInt32(row.Cells["ProdCatID"].Value);
                        prod.Date = DateTime.Parse(row.Cells["Date"].Value.ToString());
                        data.Add(prod);
                    }
                    else if (type.Name.Equals("Categories"))
                    {
                        Categories cat = new Categories();
                        cat.CatId = Convert.ToInt32(row.Cells["CatId"].Value);
                        cat.CatName = row.Cells["CatName"].Value.ToString();
                        cat.CatDesc = row.Cells["CatDesc"].Value.ToString();
                        cat.Date = DateTime.Parse(row.Cells["Date"].Value.ToString());
                        data.Add(cat);
                    }
                    else if (type.Name.Equals("Bills"))
                    {
                        Bills bills = new Bills();
                        bills.Id = Convert.ToInt32(row.Cells["Id"].Value);
                        bills.Comments = row.Cells["Comments"].Value.ToString();
                        bills.SellName = row.Cells["SellName"].Value.ToString();
                        bills.BillDate = row.Cells["BillDate"].Value.ToString();
                        bills.TotAmt = Convert.ToInt32(row.Cells["TotAmt"].Value);
                        data.Add(bills);
                    }
                    else if (type.Name.Equals("BillingProducts"))
                    {
                        BillingProducts billProducts = new BillingProducts();
                        billProducts.Id = Convert.ToInt32(row.Cells["Id"].Value);
                        billProducts.ProdName = row.Cells["ProdName"].Value.ToString();
                        billProducts.Price = Convert.ToInt32(row.Cells["Price"].Value);
                        billProducts.Qty = Convert.ToInt32(row.Cells["Qty"].Value);
                        billProducts.Total = Convert.ToInt32(row.Cells["Total"].Value);
                        data.Add(billProducts);
                    }
                }
                return data;
            }
            catch
            {
                return null;
            }
        }

        private static async Task SaveExcelFile(List<object> data, FileInfo file, Type type)
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
                    if (type.Name.Equals("Products"))
                    {
                        ws.Cells["A1"].Value = "Report Products";
                    }
                    else if (type.Name.Equals("Categories"))
                    {
                        ws.Cells["A1"].Value = "Report Categories";
                    }
                    else if (type.Name.Equals("Bills"))
                    {
                        ws.Cells["A1"].Value = "Report Bills";
                    }
                    else if (type.Name.Equals("BillingProducts"))
                    {
                        ws.Cells["A1"].Value = "Report Billing Products";
                    }
                    
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
