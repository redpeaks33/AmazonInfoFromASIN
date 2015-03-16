using Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ProductInfoFromASIN
{
    internal class ExcelExporter
    {
        internal void Start(ProductInfoDataGridView productInfoDataGridView, string FileName)
        {
            exportToExcel(productInfoDataGridView, FileName);
            //exportToCSV(productInfoDataGridView, FileName);
        }

        private void exportToCSV(ProductInfoDataGridView productInfoDataGridView, string FileName)
        {
            var dataTable = CreateDataTableFormDataGridView(productInfoDataGridView);
            ConvertDataTableToCsv(dataTable, FileName, true);
        }

        private System.Data.DataTable CreateDataTableFormDataGridView(ProductInfoDataGridView productInfoDataGridView)
        {
            var dt = new System.Data.DataTable();

            var cols = productInfoDataGridView.Columns;
            foreach (DataGridViewColumn c in cols)
            {
                if (c.ValueType != null)
                {
                    dt.Columns.Add(c.Name, c.ValueType);
                }
                else
                {
                    dt.Columns.Add(c.Name);
                }
            }

            var rows = productInfoDataGridView.Rows;
            foreach (DataGridViewRow r in rows)
            {
                List<object> array = new List<object>();
                foreach (DataGridViewCell cell in r.Cells)
                {
                    array.Add(cell.Value);
                }
                dt.Rows.Add(array.ToArray());
            }
            return dt;
        }

        private void exportToExcel(ProductInfoDataGridView productInfoDataGridView, string FileName)
        {
            FileInfo f = new FileInfo(FileName);
            //if (f.Extension.Equals(".csv"))
            {
                Microsoft.Office.Interop.Excel.Application xlApp;
                Workbook xlWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Worksheet)xlWorkBook.Worksheets.get_Item(1);

                xlWorkSheet.Cells[1, 1] = "ASIN";
                xlWorkSheet.Cells[1, 2] = "Image";
                xlWorkSheet.Cells[1, 3] = "ImageLink";
                xlWorkSheet.Cells[1, 4] = "URL";
                xlWorkSheet.Cells[1, 5] = "Category";
                xlWorkSheet.Cells[1, 6] = "AmazonRank";
                xlWorkSheet.Cells[1, 7] = "Price";

                int i = 0;
                int j = 0;

                for (i = 0; i <= productInfoDataGridView.RowCount - 1; i++)
                {
                    for (j = 0; j <= productInfoDataGridView.ColumnCount - 1; j++)
                    {
                        DataGridViewCell cell = productInfoDataGridView[j, i];
                        xlWorkSheet.Cells.Borders.LineStyle = XlLineStyle.xlContinuous;
                        xlWorkSheet.Columns.AutoFit();
                        if (cell.Value.GetType() == typeof(Bitmap))
                        {
                            xlWorkSheet.Cells[i + 2, j + 1] = (Bitmap)cell.Value;
                        }
                        else
                        {
                            xlWorkSheet.Cells[i + 2, j + 1] = cell.Value;
                        }
                    }
                }

                xlWorkSheet.Columns[2].Delete();

                xlWorkBook.SaveAs(f.Name, XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);
            }
            //else
            //{
            //    MessageBox.Show("Invalid file type");
            //}
        }

        private void releaseObject(Microsoft.Office.Interop.Excel.Application xlApp)
        {
            Marshal.ReleaseComObject(xlApp);
        }

        private void releaseObject(Workbook xlWorkBook)
        {
            Marshal.ReleaseComObject(xlWorkBook);
        }

        private void releaseObject(Worksheet xlWorkSheet)
        {
            Marshal.ReleaseComObject(xlWorkSheet);
        }

        #region CSV

        /// <summary>
        ///
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="csvPath"></param>
        /// <param name="writeHeader">with header : true, without header : false</param>
        public void ConvertDataTableToCsv(System.Data.DataTable dt, string csvPath, bool writeHeader)
        {
            System.Text.Encoding enc = System.Text.Encoding.GetEncoding("Shift_JIS");

            System.IO.StreamWriter sr = new System.IO.StreamWriter(csvPath, false, enc);

            int colCount = dt.Columns.Count;
            int lastColIndex = colCount - 1;

            if (writeHeader)
            {
                for (int i = 0; i < colCount; i++)
                {
                    string field = dt.Columns[i].Caption;
                    field = EncloseDoubleQuotesIfNeed(field);
                    sr.Write(field);
                    if (lastColIndex > i)
                    {
                        sr.Write(',');
                    }
                }
                sr.Write("\r\n");
            }

            foreach (DataRow row in dt.Rows)
            {
                for (int i = 0; i < colCount; i++)
                {
                    string field = row[i].ToString();
                    field = EncloseDoubleQuotesIfNeed(field);
                    sr.Write(field);
                    if (lastColIndex > i)
                    {
                        sr.Write(',');
                    }
                }
                sr.Write("\r\n");
            }

            sr.Close();
        }

        private string EncloseDoubleQuotesIfNeed(string field)
        {
            if (NeedEncloseDoubleQuotes(field))
            {
                return EncloseDoubleQuotes(field);
            }
            return field;
        }

        private string EncloseDoubleQuotes(string field)
        {
            if (field.IndexOf('"') > -1)
            {
                field = field.Replace("\"", "\"\"");
            }
            return "\"" + field + "\"";
        }

        private bool NeedEncloseDoubleQuotes(string field)
        {
            return field.IndexOf('"') > -1 ||
                field.IndexOf(',') > -1 ||
                field.IndexOf('\r') > -1 ||
                field.IndexOf('\n') > -1 ||
                field.StartsWith(" ") ||
                field.StartsWith("\t") ||
                field.EndsWith(" ") ||
                field.EndsWith("\t");
        }

        #endregion CSV
    }
}