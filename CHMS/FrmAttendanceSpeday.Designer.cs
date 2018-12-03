namespace CHMS
{
    partial class FrmAttendanceSpeday
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnColse = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbLeaveClass = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtApproveDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtApprover = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tvUserInfo = new System.Windows.Forms.TreeView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnColse);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 55);
            this.panel1.TabIndex = 2;
            // 
            // btnColse
            // 
            this.btnColse.BackColor = System.Drawing.Color.IndianRed;
            this.btnColse.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnColse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnColse.Location = new System.Drawing.Point(107, 0);
            this.btnColse.Name = "btnColse";
            this.btnColse.Size = new System.Drawing.Size(107, 55);
            this.btnColse.TabIndex = 6;
            this.btnColse.Text = "关闭";
            this.btnColse.UseVisualStyleBackColor = false;
            this.btnColse.Click += new System.EventHandler(this.btnColse_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSave.Location = new System.Drawing.Point(0, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 55);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(690, 421);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbLeaveClass);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtRemark);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.dtApproveDate);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtApprover);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.dtEndDate);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.dtStartDate);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtUserName);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtUserid);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(288, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(402, 421);
            this.panel3.TabIndex = 2;
            // 
            // cbLeaveClass
            // 
            this.cbLeaveClass.FormattingEnabled = true;
            this.cbLeaveClass.Location = new System.Drawing.Point(83, 138);
            this.cbLeaveClass.Name = "cbLeaveClass";
            this.cbLeaveClass.Size = new System.Drawing.Size(109, 20);
            this.cbLeaveClass.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 34;
            this.label8.Text = "所属假期：";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(83, 186);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(306, 182);
            this.txtRemark.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 32;
            this.label7.Text = "请假描述：";
            // 
            // dtApproveDate
            // 
            this.dtApproveDate.Location = new System.Drawing.Point(269, 95);
            this.dtApproveDate.Name = "dtApproveDate";
            this.dtApproveDate.Size = new System.Drawing.Size(121, 21);
            this.dtApproveDate.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 30;
            this.label6.Text = "批准日期：";
            // 
            // txtApprover
            // 
            this.txtApprover.Location = new System.Drawing.Point(83, 96);
            this.txtApprover.Name = "txtApprover";
            this.txtApprover.Size = new System.Drawing.Size(109, 21);
            this.txtApprover.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 28;
            this.label5.Text = "批准人：";
            // 
            // dtEndDate
            // 
            this.dtEndDate.Location = new System.Drawing.Point(269, 53);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(121, 21);
            this.dtEndDate.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 26;
            this.label3.Text = "开始日期：";
            // 
            // dtStartDate
            // 
            this.dtStartDate.Location = new System.Drawing.Point(83, 53);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(109, 21);
            this.dtStartDate.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 24;
            this.label4.Text = "开始日期：";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(269, 12);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(120, 21);
            this.txtUserName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "姓名：";
            // 
            // txtUserid
            // 
            this.txtUserid.Location = new System.Drawing.Point(83, 9);
            this.txtUserid.Name = "txtUserid";
            this.txtUserid.Size = new System.Drawing.Size(109, 21);
            this.txtUserid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "工号：";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tvUserInfo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(288, 421);
            this.panel4.TabIndex = 1;
            // 
            // tvUserInfo
            // 
            this.tvUserInfo.CheckBoxes = true;
            this.tvUserInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvUserInfo.Location = new System.Drawing.Point(0, 0);
            this.tvUserInfo.Name = "tvUserInfo";
            this.tvUserInfo.Size = new System.Drawing.Size(288, 421);
            this.tvUserInfo.TabIndex = 4;
            this.tvUserInfo.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvUserInfo_AfterSelect);
            // 
            // frmAttendanceSpeday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 476);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmAttendanceSpeday";
            this.Text = "frmAttendanceSpeday";
            this.Load += new System.EventHandler(this.frmAttendanceSpeday_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnColse;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtApproveDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtApprover;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TreeView tvUserInfo;
        private System.Windows.Forms.ComboBox cbLeaveClass;
        private System.Windows.Forms.Label label8;
    }
}