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
//下载源码到51aspx
namespace CHMS
{
    public partial class FrmCreateAttLog : Form
    {
        public FrmCreateAttLog()
        {
            InitializeComponent();
        }

        private void frmCreateAttLog_Load(object sender, EventArgs e)
        {
            new TreeViewManager().BindTreeView(this.tvUserInfo);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string UserInfo = new TreeViewManager().GetCheckedValues(tvUserInfo);
                if (UserInfo == "")
                {
                    MessageBox.Show("请选择生成的人员", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string StartDateTime = dtStartDateTime.Value.ToShortDateString();
                string EndDateTime = dtEndDateTime.Value.ToString();
                int Range = 0;
                if (txtRange.Text != "")
                {
                    Range = int.Parse(txtRange.Text.Trim());
                }
                ReturnValue rtn = new BLL.BLLAttLog().CreateUserAttLog(StartDateTime, EndDateTime, UserInfo, Range);
                if (rtn.Result == 1)
                {
                    MessageBox.Show("模拟考勤生成成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("模拟考勤生成失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("模拟考勤生成失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LogManager.WriteTextLog("frmRptRecordLog", "", "btnSave_Click", ex.Message + ex.StackTrace);
            }
        }

        private void btnColse_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
