using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void read_xlsx_button_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Range range;

            string str;
            int rCnt;
            int cCnt;
            int rw = 0;
            int cl = 0;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(@"E:\9_Github\12_GuruOfPython\Read-Excel-File-in-C-\Read_XLSX\HE+D4D-Mailing List.xlsx", 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            range = xlWorkSheet.UsedRange;
            rw = range.Rows.Count;
            cl = range.Columns.Count;


            for (rCnt = 1; rCnt <= rw; rCnt++)
            {
                List<string> row = new List<string>();
                for (cCnt = 1; cCnt <= cl; cCnt++)
                {
                    //str = (string)(range.Cells[rCnt, cCnt] as Excel.Range).Value2;
                    //MessageBox.Show(str);
                    try
                    {
                        str = (range.Cells[rCnt, cCnt] as Excel.Range).Value2.ToString();
                    }
                    catch
                    {
                        str = "";
                    }
                    row.Add(str);
                }
                string row_str = string.Join(",", row.ToArray());
                Console.WriteLine(row_str);
            }

            xlWorkBook.Close(true, null, null);
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);
        }

        private void http_request_button_Click(object sender, EventArgs e)
        {
            var responseString = await client.GetStringAsync("http://www.example.com/recepticle.aspx");
            Console.WriteLine(responseString);
        }
    }
}
