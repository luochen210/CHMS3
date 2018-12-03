using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//下载源码到51aspx
namespace CHMS
{
    public partial class FrmPrivilege : Form
    {
        public FrmPrivilege()
        {
            InitializeComponent();
        }
        private void btnColse_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtIdx.Text == "")
            {
                MessageBox.Show("选择权限组", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                if (this.dgvFunc.DataSource != null && this.dgvFunc.Rows.Count > 0)
                {
                     int Roleid=int.Parse(txtIdx.Text);
                    for (int i = 0; i < dgvFunc.Rows.Count; i++)
                    {

                        string Funcno = dgvFunc.Rows[i].Cells["No"].Value.ToString();
                        bool Isownprivilege=false;
                        if (dgvFunc.Rows[i].Cells["Isownprivilege"].Value.ToString() == "True")
                        {
                            Isownprivilege=true;
                        }
                        new BLL.BLLRole().AddPrivilage(Roleid, Funcno, Isownprivilege);
                    }
                }
                MessageBox.Show("保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("保存失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }  

        }
        private void frmPrivilege_Load(object sender, EventArgs e)
        {
            //
            this.dgvRole.AutoGenerateColumns = false;
            this.dgvRole.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvRole.DataSource = new BLL.BLLRole().GetRoleIlist();

            //
            this.dgvModule.AutoGenerateColumns = false;
            this.dgvModule.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvModule.DataSource = new BLL.BLLRole().GetModuleList("");

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
                        txtNotes.Text = model.Notes;
                        txtOprTime.Text = model.DoDateTime.ToString();
                        txtOpr.Text = model.DoUserCode;
                    }
                }
            }
        }
        private void dgvModule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvModule.DataSource != null && this.dgvModule.Rows.Count > 0)
            {
                if (e.RowIndex != -1)
                {
                    Model.Module model = this.dgvModule.CurrentRow.DataBoundItem as Model.Module;
                    if (model != null)
                    {
                        dgvFunc.DataSource = new BLL.BLLRole().GetFuncnoDataTable(model.Id);
                    }
                }
            }

        }

        private void btnALL_Click(object sender, EventArgs e)
        {
            if (this.dgvFunc.DataSource != null && this.dgvFunc.Rows.Count > 0)
            {
                for (int i = 0; i < dgvFunc.Rows.Count; i++)
                {
                    dgvFunc.Rows[i].Cells["Isownprivilege"].Value = "True";
                }
            }
        }
        private void btnNotAll_Click(object sender, EventArgs e)
        {
            if (this.dgvFunc.DataSource != null && this.dgvFunc.Rows.Count > 0)
            {
                for (int i = 0; i < dgvFunc.Rows.Count; i++)
                {
                    dgvFunc.Rows[i].Cells["Isownprivilege"].Value = "False";
                }
            }
        }
    }
}
