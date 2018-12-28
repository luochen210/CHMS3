using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;
using BLL;
using Models;

namespace CHMS
{
    public partial class FrmRunUserDaily : Form
    {
        public FrmRunUserDaily()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRunUserLog.DataSource != null && dgvRunUserLog.Rows.Count > 0)
                {
                    BLLUserRun userRun = new BLLUserRun();
                    string UserID = "";
                    string RunID = "";
                    string RunDate = "";
                    string SchclassInfo = "";
                    for (int i = 0; i < dgvRunUserLog.Rows.Count; i++)
                    {
                        UserID = dgvRunUserLog.Rows[i].Cells["UserID"].Value.ToString();
                        for (int j = 0; j < dgvRunUserLog.Columns.Count; j++)
                        {
                            if (j > 1)
                            {
                                if (dgvRunUserLog.Rows[i].Cells[j].Value != null)
                                {
                                    RunID = dgvRunUserLog.Rows[i].Cells[j].Value.ToString();
                                    RunDate = dgvRunUserLog.Columns[j].Name;
                                    SchclassInfo = GetSchclassInfo(RunID);
                                    userRun.AddRunUserDaily(UserID, RunID, RunDate, SchclassInfo);
                                }
                            }
                        }
                    }
                }
                MessageBox.Show("排班成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                LogManager.WriteTextLog("CHMS", "frmRunUserDaily", "btnSave_Click", ex.Message + ex.StackTrace);
                MessageBox.Show("排班失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void btnColse_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmRunUserDaily_Load(object sender, EventArgs e)
        {
            //       
            lsbRunInfo.DataSource =new BLL.BLLRunNum().GetList();
            lsbRunInfo.DisplayMember = "Name";
            lsbRunInfo.ValueMember = "RunID";
            //
            new TreeViewManager().BindTreeView(this.tvUserInfo);
        }
        private void btnDown_Click(object sender, EventArgs e)
        {
            if (lsbRunInfo.SelectedValue != null)
            {
                lsbSelectRunInfo.Items.Add(new RunItem(lsbRunInfo.SelectedValue.ToString(), lsbRunInfo.Text));
                lsbSelectRunInfo.ValueMember = "RunID";
                lsbSelectRunInfo.DisplayMember = "RunName";
            }
        }
        private void btnUp_Click(object sender, EventArgs e)
        {
            if (lsbSelectRunInfo.SelectedIndex != -1)
            {
                lsbSelectRunInfo.Items.RemoveAt(lsbSelectRunInfo.SelectedIndex);
            }
        }

        private string GetSchclassInfo(string RunID)
        {
            StringBuilder sb = new StringBuilder();
            BLLRunNum CurBLLRunNum = new BLLRunNum();
            IList<Models.RunNumSchclass> result = CurBLLRunNum.GetRunNumSchclassList(string.Format(" AND RunID='{0}'", RunID));
            foreach (Models.RunNumSchclass model in result)
            {
                sb.Append(string.Format("INSERT INTO #TempSchclass(SchclassID)VALUES('{0}');", model.SchclassID));
            }
            return sb.ToString();
        }

        public string GetRunInfo()
        {
            StringBuilder sb = new StringBuilder();
            foreach (RunItem item in lsbSelectRunInfo.Items)
            {
                sb.Append(string.Format("{0}$", item.RunID));
            }
            return sb.ToString();
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
                ReturnValue rtn = new BLLUserRun().QueryRunUser(UserID, StartDate, EndDate, out ds);
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
                            System.Windows.Forms.DataGridViewComboBoxColumn cbl = new DataGridViewComboBoxColumn();
                            cbl.Name = dt.Columns[i].ColumnName;
                            cbl.DataSource = new BLLRunNum().GetRunNumDataTable();
                            cbl.DisplayMember = "Name";
                            cbl.ValueMember = "RunID";
                            cbl.DataPropertyName = dt.Columns[i].ColumnName;
                            cbl.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.DropDownButton;
                            cbl.HeaderText = dt.Columns[i].ColumnName;
                            Column[i] = cbl;
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
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string UserInfo = new TreeViewManager().GetCheckedNodesName(tvUserInfo);
                if (UserInfo == "")
                {
                    MessageBox.Show("请选择人员信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string RunInfo = GetRunInfo();
                if (RunInfo == "")
                {
                    MessageBox.Show("请选择班次信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DateTime startDate = DateTime.Parse(dtStartDate.Value.ToShortDateString());
                DateTime endDate = DateTime.Parse(dtEndDate.Value.ToShortDateString());              
                int Count = (endDate - startDate).Days + 2;
                int RunLength=RunInfo.Split('$').Length-2;
                if ((endDate - startDate).Days <RunLength)
                {
                    MessageBox.Show("请选择班次信息与时间不合要求", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

              
                List<System.Windows.Forms.DataGridViewColumn> list = new List<DataGridViewColumn>();              
                DataTable dt = new DataTable();

                System.Windows.Forms.DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                col.Name = "UserID";
                col.HeaderText = "编号";
                col.DataPropertyName = "UserID";
                list.Add(col);

                DataColumn dc = new DataColumn();
                dc.DataType = System.Type.GetType("System.String");//该列的数据类型 
                dc.ColumnName = "UserID";//该列得名称 
                dt.Columns.Add(dc);

                System.Windows.Forms.DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
                col1.Name = "UserName";
                col1.HeaderText = "姓名";
                col1.DataPropertyName = "UserName";
                list.Add(col1);
                //
                DataColumn dc1 = new DataColumn();
                dc1.DataType = System.Type.GetType("System.String");//该列的数据类型 
                dc1.ColumnName = "UserName";//该列得名称 
                dt.Columns.Add(dc1);
                //
                while (startDate<=endDate)
                {
                    System.Windows.Forms.DataGridViewComboBoxColumn cbl = new DataGridViewComboBoxColumn();
                    cbl.Name = startDate.ToString("yyyy-MM-dd");
                    cbl.DataSource = new BLLRunNum().GetRunNumDataTable();
                    cbl.DisplayMember = "Name";
                    cbl.ValueMember = "RunID";
                    cbl.DataPropertyName = startDate.ToString("yyyy-MM-dd");
                    cbl.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.DropDownButton;
                    cbl.HeaderText = startDate.ToString("yyyy-MM-dd");
                    list.Add(cbl);
                    //
                    DataColumn dcc = new DataColumn();
                    dcc.DataType = System.Type.GetType("System.String");//该列的数据类型 
                    dcc.ColumnName = startDate.ToString("yyyy-MM-dd");
                    dt.Columns.Add(dcc);
                    startDate=startDate.AddDays(1);
                }
                System.Windows.Forms.DataGridViewColumn[] Column = list.ToArray();
                this.dgvRunUserLog.Columns.Clear();
                this.dgvRunUserLog.Columns.AddRange(Column);
                //
                startDate = DateTime.Parse(dtStartDate.Value.ToString("yyyy-MM-dd"));
                foreach (string UserID in UserInfo.Split('&'))
                {
                    if (UserID != "")
                    {
                        DataRow dr = dt.NewRow();
                        dr["UserID"] = UserID.Split('$')[0];
                        dr["UserName"] = UserID.Split('$')[1];
                        while (startDate<=endDate)
                        {
                            foreach (string RunID in RunInfo.Split('$'))
                            {
                                if (RunID != "")
                                {
                                    if (startDate <= endDate)
                                    {
                                        dr[startDate.ToString("yyyy-MM-dd")] = RunID;
                                        startDate = startDate.AddDays(1);
                                    }
                                }
                            }
                        }
                        dt.Rows.Add(dr);
                    }
                    startDate =DateTime.Parse(dtStartDate.Value.ToString("yyyy-MM-dd"));
                }
                this.dgvRunUserLog.DataSource = dt;
                MessageBox.Show("生成成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                LogManager.WriteTextLog("CHMS", "frmRunUserDaily", "btnSave_Click", ex.Message + ex.StackTrace);
                MessageBox.Show("排班失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
    public class RunItem
    {
        public RunItem(string RunID, string RunName)
        {
            this.RunID = RunID;
            this.RunName = RunName;
        }
        public string RunID { get; set; }
        public string RunName { get; set; }
    }
}
