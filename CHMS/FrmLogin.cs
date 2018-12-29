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
                MessageBox.Show("�û�������Ϊ��", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        MessageBox.Show("��������Ա��ɾ��", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        MessageBox.Show("�û���������", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textName.Text = "";
                        textName.Focus();
                        break;
                    }
                case Login.LoginResult.PasswordError:
                    {
                        MessageBox.Show("�������", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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