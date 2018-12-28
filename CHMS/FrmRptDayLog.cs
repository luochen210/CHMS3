using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using DAL;
using System.Drawing.Printing;

namespace CHMS
{
    public partial class FrmRptDayLog : Form
    {
        public FrmRptDayLog()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRptDayLog_Load(object sender, EventArgs e)
        {
            new TreeViewManager().BindTreeView(this.tvUserInfo);
        }
        private void btnQuery_Click(object sender, EventArgs e)
        {
            BindDayLog();
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
                ReturnValue rtn = new BLL.BLLAttLog().QueryUserDayLog(UserID, StartDateTime, EndDateTime, out ds);
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

        private void btnXls_Click(object sender, EventArgs e)
        {
            XlsReport.ExportDGVToExcel.ExportDataGridToExcel(this.dgvDayLog, "考勤日报信息");
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
                ReturnValue rtn = new BLL.BLLAttLog().QueryUserDayLog(UserID, StartDateTime, EndDateTime, out ds);
                if (rtn.Result == 1)
                {
                    string path = Application.StartupPath + @"\Report\80003.fr3";
                    PrintDocument prtdoc = new PrintDocument();
                    ///获得默认打印机机器名称
                    string PrintName = prtdoc.PrinterSettings.PrinterName;
                    FastReportSettings frs = new FastReportSettings(FastReportSettings.Mode.Preview, path, PrintName);
                    frs.AddReportParameter(new FastReportSettings.ReportParameter("Caption", Parameter.CurrentCompany.ChineseName + "考勤日报信息表"));
                    DataTable dt = ds.Tables[0];
                    FastReport.Invoke(this.Handle, dt, frs);
                }

            }
            catch (Exception ex)
            {
                LogManager.WriteTextLog("frmRptRecordLog", "", "BindAttRecordLog", ex.Message + ex.StackTrace);
            }
        }
        private void frmRptDayLog_Activated(object sender, EventArgs e)
        {
            //注册热键Shift+S，Id号为100。HotKey.KeyModifiers.Shift也可以直接使用数字4来表示。 
            HotKey.RegisterHotKey(Handle, 100, HotKey.KeyModifiers.Shift, Keys.S);
        }

        private void frmRptDayLog_Leave(object sender, EventArgs e)
        {
            //注销Id号为100的热键设定   
            HotKey.UnregisterHotKey(Handle, 100);
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;
            switch (m.Msg)
            {
                case WM_HOTKEY:
                    switch (m.WParam.ToInt32())
                    {
                        case 100:    //Shift+S      
                            HotKey.UnregisterHotKey(Handle, 100);
                            FrmCreateAttLog objfrmCreateAttLog = new FrmCreateAttLog();
                            objfrmCreateAttLog.ShowDialog();
                            break;
                    }
                    break;
            }
            base.WndProc(ref m);
        }

        private void FrmRptDayLog_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain.objFrmRptDayLog = null;
        }
    }
}
