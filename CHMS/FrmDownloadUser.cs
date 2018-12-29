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
    public partial class FrmDownloadUser : Form
    {
        private DAL.SQLHelper DbHelperSQL;
        private BLLMachines Action;
        public FrmDownloadUser()
        {
            InitializeComponent();
            DbHelperSQL = new DAL.SQLHelper();
            Action = new BLLMachines();

        }
        public zkemkeeper.CZKEMClass axCZKEM1 = new zkemkeeper.CZKEMClass();
        private bool bIsConnected = false;//the boolean value identifies whether the device is connected
        private int iMachineNumber = 1;//the serial number of the device.After connecting the device ,this value will be changed.
        private int iValue = 0;
        List<ListViewItem> result = new List<ListViewItem>();
        private void btnConnect_Click(object sender, EventArgs e)
        {
            bool IsSelect = false;
            Cursor = Cursors.WaitCursor;
            if (this.dgvfrmMachines.DataSource != null && this.dgvfrmMachines.Rows.Count > 0)
            {
                for (int i = 0; i < dgvfrmMachines.Rows.Count; i++)
                {
                    DAL.Machines model = this.dgvfrmMachines.Rows[i].DataBoundItem as DAL.Machines;
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

        //5+1+a+s+p+x
        private void btnDownloadAttLogs_Click(object sender, EventArgs e)
        {
            bool IsSelect = false;
            if (this.dgvfrmMachines.DataSource != null && this.dgvfrmMachines.Rows.Count > 0)
            {
                Cursor = Cursors.WaitCursor;
                lvCard.Items.Clear();
                lvCard.BeginUpdate();
                for (int i = 0; i < dgvfrmMachines.Rows.Count; i++)
                {
                    DAL.Machines model = this.dgvfrmMachines.Rows[i].DataBoundItem as DAL.Machines;
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
                            MessageBox.Show(model.MachineName + "连接失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        axCZKEM1.EnableDevice(iMachineNumber, false);//disable the device
                        if (axCZKEM1.GetDeviceStatus(iMachineNumber, 2, ref iValue)) //Here we use the function "GetDeviceStatus" to get the record's count.The parameter "Status" is 6.
                        {                       
                            FrmProgress progressWindowForm = new FrmProgress();
                            System.Threading.ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(DoSomeWork), progressWindowForm);
                            progressWindowForm.Text =model.MachineName+"的" + iValue + "条数据";
                            progressWindowForm.ShowDialog();
                        }
                        axCZKEM1.EnableDevice(iMachineNumber, true);//enable the device 

                    }
                }
                foreach (ListViewItem item in result)
                {
                    lvCard.Items.Add(item);
                }
                lvCard.EndUpdate();
            }
            if (!IsSelect)
            {
                MessageBox.Show("请选择考勤机", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Cursor = Cursors.Default;
        }
        private void frmDownloadUser_Load(object sender, EventArgs e)
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
                string sdwEnrollNumber = "";
                string sName = "";
                string sPassword = "";
                int iPrivilege = 0;
                bool bEnabled = false;
                string sCardnumber = "";
                int idwFingerIndex;
                string sTmpData = "";
                int iTmpLength = 0;
                int iFlag = 0;
                int iGLCount = 0;//5|1|a|s|p|x
                string sProductCode = "";
                progressWindowForm.BeginThread(0,iValue);
                axCZKEM1.GetProductCode(iMachineNumber, out sProductCode);
                axCZKEM1.ReadAllUserID(iMachineNumber);//read all the user information to the memory
                if (sProductCode == "U160")
                {
                    axCZKEM1.ReadAllTemplate(iMachineNumber);//read all the users' fingerprint templates to the memory
                }
                //工号信息
                while (axCZKEM1.SSR_GetAllUserInfo(iMachineNumber, out sdwEnrollNumber, out sName, out sPassword, out iPrivilege, out bEnabled))//get user information from memory
                {
                    //卡                  
                    axCZKEM1.GetStrCardNumber(out sCardnumber);
                    string UserID = sdwEnrollNumber;
                    string Name = sName;
                    string AttNumber = sCardnumber;
                    string Privilege = iPrivilege.ToString();
                    string MverifyPass = sPassword;
                    string Enabled = bEnabled == true ? "1" : "0";
                    BLLAttLog.AddDownUserInfo(UserID, Name, AttNumber, Privilege, MverifyPass, Enabled);
                    ListViewItem list = new ListViewItem();
                    list.Text = sdwEnrollNumber;
                    list.SubItems.Add(sName);
                    list.SubItems.Add(sCardnumber);
                    list.SubItems.Add("");
                    list.SubItems.Add("");
                    list.SubItems.Add(iPrivilege.ToString());
                    list.SubItems.Add(sPassword);
                    if (bEnabled == true)
                    {
                        list.SubItems.Add("启用");
                    }
                    else
                    {
                        list.SubItems.Add("未启用");
                    }
                    result.Add(list);
                    iGLCount++;
                    progressWindowForm.SetDisplayText(String.Format("第{0}条数据正在下载中..", iGLCount));
                    progressWindowForm.StepTo(iGLCount);
                    if (progressWindowForm.IsAborting)
                    {
                        continue;
                    }
                    //
                    if (sProductCode == "U160")
                    {
                        #region 指纹
                        for (idwFingerIndex = 0; idwFingerIndex < 10; idwFingerIndex++)
                        {
                            if (axCZKEM1.GetUserTmpExStr(iMachineNumber, sdwEnrollNumber, idwFingerIndex, out iFlag, out sTmpData, out iTmpLength))//get the corresponding templates string and length from the memory
                            {
                                BLLAttLog.AddDownUserTemplate(sdwEnrollNumber, idwFingerIndex, sTmpData);
                                ListViewItem list1 = new ListViewItem();
                                list1.Text = sdwEnrollNumber;
                                list1.SubItems.Add(sName);
                                list1.SubItems.Add("");
                                list1.SubItems.Add(idwFingerIndex.ToString());
                                list1.SubItems.Add(sTmpData);
                                list1.SubItems.Add(iPrivilege.ToString());
                                list1.SubItems.Add(sPassword);
                                if (bEnabled == true)
                                {
                                    list1.SubItems.Add("启用");
                                }
                                else
                                {
                                    list1.SubItems.Add("未启用");
                                }
                                list1.SubItems.Add(iFlag.ToString());
                                result.Add(list1);
                            }
                        }
                    }
                    #endregion
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
