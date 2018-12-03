using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Model;
//下载源码到51aspx
namespace CHMS
{
    public partial class FrmRole : Form
    {
        private string DoType = "Insert";
        private BLLRole Action;
        public FrmRole()
        {
            InitializeComponent();
            Action = new BLLRole();
        }

        private void btnColse_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtIdx.Text = "";
            txtCDesc.Text = "";
            txtRptCount.Text = "0";
            txtNotes.Text = "";
            chkState.Checked = true;
            txtOprTime.Text = DateTime.Now.ToString();
            txtOpr.Text = Parameter.CurrentUser.UserName;
            txtIdx.Text = Action.GetMaxRoleID();
            DoType = "Insert";
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtIdx.Text != "")
            {
                if (Action.Delete(txtIdx.Text.Trim()) > 0)
                {
                    MessageBox.Show("删除成功", "角色组管理", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.BindRoleIlist();
                    btnAdd_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("删除失败", "角色组管理", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("请选择删除的角色组", "角色组管理", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DoType == "Insert")
            {
                if (Action.Add(GetRole()) > 0)
                {
                    MessageBox.Show("保存成功", "角色组管理", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.BindRoleIlist();
                    btnAdd_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("保存失败", "角色组管理", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                if (Action.Update(GetRole()) > 0)
                {
                    MessageBox.Show("保存成功", "角色组管理", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.BindRoleIlist();
                    btnAdd_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("保存失败", "角色组管理", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
        private Role GetRole()
        {
            Role model = new Role();
            model.Idx = int.Parse(txtIdx.Text.Trim());
            model.CName = txtCDesc.Text.Trim();
            model.DoDateTime = DateTime.Now;
            model.DoUserCode = Parameter.CurrentUser.UserName;
            if (txtRptCount.Text.Trim() != "")
            {
                model.RptCount = int.Parse(txtRptCount.Text.Trim());
            }
            else
            {
                model.RptCount = -1;
            }
            model.Notes = txtNotes.Text.Trim();
            model.State = chkState.Checked;
            return model;
        }
        private void BindRoleIlist()
        {
            this.dgvRole.AutoGenerateColumns = false;
            this.dgvRole.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvRole.DataSource = Action.GetRoleIlist();
        }
        private void frmRole_Load(object sender, EventArgs e)
        {      
            BindRoleIlist();
            btnAdd_Click(sender, e);
        }
        private void dgvRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvRole.DataSource != null && this.dgvRole.Rows.Count > 0)
            {
                if (e.RowIndex != -1)
                {
                    Model.Role model = this.dgvRole.CurrentRow.DataBoundItem as Model.Role;
                    if (model != null)
                    {
                        txtIdx.Text = model.Idx.ToString();
                        txtCDesc.Text = model.CName;
                        txtRptCount.Text = model.RptCount.ToString();
                        txtNotes.Text = model.Notes;
                        chkState.Checked = model.State;
                        txtOprTime.Text = model.DoDateTime.ToString();
                        txtOpr.Text = model.DoUserCode;
                        DoType = "Update";
                    }
                }
            }
        }
    }
}
