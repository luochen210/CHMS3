using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace CHMS
{
    public partial class FrmSchclass : Form
    {
        private BLLSchclass Action;
        private string ToDoType = "Insert";
        public FrmSchclass()
        {
            InitializeComponent();
            Action = new BLLSchclass();
        }
        private void btnColse_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtSchclassId.Text == "")
            {
                MessageBox.Show("时段ID信息不能为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (ToDoType == "Insert")
            {
                if (Action.Add(GetSchclassModel()) > 0)
                {
                    MessageBox.Show("保存成功", "班次时段信息管理", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.BindSchclassList();
                    btnAdd_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("保存失败", "班次时段信息管理", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                if (Action.Update(GetSchclassModel()) > 0)
                {
                    MessageBox.Show("保存成功", "班次时段信息管理", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.BindSchclassList();
                    btnAdd_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("保存失败", "班次时段信息管理", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void linkLabelColor_Click(object sender, EventArgs e)
        {

        }
        private void linkLabelColor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void BindSchclassList()
        {
            this.dgvSchclass.AutoGenerateColumns = false;
            this.dgvSchclass.DataSource = Action.GetSchclassList("");
            this.dgvSchclass.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private Model.Schclass GetSchclassModel()
        {
            Model.Schclass model = new Model.Schclass();
            model.Schclassid = txtSchclassId.Text;
            model.Schname = txtSchname.Text;
            model.Starttime = txtStartTime.Text;
            model.Endtime = txtEndTime.Text;
            model.Lateminutes = 0;
            if (txtLateMinutes.Text != "")
            {
                model.Lateminutes = int.Parse(txtLateMinutes.Text);
            }
            model.Earlyminutes = 0;
            if (txtEarlyMinutes.Text != "")
            {
                model.Earlyminutes = int.Parse(txtEarlyMinutes.Text);
            }
            model.Checkin = chkCheckIn.Checked == true ? 1 : 0;
            model.Checkout = chkCheckOut.Checked == true ? 1 : 0;
            model.Checkintime1 = txtCheckInTime1.Text;
            model.Checkintime2 = txtCheckInTime2.Text;
            model.Checkouttime1 = txtCheckOutTime1.Text;
            model.Checkouttime2 = txtCheckOutTime2.Text;
            model.Color = 0;
            model.Autobind = decimal.Parse(txtAutoBind.Text);
            return model;
        }

        private void frmSchclass_Load(object sender, EventArgs e)
        {
            BindSchclassList();
            // 
            txtStartTime.Text = "09:00:00";
            txtEndTime.Text = "18:00:00";
            txtCheckInTime1.Text = "07:00:00";
            txtCheckInTime2.Text = "10:00:00";
            txtCheckOutTime1.Text = "18:00:00";
            txtCheckOutTime2.Text = "19:00:00";
         
        }

        private void dgvSchclass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvSchclass.DataSource != null && this.dgvSchclass.Rows.Count > 0)
            {
                if (e.RowIndex != -1)
                {
                    ToDoType = "Update";
                    Model.Schclass model = this.dgvSchclass.CurrentRow.DataBoundItem as Model.Schclass;
                    txtSchclassId.Text = model.Schclassid;
                    txtSchname.Text = model.Schname;
                    txtStartTime.Text = model.Starttime;
                    txtEndTime.Text = model.Endtime;
                    txtLateMinutes.Text = model.Lateminutes.ToString();
                    txtEarlyMinutes.Text = model.Earlyminutes.ToString();
                    chkCheckIn.Checked = model.Checkin == 1 ? true : false;
                    chkCheckOut.Checked = model.Checkout == 1 ? true : false;
                    txtCheckInTime1.Text = model.Checkintime1;
                    txtCheckInTime2.Text = model.Checkintime2;
                    txtCheckOutTime1.Text = model.Checkouttime1;
                    txtCheckOutTime2.Text = model.Checkouttime2;
                    txtAutoBind.Text = model.Autobind.ToString();
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtSchclassId.Text != "")
            {
                if (Action.Delete(txtSchclassId.Text) > 0)
                {
                    MessageBox.Show("删除成功!");
                    BindSchclassList();
                    btnAdd_Click(sender, e);

                }
                else
                {
                    MessageBox.Show("删除失败!");
                }

            }
            else
            {
                MessageBox.Show("请选择要删除的时段!");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtSchclassId.Text = "";
            txtSchname.Text = "";
            txtStartTime.Text = "";
            txtEndTime.Text = "";
            txtLateMinutes.Text = "";
            txtEarlyMinutes.Text = "";
            chkCheckIn.Checked = false;
            chkCheckOut.Checked = false;
            txtStartTime.Text = "09:00:00";
            txtEndTime.Text = "18:00:00";
            txtCheckInTime1.Text = "07:00:00";
            txtCheckInTime2.Text = "10:00:00";
            txtCheckOutTime1.Text = "18:00:00";
            txtCheckOutTime2.Text = "19:00:00";
            txtLateMinutes.Text = "0";
            txtEarlyMinutes.Text = "0";
            txtAutoBind.Text = "";
            ToDoType = "Insert";
        }
    }
}
