using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;

using Excel = Microsoft.Office.Interop.Excel;

namespace DAL
{
    /// <summary>
    /// EXEL��������
    /// </summary>
    public class ImportExportToExcel
    {
        /// <summary>
        /// ���캯��
        /// </summary>
        public ImportExportToExcel() { }

        /// <summary>
        /// ��ȡָ����Excel�ļ�
        /// </summary>
        /// <param name="strFileName">Excel�ļ�����·��</param>
        /// <returns>DataTable</returns>
        public DataTable ImportFromExcel(string strFileName)
        {
            DataTable ds = new DataTable();
            ds = DoImport(strFileName);
            return ds;
        }

        /// <summary>
        /// ִ�е���
        /// </summary>
        /// <param name="strFileName">�ļ�����·��</param>
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
                OleDbDataAdapter sda = new OleDbDataAdapter("SELECT ���,����,����,���� FROM [Sheet1$]", dbcnn);
                DataTable ExcelDs = new DataTable();
                sda.Fill(ExcelDs);
                return ExcelDs;
            }
        }

        /// <summary>
        /// ����ָ����Excel�ļ�,��DataSet������Excel#region ��DataSet������Excel
        /// </summary>
        /// <param name="ds">Ҫ������DataTable</param>
        /// <param name="strExcelFileName">Ҫ������Excel�ļ���</param>
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
        /// �����û�ѡ���Excel�ļ�
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
        /// ִ�е���
        /// </summary>
        /// <param name="ds">Ҫ������DataTable</param>
        /// <param name="strExcelFileName">Ҫ�������ļ���</param>
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

                GC.Collect();//��������
            }
        }


        /// <summary>
        ///  ��XML���뵽DataTabl
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable ImportFromXML()
        {
            DataTable ds = new DataTable();
            System.Windows.Forms.OpenFileDialog openFileDlg = new System.Windows.Forms.OpenFileDialog();
            openFileDlg.DefaultExt = "xml";
            openFileDlg.Filter = "xml�ļ� (*.xml)|*.xml";
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
        /// ��ָ����XML�ļ�����
        /// </summary>
        /// <param name="strFileName">XML�ļ���</param>
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
        /// ����ָ����XML�ļ�
        /// </summary>
        /// <param name="ds">Ҫ������DataTable</param>
        /// <param name="strXMLFileName">Ҫ������XML�ļ���</param>
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
        /// �����û�ѡ���XML�ļ�
        /// </summary>
        /// <param name="ds">DataSet</param>
        public void ExportToXML(DataTable ds)
        {
            System.Windows.Forms.SaveFileDialog saveFileDlg = new System.Windows.Forms.SaveFileDialog();
            saveFileDlg.DefaultExt = "xml";
            saveFileDlg.Filter = "xml�ļ� (*.xml)|*.xml";
            if (saveFileDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DoExportXML(ds, saveFileDlg.FileName);
            }
        }

        /// <summary>
        /// ִ�е���
        /// </summary>
        /// <param name="ds">Ҫ������DataTable</param>
        /// <param name="strXMLFileName">Ҫ������XML�ļ���</param>
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
