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
    public partial class FrmLeaveClass : Form
    {
        private BLLLeaveClass Action;
        private string ToDoType = "Insert";
        public FrmLeaveClass()
        {
            InitializeComponent();
            Action = new BLLLeaveClass();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Model.LeaveClass model = new Model.LeaveClass();
            model.LeaveId = txtLeaveId.Text;
            model.LeaveName = txtLeaveName.Text;
            model.MinUnit = decimal.Parse(txtMinUnit.Text.Trim());
            model.Unit = int.Parse(txtUnit.Text.Trim());
            model.RemaindProc = int.Parse(txtRemaindProc.Text.Trim());
            model.RemaindCount = int.Parse(txtRemaindProc.Text);
            model.ReportSymbol = txtReportSymbol.Text;
            model.Deduct = 0;
            model.Color = btnColor.BackColor.ToString();
            model.Classify = chkClassify.Checked == true ? 1 : 0;
            if (ToDoType == "Insert")
            {
                if (Action.Add(model) > 0)
                {
                    MessageBox.Show("保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.BindLeaveClass();
                    btnAdd_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("保存失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                if (Action.Update(model) > 0)
                {
                    MessageBox.Show("保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.BindLeaveClass();
                    btnAdd_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("保存失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
        private void linkLabelColor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void frmLeaveClass_Load(object sender, EventArgs e)
        {
            this.BindLeaveClass();
        }
        private void BindLeaveClass()
        {
            this.dgvLeaveClass.AutoGenerateColumns = false;
            this.dgvLeaveClass.DataSource = Action.GetList("");
            this.dgvLeaveClass.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void dgvLeaveClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvLeaveClass.DataSource != null && this.dgvLeaveClass.Rows.Count > 0)
            {
                if (e.RowIndex != -1)
                {
                    Model.LeaveClass model = dgvLeaveClass.CurrentRow.DataBoundItem as Model.LeaveClass;
                    txtLeaveId.Text = model.LeaveId;
                    txtLeaveName.Text = model.LeaveName;
                    txtMinUnit.Text = model.MinUnit.ToString();
                    txtUnit.Text = model.Unit.ToString();
                    txtRemaindProc.Text = model.RemaindProc.ToString();
                    txtRemaindProc.Text = model.RemaindCount.ToString();
                    txtReportSymbol.Text = model.ReportSymbol;
                    chkClassify.Checked = model.Classify == 1 ? true : false;
                    ToDoType = "Update";
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtLeaveId.Text = "";
            txtLeaveName.Text = "";
            txtMinUnit.Text = "";
            txtUnit.Text = "";
            txtRemaindProc.Text = "";
            txtRemaindProc.Text = "";
            txtReportSymbol.Text = "";
            chkClassify.Checked = false;
            ToDoType = "Insert";
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtLeaveId.Text != "")
            {
                if (Action.Delete(txtLeaveId.Text.Trim()) > 0)
                {
                    MessageBox.Show("删除成功!");
                    BindLeaveClass();
                    btnAdd_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }
            else
            {
                MessageBox.Show("请选择要删除假期类型！");
            }
        }
    }
}
