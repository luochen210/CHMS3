using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using DAL;
namespace CHMSDBConfig
{
    public partial class FrmDbConfig : Form
    {
        #region Construct() && _Load()

        public FrmDbConfig()
        {
            InitializeComponent();
        }

        private void FrmDbConfig_Load(object sender, EventArgs e)
        {
            this.txtServer.Text = AppSettings.GetValue("SERVER");
            this.txtUID.Text = AppSettings.GetValue("UID");
            this.txtPWD.Text = AppSettings.GetValue("PWD");
            this.txtDataBase.Text = AppSettings.GetValue("DATABASE");
        }

        #endregion

        #region buttonclick_event响应方法

        /// <summary>
        /// btn测试连接click_event响应方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTest_Click(object sender, EventArgs e)
        {
            string connString = string.Format(@"SERVER={0};UID={1};PWD={2};DATABASE={3};", txtServer.Text.ToString().Trim(),
                txtUID.Text.ToString().Trim(), txtPWD.Text.ToString().Trim(), txtDataBase.Text.ToString().Trim());
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                MessageBox.Show("数据库连接测试成功", "连接测试", MessageBoxButtons.OK,MessageBoxIcon.Information);              
            }
            catch (Exception)
            {
                MessageBox.Show("数据库连接测试失败", "连接测试", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        /// <summary>
        /// btn确认click_event响应方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            string connString = string.Format(@"SERVER={0};UID={1};PWD={2};DATABASE={3};", txtServer.Text.ToString().Trim(),
                  txtUID.Text.ToString().Trim(), txtPWD.Text.ToString().Trim(), txtDataBase.Text.ToString().Trim());
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                AppSettings.SetValue("SERVER", txtServer.Text.Trim());
                AppSettings.SetValue("UID", txtUID.Text.Trim());
                AppSettings.SetValue("PWD", txtPWD.Text.Trim());
                AppSettings.SetValue("DATABASE", txtDataBase.Text.Trim());
                MessageBox.Show("数据库配置保存成功，请重新启动系统", "数据库配置", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("数据库配置保存失败！", "数据库配置", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        /// <summary>
        /// btn取消click_event响应方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
