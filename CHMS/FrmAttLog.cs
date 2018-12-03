using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Framework;
using Model;
//下载源码到51aspx
namespace CHMS
{
    public partial class FrmAttLog : Form
    {
        private DataAccess.SqlProvider DbHelperSQL;
        private BLLMachines Action;
        public FrmAttLog()
        {
            InitializeComponent();
            DbHelperSQL = new DataAccess.SqlProvider();
            Action = new BLLMachines();
        }
        public zkemkeeper.CZKEMClass axCZKEM1 = new zkemkeeper.CZKEMClass();
        private bool bIsConnected = false;//the boolean value identifies whether the device is connected
        private int iMachineNumber = 1;//the serial number of the device.After connecting the device ,this value will be changed.
        private int iIndex = 0;
        private int iValue = 0;
        IList<AttLog> result = new List<AttLog>();
        private void btnConnect_Click(object sender, EventArgs e)
        {
            bool IsSelect = false;
            Cursor = Cursors.WaitCursor;
            if (this.dgvfrmMachines.DataSource != null && this.dgvfrmMachines.Rows.Count > 0)
            {
                for (int i = 0; i < dgvfrmMachines.Rows.Count; i++)
                {
                    Model.Machines model = this.dgvfrmMachines.Rows[i].DataBoundItem as Model.Machines;
                    if (model.State)
                    {
                        IsSelect = true;
                        string IPAdd = model.IP;
                        int Port = int.Parse(model.Port);
                        bIsConnected = axCZKEM1.Connect_Net(IPAdd, Port);
                        if (bIsConnected == true)
                        {
                            model.Remarks = "连接成功";
                        }
                        else
                        {
                            model.Remarks = "连接失败";
                            MessageBox.Show(model.MachineName + "连接失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        axCZKEM1.Disconnect();
                    }
                }
                this.machinesBindingSource.ResetBindings(false);
            }
            if (!IsSelect)
            {
                MessageBox.Show("请选择考勤机", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Cursor = Cursors.Default;
        }
        private void btnDownloadAttLogs_Click(object sender, EventArgs e)
        {
            bool IsSelect = false;
            Cursor = Cursors.WaitCursor;
            if (this.dgvfrmMachines.DataSource != null && this.dgvfrmMachines.Rows.Count > 0)
            {

                for (int i = 0; i < dgvfrmMachines.Rows.Count; i++)
                {
                    Model.Machines model = this.dgvfrmMachines.Rows[i].DataBoundItem as Model.Machines;
                    if (model.State)
                    {
                        IsSelect = true;
                        string IPAdd = model.IP;
                        int Port = int.Parse(model.Port);
                        bIsConnected = axCZKEM1.Connect_Net(IPAdd, Port);
                        if (bIsConnected == false)
                        {
                            axCZKEM1.Disconnect();
                            Cursor = Cursors.Default;
                            MessageBox.Show(model.MachineName + "请连接失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        axCZKEM1.EnableDevice(iMachineNumber, false);//disable the device
                        FrmProgress progressWindowForm = new FrmProgress();
                        if (axCZKEM1.GetDeviceStatus(iMachineNumber, 6, ref iValue)) //Here we use the function "GetDeviceStatus" to get the record's count.The parameter "Status" is 6.
                        {
                            progressWindowForm.Text = model.MachineName + "的" + iValue + "条数据";
                            System.Threading.ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(DoSomeWork), progressWindowForm);
                            progressWindowForm.ShowDialog();
                        }                        
                        axCZKEM1.EnableDevice(iMachineNumber, true);//enable the device
                        axCZKEM1.Disconnect();
                    }
                }
                foreach (AttLog item in result)
                {
                    lvLogs.Items.Add(iIndex.ToString());
                    lvLogs.Items[iIndex].SubItems.Add(item.SdwEnrollNumber);
                    lvLogs.Items[iIndex].SubItems.Add(item.UserName);
                    lvLogs.Items[iIndex].SubItems.Add(item.AttLogDate);
                    lvLogs.Items[iIndex].SubItems.Add(item.IdwVerifyMode);
                    iIndex++;
                }            
            }
            if (!IsSelect)
            {
                MessageBox.Show("请选择考勤机", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Cursor = Cursors.Default;

        }
        private void frmAttLog_Load(object sender, EventArgs e)
        {
            //
            dgvfrmMachines.AutoGenerateColumns = false;
            this.machinesBindingSource.DataSource = new BLLMachines().GetMachinesList("");
            this.machinesBindingSource.ResetBindings(false);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        private void DoSomeWork(object status)
        {
            FrmProgress progressWindowForm = status as FrmProgress;
            try
            {
                progressWindowForm.BeginThread(0, iValue);
                string sdwEnrollNumber = "";
                int idwVerifyMode = 0;
                int idwInOutMode = 0;
                int idwYear = 0;
                int idwMonth = 0;
                int idwDay = 0;
                int idwHour = 0;
                int idwMinute = 0;
                int idwSecond = 0;
                int idwWorkcode = 0;
                int idwErrorCode = 0;
                int iGLCount = 0;
                if (axCZKEM1.ReadGeneralLogData(iMachineNumber))//read all the attendance records to the memory
                {
                    while (axCZKEM1.SSR_GetGeneralLogData(iMachineNumber,
                                                           out sdwEnrollNumber,
                                                           out idwVerifyMode,
                                                           out idwInOutMode,
                                                           out idwYear,
                                                           out idwMonth,
                                                           out idwDay,
                                                           out idwHour,
                                                           out idwMinute,
                                                           out idwSecond,
                                                           ref idwWorkcode))//get records from the memory
                    {
                        string UserID = sdwEnrollNumber;
                        string VerifyMode = idwVerifyMode.ToString();
                        string InOutMode = idwInOutMode.ToString();
                        string AttDate = idwYear.ToString() + "-" + idwMonth.ToString() + "-" + idwDay.ToString() + " " + idwHour.ToString() + ":" + idwMinute.ToString() + ":" + idwSecond.ToString();
                        string WorkCode = idwWorkcode.ToString();
                        string Reserved = "";
                        ReturnValue rtn = BLLAttLog.AddAttLog(UserID, VerifyMode, InOutMode, AttDate, WorkCode, Reserved);                   
                        AttLog model=new AttLog();
                        model.SdwEnrollNumber = sdwEnrollNumber;
                        model.UserName = rtn.Reason;
                        model.AttLogDate = idwYear.ToString() + "-" + idwMonth.ToString() + "-" + idwDay.ToString() + " " + idwHour.ToString() + ":" + idwMinute.ToString() + ":" + idwSecond.ToString();
                        model.IdwVerifyMode =idwVerifyMode.ToString();
                        result.Add(model);
                        iGLCount++;
                        progressWindowForm.SetDisplayText(String.Format("第{0}条数据正在下载中..", iGLCount));
                        progressWindowForm.StepTo(iGLCount);
                        if (progressWindowForm.IsAborting)
                        {
                            continue;
                        }
                    }
                }
                else
                {
                    Cursor = Cursors.Default;
                    axCZKEM1.GetLastError(ref idwErrorCode);
                    MessageBox.Show("下载考勤数据失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            finally
            {
                if (progressWindowForm != null)
                {
                    progressWindowForm.End();
                }
            }
        }
    }
}
