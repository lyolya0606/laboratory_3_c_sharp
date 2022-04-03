using Microsoft.Office.Interop.Excel;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace laboratory_3 {
    class ExcelWork : IDisposable {
        private Application excel;
        private Workbook workbook;
        private string filePath;
        private Worksheet worksheet;

        public ExcelWork() {
            excel = new Excel.Application();
        }

        public bool Open(string fileName) {
            try {
                if (File.Exists(fileName)) {
                    workbook = excel.Workbooks.Open(fileName);
                    
                } else {
                    workbook = excel.Workbooks.Add();
                    filePath = fileName;
                }
                return true;
            } catch (Exception) {
                return false;
            }
        }

        public void Save() {
            if (!string.IsNullOrEmpty(filePath)) {
                workbook.SaveAs(filePath);
                filePath = null;
            }
            else {
                workbook.Save();
            }
        }

        public bool SetData(string column, int row, object data) {
            try {
                ((Excel.Worksheet)excel.ActiveSheet).Cells[row, column] = data;
                return true;

            } catch (Exception) {
                return false;
            }
        }

        public void DrawInExcel() {
            object misValue = System.Reflection.Missing.Value;
            worksheet = (Excel.Worksheet)workbook.Worksheets.get_Item(1);
            Excel.Range chartRange;
            Excel.ChartObjects chartObjects = (Excel.ChartObjects)worksheet.ChartObjects(Type.Missing);
            Excel.ChartObject myChart = (Excel.ChartObject)chartObjects.Add(10, 80, 300, 250);
            Excel.Chart chartPage = myChart.Chart;
                
            chartRange = worksheet.get_Range("A7", "B100");
            chartPage.SetSourceData(chartRange, misValue);
            //chartPage.ChartType = Excel.XlChartType.xlColumnClustered;
            chartPage.ChartType = Excel.XlChartType.xlLine;

        } 

        public void Dispose() {
            try {
                workbook.Close();
                excel.Quit();
            } catch (Exception) {

            }
        }
    }
}
