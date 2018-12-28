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
    public partial class FrmMachines : Form
    {
        private BLLMachines Action;
        private string ToDoType = "Insert";
        public FrmMachines()
        {
            InitializeComponent();
            Action = new BLLMachines();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtIdx.Text = "";
            txtMachineName.Text = "";
            cbConnectType.Text = "";
            txtIP.Text = "192.168.0.200";
            txtPort.Text = "4370";
            cbSerialPort.Text = "";
            cbBaudrate.Text = "";
            txtSn.Text = "";
            txtCommPassword.Text = "";
            ToDoType = "Insert";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtIdx.Text == "")
            {
                MessageBox.Show("编号不能为空！", "设备信息管理", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            if (ToDoType == "Insert")
            {
                if (Action.Add(GetMachinesModel()) > 0)
                {
                    MessageBox.Show("保存成功", "设备信息管理", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnAdd_Click(sender, e);
                    this.BindMachinesList();
                }
                else
                {
                    MessageBox.Show("保存失败", "设备信息管理", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                if (Action.Update(GetMachinesModel()) > 0)
                {
                    MessageBox.Show("保存成功", "设备信息管理", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.BindMachinesList();
                }
                else
                {
                    MessageBox.Show("保存失败", "设备信息管理", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
        private void BindMachinesList()
        {
            this.dgvMachines.AutoGenerateColumns = false;
            this.dgvMachines.DataSource = Action.GetMachinesList("");
            this.dgvMachines.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtIdx.Text != "")
            {
                if (DialogResult.Yes == MessageBox.Show("是否真的要删除设备信息", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                {
                    if (Action.Delete(txtIdx.Text.Trim()) > 0)
                    {
                        MessageBox.Show("删除成功", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        this.BindMachinesList();
                        btnAdd_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("删除失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择删除设备", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Models.Machines GetMachinesModel()
        {
            Models.Machines model = new Models.Machines();
            model.Idx = txtIdx.Text;
            model.MachineName = txtMachineName.Text;
            model.ConnectType = cbConnectType.Text;

            model.IP = txtIP.Text;
            model.Port = txtPort.Text;

            model.Baudrate = cbBaudrate.Text;
            model.SerialPort = cbSerialPort.Text;


            model.sn = txtSn.Text;
            model.CommPassword = txtCommPassword.Text;

            model.State = true;
            model.MachineNumber = "";
            return model;
        }
        private void frmMachines_Load(object sender, EventArgs e)
        {
            BindMachinesList();
        }
        private void dgvMachines_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvMachines.DataSource != null && this.dgvMachines.Rows.Count > 0)
            {
                if (e.RowIndex != -1)
                {
                    Models.Machines model = dgvMachines.CurrentRow.DataBoundItem as Models.Machines;
                    txtIdx.Text = model.Idx;
                    txtMachineName.Text = model.MachineName;
                    cbConnectType.Text = model.ConnectType;
                    txtIP.Text = model.IP;
                    txtPort.Text = model.Port;
                    cbSerialPort.Text = model.SerialPort;
                    cbBaudrate.Text = model.Baudrate;
                    txtSn.Text = model.sn;
                    txtCommPassword.Text = model.CommPassword;
                    ToDoType = "Update";
                }
            }
        }
    }
}
