using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;
//下载源码到51aspx
namespace CHMS
{
    public partial class FrmCheckAttLog : Form
    {
        public FrmCheckAttLog()
        {
            InitializeComponent();
        }

        private void frmCheckAttLog_Load(object sender, EventArgs e)
        {
            dtStartDateTime.Value = DateTime.Now;
            dtEndDateTime.Value = DateTime.Now;
            //
            new TreeViewManager().BindTreeView(this.tvUserInfo);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string UserInfo = new TreeViewManager().GetCheckedValues(tvUserInfo);
                if (UserInfo == "")
                {
                    MessageBox.Show("请选择检查的人员", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DateTime StartDateTime = dtStartDateTime.Value;
                DateTime EndDateTime = dtEndDateTime.Value;  
                ReturnValue rtn = new BLL.BLLAttLog().CheckUserAttLog(StartDateTime, EndDateTime, UserInfo);
                if (rtn.Result == 1)
                {
                    MessageBox.Show("考勤修正成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("考勤修正失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("考勤修正失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LogManager.WriteTextLog("frmRptRecordLog", "", "btnSave_Click", ex.Message + ex.StackTrace);
            }
        }

        private void btnColse_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
