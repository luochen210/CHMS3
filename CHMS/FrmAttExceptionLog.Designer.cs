namespace CHMS
{
    partial class FrmAttExceptionLog
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnColse = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNotAll = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtRange = new System.Windows.Forms.TextBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEndTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tvUserInfo = new System.Windows.Forms.TreeView();
            this.fastSelect1 = new CHMS.FastSelect(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnColse);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnNotAll);
            this.panel1.Controls.Add(this.btnAll);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 55);
            this.panel1.TabIndex = 7;
            // 
            // btnColse
            // 
            this.btnColse.BackColor = System.Drawing.Color.IndianRed;
            this.btnColse.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnColse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnColse.Location = new System.Drawing.Point(300, 0);
            this.btnColse.Name = "btnColse";
            this.fastSelect1.SetSelectionSource(this.btnColse, null);
            this.btnColse.Size = new System.Drawing.Size(107, 55);
            this.btnColse.TabIndex = 7;
            this.btnColse.Text = "关闭";
            this.btnColse.UseVisualStyleBackColor = false;
            this.btnColse.Click += new System.EventHandler(this.btnColse_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSave.Location = new System.Drawing.Point(200, 0);
            this.btnSave.Name = "btnSave";
            this.fastSelect1.SetSelectionSource(this.btnSave, null);
            this.btnSave.Size = new System.Drawing.Size(100, 55);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "录入考勤";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNotAll
            // 
            this.btnNotAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNotAll.Location = new System.Drawing.Point(100, 0);
            this.btnNotAll.Name = "btnNotAll";
            this.fastSelect1.SetSelectionSource(this.btnNotAll, this.tvUserInfo);
            this.fastSelect1.SetSelectionType(this.btnNotAll, CHMS.SelectionType.反选);
            this.btnNotAll.Size = new System.Drawing.Size(100, 55);
            this.btnNotAll.TabIndex = 5;
            this.btnNotAll.Text = "反选";
            this.btnNotAll.UseVisualStyleBackColor = true;
            // 
            // btnAll
            // 
            this.btnAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAll.Location = new System.Drawing.Point(0, 0);
            this.btnAll.Name = "btnAll";
            this.fastSelect1.SetSelectionSource(this.btnAll, this.tvUserInfo);
            this.fastSelect1.SetSelectionType(this.btnAll, CHMS.SelectionType.全选);
            this.btnAll.Size = new System.Drawing.Size(100, 55);
            this.btnAll.TabIndex = 4;
            this.btnAll.Text = "全选";
            this.btnAll.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtRange);
            this.panel2.Controls.Add(this.txtRemark);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtStartTime);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtEndTime);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dtEndDate);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dtStartDate);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(301, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(439, 400);
            this.panel2.TabIndex = 8;
            // 
            // txtRange
            // 
            this.txtRange.Location = new System.Drawing.Point(82, 88);
            this.txtRange.Name = "txtRange";
            this.txtRange.Size = new System.Drawing.Size(130, 21);
            this.txtRange.TabIndex = 30;
            this.txtRange.Text = "10";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(82, 129);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(337, 228);
            this.txtRemark.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 129);
            this.label5.Name = "label5";
            this.fastSelect1.SetSelectionSource(this.label5, null);
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 28;
            this.label5.Text = "备注：";
            // 
            // txtStartTime
            // 
            this.txtStartTime.Location = new System.Drawing.Point(82, 47);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(130, 21);
            this.txtStartTime.TabIndex = 27;
            this.txtStartTime.Text = "08:00:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 50);
            this.label3.Name = "label3";
            this.fastSelect1.SetSelectionSource(this.label3, null);
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 26;
            this.label3.Text = "上班时间：";
            // 
            // txtEndTime
            // 
            this.txtEndTime.Location = new System.Drawing.Point(298, 50);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(130, 21);
            this.txtEndTime.TabIndex = 25;
            this.txtEndTime.Text = "18:00:00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 53);
            this.label4.Name = "label4";
            this.fastSelect1.SetSelectionSource(this.label4, null);
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 24;
            this.label4.Text = "下班时间：";
            // 
            // dtEndDate
            // 
            this.dtEndDate.Location = new System.Drawing.Point(298, 8);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(130, 21);
            this.dtEndDate.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 12);
            this.label2.Name = "label2";
            this.fastSelect1.SetSelectionSource(this.label2, null);
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 22;
            this.label2.Text = "开始日期：";
            // 
            // dtStartDate
            // 
            this.dtStartDate.Location = new System.Drawing.Point(82, 6);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(130, 21);
            this.dtStartDate.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.fastSelect1.SetSelectionSource(this.label1, null);
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "开始日期：";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tvUserInfo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(301, 400);
            this.panel3.TabIndex = 9;
            // 
            // tvUserInfo
            // 
            this.tvUserInfo.CheckBoxes = true;
            this.tvUserInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvUserInfo.Location = new System.Drawing.Point(0, 0);
            this.tvUserInfo.Name = "tvUserInfo";
            this.tvUserInfo.Size = new System.Drawing.Size(301, 400);
            this.tvUserInfo.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 91);
            this.label6.Name = "label6";
            this.fastSelect1.SetSelectionSource(this.label6, null);
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 31;
            this.label6.Text = "范围值：";
            // 
            // frmAttExceptionLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 455);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmAttExceptionLog";
            this.Text = "frmAttExceptionLog";
            this.Load += new System.EventHandler(this.frmAttExceptionLog_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnColse;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNotAll;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtRange;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEndTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView tvUserInfo;
        private FastSelect fastSelect1;
        private System.Windows.Forms.Label label6;
    }
}