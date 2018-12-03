using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Framework;
//下载源码到51aspx
namespace CHMS
{
    public partial class FrmRptSpeday : Form
    {
        private DataAccess.SqlProvider DbHelperSQL;
        public FrmRptSpeday()
        {
            InitializeComponent();
            DbHelperSQL = new DataAccess.SqlProvider();
        }
        private void frmRptSpeday_Load(object sender, EventArgs e)
        {
            new TreeViewManager().BindTreeView(this.tvUserInfo);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXls_Click(object sender, EventArgs e)
        {
            XlsReport.ExportDGVToExcel.ExportDataGridToExcel(this.dgvSpedayLog, "请假详细信息");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            XlsReport.PrintDGV.PrintMode = 0;
            XlsReport.PrintDGV.Print_DataGridView(this.dgvSpedayLog);
        }
        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                string UserInfo = new TreeViewManager().GetCheckedValues(tvUserInfo);
                if (UserInfo == "")
                {
                    MessageBox.Show("请选择人员信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string StartDate = dtStartDate.Value.ToShortDateString();
                string EndDate = dtEndDate.Value.ToShortDateString();
                DataSet ds;
                ReturnValue rtn = new BLL.BLLAttLog().QueryUserSpeday(UserInfo, StartDate, EndDate, out ds);
                if (rtn.Result == 1)
                {
                    this.dgvSpedayLog.AutoGenerateColumns = false;
                    this.dgvSpedayLog.DataSource = ds.Tables[0];//5!1+a+s+p+x
                    this.dgvSpedayLog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
            }
            catch (Exception ex)
            {
                LogManager.WriteTextLog("CHMS", "frmRunUser", "btnSave_Click", ex.Message + ex.StackTrace);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (labIDX.Text == "")
            {
                MessageBox.Show("请选择删除的信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
               string strSql=string.Format("DELETE FROM [AttendanceSpeday] WHERE Idx={0}",labIDX.Text);
               if (DbHelperSQL.ExcuteNonQuery(strSql, CommandType.Text) > 0)
               {
                   MessageBox.Show("删除成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   labIDX.Text = "";
                   btnQuery_Click(sender, e);
               }
               else
               {
                   MessageBox.Show("删除失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
            }

        }
        private void dgvSpedayLog_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvSpedayLog.DataSource != null && this.dgvSpedayLog.Rows.Count > 0)
            {
                if (e.RowIndex != -1)
                {
                    labIDX.Text = dgvSpedayLog.Rows[e.RowIndex].Cells["IDX"].Value.ToString();
                }
            }
        }
    }
}
