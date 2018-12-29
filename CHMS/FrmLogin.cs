using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using BLL;
using Models;


namespace CHMS
{
    public partial class FrmLogin : Form
    {

        public FrmLogin()
        {
            InitializeComponent();
        }
        private void butClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }
        private void butLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textName.Text.Trim()))
            {
                MessageBox.Show("用户名不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textName.Focus();
                return;
            }
            string UserCode = textName.Text;
            string Password = textPass.Text;
            User UserInfo = null;
            switch (new Login().LoginValidate(UserCode, Password, out UserInfo))
            {
                case Login.LoginResult.NoAdmin:
                    {
                        MessageBox.Show("超级管理员被删除", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                case Login.LoginResult.Success:
                    {
                        this.Hide();
                        FrmMain objfrmMain = new FrmMain();
                        Parameter.CurrentUser = UserInfo;
                        objfrmMain.Show();
                        break;
                    }
                case Login.LoginResult.NoUser:
                    {
                        MessageBox.Show("用户名不存在", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textName.Text = "";
                        textName.Focus();
                        break;
                    }
                case Login.LoginResult.PasswordError:
                    {
                        MessageBox.Show("密码错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textPass.Text = "";
                        textPass.Focus();
                        break;
                    }
            }
        }
        private void textName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                textPass.Focus();
            }
        }
        private void textPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                butLogin.Focus();
            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
        }
    }
}