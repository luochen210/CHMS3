using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Framework;

namespace CHMS
{
    public partial class FrmAttExceptionLog : Form
    {
        public FrmAttExceptionLog()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string UserInfo = new TreeViewManager().GetCheckedValues(tvUserInfo);
                DateTime StartDate = dtStartDate.Value;
                DateTime EndDate = dtEndDate.Value;
                string StartTime = txtStartTime.Text;
                string EndTime = txtEndTime.Text;
                int Range = 10;
                if (txtRange.Text != "")
                {
                    Range = int.Parse(txtRange.Text);
                }
                string Reserved = txtRemark.Text;
                ReturnValue rtn = new BLL.BLLAttLog().AddAttExceptionLog(UserInfo, StartDate, EndDate, StartTime, EndTime, Range, Reserved);
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
        private void btnColse_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAttExceptionLog_Load(object sender, EventArgs e)
        {
            new TreeViewManager().BindTreeView(tvUserInfo);
        }
    }
}
