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
    public partial class FrmUserinfo : Form
    {
        private BLLUserinfo Action;
        private CommonUtilities utilities;
        private string ToDoType = "Insert";
        public FrmUserinfo()
        {
            InitializeComponent();
            Action = new BLLUserinfo();
            utilities = new CommonUtilities();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text == "")
            {
                MessageBox.Show("编号不能为空！", "人员信息管理", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (ToDoType == "Insert")
            {
                if (Action.Add(GetUserModel()) > 0)
                {
                    MessageBox.Show("保存成功", "人员信息管理", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.BindUserinfoIList();
                    btnAdd_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("保存失败", "人员信息管理", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                if (Action.Update(GetUserModel()) > 0)
                {
                    MessageBox.Show("保存成功", "人员信息管理", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.BindUserinfoIList();
                    btnAdd_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("保存失败", "人员信息管理", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }

        }
        private void BindLlist()
        {

            cbDefaultdept.DisplayMember = "DEPTNAME";
            cbDefaultdept.ValueMember = "DEPTID";
            cbDefaultdept.DataSource = new BLL.BLLDepartments().GetList("");
            //
            cbRole.ValueMember = "Idx";
            cbRole.DisplayMember = "CName";
            cbRole.DataSource = new BLL.BLLRole().GetRoleIlist();

            //
            cbGender.DataSource = utilities.GetAttparam("Gender");
            cbGender.ValueMember = "ParaName";
            cbGender.DisplayMember = "ParaName";

        }
        private void BindUserinfoIList()
        {
            this.dgvUserinfo.AutoGenerateColumns = false;
            this.dgvUserinfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserinfo.DataSource = Action.GetUserinfoIList("");
        }
        private Model.Userinfo GetUserModel()
        {
            Model.Userinfo model = new Model.Userinfo();
            model.UserID = txtUserID.Text;
            model.AttNumber = txtAttNumber.Text;
            model.Ssn = txtSsn.Text;
            model.Name = txtName.Text;
            model.Gender = "男";
            if (cbGender.SelectedValue != null)
            {
                model.Gender = cbGender.SelectedValue.ToString();
            }
            model.Title = txtTitle.Text;
            model.Mobile = txtMobile.Text;
            model.Birthday = dtBirthday.Value;
            model.Hiredday = dtHiredday.Value;
            model.Address = txtAddress.Text;
            model.Province = "";
            model.City = "";
            model.Zip = "";
            model.OfficePhone = txtOfficePhone.Text;
            model.VerificationMethod = 1;
            model.DefaultDeptid = "";
            if (cbDefaultdept.SelectedValue != null)
            {
                model.DefaultDeptid = cbDefaultdept.SelectedValue.ToString();
            }
            model.RoleID = -1;
            if (cbRole.SelectedValue!=null)
            {
                model.RoleID = int.Parse(cbRole.SelectedValue.ToString());
            }
            model.Att = txtAtt.Text;
            model.Inlate = 1;
            model.Outearly = 1;
            model.Overtime = 1;
            model.Holiday = 1;
            model.Nationality = txtNationality.Text;
            model.Password =DesSecurity.MD5(txtPassword.Text);
            model.Lunchduration = 1;
            model.MverifyPass = "";
            return model;
        }

        private void frmUserinfo_Load(object sender, EventArgs e)
        {
            this.BindLlist();
            this.BindUserinfoIList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtUserID.Text ="";
            txtAttNumber.Text = "";
            txtSsn.Text ="";
            txtName.Text ="";
            cbGender.SelectedIndex = -1;
            txtTitle.Text ="";
            txtMobile.Text ="";
            dtBirthday.Value = DateTime.Now;
            dtHiredday.Value =DateTime.Now;
            txtAddress.Text = "";
            //model.Province = "";
            //model.City = "";
            //model.Zip = "";
            txtOfficePhone.Text ="";
            //model.VerificationMethod = 1;
            //cbDefaultdept.SelectedValue = model.DefaultDeptid;
            cbDefaultdept.SelectedIndex = -1;
           //cbRole.SelectedValue = model.RoleID.ToString();
            cbRole.SelectedIndex = -1;
            //model.Att = 1;
            //model.Inlate = 1;
            //model.Outearly = 1;
            //model.Overtime = 1;
            //model.Holiday = 1;
            txtNationality.Text = "";
            txtPassword.Text = "";
            // model.Lunchduration = 1;
            //model.MverifyPass = "";
            ToDoType = "Insert";
            txtAtt.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text != "")
            {
                if (Action.Delete(txtUserID.Text.Trim())> 0)
                {
                    MessageBox.Show("删除成功", "人员信息管理", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.BindUserinfoIList();
                    btnAdd_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("删除失败", "人员信息管理", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("请选择删除的人员", "人员信息管理", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void dgvUserinfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvUserinfo.DataSource != null && this.dgvUserinfo.Rows.Count > 0)
            {
                if (e.RowIndex != -1)
                {
                    Model.Userinfo model = this.dgvUserinfo.CurrentRow.DataBoundItem as Model.Userinfo;
                    if (model != null)
                    {
                        txtUserID.Text = model.UserID;
                        txtAttNumber.Text = model.AttNumber;
                        txtSsn.Text = model.Ssn;
                        txtName.Text = model.Name;
                        if (model.Gender !=null)
                        {
                            cbGender.SelectedValue = model.Gender;
                        }
                        txtTitle.Text = model.Title;
                        txtMobile.Text = model.Mobile;
                        dtBirthday.Value = model.Birthday;
                        dtHiredday.Value = model.Hiredday;
                        txtAddress.Text = model.Address;
                        //model.Province = "";
                        //model.City = "";
                        //model.Zip = "";
                        txtOfficePhone.Text = model.OfficePhone;
                        //model.VerificationMethod = 1;
                        if (model.DefaultDeptid != null)
                        {
                            cbDefaultdept.SelectedValue = model.DefaultDeptid;
                        }
                        cbRole.SelectedValue=model.RoleID;
                        txtAtt.Text = model.Att;
                        //model.Inlate = 1;
                        //model.Outearly = 1;
                        //model.Overtime = 1;
                        //model.Holiday = 1;
                        txtNationality.Text = model.Nationality;
                        txtPassword.Text = model.Password;
                        //model.Lunchduration = 1;
                        //model.MverifyPass = "";
                        ToDoType = "Update";
                    }
                }
            }
        }

        private void FrmUserinfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain.objFrmUserinfo = null;
        }
    }
}
