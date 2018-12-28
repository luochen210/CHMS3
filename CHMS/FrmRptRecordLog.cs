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

namespace CHMS
{
    public partial class FrmRptRecordLog : Form
    {
        public FrmRptRecordLog()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            XlsReport.PrintDGV.PrintMode = 0;
            XlsReport.PrintDGV.Print_DataGridView(this.dgvRecordLog);
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            BindAttRecordLog();
        }
        private void BindAttRecordLog()
        {
            try
            {
                string UserID = txtUserID.Text.Trim();
                string Name = txtName.Text.Trim();
                string AttNumber = txtAttNumber.Text.Trim();
                string StartDate = dtStartDate.Value.ToShortDateString();
                string EndDate = dtEndDate.Value.ToShortDateString();
                string Deptid = "";
                if (cbDepartments.SelectedValue != null)
                {
                   Deptid=cbDepartments.SelectedValue.ToString();
                }
                DataSet ds;
                ReturnValue rtn = new BLLAttLog().QueryAttRecordLog(UserID, Name, AttNumber, StartDate, EndDate, Deptid, out ds);
                if (rtn.Result == 1)
                {
                    dgvRecordLog.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                LogManager.WriteTextLog("frmRptRecordLog", "", "BindAttRecordLog", ex.Message + ex.StackTrace);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnXls_Click(object sender, EventArgs e)
        {
            XlsReport.ExportDGVToExcel.ExportDataGridToExcel(this.dgvRecordLog,"打卡详细信息");
        }

        private void frmRptRecordLog_Load(object sender, EventArgs e)
        {
            List<ListItem> li = new List<ListItem>();
            li.Add(new ListItem("", "请选择"));
            IList<Model.Departments> result = new BLLDepartments().GetList("");
            foreach (Model.Departments item in result)
            {
                li.Add(new ListItem(item.DEPTID, item.DEPTNAME));
            }
            cbDepartments.ValueMember = "Value";
            cbDepartments.DisplayMember = "Text";
            cbDepartments.DataSource = li;
        }

        private void frmRptRecordLog_Activated(object sender, EventArgs e)
        {
            //注册热键Shift+S，Id号为100。HotKey.KeyModifiers.Shift也可以直接使用数字4来表示。 
            HotKey.RegisterHotKey(Handle, 100, HotKey.KeyModifiers.Shift, Keys.S);
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
                            FrmCheckAttLog objfrmCreateAttLog = new FrmCheckAttLog();
                            objfrmCreateAttLog.ShowDialog();
                            break;
                    }
                    break;
            }
            base.WndProc(ref m);
        }

        private void frmRptRecordLog_Leave(object sender, EventArgs e)
        {
            //注销Id号为100的热键设定   
            HotKey.UnregisterHotKey(Handle, 100);
        }
    }
}
