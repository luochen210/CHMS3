using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;

using Excel = Microsoft.Office.Interop.Excel;

namespace DAL
{
    /// <summary>
    /// EXEL操作对象
    /// </summary>
    public class ImportExportToExcel
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public ImportExportToExcel() { }

        /// <summary>
        /// 读取指定的Excel文件
        /// </summary>
        /// <param name="strFileName">Excel文件名及路径</param>
        /// <returns>DataTable</returns>
        public DataTable ImportFromExcel(string strFileName)
        {
            DataTable ds = new DataTable();
            ds = DoImport(strFileName);
            return ds;
        }

        /// <summary>
        /// 执行导入
        /// </summary>
        /// <param name="strFileName">文件名及路径</param>
        /// <returns>DataTable</returns>
        private DataTable DoImport(string strFileName)
        {
            if (strFileName == "")
            {
                return null;
            }
            else
            {
                string strConn = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + strFileName + ";Extended Properties=Excel 8.0;";
                OleDbConnection dbcnn = new OleDbConnection(strConn);
                dbcnn.Open();
                OleDbDataAdapter sda = new OleDbDataAdapter("SELECT 编号,姓名,部门,工号 FROM [Sheet1$]", dbcnn);
                DataTable ExcelDs = new DataTable();
                sda.Fill(ExcelDs);
                return ExcelDs;
            }
        }

        /// <summary>
        /// 导出指定的Excel文件,从DataSet到出到Excel#region 从DataSet到出到Excel
        /// </summary>
        /// <param name="ds">要导出的DataTable</param>
        /// <param name="strExcelFileName">要导出的Excel文件名</param>
        public void ExportToExcel(DataTable ds, string strExcelFileName)
        {
            if (ds.Rows.Count == 0 || strExcelFileName == "")
            {
                return;
            }
            else
            {
                DoExport(ds, strExcelFileName);
            }

        }
        /// <summary>
        /// 导出用户选择的Excel文件
        /// </summary>
        /// <param name="ds">DataTable</param>
        public void ExportToExcel(DataTable ds)
        {
            System.Windows.Forms.OpenFileDialog saveFileDlg = new System.Windows.Forms.OpenFileDialog();
            if (saveFileDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DoExport(ds, saveFileDlg.FileName);
            }

        }
        /// <summary>
        /// 执行导出
        /// </summary>
        /// <param name="ds">要导出的DataTable</param>
        /// <param name="strExcelFileName">要导出的文件名</param>
        private void DoExport(DataTable ds, string strExcelFileName)
        {
            Excel.Application excel = new Excel.Application();
            int rowIndex = 1;
            int colIndex = 0;
            excel.Application.Workbooks.Add(true);
            System.Data.DataTable table = ds;
            try
            {
                foreach (DataColumn col in table.Columns)
                {
                    colIndex++;
                    excel.Cells[1, colIndex] = col.ColumnName;
                }

                foreach (DataRow row in table.Rows)
                {
                    rowIndex++;
                    colIndex = 0;
                    foreach (DataColumn col in table.Columns)
                    {
                        colIndex++;
                        excel.Cells[rowIndex, colIndex] = row[col.ColumnName].ToString();
                    }
                }
                excel.Visible = false;
                excel.ActiveWorkbook.SaveAs(strExcelFileName + ".XLS", Excel.XlFileFormat.xlExcel9795, null, null, false, false, Excel.XlSaveAsAccessMode.xlNoChange, null, null, null, null);
                excel.Quit();
                excel = null;

            }
            catch (Exception err)
            {

                throw err;
            }
            finally
            {

                GC.Collect();//垃圾回收
            }
        }


        /// <summary>
        ///  从XML导入到DataTabl
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable ImportFromXML()
        {
            DataTable ds = new DataTable();
            System.Windows.Forms.OpenFileDialog openFileDlg = new System.Windows.Forms.OpenFileDialog();
            openFileDlg.DefaultExt = "xml";
            openFileDlg.Filter = "xml文件 (*.xml)|*.xml";
            if (openFileDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    ds.ReadXml(openFileDlg.FileName);
                }
                catch (Exception err)
                {
                    throw err;
                }
                finally
                {
                    GC.Collect();
                }
            }
            return ds;
        }
        /// <summary>
        /// 从指定的XML文件导入
        /// </summary>
        /// <param name="strFileName">XML文件名</param>
        /// <returns>DataTable</returns>
        public DataTable ImportFromXML(string strFileName)
        {
            if (strFileName == "")
            {
                return null;
            }
            else
            {
                DataTable ds = new DataTable();
                try
                {
                    ds.ReadXml(strFileName);
                }
                catch (Exception err)
                {
                    throw err;
                }
                finally
                {
                    GC.Collect();
                }
                return ds;
            }
        }
        /// <summary>
        /// 导出指定的XML文件
        /// </summary>
        /// <param name="ds">要导出的DataTable</param>
        /// <param name="strXMLFileName">要导出的XML文件名</param>
        public void ExportToXML(DataTable ds, string strXMLFileName)
        {
            if (ds.Rows.Count == 0 || strXMLFileName == "")
            {
                return;
            }
            else
            {
                DoExportXML(ds, strXMLFileName);
            }
        }
        /// <summary>
        /// 导出用户选择的XML文件
        /// </summary>
        /// <param name="ds">DataSet</param>
        public void ExportToXML(DataTable ds)
        {
            System.Windows.Forms.SaveFileDialog saveFileDlg = new System.Windows.Forms.SaveFileDialog();
            saveFileDlg.DefaultExt = "xml";
            saveFileDlg.Filter = "xml文件 (*.xml)|*.xml";
            if (saveFileDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DoExportXML(ds, saveFileDlg.FileName);
            }
        }

        /// <summary>
        /// 执行导出
        /// </summary>
        /// <param name="ds">要导出的DataTable</param>
        /// <param name="strXMLFileName">要导出的XML文件名</param>
        private void DoExportXML(DataTable ds, string strXMLFileName)
        {
            try
            {
                ds.WriteXml(strXMLFileName, System.Data.XmlWriteMode.WriteSchema);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
