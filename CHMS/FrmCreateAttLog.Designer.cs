namespace CHMS
{
    partial class FrmCreateAttLog
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnColse = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNotAll = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRange = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtEndDateTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtStartDateTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tvUserInfo = new System.Windows.Forms.TreeView();
            this.fastSelect1 = new CHMS.FastSelect(this.components);
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnColse);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.btnNotAll);
            this.panel3.Controls.Add(this.btnAll);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(585, 57);
            this.panel3.TabIndex = 1;
            // 
            // btnColse
            // 
            this.btnColse.BackColor = System.Drawing.Color.IndianRed;
            this.btnColse.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnColse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnColse.Location = new System.Drawing.Point(321, 0);
            this.btnColse.Name = "btnColse";
            this.fastSelect1.SetSelectionSource(this.btnColse, null);
            this.btnColse.Size = new System.Drawing.Size(107, 57);
            this.btnColse.TabIndex = 7;
            this.btnColse.Text = "关闭";
            this.btnColse.UseVisualStyleBackColor = false;
            this.btnColse.Click += new System.EventHandler(this.btnColse_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSave.Location = new System.Drawing.Point(214, 0);
            this.btnSave.Name = "btnSave";
            this.fastSelect1.SetSelectionSource(this.btnSave, null);
            this.btnSave.Size = new System.Drawing.Size(107, 57);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "生成考勤数据";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNotAll
            // 
            this.btnNotAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNotAll.Location = new System.Drawing.Point(107, 0);
            this.btnNotAll.Name = "btnNotAll";
            this.fastSelect1.SetSelectionSource(this.btnNotAll, this.tvUserInfo);
            this.fastSelect1.SetSelectionType(this.btnNotAll, CHMS.SelectionType.反选);
            this.btnNotAll.Size = new System.Drawing.Size(107, 57);
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
            this.btnAll.Size = new System.Drawing.Size(107, 57);
            this.btnAll.TabIndex = 4;
            this.btnAll.Text = "全选";
            this.btnAll.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtRange);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtEndDateTime);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtStartDateTime);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(289, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 446);
            this.panel1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(29, 172);
            this.label5.Name = "label5";
            this.fastSelect1.SetSelectionSource(this.label5, null);
            this.label5.Size = new System.Drawing.Size(215, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "请谨慎操作,该操作将删除真实考勤记录";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(56, 143);
            this.label4.Name = "label4";
            this.fastSelect1.SetSelectionSource(this.label4, null);
            this.label4.Size = new System.Drawing.Size(173, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "范围值表示生成模拟考勤偏移值";
            // 
            // txtRange
            // 
            this.txtRange.Location = new System.Drawing.Point(82, 99);
            this.txtRange.Name = "txtRange";
            this.txtRange.Size = new System.Drawing.Size(133, 21);
            this.txtRange.TabIndex = 5;
            this.txtRange.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 102);
            this.label3.Name = "label3";
            this.fastSelect1.SetSelectionSource(this.label3, null);
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "范围值：";
            // 
            // dtEndDateTime
            // 
            this.dtEndDateTime.Location = new System.Drawing.Point(82, 57);
            this.dtEndDateTime.Name = "dtEndDateTime";
            this.dtEndDateTime.Size = new System.Drawing.Size(135, 21);
            this.dtEndDateTime.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.fastSelect1.SetSelectionSource(this.label2, null);
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "开始日期：";
            // 
            // dtStartDateTime
            // 
            this.dtStartDateTime.Location = new System.Drawing.Point(82, 19);
            this.dtStartDateTime.Name = "dtStartDateTime";
            this.dtStartDateTime.Size = new System.Drawing.Size(135, 21);
            this.dtStartDateTime.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.fastSelect1.SetSelectionSource(this.label1, null);
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "开始日期：";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tvUserInfo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 57);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(289, 446);
            this.panel4.TabIndex = 7;
            // 
            // tvUserInfo
            // 
            this.tvUserInfo.CheckBoxes = true;
            this.tvUserInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvUserInfo.Location = new System.Drawing.Point(0, 0);
            this.tvUserInfo.Name = "tvUserInfo";
            this.tvUserInfo.Size = new System.Drawing.Size(289, 446);
            this.tvUserInfo.TabIndex = 2;
            // 
            // frmCreateAttLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 503);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "frmCreateAttLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "生成模拟考勤数据";
            this.Load += new System.EventHandler(this.frmCreateAttLog_Load);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtEndDateTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtStartDateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnColse;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNotAll;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.TreeView tvUserInfo;
        private FastSelect fastSelect1;
    }
}