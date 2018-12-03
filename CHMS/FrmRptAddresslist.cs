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
using System.Drawing.Printing;

namespace CHMS
{
    public partial class FrmRptAddresslist : Form
    {
        public FrmRptAddresslist()
        {
            InitializeComponent();
        }

        private void frmRptAddresslist_Load(object sender, EventArgs e)
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
            //
            this.dgvUserInfo.AutoGenerateColumns = false;
            this.dgvUserInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserInfo.DataSource = BindUserInfo();
        }
        private DataTable BindUserInfo()
        {
            //
            UserInfoDepartments user = new UserInfoDepartments();
            string DefaultDeptid = cbDepartments.SelectedValue.ToString();
            string strName = txtName.Text;
            string UserID = txtUserID.Text;
            string AttNumber = "";
            return user.QueryUserInfo(DefaultDeptid, strName, UserID, AttNumber);
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + @"\Report\80002.fr3";
            PrintDocument prtdoc = new PrintDocument();
            ///获得默认打印机机器名称
            string PrintName = prtdoc.PrinterSettings.PrinterName;
            FastReportSettings frs = new FastReportSettings(FastReportSettings.Mode.Preview, path, PrintName);
            frs.AddReportParameter(new FastReportSettings.ReportParameter("Caption", Parameter.CurrentCompany.ChineseName + "通讯录"));
            DataTable dt = BindUserInfo();
            FastReport.Invoke(this.Handle, dt, frs);
        }
        private void btnXls_Click(object sender, EventArgs e)
        {
            //string path = Application.StartupPath + @"\Report\80002.fr3";
            //PrintDocument prtdoc = new PrintDocument();
            /////获得默认打印机机器名称
            //string PrintName = prtdoc.PrinterSettings.PrinterName;
            //FastReportSettings frs = new FastReportSettings(FastReportSettings.Mode.Preview, path, PrintName);
            //frs.AddReportParameter(new FastReportSettings.ReportParameter("Caption", Parameter.CurrentCompany.ChineseName + "通讯录"));
            //DataTable dt = BindUserInfo();
            //FastReport.Invoke(this.Handle, dt, frs);
            XlsReport.ExportDGVToExcel.ExportDataGridToExcel(this.dgvUserInfo, "公司通讯录");
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            this.dgvUserInfo.AutoGenerateColumns = false;
            this.dgvUserInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserInfo.DataSource = BindUserInfo();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
