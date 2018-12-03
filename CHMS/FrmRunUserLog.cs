using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Framework;

namespace CHMS
{
    public partial class FrmRunUserLog : Form
    {

        public FrmRunUserLog()
        {
            InitializeComponent();
        }
        private void frmRunUserLog_Load(object sender, EventArgs e)
        {
            //  
            new TreeViewManager().BindTreeView(this.tvUserInfo);
        }
        // 当用户选择下拉列表框时改变DataGridView单元格的内容
        private void cbRunNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbRunNum = (ComboBox)sender;
            dgvRunUserLog.CurrentCell.Value = cbRunNum.Text;
            dgvRunUserLog.CurrentCell.Tag = cbRunNum.SelectedValue;
        }
        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                string UserID = new TreeViewManager().GetCheckedValues(tvUserInfo);
                if (UserID == "")
                {
                    MessageBox.Show("请选择人员信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                DateTime StartDate = dtStartDate.Value;
                DateTime EndDate = dtEndDate.Value;
                DataSet ds;
                ReturnValue rtn = new BLLUserRun().QueryRunUserLog(UserID, StartDate, EndDate, out ds);
                if (rtn.Result == 1)
                {
                    DataTable dt = ds.Tables[0];
                    System.Windows.Forms.DataGridViewColumn[] Column = new System.Windows.Forms.DataGridViewColumn[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        if (i == 0)
                        {
                            System.Windows.Forms.DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                            col.Name = "UserID";
                            col.HeaderText = "编号";
                            col.DataPropertyName = "UserID";
                            Column[i] = col;
                        }
                        else if (i == 1)
                        {
                            System.Windows.Forms.DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                            col.Name = "UserName";
                            col.HeaderText = "姓名";
                            col.DataPropertyName = "UserName";
                            Column[i] = col;
                        }
                        else
                        {
                            System.Windows.Forms.DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();                        
                            col.DataPropertyName = dt.Columns[i].ColumnName;                       
                            col.HeaderText = dt.Columns[i].ColumnName;
                            col.Name = dt.Columns[i].ColumnName;
                            Column[i] = col;
                        }
                    }
                    this.dgvRunUserLog.Columns.Clear();
                    this.dgvRunUserLog.Columns.AddRange(Column);
                    this.dgvRunUserLog.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("统计失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                LogManager.WriteTextLog("CHMS", "frmRunUserLog", "btnQuery_Click", ex.Message + ex.StackTrace);
            }
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            XlsReport.PrintDGV.PrintMode = 0;
            XlsReport.PrintDGV.Print_DataGridView(this.dgvRunUserLog);
        }
        private void btnXls_Click(object sender, EventArgs e)
        {
            XlsReport.ExportDGVToExcel.ExportDataGridToExcel(this.dgvRunUserLog, "排班详细信息");
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
