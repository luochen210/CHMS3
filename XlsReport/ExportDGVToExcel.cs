using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace XlsReport
{
    public class ExportDGVToExcel
    {
        /// <summary>
        /// 导出DataGrid数据到Excel
        /// </summary>
        /// <param name="dgv">DataGridView</param>
        /// <param name="caption">表标题</param>
        public static void ExportDataGridToExcel(DataGridView dgv, string caption)
        {
            try
            {
                Excel.ApplicationClass Mylxls = new Excel.ApplicationClass();
                Mylxls.Application.Workbooks.Add(true);
                Mylxls.Caption = caption;

                int rowIndex = 2;//在EXCEL第2行开始写入数据                 
                int row_cnt = dgv.Rows.Count;
                int col_cnt = dgv.Columns.Count;

                //遍历数据表中的所有列得到列头
                string[] arr_caption = new string[dgv.Columns.Count];
                int arrindex = 0;
                foreach (DataGridViewColumn cs in dgv.Columns)
                {

                    arr_caption[arrindex] = cs.HeaderText;
                    arrindex++;

                }

                //逐行写入数据，表中第1行显示列标题 
                //创建表格的列头
                for (int celindex = 0; celindex < col_cnt; celindex++)
                {
                    Mylxls.Cells[1, celindex + 1] = arr_caption[celindex]; ;
                }
                //这里要注意,由于DataGrid中总是要多显示一行，而最后一行中没有数据，所以在读取的时候不要读最后一行                 
                for (int row = 0; row < row_cnt; row++)
                {
                    for (int col = 0; col < col_cnt; col++)
                    {
                        try
                        {
                            //5+1+a+s+p+x
                            Excel.Range myrange = Mylxls.get_Range(Mylxls.Cells[rowIndex, col + 1], Mylxls.Cells[rowIndex, col + 1]);
                            myrange.NumberFormatLocal = "@";//文本格式 
                            Mylxls.Cells[rowIndex, col + 1] = dgv.Rows[row].Cells[col].Value.ToString();
                        }
                        catch
                        {
                            return;
                        }
                    }
                    rowIndex++;
                }
                Mylxls.Visible = true;

            }
            catch
            {
                return;
            }
        }
    }
}
