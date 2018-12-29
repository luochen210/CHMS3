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
    public partial class FrmUpload : Form
    {
        private DAL.SQLHelper DbHelperSQL;
        private UserInfoDepartments Ation = new UserInfoDepartments();
        public FrmUpload()
        {
            InitializeComponent();
            DbHelperSQL = new DAL.SQLHelper();
        }
        public zkemkeeper.CZKEMClass axCZKEM1 = new zkemkeeper.CZKEMClass();
        private bool bIsConnected = false;//the boolean value identifies whether the device is connected
        private int iMachineNumber = 1;//the serial number of the device.After connecting the device ,this value will be changed.
        private int iValue = 0;
        private string UserInfo = "";
        private bool IsSelect = false;
        private bool IsExUpLoad = true;
        private void btnColse_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            UserInfo = new TreeViewManager().GetCheckedNodes(tvUserInfo);
            if (UserInfo == "")
            {
                MessageBox.Show("请选择上传的人事信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        
            if (this.dgvfrmMachines.DataSource != null && this.dgvfrmMachines.Rows.Count > 0)
            {
                for (int i = 0; i < dgvfrmMachines.Rows.Count; i++)
                {
                    DAL.Machines model = this.dgvfrmMachines.Rows[i].DataBoundItem as DAL.Machines;
                    if (model.State)
                    {
                        IsSelect = true;
                    }
                }
            }
            if (!IsSelect)
            {
                MessageBox.Show("请选择考勤机", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }        
            Cursor = Cursors.WaitCursor;
            if (this.dgvfrmMachines.DataSource != null && this.dgvfrmMachines.Rows.Count > 0)
            {                
                for (int i = 0; i < dgvfrmMachines.Rows.Count; i++)
                {
                    DAL.Machines model = this.dgvfrmMachines.Rows[i].DataBoundItem as DAL.Machines;
                    if (model.State)
                    {                 
                        string IPAdd = model.IP;
                        int Port = int.Parse(model.Port);
                        bIsConnected = axCZKEM1.Connect_Net(IPAdd, Port);                   
                        if (!bIsConnected)
                        {
                            Cursor = Cursors.Default;
                            axCZKEM1.Disconnect();
                            MessageBox.Show(model.MachineName + "请连接失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                         iValue=UserInfo.Split('$').Length-1;
                        FrmProgress progressWindowForm = new FrmProgress();
                        System.Threading.ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(DoSomeWork), progressWindowForm);
                        progressWindowForm.Text="上传"+iValue+"条人员信息到"+model.MachineName;
                        progressWindowForm.ShowDialog();                                              
                    }
                }
            }           
            if (IsExUpLoad)
            {
                MessageBox.Show("人事信息上传成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Cursor = Cursors.Default;         

        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
        
            Cursor = Cursors.WaitCursor;
            if (this.dgvfrmMachines.DataSource != null && this.dgvfrmMachines.Rows.Count > 0)
            {
             
                for (int i = 0; i < dgvfrmMachines.Rows.Count; i++)
                {
                    DAL.Machines model = this.dgvfrmMachines.Rows[i].DataBoundItem as DAL.Machines;
                    if (model.State)
                    {               
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
                    }
                }
                this.machinesBindingSource.ResetBindings(false);
            }           
            Cursor = Cursors.Default;
        }
        private void frmUpload_Load(object sender, EventArgs e)
        {
            //
            dgvfrmMachines.AutoGenerateColumns = false;
            this.machinesBindingSource.DataSource = new BLLMachines().GetMachinesList("");
            this.machinesBindingSource.ResetBindings(false);
            //
            new TreeViewManager().BindTreeView(tvUserInfo);
        }

        private void DoSomeWork(object status)
        {
            FrmProgress progressWindowForm = status as FrmProgress;
            try
            {              
                progressWindowForm.BeginThread(0, iValue);
                int iGLCount=1;
                foreach (string item in UserInfo.Split('$'))
                {
                    if (item != "")
                    {                      
                        progressWindowForm.SetDisplayText(String.Format("第{0}条数据正在上传中..", iGLCount));
                        progressWindowForm.StepTo(iGLCount);                     
                        iGLCount++;
                        string UserID = item;
                        DataSet ds;
                        ReturnValue rtn = BLLAttLog.QueryUploadByUserID(UserID, out ds);
                        if (rtn.Result == 1)
                        {
                            int idwErrorCode = 0;
                            //传卡信息
                            DataTable dt = ds.Tables[0];
                            int iFlag = 1;
                            string sdwEnrollNumber = dt.Rows[0]["UserID"].ToString();
                            string sName = dt.Rows[0]["Name"].ToString();
                            string sPassword = dt.Rows[0]["MverifyPass"].ToString();
                            int iPrivilege = Convert.ToInt32(dt.Rows[0]["Privilege"].ToString());
                            string sCardnumber = dt.Rows[0]["AttNumber"].ToString();
                            bool bEnabled = dt.Rows[0]["Enabled"].ToString() == "1" ? true : false;
                            string sProductCode = "";
                            axCZKEM1.EnableDevice(iMachineNumber, false);
                            axCZKEM1.GetProductCode(iMachineNumber, out sProductCode);
                            axCZKEM1.SetStrCardNumber(sCardnumber);//Before you using function SetUserInfo,set the card number to make sure you can upload it to the device
                            if (axCZKEM1.SSR_SetUserInfo(iMachineNumber, sdwEnrollNumber, sName, sPassword, iPrivilege, bEnabled))//upload the user's information(card number included)
                            {
                                DataTable dtTempData = ds.Tables[1];
                                //传指纹信息
                                if (sProductCode == "U160")
                                {
                                    for (int j = 0; j < dtTempData.Rows.Count; j++)
                                    {
                                        int idwFingerIndex = Convert.ToInt32(dtTempData.Rows[j]["Fingerid"].ToString());
                                        string sTmpData = dtTempData.Rows[j]["Template"].ToString();
                                        axCZKEM1.SetUserTmpExStr(iMachineNumber, sdwEnrollNumber, idwFingerIndex, iFlag, sTmpData);//upload templates information to the device
                                    }
                                }
                            }
                            else
                            {
                                axCZKEM1.GetLastError(ref idwErrorCode);
                                IsExUpLoad = false;
                            }
                            axCZKEM1.RefreshData(iMachineNumber);//the data in the device should be refreshed
                            axCZKEM1.EnableDevice(iMachineNumber, true);                          
                            if (!IsExUpLoad)
                            {
                                Cursor = Cursors.Default;
                                MessageBox.Show("人事信息失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
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
