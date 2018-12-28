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
//下载源码到51aspx
namespace CHMS
{
    public partial class FrmHolidays : Form
    {
        private BLLHolidays Ation;
        public FrmHolidays()
        {
            InitializeComponent();
            Ation = new BLLHolidays();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime StartDate = dtStartDate.Value;
                DateTime EndDate = dtEndDate.Value;
                string LeaveId = cbLeaveClass.SelectedValue.ToString();
                ReturnValue rtn = Ation.AddHolidays(StartDate, EndDate, LeaveId);
                if (rtn.Result == 1)
                {
                    MessageBox.Show("保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.BindHolidays();
                    btnAdd_Click(sender,e);
                }
                else
                {
                    MessageBox.Show("保存失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmHolidays_Load(object sender, EventArgs e)
        {
            cbLeaveClass.DataSource = new BLLLeaveClass().GetDataTable();
            cbLeaveClass.ValueMember = "LeaveId";
            cbLeaveClass.DisplayMember = "LeaveName";
            //
            this.BindHolidays();
        }
        private void BindHolidays()
        {
            this.dgvHolidays.AutoGenerateColumns = false;
            this.dgvHolidays.DataSource = Ation.GetHolidaysIList("");
            this.dgvHolidays.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cbLeaveClass.SelectedIndex = -1;
            dtStartDate.Value = DateTime.Now;
            dtEndDate.Value = DateTime.Now;
            labHolidayid.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (labHolidayid.Text != "")
            {
                if (Ation.Delete(labHolidayid.Text.Trim()) > 0)
                {
                    MessageBox.Show("删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.BindHolidays();
                    btnAdd_Click(sender, e);
                }
                else
                {               
                    MessageBox.Show("删除失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void dgvHolidays_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvHolidays.DataSource != null && this.dgvHolidays.Rows.Count > 0)
            {
                if (e.RowIndex != -1)
                {
                    Models.Holidays model = this.dgvHolidays.CurrentRow.DataBoundItem as Models.Holidays;
                    dtStartDate.Value = model.HolidayDate;
                    dtEndDate.Value = model.HolidayDate;
                    cbLeaveClass.SelectedValue = model.LeaveId.ToString();
                    labHolidayid.Text = model.Holidayid.ToString();
                }
            }
        }
    }
}
