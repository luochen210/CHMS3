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
using Framework;
using System.Data.SqlClient;

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

        //#region TopMenu
        ///// <summary>
        ///// 动态创建菜单
        ///// </summary>
        ///// <param name="FilePath">菜单XML文件的路径</param>
        //private void CreateMenu()
        //{
        //    //从XML中读取数据。数据结构后面详细讲一下。
        //    if (!File.Exists(Application.StartupPath + @"\Menu.xml"))
        //    {
        //        MessageBox.Show("配置文件不存在");
        //        return;
        //    }
        //    DataSet ds = new DataSet();
        //    ds.ReadXml(Application.StartupPath + @"\Menu.xml");
        //    DataView dv = ds.Tables[0].DefaultView;
        //    //通过DataView来过滤数据首先得到最顶层的菜单
        //    dv.RowFilter = "ParentItemID=0";
        //    for (int i = 0; i < dv.Count; i++)
        //    {
        //        //创建一个菜单项
        //        ToolStripMenuItem topMenu = new ToolStripMenuItem();
        //        //给菜单赋Text值。也就是在界面上看到的值。
        //        topMenu.Text = dv[i]["Text"].ToString();
        //        ///
        //        /// 添加退出事件
        //        /// 
        //        if ("Exit".Equals(dv[i]["FormName"].ToString()))
        //        {
        //            topMenu.Click += new EventHandler(topMenu_Click);
        //        }
        //        //如果是有下级菜单则通过CreateSubMenu方法来创建下级菜单
        //        if (Convert.ToInt16(dv[i]["IsModule"]) == 1)
        //        {
        //            //以ref的方式将顶层菜单传递参数，因为他可以在赋值后再回传。－－也许还有更好的方法^_^.
        //            CreateSubMenu(ref topMenu, Convert.ToInt32(dv[i]["ItemID"]), ds.Tables[0]);
        //        }
        //        //显示应用程序中已打开的 MDI 子窗体列表的菜单项
        //        tmsCHMS.MdiWindowListItem = topMenu;
        //        //将递归附加好的菜单加到菜单根项上。
        //        tmsCHMS.Items.Add(topMenu);
        //    }
        //}
        //#region 创建子菜单
        ///// <summary>
        ///// 创建子菜单
        ///// </summary>
        ///// <param name="topMenu">父菜单项</param>
        ///// <param name="ItemID">父菜单的ID</param>
        ///// <param name="dt">所有菜单数据集</param>
        //private void CreateSubMenu(ref ToolStripMenuItem topMenu, int ItemID, DataTable dt)
        //{
        //    DataView dv = new DataView(dt);
        //    //过滤出当前父菜单下在所有子菜单数据(仅为下一层的)
        //    dv.RowFilter = "ParentItemID=" + ItemID.ToString();
        //    for (int i = 0; i < dv.Count; i++)
        //    {
        //        //创建子菜单项
        //        string strFormName = dv[i]["FormName"].ToString();
        //        string strText = dv[i]["Text"].ToString();
        //        ToolStripMenuItem subMenu = new ToolStripMenuItem();
        //        subMenu.Text = dv[i]["Text"].ToString();
        //        if ("Calc".Equals(strFormName))
        //        {
        //            subMenu.Tag = "Calc";
        //            subMenu.Click += new EventHandler(OtherTools_Click);
        //        }
        //        else if ("Notepad".Equals(strFormName))
        //        {
        //            subMenu.Tag = "Notepad";
        //            subMenu.Click += new EventHandler(OtherTools_Click);
        //        }
        //        else if ("MsPaint".Equals(strFormName))
        //        {
        //            subMenu.Tag = "MsPaint";
        //            subMenu.Click += new EventHandler(OtherTools_Click);
        //        }
        //        else if ("DBBack".Equals(strFormName))
        //        {
        //            subMenu.Tag = "DBBack";
        //            subMenu.Click += new EventHandler(OtherTools_Click);
        //        }
        //        else
        //        {
        //            if (strFormName != "")
        //            {
        //                //扩展属性可以加任何想要的值。这里用formName属性来加载窗体。                   
        //                //验证此操作员是否具有此菜单的操作权限
        //                if (new Privilege().Validate(Parameter.CurrentUser.UserId, strFormName))
        //                {
        //                    //给没有子菜单的菜单项加事件。
        //                    subMenu.Tag = strFormName;
        //                    subMenu.Text = strText;
        //                    subMenu.Click += new EventHandler(subMenu_Click);
        //                }
        //                else
        //                {
        //                    subMenu.Enabled = false;
        //                }
        //            }
        //        }
        //        //将菜单加到顶层菜单下。
        //        topMenu.DropDownItems.Add(subMenu);
        //    }
        //}
        //#endregion

        ///// <summary>
        ///// 菜单单击事件
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //void subMenu_Click(object sender, EventArgs e)
        //{
        //    //tag属性在这里有用到。       
        //    ToolStripMenuItem tim = (ToolStripMenuItem)sender;
        //    Type t = Type.GetType(tim.Tag.ToString());
        //    Form frmCurrent = (Form)System.Activator.CreateInstance(t);
        //    frmCurrent.StartPosition = FormStartPosition.CenterScreen;
        //    frmCurrent.Size = new Size(new Point(800, 600));
        //    frmCurrent.Show();

        //}
        ////其它工具菜单事件的注册方法
        //private void OtherTools_Click(object sender, EventArgs e)
        //{
        //    switch (((ToolStripMenuItem)(sender)).Tag.ToString())
        //    {
        //        case "Calc":   //计算器
        //            {
        //                System.Diagnostics.Process.Start("Calc.exe");
        //                break;
        //            }
        //        case "Notepad": //记事本
        //            {
        //                System.Diagnostics.Process.Start("Notepad.exe");
        //                break;
        //            }
        //        case "MsPaint": //画图
        //            {
        //                System.Diagnostics.Process.Start("MsPaint.exe");
        //                break;
        //            }
        //        case "DBBack"://数据库同步
        //            {
        //                //备份
        //                string FileBackupPath = AppSettings.GetValue("BackupPath");
        //                if (File.Exists(FileBackupPath+"back.bak"))
        //                {
        //                    File.Delete(FileBackupPath+"back.bak");
        //                }
        //                DataBaseControl DBC = new DataBaseControl();
        //                DBC.ConnectionString = AppSettings.GetValue("ConnectionString");
        //                DBC.DataBaseName = "CHMS";
        //                DBC.DataBaseOfBackupName = "back.bak";
        //                DBC.DataBaseOfBackupPath = FileBackupPath;
        //                if (DBC.BackupDataBase())
        //                {

        //                    DBC = new DataBaseControl();
        //                    DBC.ConnectionString = AppSettings.GetValue("ConnectionString");
        //                    DBC.DataBaseName = "CHMST";
        //                    DBC.DataBaseOfBackupName = "back.bak";
        //                    DBC.DataBaseOfBackupPath = FileBackupPath;
        //                    if (DBC.ReplaceDataBase())
        //                    {
        //                        MessageBox.Show("数据库同步成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
        //                    }
        //                    else
        //                    {
        //                        MessageBox.Show("数据库同步失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
        //                    }
        //                }
        //                else
        //                {
        //                    MessageBox.Show("数据库连接备份失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
        //                }
        //                break;
        //            }
        //    }
        //}
        ///// <summary>
        ///// 退出菜单单击事件
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //void topMenu_Click(object sender, EventArgs e)
        //{
        //    if (MessageBox.Show("您确实要退出系统吗？", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
        //    {
        //        this.Dispose();
        //        Application.Exit();
        //        Process.GetCurrentProcess().Dispose();
        //        Process.GetCurrentProcess().Kill();
        //        GC.Collect();

        //    }
        //}
        //#endregion

        //#region LeftMenu
        //private void CreateLeftMenu()
        //{
        //    if (!File.Exists(Application.StartupPath + @"\Menu.xml"))
        //    {
        //        MessageBox.Show("配置文件不存在");
        //        return;
        //    }
        //    DataSet ds = new DataSet();
        //    ds.ReadXml(Application.StartupPath + @"\Menu.xml");
        //    DataView dv = ds.Tables[0].DefaultView;
        //    //通过DataView来过滤数据首先得到最顶层的菜单
        //    dv.RowFilter = "ParentItemID=0";
        //    for (int i = 0; i < dv.Count; i++)
        //    {
        //        string strItemID = dv[i]["ItemID"].ToString();
        //        if (strItemID == "101" || strItemID == "102" || strItemID == "103")
        //        {
        //            XPExplorerBar.Expando leftMenu = new XPExplorerBar.Expando();
        //            leftMenu.Size = new System.Drawing.Size(140, 28);
        //            leftMenu.ExpandedHeight = 28;
        //            leftMenu.Text = dv[i]["Text"].ToString();
        //            //如果是有下级菜单则通过CreateSubMenu方法来创建下级菜单
        //            if (Convert.ToInt16(dv[i]["IsModule"]) == 1)
        //            {
        //                //以ref的方式将顶层菜单传递参数，因为他可以在赋值后再回传。－－也许还有更好的方法^_^.
        //                CreateLeftSubMenu(ref leftMenu, Convert.ToInt32(dv[i]["ItemID"]), ds.Tables[0]);
        //            }
        //            tkpMenu.Controls.Add(leftMenu);
        //        }
        //    }
        //}
        //private void CreateLeftSubMenu(ref XPExplorerBar.Expando leftMenu, int ItemID, DataTable dt)
        //{
        //    DataView dv = new DataView(dt);
        //    //过滤出当前父菜单下在所有子菜单数据(仅为下一层的)
        //    dv.RowFilter = "ParentItemID=" + ItemID.ToString();
        //    leftMenu.Height += dv.Count * 20;
        //    leftMenu.ExpandedHeight += dv.Count * 20;
        //    for (int i = 0; i < dv.Count; i++)
        //    {
        //        string strFormName = dv[i]["FormName"].ToString();
        //        string strText = dv[i]["Text"].ToString();
        //        XPExplorerBar.TaskItem tsm = new XPExplorerBar.TaskItem();
        //        tsm.Size = new System.Drawing.Size(140, 15);
        //        tsm.Location = new System.Drawing.Point(3, i == 0 ? 28 : i * 20 + 28);
        //        tsm.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
        //        tsm.Text = strText;
        //        tsm.TextAlign = ContentAlignment.MiddleCenter;
        //        if (strFormName != "")
        //        {
        //            ////扩展属性可以加任何想要的值。这里用formName属性来加载窗体。                 
        //            ////验证此操作员是否具有此菜单的操作权限
        //            if (new Privilege().Validate(Parameter.CurrentUser.UserId, strFormName))
        //            {
        //                tsm.Tag = strFormName;
        //                tsm.Text = strText;
        //                //给没有子菜单的菜单项加事件。
        //                tsm.Click += new EventHandler(LeftMenu_Click);
        //            }
        //            else
        //            {
        //                tsm.Enabled = false;
        //            }
        //        }
        //        leftMenu.Items.Add(tsm);
        //    }
        //}
        //void LeftMenu_Click(object sender, EventArgs e)
        //{
        //    //tag属性在这里有用到。       
        //    XPExplorerBar.TaskItem tsm = (XPExplorerBar.TaskItem)sender;
        //    Type t = Type.GetType(tsm.Tag.ToString());
        //    Form frmCurrent = (Form)System.Activator.CreateInstance(t);
        //    frmCurrent.Text = tsm.Text;
        //    frmCurrent.StartPosition = FormStartPosition.CenterScreen;
        //    frmCurrent.Size = new Size(new Point(800, 600));
        //    frmCurrent.Show();
        //}
        //#endregion


        private void frmMain_Load(object sender, EventArgs e)
        {
            this.tssCurrentName.Text = "当前用户|" + Parameter.CurrentUser.UserName;
            timCurrent.Start();
            //
            DateTime endTime = DateTime.Parse(Framework.AppSettings.GetValue("Task"));
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
            //
            //Rectangle rect = new Rectangle();
            //rect = Screen.GetWorkingArea(this);
            //this.Width = rect.Width;
            //this.Height = rect.Height;
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
                        axCZKEM1.EnableDevice(iMachineNumber, false);//disable the device    
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
                                BLLAttLog.AddAttLog(UserID, VerifyMode, InOutMode, AttDate, WorkCode, Reserved);
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
        private void 下载人事ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objFrmDownloadUser == null)
            {
                objFrmDownloadUser = new FrmDownloadUser();
                objFrmDownloadUser.Show();
            }
            else
            {
                objFrmDownloadUser.Activate();//激活只能在最小化的时候起作用
                objFrmDownloadUser.WindowState = FormWindowState.Normal;
            }
        }

        //上传员工信息
        public static FrmUpload objFrmUpload = null;
        private void 上传人事ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objFrmUpload == null)
            {
                objFrmUpload = new FrmUpload();
                objFrmUpload.Show();
            }
            else
            {
                objFrmUpload.Activate();//激活只能在最小化的时候起作用
                objFrmUpload.WindowState = FormWindowState.Normal;
            }
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