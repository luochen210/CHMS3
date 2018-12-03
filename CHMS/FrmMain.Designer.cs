namespace CHMS
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmsCHMS = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssCurrentName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssCurrentTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslUserInfo = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timCurrent = new System.Windows.Forms.Timer(this.components);
            this.设备管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下载考勤ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下载员工信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上传员工信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设备参数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.人事管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.员工设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.员工档案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.员工通讯录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.部门信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.公司信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.考勤管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.时段设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.班次设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.人员排班ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.排班查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.假期设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.法定假日ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.原始考勤ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.考勤异常ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.请假登记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.请假统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.考勤日报ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.考勤月报ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.常用工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计算器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.记事本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.画图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据同步ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsCHMS.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmsCHMS
            // 
            this.tmsCHMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设备管理ToolStripMenuItem,
            this.人事管理ToolStripMenuItem,
            this.考勤管理ToolStripMenuItem,
            this.常用工具ToolStripMenuItem,
            this.退出系统ToolStripMenuItem});
            this.tmsCHMS.Location = new System.Drawing.Point(0, 0);
            this.tmsCHMS.Name = "tmsCHMS";
            this.tmsCHMS.Size = new System.Drawing.Size(1016, 25);
            this.tmsCHMS.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tssCurrentName,
            this.tssCurrentTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 708);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1016, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(333, 21);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "欢迎使用人事管理系统";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tssCurrentName
            // 
            this.tssCurrentName.Name = "tssCurrentName";
            this.tssCurrentName.Size = new System.Drawing.Size(333, 21);
            this.tssCurrentName.Spring = true;
            this.tssCurrentName.Text = "当前用户|Null";
            // 
            // tssCurrentTime
            // 
            this.tssCurrentTime.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tssCurrentTime.Name = "tssCurrentTime";
            this.tssCurrentTime.Size = new System.Drawing.Size(333, 21);
            this.tssCurrentTime.Spring = true;
            this.tssCurrentTime.Text = "当前时间|2010-10-10 20:57";
            this.tssCurrentTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslUserInfo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1016, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tslUserInfo
            // 
            this.tslUserInfo.Image = global::CHMS.Properties.Resources._01;
            this.tslUserInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tslUserInfo.Name = "tslUserInfo";
            this.tslUserInfo.Size = new System.Drawing.Size(100, 22);
            this.tslUserInfo.Text = "人事档案浏览";
            this.tslUserInfo.Click += new System.EventHandler(this.tslUserInfo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 658);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::CHMS.Properties.Resources.主界面_;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(140, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(876, 658);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 658);
            this.panel2.TabIndex = 0;
            // 
            // timCurrent
            // 
            this.timCurrent.Interval = 1000;
            this.timCurrent.Tick += new System.EventHandler(this.timCurrent_Tick);
            // 
            // 设备管理ToolStripMenuItem
            // 
            this.设备管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设备参数ToolStripMenuItem,
            this.toolStripSeparator1,
            this.下载考勤ToolStripMenuItem,
            this.toolStripSeparator2,
            this.下载员工信息ToolStripMenuItem,
            this.上传员工信息ToolStripMenuItem});
            this.设备管理ToolStripMenuItem.Name = "设备管理ToolStripMenuItem";
            this.设备管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.设备管理ToolStripMenuItem.Text = "设备管理";
            // 
            // 下载考勤ToolStripMenuItem
            // 
            this.下载考勤ToolStripMenuItem.Name = "下载考勤ToolStripMenuItem";
            this.下载考勤ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.下载考勤ToolStripMenuItem.Text = "下载考勤";
            // 
            // 下载员工信息ToolStripMenuItem
            // 
            this.下载员工信息ToolStripMenuItem.Name = "下载员工信息ToolStripMenuItem";
            this.下载员工信息ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.下载员工信息ToolStripMenuItem.Text = "下载员工信息";
            // 
            // 上传员工信息ToolStripMenuItem
            // 
            this.上传员工信息ToolStripMenuItem.Name = "上传员工信息ToolStripMenuItem";
            this.上传员工信息ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.上传员工信息ToolStripMenuItem.Text = "上传员工信息";
            // 
            // 设备参数ToolStripMenuItem
            // 
            this.设备参数ToolStripMenuItem.Name = "设备参数ToolStripMenuItem";
            this.设备参数ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.设备参数ToolStripMenuItem.Text = "设备参数";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // 人事管理ToolStripMenuItem
            // 
            this.人事管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.员工设置ToolStripMenuItem,
            this.toolStripSeparator3,
            this.员工档案ToolStripMenuItem,
            this.员工通讯录ToolStripMenuItem,
            this.toolStripSeparator4,
            this.部门信息ToolStripMenuItem,
            this.公司信息ToolStripMenuItem});
            this.人事管理ToolStripMenuItem.Name = "人事管理ToolStripMenuItem";
            this.人事管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.人事管理ToolStripMenuItem.Text = "人事管理";
            // 
            // 员工设置ToolStripMenuItem
            // 
            this.员工设置ToolStripMenuItem.Name = "员工设置ToolStripMenuItem";
            this.员工设置ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.员工设置ToolStripMenuItem.Text = "员工设置";
            // 
            // 员工档案ToolStripMenuItem
            // 
            this.员工档案ToolStripMenuItem.Name = "员工档案ToolStripMenuItem";
            this.员工档案ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.员工档案ToolStripMenuItem.Text = "员工档案";
            // 
            // 员工通讯录ToolStripMenuItem
            // 
            this.员工通讯录ToolStripMenuItem.Name = "员工通讯录ToolStripMenuItem";
            this.员工通讯录ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.员工通讯录ToolStripMenuItem.Text = "员工通讯录";
            // 
            // 部门信息ToolStripMenuItem
            // 
            this.部门信息ToolStripMenuItem.Name = "部门信息ToolStripMenuItem";
            this.部门信息ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.部门信息ToolStripMenuItem.Text = "部门信息";
            // 
            // 公司信息ToolStripMenuItem
            // 
            this.公司信息ToolStripMenuItem.Name = "公司信息ToolStripMenuItem";
            this.公司信息ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.公司信息ToolStripMenuItem.Text = "公司信息";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(149, 6);
            // 
            // 考勤管理ToolStripMenuItem
            // 
            this.考勤管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.原始考勤ToolStripMenuItem,
            this.考勤异常ToolStripMenuItem,
            this.toolStripSeparator8,
            this.请假登记ToolStripMenuItem,
            this.请假统计ToolStripMenuItem,
            this.toolStripSeparator5,
            this.考勤日报ToolStripMenuItem,
            this.考勤月报ToolStripMenuItem,
            this.toolStripSeparator7,
            this.假期设置ToolStripMenuItem,
            this.法定假日ToolStripMenuItem,
            this.toolStripSeparator6,
            this.人员排班ToolStripMenuItem,
            this.排班查询ToolStripMenuItem,
            this.toolStripSeparator9,
            this.时段设置ToolStripMenuItem,
            this.班次设置ToolStripMenuItem});
            this.考勤管理ToolStripMenuItem.Name = "考勤管理ToolStripMenuItem";
            this.考勤管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.考勤管理ToolStripMenuItem.Text = "考勤管理";
            // 
            // 时段设置ToolStripMenuItem
            // 
            this.时段设置ToolStripMenuItem.Name = "时段设置ToolStripMenuItem";
            this.时段设置ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.时段设置ToolStripMenuItem.Text = "时段设置";
            // 
            // 班次设置ToolStripMenuItem
            // 
            this.班次设置ToolStripMenuItem.Name = "班次设置ToolStripMenuItem";
            this.班次设置ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.班次设置ToolStripMenuItem.Text = "班次设置";
            // 
            // 人员排班ToolStripMenuItem
            // 
            this.人员排班ToolStripMenuItem.Name = "人员排班ToolStripMenuItem";
            this.人员排班ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.人员排班ToolStripMenuItem.Text = "人员排班";
            // 
            // 排班查询ToolStripMenuItem
            // 
            this.排班查询ToolStripMenuItem.Name = "排班查询ToolStripMenuItem";
            this.排班查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.排班查询ToolStripMenuItem.Text = "排班查询";
            // 
            // 假期设置ToolStripMenuItem
            // 
            this.假期设置ToolStripMenuItem.Name = "假期设置ToolStripMenuItem";
            this.假期设置ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.假期设置ToolStripMenuItem.Text = "假期设置";
            // 
            // 法定假日ToolStripMenuItem
            // 
            this.法定假日ToolStripMenuItem.Name = "法定假日ToolStripMenuItem";
            this.法定假日ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.法定假日ToolStripMenuItem.Text = "法定假日";
            // 
            // 原始考勤ToolStripMenuItem
            // 
            this.原始考勤ToolStripMenuItem.Name = "原始考勤ToolStripMenuItem";
            this.原始考勤ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.原始考勤ToolStripMenuItem.Text = "原始考勤";
            // 
            // 考勤异常ToolStripMenuItem
            // 
            this.考勤异常ToolStripMenuItem.Name = "考勤异常ToolStripMenuItem";
            this.考勤异常ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.考勤异常ToolStripMenuItem.Text = "考勤异常";
            // 
            // 请假登记ToolStripMenuItem
            // 
            this.请假登记ToolStripMenuItem.Name = "请假登记ToolStripMenuItem";
            this.请假登记ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.请假登记ToolStripMenuItem.Text = "请假登记";
            // 
            // 请假统计ToolStripMenuItem
            // 
            this.请假统计ToolStripMenuItem.Name = "请假统计ToolStripMenuItem";
            this.请假统计ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.请假统计ToolStripMenuItem.Text = "请假统计";
            // 
            // 考勤日报ToolStripMenuItem
            // 
            this.考勤日报ToolStripMenuItem.Name = "考勤日报ToolStripMenuItem";
            this.考勤日报ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.考勤日报ToolStripMenuItem.Text = "考勤日报";
            // 
            // 考勤月报ToolStripMenuItem
            // 
            this.考勤月报ToolStripMenuItem.Name = "考勤月报ToolStripMenuItem";
            this.考勤月报ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.考勤月报ToolStripMenuItem.Text = "考勤月报";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(149, 6);
            // 
            // 常用工具ToolStripMenuItem
            // 
            this.常用工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.计算器ToolStripMenuItem,
            this.记事本ToolStripMenuItem,
            this.画图ToolStripMenuItem,
            this.数据同步ToolStripMenuItem});
            this.常用工具ToolStripMenuItem.Name = "常用工具ToolStripMenuItem";
            this.常用工具ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.常用工具ToolStripMenuItem.Text = "常用工具";
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.退出系统ToolStripMenuItem.Text = "退出系统";
            // 
            // 计算器ToolStripMenuItem
            // 
            this.计算器ToolStripMenuItem.Name = "计算器ToolStripMenuItem";
            this.计算器ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.计算器ToolStripMenuItem.Text = "计算器";
            // 
            // 记事本ToolStripMenuItem
            // 
            this.记事本ToolStripMenuItem.Name = "记事本ToolStripMenuItem";
            this.记事本ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.记事本ToolStripMenuItem.Text = "记事本";
            // 
            // 画图ToolStripMenuItem
            // 
            this.画图ToolStripMenuItem.Name = "画图ToolStripMenuItem";
            this.画图ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.画图ToolStripMenuItem.Text = "画图";
            // 
            // 数据同步ToolStripMenuItem
            // 
            this.数据同步ToolStripMenuItem.Name = "数据同步ToolStripMenuItem";
            this.数据同步ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.数据同步ToolStripMenuItem.Text = "数据同步";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 734);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tmsCHMS);
            this.MainMenuStrip = this.tmsCHMS;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "人事考勤管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tmsCHMS.ResumeLayout(false);
            this.tmsCHMS.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip tmsCHMS;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssCurrentName;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripStatusLabel tssCurrentTime;
        private System.Windows.Forms.Timer timCurrent;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripButton tslUserInfo;
        private System.Windows.Forms.ToolStripMenuItem 设备管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设备参数ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 下载考勤ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 下载员工信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上传员工信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 人事管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 员工设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 员工档案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 员工通讯录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem 部门信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 公司信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 考勤管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 原始考勤ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 考勤异常ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem 请假登记ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 请假统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem 考勤日报ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 考勤月报ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem 假期设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 法定假日ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem 人员排班ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 排班查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem 时段设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 班次设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 常用工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 计算器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 记事本ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 画图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据同步ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
    }
}

