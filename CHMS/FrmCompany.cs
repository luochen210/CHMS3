using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
//
using System.Collections;
using Model;
using BLL;
//下载源码到51aspx
namespace CHMS
{
    public partial class FrmCompany : Form
    {
        private BLLCompany Action;
        public FrmCompany()
        {
            InitializeComponent();
            Action = new BLLCompany();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Action.Update(GetCompanyModle()) > 0)
            {
                MessageBox.Show("系统基本信息保存成功", "添加系统基本信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("系统基本信息保存失败", "添加系统基本信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Bind()
        {
            Company model = Action.GetModel();
            if (model != null)
            {
                this.txtAddress.Text = model.Addr;
                this.txtPrincipal.Text = model.Principal;
                this.txtCity.Text = model.City;
                this.txtCountry.Text = model.Country;
                this.txtFax.Text = model.Fax;
                this.txtEdesc.Text = model.EnglishName;
                this.txtCdesc.Text = model.ChineseName;
                this.txtTel1.Text = model.Tel;
                this.txtTel2.Text = model.Mobile;
                this.txtZIP.Text = model.Zip;
            }
        }

        private Company GetCompanyModle()
        {
            Company modle = new Company();
            modle.CompanyID= "20101001";
            modle.Addr = this.txtAddress.Text;
            modle.Principal = this.txtPrincipal.Text;
            modle.City = this.txtCity.Text;
            modle.Country = this.txtCountry.Text;
            modle.Fax = this.txtFax.Text;
            modle.ChineseName = this.txtCdesc.Text;
            modle.EnglishName = this.txtEdesc.Text;
            modle.Tel = this.txtTel1.Text;
            modle.Mobile = this.txtTel2.Text;
            modle.Zip = this.txtZIP.Text;
            modle.Reamark = "";
            modle.Email = "";
            modle.WebSite = "";
            return modle;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtCdesc.Text = "";
            this.txtCountry.Text = "";
            this.txtCity.Text = "";
            this.txtEdesc.Text = "";
            this.txtAddress.Text = "";
            this.txtFax.Text = "";
            this.txtZIP.Text = "";
            this.txtPrincipal.Text = "";
            this.txtTel1.Text = "";
            this.txtTel2.Text = "";
        }   
        private void frmCompany_Load(object sender, EventArgs e)
        {
            this.Bind();
        }
        private void frmCompany_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}