using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Framework;
using System.Drawing.Printing;

namespace CHMS
{
    public partial class FrmRptMonthLog : Form
    {
        public FrmRptMonthLog()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            BindDayLog();
        }

        private void frmRptMonthLog_Load(object sender, EventArgs e)
        {
            new TreeViewManager().BindTreeView(this.tvUserInfo);
        }
        private void BindDayLog()
        {
            try
            {
                string UserID = new TreeViewManager().GetCheckedValues(tvUserInfo);
                if (UserID == "")
                {
                    MessageBox.Show("请选择需要统计的人员", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DateTime StartDateTime = dtStartDate.Value;
                DateTime EndDateTime = dtEndDate.Value;
                DataSet ds;
                ReturnValue rtn = new BLL.BLLAttLog().QueryUserMonthLog(UserID, StartDateTime, EndDateTime, out ds);
                if (rtn.Result == 1)
                {
                    dgvDayLog.AutoGenerateColumns = false;
                    dgvDayLog.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                LogManager.WriteTextLog("frmRptRecordLog", "", "BindAttRecordLog", ex.Message + ex.StackTrace);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                string UserID = new TreeViewManager().GetCheckedValues(tvUserInfo);
                if (UserID == "")
                {
                    MessageBox.Show("请选择需要统计的人员", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DateTime StartDateTime = dtStartDate.Value;
                DateTime EndDateTime = dtEndDate.Value;
                DataSet ds;
                ReturnValue rtn = new BLL.BLLAttLog().QueryUserMonthLog(UserID, StartDateTime, EndDateTime, out ds);
                if (rtn.Result == 1)
                {
                    string path = Application.StartupPath + @"\Report\80004.fr3";
                    PrintDocument prtdoc = new PrintDocument();
                    ///获得默认打印机机器名称
                    string PrintName = prtdoc.PrinterSettings.PrinterName;
                    FastReportSettings frs = new FastReportSettings(FastReportSettings.Mode.Preview, path, PrintName);
                    frs.AddReportParameter(new FastReportSettings.ReportParameter("Caption", Parameter.CurrentCompany.ChineseName + "考勤月报信息表"));
                    DataTable dt = ds.Tables[0];
                    FastReport.Invoke(this.Handle, dt, frs);
                }
            }
            catch (Exception ex)
            {
                LogManager.WriteTextLog("frmRptRecordLog", "", "BindAttRecordLog", ex.Message + ex.StackTrace);
            }
        }
        private void btnXls_Click(object sender, EventArgs e)
        {
            XlsReport.ExportDGVToExcel.ExportDataGridToExcel(this.dgvDayLog, "考勤月报信息");
        }
    }
}
