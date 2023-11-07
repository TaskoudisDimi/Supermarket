using ClassLibrary1.Models;
using DataClass;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using SupermarketTuto.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public class ExcelFile
    {

        #region Csv files

        public DataTable import<T>(Type type) where T : class
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

                        table = GetData<T>(dialog.FileName);
                        SourceURl = dialog.FileName;
                        if (table.Rows != null && table.Rows.Count > 0)
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

        private DataTable GetData<T>(string path) where T : class
        {
            PropertyInfo[] properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

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
                            if (headerWord == "ProdId")
                            {
                                dt.Columns.Add(new DataColumn(headerWord));
                                dt.PrimaryKey = new DataColumn[] { dt.Columns["ProdId"] };
                            }
                            else if (headerWord == "CatId")
                            {
                                dt.Columns.Add(new DataColumn(headerWord));
                                dt.PrimaryKey = new DataColumn[] { dt.Columns["CatId"] };
                            }
                            else
                            {
                                dt.Columns.Add(new DataColumn(headerWord));
                            }
                        }
                        //Set the data types of the columns
                        foreach (PropertyInfo p in properties)
                        {
                            Type getType = GetProperties(p, dt.Columns[$"{p.Name}"].DataType);
                            dt.Columns[$"{p.Name}"].DataType = getType;
                        }
                        //For Data
                        for (int i = 1; i < lines.Length; i++)
                        {
                            string[] dataWords = lines[i].Split(',');
                            if (dataWords.Length > 0 && string.IsNullOrEmpty(dataWords[dataWords.Length - 1]))
                            {
                                // Remove the last element from the array
                                Array.Resize(ref dataWords, dataWords.Length - 1);
                            }
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

        public void exportCsv(DataGridView table, bool useSelected = false)
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
                                    if (table.Columns[i].HeaderText.ToString() != "Select")
                                        colNames += table.Columns[i].HeaderText.ToString();
                                }
                                else
                                {
                                    if (table.Columns[i].HeaderText.ToString() != "Select")
                                        colNames += table.Columns[i].HeaderText.ToString() + ",";
                                }
                            }
                            outputCSV[0] += colNames;

                            for (int i = 1; (i - 1) < table.Rows.Count; i++)
                            {
                                if (useSelected)
                                {
                                    for (int j = 1; j < colCount; j++)
                                    {
                                        outputCSV[i] += table.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                    }
                                }
                                else
                                {
                                    for (int j = 0; j < colCount; j++)
                                    {
                                        outputCSV[i] += table.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                    }
                                }
                            }
                            File.WriteAllLines(dialog.FileName, outputCSV, Encoding.UTF8);
                            MessageBox.Show("Successfully export", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public bool SaveToDB(DataTable table, Type type)
        {
            //Save the table

            if (type.Name == "CategoryTbl")
            {
                List<CategoryTbl> list = Utils.ToList<CategoryTbl>(table);
                foreach (CategoryTbl item in list)
                {
                    CategoryTbl cat = DataModel.Select<CategoryTbl>(where: $"CatName = '{item.CatName}'").FirstOrDefault();
                    if (cat == null)
                        DataModel.Create<CategoryTbl>(item);
                }
            }
            else if (type.Name == "ProductTbl")
            {
                List<ProductTbl> list = Utils.ToList<ProductTbl>(table);
                foreach (ProductTbl item in list)
                {
                    ProductTbl prod = DataModel.Select<ProductTbl>(where: $"ProdName = '{item.ProdName}'").FirstOrDefault();
                    if (prod == null)
                    {
                        CategoryTbl catId = DataModel.Select<CategoryTbl>(where: $"CatName = '{item.ProdCat}'").FirstOrDefault();
                        if (catId != null)
                        {
                            item.ProdCatID = catId.CatId;
                            DataModel.Create<ProductTbl>(item);
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }

            return false;
        }

        #region Xlsx files


        //Import
        public List<T> ImportExcel<T>() where T : new()
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog()
                {
                    Title = "Browse Text File",
                    CheckFileExists = true,
                    CheckPathExists = true,
                    Filter = "xlsx files (*.xlsx)|*.xlsx",
                    FilterIndex = 2,
                    RestoreDirectory = true,
                    ReadOnlyChecked = true,
                    ShowReadOnly = true
                };

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    if (dialog.FileName.EndsWith(".xlsx"))
                    {
                        ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                        var modelType = typeof(T);
                        var properties = modelType.GetProperties();
                        var propertyNames = properties.Select(prop => prop.Name).ToList();

                        List<T> resultList = new List<T>();

                        using (var package = new ExcelPackage(new FileInfo(dialog.FileName)))
                        {
                            ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // Assuming the first worksheet

                            // Find the actual used range of the worksheet
                            var start = worksheet.Dimension.Start;
                            var end = worksheet.Dimension.End;

                            for (int row = start.Row + 2; row <= end.Row; row++)
                            {
                                T modelObject = new T();

                                for (int col = 1; col <= propertyNames.Count; col++)
                                {
                                    var propertyName = propertyNames[col - 1];
                                    var property = properties.First(p => p.Name == propertyName);

                                    // Assuming the column names in Excel match the property names in your model
                                    var cellValue = worksheet.Cells[row, col].Text;

                                    // Convert cell value to the property's type with error handling
                                    if (property.PropertyType == typeof(DateTime))
                                    {
                                        DateTime value = ConvertExcelDateToDateTime(Convert.ToDouble(cellValue));
                                        property.SetValue(modelObject, value);
                                    }
                                    else if (IsNumericType(property.PropertyType))
                                    {
                                        if (Int32.TryParse(cellValue, out Int32 numericValue))
                                        {
                                            property.SetValue(modelObject, numericValue);
                                        }
                                        else
                                        {
                                            // Handle invalid numeric format (e.g., set a default value)
                                            property.SetValue(modelObject, 0);
                                        }
                                    }
                                    else
                                    {
                                        // Handle other property types as needed
                                        property.SetValue(modelObject, cellValue);
                                    }
                                }
                                resultList.Add(modelObject);
                            }
                        }
                        return resultList;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                // Handle exceptions here
                return null;
            }
        }

        private bool IsNumericType(Type type)
        {
            return type == typeof(int) || type == typeof(double) || type == typeof(float) || type == typeof(decimal);
        }

        public static DateTime ConvertExcelDateToDateTime(double excelDate)
        {
            return DateTime.FromOADate(excelDate);
        }



        //Export
        public async Task ExportExcel<T>(DataGridView dataGridView, string title) where T : new()
        {
            try
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                string path = "";

                SaveFileDialog dialog = new SaveFileDialog()
                {
                    Filter = "xlsx (*.xlsx)|*.xlsx",
                    Title = "xlsx Files",
                    RestoreDirectory = true
                };

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    path = dialog.FileName;
                    FileInfo file = new FileInfo(path);
                    List<T> data = GetSetupDataProd<T>(dataGridView);

                    await SaveExcelFile<T>(data, file, title);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions here
            }
        }

        private List<T> GetSetupDataProd<T>(DataGridView dataGridView) where T : new()
        {
            List<T> data = new List<T>();

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                T model = new T();

                foreach (PropertyInfo property in typeof(T).GetProperties())
                {
                    string propertyName = property.Name;
                    if (dataGridView.Columns.Contains(propertyName))
                    {
                        object cellValue = row.Cells[propertyName].Value;
                        if (cellValue != null)
                        {
                            // Convert cell value to the property's type
                            if (property.PropertyType == typeof(DateTime))
                            {
                                property.SetValue(model, DateTime.Parse(cellValue.ToString()));
                            }
                            else
                            {
                                property.SetValue(model, Convert.ChangeType(cellValue, property.PropertyType));
                            }
                        }
                    }
                }

                data.Add(model);
            }

            return data;
        }

        private async Task SaveExcelFile<T>(List<T> data, FileInfo file, string title)
        {
            DeleteIfExists(file);

            using (var package = new ExcelPackage(file))
            {
                ExcelWorksheet ws = package.Workbook.Worksheets.Add("MainReport");

                var range = ws.Cells["A2"].LoadFromCollection(data, true);
                range.AutoFitColumns();
                ws.Cells["A1"].Value = "Report " + title;

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
            }
        }

        private void DeleteIfExists(FileInfo file)
        {
            if (file.Exists)
            {
                file.Delete();
            }
        }


        #endregion


        #region Helpers

        private Type GetProperties(PropertyInfo prop, Type type)
        {

            if (prop.PropertyType == typeof(int))
            {
                return typeof(System.Int32);
            }
            else if (prop.PropertyType == typeof(string))
            {
                return typeof(System.String);
            }
            else if (prop.PropertyType == typeof(double))
            {
                return typeof(System.Double);
            }
            else if (prop.PropertyType == typeof(decimal))
            {
                return typeof(System.Decimal);
            }
            else if (prop.PropertyType == typeof(bool))
            {
                return typeof(System.Boolean);
            }
            else if (prop.PropertyType == typeof(DateTime))
            {
                return typeof(System.DateTime);
            }
            return null;
        }

        #endregion

    }
}
