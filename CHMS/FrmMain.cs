using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using BLL;
using System.Timers;
using DAL;
using System.Data.SqlClient;
using Model;

namespace CHMS
{
    public partial class FrmMain : Form
    {
        Events events = new Events();
        Event tEvent;
        TimeSpan remainTime;
        public FrmMain()
        {
            InitializeComponent();
        }
        private IList<Model.Machines> Machineslist = new BLLMachines().GetMachinesList("");
        public zkemkeeper.CZKEMClass axCZKEM1 = new zkemkeeper.CZKEMClass();
        private bool bIsConnected = false;//the boolean value identifies whether the device is connected
        private int iMachineNumber = 1;//the serial number of the device.After connecting the device ,this value will be changed.
        IList<AttLog> result = new List<AttLog>();

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.tssCurrentName.Text = "当前用户|" + Parameter.CurrentUser.UserName;
            timCurrent.Start();
            //
            DateTime endTime = DateTime.Parse(DAL.AppSettings.GetValue("Task"));
            tEvent = new Event("定时考勤记录采集", DateTime.Now, endTime);
            events.Add(tEvent);
            remainTime = tEvent.EndTime.Subtract(DateTime.Now);
            if (remainTime.TotalMilliseconds > 0)
            {
                tEvent.showMessage.Interval = remainTime.TotalMilliseconds;
                tEvent.showMessage.AutoReset = false;
                tEvent.tEventTimer.Tick += new EventHandler(tEventTimer_Tick);
                tEvent.showMessage.Elapsed += new ElapsedEventHandler(tEventTimer_Elapsed);
                tEvent.tEventTimer.Start();
                tEvent.showMessage.Start();
            }
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_CLOSE = 0xF060;
            if (m.Msg == WM_SYSCOMMAND && (int)m.WParam == SC_CLOSE)
            {
                this.Dispose();
                Application.Exit();
                Process.GetCurrentProcess().Dispose();
                Process.GetCurrentProcess().Kill();
                GC.Collect();
            }
            base.WndProc(ref m);
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Application.Exit();
            Process.GetCurrentProcess().Dispose();
            Process.GetCurrentProcess().Kill();
            GC.Collect();
        }

        private void timCurrent_Tick(object sender, EventArgs e)
        {
            tssCurrentTime.Text = "当前时间|" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        //人事信息
        private void tslUserInfo_Click(object sender, EventArgs e)
        {
            FrmRptUserInfo objfrmRptUserInfo = new FrmRptUserInfo();
            objfrmRptUserInfo.StartPosition = FormStartPosition.CenterScreen;
            objfrmRptUserInfo.Size = new Size(new Point(800, 600));
            objfrmRptUserInfo.Show();
        }

        void tEventTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                remainTime = tEvent.EndTime.Subtract(DateTime.Now);
                if (remainTime.TotalSeconds >= 0)
                {

                }
                else
                {
                    if (tEvent.tEventTimer != null)
                    {
                        tEvent.tEventTimer.Stop();
                        tEvent.tEventTimer.Dispose();
                    }
                }
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        void tEventTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                if (tEvent._timeUp && tEvent.showMessage != null)
                {
                    tEvent.showMessage.Stop();
                    tEvent.showMessage.Close();
                    tEvent.showMessage.Dispose();
                    tEvent._timeUp = false;
                    //
                    foreach (Model.Machines model in Machineslist)
                    {
                        string IPAdd = model.IP;
                        int Port = int.Parse(model.Port);
                        bIsConnected = axCZKEM1.Connect_Net(IPAdd, Port);

                        if (bIsConnected == false)
                        {
                            continue;
                        }
                           
                        //初始化记录变量
                        int idwEnrollNumber = 0;
                        int idwVerifyMode = 0;
                        int idwInOutMode = 0;
                        string sTime = "";

                        int idwWorkcode = 0;
                        int idwErrorCode = 0;
                        int iGLCount = 0;

                        axCZKEM1.EnableDevice(iMachineNumber, false);//disable the device 
                        if (axCZKEM1.ReadGeneralLogData(iMachineNumber))//read all the attendance records to the memory
                        {
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

                            //进度条
                            FrmProgress progressWindowForm = new FrmProgress();
                            //开始读取
                            while (axCZKEM1.GetGeneralLogDataStr(iMachineNumber, ref idwEnrollNumber, ref idwVerifyMode, ref idwInOutMode, ref sTime))//从内存取得记录
                            {
                                //把记录循环写入DataTable表
                                DataRow dr = AttLogTable.NewRow();
                                dr[0] = idwEnrollNumber;
                                dr[1] = iMachineNumber;
                                dr[2] = idwVerifyMode;
                                dr[3] = idwInOutMode;
                                dr[4] = sTime;
                                AttLogTable.Rows.Add(dr);

                                /////////////////////////////////////////////////////////


                                int UserId = idwEnrollNumber;
                                string VerifyMode = idwVerifyMode.ToString();
                                string InOutMode = idwInOutMode.ToString();
                                string AttDate = sTime;
                                string WorkCode = idwWorkcode.ToString();

                                ReturnValue rtn = BLLAttLog.AddAttLog(idwEnrollNumber, iMachineNumber, idwVerifyMode, idwInOutMode, sTime);

                                AttLog objAttLog = new AttLog();

                                objAttLog.SdwEnrollNumber = idwEnrollNumber;
                                objAttLog.UserName = rtn.Reason;
                                objAttLog.AttLogDate = sTime;
                                objAttLog.IdwVerifyMode = idwVerifyMode;

                                result.Add(objAttLog);////////////////////////////////////


                                iGLCount++;//下载个数
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
                        }
                        axCZKEM1.EnableDevice(iMachineNumber, true);//enable the device
                        Cursor = Cursors.Default;
                    }
                }
            }
            catch
            {
                throw new NotImplementedException();
            }
        }


        #region 设备管理

        //设备参数
        public static FrmMachines objFrmMachines = null;
        private void 设备参数ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objFrmMachines == null)
            {
                objFrmMachines = new FrmMachines();
                objFrmMachines.Show();
            }
            else
            {
                objFrmMachines.Activate();//激活只能在最小化的时候起作用
                objFrmMachines.WindowState = FormWindowState.Normal;
            }
        }

        //下载考勤
        public static FrmAttLog objFrmAttLog = null;
        private void 下载考勤ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objFrmAttLog == null)
            {
                objFrmAttLog = new FrmAttLog();
                objFrmAttLog.Show();
            }
            else
            {
                objFrmAttLog.Activate();//激活只能在最小化的时候起作用
                objFrmAttLog.WindowState = FormWindowState.Normal;
            }
        }

        //下载员工信息
        public static FrmDownloadUser objFrmDownloadUser = null;
        private void 下载员工信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //上传员工信息
        public static FrmUpload objFrmUpload = null;
        private void 上传员工信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #endregion



        //员工设置
        public static FrmUserinfo objFrmUserinfo = null;
        private void 员工设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objFrmUserinfo == null)
            {
                objFrmUserinfo = new FrmUserinfo();
                objFrmUserinfo.Show();
            }
            else
            {
                objFrmUserinfo.Activate();//激活只能在最小化的时候起作用
                objFrmUserinfo.WindowState = FormWindowState.Normal;
            }
        }

        //员工档案
        public static FrmRptUserInfo objFrmRptUserInfo = null;
        private void 员工档案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objFrmRptUserInfo == null)
            {
                objFrmRptUserInfo = new FrmRptUserInfo();
                objFrmRptUserInfo.Show();
            }
            else
            {
                objFrmRptUserInfo.Activate();//激活只能在最小化的时候起作用
                objFrmRptUserInfo.WindowState = FormWindowState.Normal;
            }
        }

        //员工通讯录
        public static FrmRptAddresslist objFrmRptAddresslist = null;
        private void 员工通讯录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objFrmRptAddresslist == null)
            {
                objFrmRptAddresslist = new FrmRptAddresslist();
                objFrmRptAddresslist.Show();
            }
            else
            {
                objFrmRptAddresslist.Activate();//激活只能在最小化的时候起作用
                objFrmRptAddresslist.WindowState = FormWindowState.Normal;
            }
        }

        //公司信息
        public static FrmRptAddresslist objFrmCompany = null;
        private void 公司信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objFrmCompany == null)
            {
                objFrmCompany = new FrmRptAddresslist();
                objFrmCompany.Show();
            }
            else
            {
                objFrmCompany.Activate();//激活只能在最小化的时候起作用
                objFrmCompany.WindowState = FormWindowState.Normal;
            }
        }

        //部门信息
        public static FrmDeartments objFrmDeartments = null;
        private void 部门信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objFrmDeartments == null)
            {
                objFrmDeartments = new FrmDeartments();
                objFrmDeartments.Show();
            }
            else
            {
                objFrmDeartments.Activate();//激活只能在最小化的时候起作用
                objFrmDeartments.WindowState = FormWindowState.Normal;
            }
        }

        public static FrmRptMonthLog objFrmRptMonthLog = null;
        private void 考勤月报ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objFrmRptMonthLog == null)
            {
                objFrmRptMonthLog = new FrmRptMonthLog();
                objFrmRptMonthLog.Show();
            }
            else
            {
                objFrmRptMonthLog.Activate();//激活只能在最小化的时候起作用
                objFrmRptMonthLog.WindowState = FormWindowState.Normal;
            }
        }

        public static FrmRptDayLog objFrmRptDayLog = null;
        private void 考勤日报ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objFrmRptDayLog == null)
            {
                objFrmRptDayLog = new FrmRptDayLog();
                objFrmRptDayLog.Show();
            }
            else
            {
                objFrmRptDayLog.Activate();//激活只能在最小化的时候起作用
                objFrmRptDayLog.WindowState = FormWindowState.Normal;
            }
        }

        //创建模拟数据
        public static FrmCreateAttLog objFrmCreateAttLog = null;
        private void btnTest_Click(object sender, EventArgs e)
        {
            if (objFrmCreateAttLog==null)
            {
                objFrmCreateAttLog = new FrmCreateAttLog();
                objFrmCreateAttLog.Show();
            }
            else
            {
                objFrmCreateAttLog.Activate();//最小化
                objFrmCreateAttLog.WindowState = FormWindowState.Normal;
            }
        }
    }


    /// <summary>
    /// 数据库操作控制类 
    /// </summary>
    public class DataBaseControl
    {
        /// <summary> 
        /// 数据库连接字符串 
        /// </summary> 
        public string ConnectionString;

        /// <summary> 
        /// SQL操作语句/存储过程 
        /// </summary> 
        public string StrSQL;

        /// <summary> 
        /// 实例化一个数据库连接对象 
        /// </summary> 
        private SqlConnection Conn;

        /// <summary> 
        /// 实例化一个新的数据库操作对象Comm 
        /// </summary> 
        private SqlCommand Comm;

        /// <summary> 
        /// 要操作的数据库名称 
        /// </summary> 
        public string DataBaseName;

        /// <summary> 
        /// 数据库文件完整地址 
        /// </summary> 
        public string DataBase_MDF;

        /// <summary> 
        /// 数据库日志文件完整地址 
        /// </summary> 
        public string DataBase_LDF;

        /// <summary> 
        /// 备份文件名 
        /// </summary> 
        public string DataBaseOfBackupName;

        /// <summary> 
        /// 备份文件路径 
        /// </summary> 
        public string DataBaseOfBackupPath;

        /// <summary> 
        /// 执行创建/修改数据库和表的操作 
        /// </summary> 
        public void DataBaseAndTableControl()
        {
            try
            {
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();
                Comm = new SqlCommand();
                Comm.Connection = Conn;
                Comm.CommandText = StrSQL;
                Comm.CommandType = CommandType.Text;
                Comm.ExecuteNonQuery();
                MessageBox.Show("数据库操作成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                Conn.Close();
            }
        }

        /// <summary> 
        /// 附加数据库 
        /// </summary> 
        public void AddDataBase()
        {
            try
            {
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();
                Comm = new SqlCommand();
                Comm.Connection = Conn;
                Comm.CommandText = "sp_attach_db";
                Comm.Parameters.Add(new SqlParameter(@"dbname", SqlDbType.NVarChar));
                Comm.Parameters[@"dbname"].Value = DataBaseName;
                Comm.Parameters.Add(new SqlParameter(@"filename1", SqlDbType.NVarChar));
                Comm.Parameters[@"filename1"].Value = DataBase_MDF;
                Comm.Parameters.Add(new SqlParameter(@"filename2", SqlDbType.NVarChar));
                Comm.Parameters[@"filename2"].Value = DataBase_LDF;
                Comm.CommandType = CommandType.StoredProcedure;
                Comm.ExecuteNonQuery();
                MessageBox.Show("附加数据库成功", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                Conn.Close();
            }
        }

        /// <summary> 
        /// 分离数据库 
        /// </summary> 
        public void DeleteDataBase()
        {
            try
            {
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();

                Comm = new SqlCommand();
                Comm.Connection = Conn;
                Comm.CommandText = @"sp_detach_db";

                Comm.Parameters.Add(new SqlParameter(@"dbname", SqlDbType.NVarChar));
                Comm.Parameters[@"dbname"].Value = DataBaseName;

                Comm.CommandType = CommandType.StoredProcedure;
                Comm.ExecuteNonQuery();

                MessageBox.Show("分离数据库成功", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                Conn.Close();
            }
        }

        /// <summary> 
        /// 备份数据库 
        /// </summary> 
        public bool BackupDataBase()
        {
            try
            {
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();
                Comm = new SqlCommand();
                Comm.Connection = Conn;
                Comm.CommandText = "use master;backup database @dbname to disk = @backupname;";
                Comm.Parameters.Add(new SqlParameter(@"dbname", SqlDbType.NVarChar));
                Comm.Parameters[@"dbname"].Value = DataBaseName;
                Comm.Parameters.Add(new SqlParameter(@"backupname", SqlDbType.NVarChar));
                Comm.Parameters[@"backupname"].Value = @DataBaseOfBackupPath + @DataBaseOfBackupName;
                Comm.CommandType = CommandType.Text;
                Comm.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                Conn.Close();
            }
        }

        /// <summary> 
        /// 还原数据库 
        /// </summary> 
        public bool ReplaceDataBase()
        {
            try
            {
                string BackupFile = @DataBaseOfBackupPath + @DataBaseOfBackupName;
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();
                Comm = new SqlCommand();
                Comm.Connection = Conn;
                Comm.CommandText = @"use master;restore database @DataBaseName From disk = @BackupFile with replace,MOVE 'CHMS' TO '"+@DataBaseOfBackupPath+"CHMS.mdf',MOVE 'CHMS_log' TO '"+@DataBaseOfBackupPath+"CHMS.ldf'";
                Comm.Parameters.Add(new SqlParameter(@"DataBaseName", SqlDbType.NVarChar));
                Comm.Parameters[@"DataBaseName"].Value = DataBaseName;
                Comm.Parameters.Add(new SqlParameter(@"BackupFile", SqlDbType.NVarChar));
                Comm.Parameters[@"BackupFile"].Value = BackupFile;
                Comm.CommandType = CommandType.Text;
                Comm.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            finally
            {
                Conn.Close();
            }
        }
    }

}