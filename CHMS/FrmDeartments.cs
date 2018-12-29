using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
//下载源码到51aspx
namespace CHMS
{
    public partial class FrmDeartments : Form
    {
        private BLLDepartments Action;
        private string ToDoType = "Insert";
        public FrmDeartments()
        {
            InitializeComponent();
            Action = new BLLDepartments();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtDEPTID.Text = "";
            txtDEPTNAME.Text = "";
            txtSUPDEPTID.Text = "";
            ToDoType = "Insert";
        }

        private void frmDeartments_Load(object sender, EventArgs e)
        {
            this.BindDeartments();
        }
        private void BindDeartments()
        {
            this.dgvDeartments.AutoGenerateColumns = false;
            this.dgvDeartments.DataSource = Action.GetList("");
            this.dgvDeartments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dgvDeartments_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Color color = dgvDeartments.RowHeadersDefaultCellStyle.ForeColor;
            if (dgvDeartments.Rows[e.RowIndex].Selected)
                color = dgvDeartments.RowHeadersDefaultCellStyle.SelectionForeColor;
            else
                color = dgvDeartments.RowHeadersDefaultCellStyle.ForeColor;

            using (SolidBrush b = new SolidBrush(color))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 20, e.RowBounds.Location.Y + 6);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DAL.Departments model = new DAL.Departments();
            model.DEPTID = txtDEPTID.Text.Trim();
            model.DEPTNAME = txtDEPTNAME.Text.Trim();
            model.SUPDEPTID = txtSUPDEPTID.Text.Trim();
            if (ToDoType == "Insert")
            {
                if (Action.Add(model) > 0)
                {
                    MessageBox.Show("保存成功", "部门信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.BindDeartments();
                }
                else
                {
                    MessageBox.Show("保存失败", "部门信息", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                if (Action.Update(model) > 0)
                {
                    MessageBox.Show("保存成功", "部门信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.BindDeartments();
                }
                else
                {
                    MessageBox.Show("保存失败", "部门信息", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void dgvDeartments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvDeartments.DataSource != null && this.dgvDeartments.Rows.Count > 0)
            {
                if (e.RowIndex != -1)
                {
                    DAL.Departments model = this.dgvDeartments.CurrentRow.DataBoundItem as DAL.Departments;
                    if (model != null)
                    {
                        txtDEPTID.Text = model.DEPTID.ToString();
                        txtDEPTNAME.Text = model.DEPTNAME;
                        txtSUPDEPTID.Text = model.SUPDEPTID;
                        ToDoType = "Update";
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtDEPTID.Text != "")
            {
                if (Action.Delete(txtDEPTID.Text.Trim()) > 0)
                {
                    MessageBox.Show("删除成功", "部门信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.BindDeartments();
                }
                else
                {
                    MessageBox.Show("删除失败", "部门信息", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("请选择删除的部门", "部门信息", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void btnAddUnderling_Click(object sender, EventArgs e)
        {
            txtSUPDEPTID.Text = txtDEPTID.Text.Trim();
            txtDEPTID.Text = "";
            txtDEPTNAME.Text = "";
            ToDoType = "Insert";
        }
    }
}
