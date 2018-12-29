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
using Models;
using System.Threading;

namespace CHMS
{
    public partial class FrmAttLog : Form
    {
        private DAL.SQLHelper DbHelperSQL;
        private BLLMachines Action;
        public FrmAttLog()
        {
            InitializeComponent();
            DbHelperSQL = new DAL.SQLHelper();
            Action = new BLLMachines();
        }

        public zkemkeeper.CZKEMClass axCZKEM1 = new zkemkeeper.CZKEMClass();//加载API
        bool bIsConnected = false;//设备连接标志
        int iMachineNumber = 1;//设备的序列号。连接设备后，这个值将被改变。
        int idwErrorCode = 0;

        private int iValue = 0;
        IList<AttLog> listAttLog = new List<AttLog>();//listAttLog

        //声明dgv委托
        public delegate void UpdataDgv(DataTable dtTable);
        UpdataDgv objUpdataDgv;//dgv更新对象

        //声明下载委托
        public delegate void GetDoSomeWork();
        GetDoSomeWork objGetDoSomeWork;

        //设置进度值的委托
        public delegate void SetPrg(int iValue, int iMachineNumber);
        SetPrg objSetPrg;

        //声明进度条委托
        public delegate void GetStartPrg(int iGLCount);
        GetStartPrg objGetStartPrg;

        //声明lbl委托
        public delegate void UpdateLbl(string msg);
        UpdateLbl objUpdateLbl;

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

                        int idwErrorCode = 0;
                        Cursor = Cursors.WaitCursor;

                        bIsConnected = axCZKEM1.Connect_Net(IPAdd, Port);//连接设备

                        if (bIsConnected == true)
                        {
                            model.Remarks = "连接成功";
                            btnConnect.Refresh();
                            iMachineNumber = 1;//In fact,when you are using the tcp/ip communication,this parameter will be ignored,that is any integer will all right.Here we use 1.
                            axCZKEM1.RegEvent(iMachineNumber, 65535);//Here you can register the realtime events that you want to be triggered(the parameters 65535 means registering all)
                        }
                        else
                        {
                            model.Remarks = "连接失败";
                            axCZKEM1.GetLastError(ref idwErrorCode);
                            MessageBox.Show("Unable to connect the device,ErrorCode=" + idwErrorCode.ToString(), "Error");
                        }
                        Cursor = Cursors.Default;
                    }
                }
                this.machinesBindingSource.ResetBindings(false);
            }
            if (!IsSelect)
            {
                MessageBox.Show("请选择考勤机", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Cursor = Cursors.Default;
            btnDownload.Enabled = true;//打开下载按钮
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            btnDownload.Enabled = false;//关闭下载按钮
            if (bIsConnected == false)
            {
                MessageBox.Show("请连接设备！", "Error");
                return;
            }

            //实例委托
            objGetDoSomeWork = DoSomeWork;

            //多线程下载记录
            Thread objThread = new Thread(new ThreadStart(delegate
            {
                objGetDoSomeWork();
            }));
            objThread.Start();

        }


        //记录下载委托实现方法
        private void DoSomeWork()
        {
            //初始化记录变量
            int idwEnrollNumber = 0;
            int idwVerifyMode = 0;
            int idwInOutMode = 0;
            string sTime = "";

            int iGLCount = 0;

            //创建一个名为"AttLogTable"的DataTable表
            DataTable AttLogTable = new DataTable();
            //设定列数据
            AttLogTable.Columns.Add("ClockId", typeof(int));
            AttLogTable.Columns.Add("MachineId", typeof(int));
            AttLogTable.Columns.Add("VerifyMode", typeof(int));
            AttLogTable.Columns.Add("InOutMode", typeof(int));
            AttLogTable.Columns.Add("ClockRecord", typeof(DateTime));
            //清空DataTable行数据
            AttLogTable.Rows.Clear();

            axCZKEM1.EnableDevice(iMachineNumber, false);//禁用设备

            if (axCZKEM1.GetDeviceStatus(iMachineNumber, 6, ref iValue)) //Here we use the function "GetDeviceStatus" to get the record's count.The parameter "Status" is 6.
            {
                //设置Prg的值
                objSetPrg = setPrg;
                BeginInvoke(objSetPrg, iValue, iMachineNumber);

                objUpdateLbl = updateLbl;//实例lbl修改的委托

                objGetStartPrg = startPrg;//实例Prg委托

                //读取考勤
                if (axCZKEM1.ReadGeneralLogData(iMachineNumber))//将记录读入内存
                {
                    //开始下载考勤
                    while (axCZKEM1.GetGeneralLogDataStr(iMachineNumber, ref idwEnrollNumber, ref idwVerifyMode, ref idwInOutMode, ref sTime))//从内存取得记录
                    {
                        iGLCount++;

                        //把记录循环写入DataTable表
                        DataRow dr = AttLogTable.NewRow();
                        dr[0] = idwEnrollNumber;
                        dr[1] = iMachineNumber;
                        dr[2] = idwVerifyMode;
                        dr[3] = idwInOutMode;
                        dr[4] = sTime;
                        AttLogTable.Rows.Add(dr);

                        //异步执行
                        BeginInvoke(objUpdateLbl, iGLCount + "/" + iValue);

                        //异步执行
                        BeginInvoke(objGetStartPrg, iGLCount);

                    }
                    //修改lbl
                    objUpdateLbl = updateLbl;
                    BeginInvoke(objUpdateLbl, "记录下载完毕！");
                }
                else
                {
                    Cursor = Cursors.Default;
                    axCZKEM1.GetLastError(ref idwErrorCode);

                    if (idwErrorCode != 0)
                    {
                        MessageBox.Show("Reading data from terminal failed,ErrorCode: " + idwErrorCode.ToString(), "Error");
                    }
                    else
                    {
                        axCZKEM1.GetLastError(ref idwErrorCode);
                        MessageBox.Show("Operation failed,ErrorCode=" + idwErrorCode.ToString(), "Error");
                    }
                }


            }

            axCZKEM1.EnableDevice(iMachineNumber, true);//设置设备状态为开启

            //实例化委托
            objUpdataDgv = new UpdataDgv(dgvDataSource);

            //异步显示记录
            BeginInvoke(objUpdataDgv, AttLogTable);

            #region 数据批量对比去重---暂停使用

            ////读取数据库已有数据
            //DataTable PastLogTable = objAttRecordService.GetAllOriginalLog().Tables[0];

            ////求差集结果，
            //IEnumerable<DataRow> drResult = AttLogTable.AsEnumerable().Except(PastLogTable.AsEnumerable(), DataRowComparer.Default);

            ////处理空结果的异常
            //if (drResult.Count() > 0)//如果序列元素的个数>0，则写入数据，否则跳过
            //{
            //    //接收不重复的数据
            //    DataTable dtResult = drResult.CopyToDataTable();
            //    //批量写入数据库
            //    SQLHelper.UpdataByBulk(dtResult, "OriginalLog");
            //    //异步修改lbl值
            //    BeginInvoke(objUpdataLbl, "数据保存成功！");
            //}

            #endregion

        }

        //进度条委托实现方法
        public void startPrg(int iGLCount)
        {
            prgDownload.Value = iGLCount;//设置当前值            
        }

        //lbl委托实现方法
        public void updateLbl(string str)
        {
            lblPrg.Text = str;
        }

        //prg设置委托实现方法
        public void setPrg(int iValue, int iMachineNumber)
        {
            //进度条
            prgDownload.Maximum = iValue;//设置最大长度值
            prgDownload.Step = 1;//设置每次增长多少

            //显示条数提示
            lblPrg.Text = iMachineNumber + "号设备的记录条数：" + iValue + "条！";//记录条数提示
        }

        //dgv委托更新显示实现方法
        public void dgvDataSource(DataTable AttLogTable)
        {
            //更新dgvAttLog
            dgvAttLog.DataSource = AttLogTable;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void frmAttLog_Load(object sender, EventArgs e)
        {
            dgvfrmMachines.AutoGenerateColumns = false;
            this.machinesBindingSource.DataSource = new BLLMachines().GetMachinesList("");
            this.machinesBindingSource.ResetBindings(false);
        }



        //#region 记录下载保存的方法
        //public void iDateTable()
        //{
        //    //初始化记录变量
        //    int idwEnrollNumber = 0;
        //    int idwVerifyMode = 0;
        //    int idwInOutMode = 0;
        //    string sTime = "";

        //    ////实例化委托
        //    //objUpdataLbl = new UpdataLbl(LblState);

        //    //创建一个名为"AttLogTable"的DataTable表
        //    DataTable AttLogTable = new DataTable();

        //    //设定列数据
        //    AttLogTable.Columns.Add("ClockId", typeof(int));
        //    AttLogTable.Columns.Add("MachineId", typeof(int));
        //    AttLogTable.Columns.Add("VerifyMode", typeof(int));
        //    AttLogTable.Columns.Add("InOutMode", typeof(int));
        //    AttLogTable.Columns.Add("ClockRecord", typeof(DateTime));

        //    //清空DataTable行数据
        //    AttLogTable.Rows.Clear();

        //    ////异步修改lbl值
        //    //BeginInvoke(objUpdataLbl, "正在下载记录……");

        //    while (axCZKEM1.GetGeneralLogDataStr(iMachineNumber, ref idwEnrollNumber, ref idwVerifyMode, ref idwInOutMode, ref sTime))//从内存取得记录
        //    {
        //        //把记录循环写入DataTable表
        //        DataRow dr = AttLogTable.NewRow();
        //        dr[0] = idwEnrollNumber;
        //        dr[1] = iMachineNumber;
        //        dr[2] = idwVerifyMode;
        //        dr[3] = idwInOutMode;
        //        dr[4] = sTime;
        //        AttLogTable.Rows.Add(dr);
        //    }

        //    //更新dgvAttLog
        //    dgvAttLog.DataSource = AttLogTable;

        //    ////异步修改lbl值
        //    //BeginInvoke(objUpdataLbl, "下载完毕！正在筛选记录……");

        //    #region 数据批量对比去重

        //    //读取数据库已有数据
        //    DataTable PastLogTable = objAttRecordService.GetAllOriginalLog().Tables[0];

        //    //求差集结果，
        //    IEnumerable<DataRow> drResult = AttLogTable.AsEnumerable().Except(PastLogTable.AsEnumerable(), DataRowComparer.Default);

        //    //处理空结果的异常
        //    if (drResult.Count() > 0)//如果序列元素的个数>0，则写入数据，否则跳过
        //    {
        //        //接收不重复的数据
        //        DataTable dtResult = drResult.CopyToDataTable();

        //        ////批量写入数据库
        //        //SQLHelper.UpdataByBulk(dtResult, "OriginalLog");
        //        ////异步修改lbl值
        //        //BeginInvoke(objUpdataLbl, "数据保存成功！");
        //    }

        //    #endregion

        //    //清空dt对象
        //    AttLogTable = null;
        //    PastLogTable = null;
        //    //异步修改lbl值
        //    BeginInvoke(objUpdataLbl, "数据保存成功！");

        //}
        //#endregion

        
        private void FrmAttLog_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain.objFrmAttLog = null;
        }
    }
}
