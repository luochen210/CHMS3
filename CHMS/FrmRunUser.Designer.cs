namespace CHMS
{
    partial class FrmRunUser
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkSunday = new System.Windows.Forms.CheckBox();
            this.chkSaturday = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbRun = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tvUserInfo = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnColse = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNotAll = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.fastSelect1 = new CHMS.FastSelect(this.components);
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chkSunday);
            this.panel2.Controls.Add(this.chkSaturday);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cbRun);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dtEndDate);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dtStartDate);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(543, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 455);
            this.panel2.TabIndex = 4;
            // 
            // chkSunday
            // 
            this.chkSunday.AutoSize = true;
            this.chkSunday.Location = new System.Drawing.Point(74, 156);
            this.chkSunday.Name = "chkSunday";
            this.chkSunday.Size = new System.Drawing.Size(48, 16);
            this.chkSunday.TabIndex = 8;
            this.chkSunday.Text = "周日";
            this.chkSunday.UseVisualStyleBackColor = true;
            // 
            // chkSaturday
            // 
            this.chkSaturday.AutoSize = true;
            this.chkSaturday.Location = new System.Drawing.Point(74, 122);
            this.chkSaturday.Name = "chkSaturday";
            this.chkSaturday.Size = new System.Drawing.Size(48, 16);
            this.chkSaturday.TabIndex = 7;
            this.chkSaturday.Text = "周六";
            this.chkSaturday.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 124);
            this.label4.Name = "label4";
            this.fastSelect1.SetSelectionSource(this.label4, null);
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "双休选择：";
            // 
            // cbRun
            // 
            this.cbRun.FormattingEnabled = true;
            this.cbRun.Location = new System.Drawing.Point(74, 84);
            this.cbRun.Name = "cbRun";
            this.cbRun.Size = new System.Drawing.Size(130, 20);
            this.cbRun.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Name = "label3";
            this.fastSelect1.SetSelectionSource(this.label3, null);
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "所属班次：";
            // 
            // dtEndDate
            // 
            this.dtEndDate.Location = new System.Drawing.Point(74, 45);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(130, 21);
            this.dtEndDate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.fastSelect1.SetSelectionSource(this.label2, null);
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "开始日期：";
            // 
            // dtStartDate
            // 
            this.dtStartDate.Location = new System.Drawing.Point(74, 6);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(130, 21);
            this.dtStartDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.fastSelect1.SetSelectionSource(this.label1, null);
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "开始日期：";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tvUserInfo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(543, 455);
            this.panel3.TabIndex = 5;
            // 
            // tvUserInfo
            // 
            this.tvUserInfo.CheckBoxes = true;
            this.tvUserInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvUserInfo.Location = new System.Drawing.Point(0, 0);
            this.tvUserInfo.Name = "tvUserInfo";
            this.tvUserInfo.Size = new System.Drawing.Size(543, 455);
            this.tvUserInfo.TabIndex = 1;
            this.tvUserInfo.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvUserInfo_AfterCheck);
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
            this.panel1.Size = new System.Drawing.Size(767, 54);
            this.panel1.TabIndex = 3;
            // 
            // btnColse
            // 
            this.btnColse.BackColor = System.Drawing.Color.IndianRed;
            this.btnColse.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnColse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnColse.Location = new System.Drawing.Point(285, 0);
            this.btnColse.Name = "btnColse";
            this.fastSelect1.SetSelectionSource(this.btnColse, null);
            this.btnColse.Size = new System.Drawing.Size(95, 54);
            this.btnColse.TabIndex = 57;
            this.btnColse.Text = "关闭";
            this.btnColse.UseVisualStyleBackColor = false;
            this.btnColse.Click += new System.EventHandler(this.btnColse_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSave.Location = new System.Drawing.Point(190, 0);
            this.btnSave.Name = "btnSave";
            this.fastSelect1.SetSelectionSource(this.btnSave, null);
            this.btnSave.Size = new System.Drawing.Size(95, 54);
            this.btnSave.TabIndex = 56;
            this.btnSave.Text = "排班";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNotAll
            // 
            this.btnNotAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNotAll.Location = new System.Drawing.Point(95, 0);
            this.btnNotAll.Name = "btnNotAll";
            this.fastSelect1.SetSelectionSource(this.btnNotAll, this.tvUserInfo);
            this.fastSelect1.SetSelectionType(this.btnNotAll, CHMS.SelectionType.反选);
            this.btnNotAll.Size = new System.Drawing.Size(95, 54);
            this.btnNotAll.TabIndex = 55;
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
            this.btnAll.Size = new System.Drawing.Size(95, 54);
            this.btnAll.TabIndex = 54;
            this.btnAll.Text = "全选";
            this.btnAll.UseVisualStyleBackColor = true;
            // 
            // frmRunUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 509);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmRunUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "日历排班";
            this.Load += new System.EventHandler(this.frmRunUser_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkSunday;
        private System.Windows.Forms.CheckBox chkSaturday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbRun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView tvUserInfo;
        private System.Windows.Forms.Button btnNotAll;
        private FastSelect fastSelect1;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnColse;
        private System.Windows.Forms.Button btnSave;
    }
}