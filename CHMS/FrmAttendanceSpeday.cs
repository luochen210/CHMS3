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
namespace CHMS
{
    public partial class FrmAttendanceSpeday : Form
    {
        public FrmAttendanceSpeday()
        {
            InitializeComponent();
        }

        private void btnColse_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmAttendanceSpeday_Load(object sender, EventArgs e)
        {
            new TreeViewManager().BindTreeViewIsNotCheckBoxes(this.tvUserInfo);
            //
            cbLeaveClass.DataSource = new BLLLeaveClass().GetDataTable();
            cbLeaveClass.ValueMember = "LeaveId";
            cbLeaveClass.DisplayMember = "LeaveName";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string UserID = txtUserid.Text;
                if (UserID == "")
                {
                    MessageBox.Show("请选择人员信息!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
 
                }
                string LeaveId = cbLeaveClass.SelectedValue.ToString();
                DateTime StartDate = dtStartDate.Value;
                DateTime EndDate = dtEndDate.Value;
                DateTime ApproveDate = dtApproveDate.Value;
                string Approver = txtApprover.Text;
                string Remark = txtRemark.Text;
                ReturnValue rtn = new BLL.BLLAttLog().AddUserSpeday(UserID, LeaveId, StartDate, EndDate, ApproveDate, Approver, Remark);
                if (rtn.Result == 1)
                {
                    MessageBox.Show("登记成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("登记失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {

                LogManager.WriteTextLog("CHMS", "frmRunUser", "btnSave_Click", ex.Message + ex.StackTrace);

            }

        }
        private void tvUserInfo_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (!e.Node.Tag.ToString().Contains("$"))
            {
                txtUserid.Text = e.Node.Tag.ToString();
                txtUserName.Text = e.Node.Text;
            }
        }
    }
}
