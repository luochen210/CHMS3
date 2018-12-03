namespace CHMS
{
    partial class FrmCheckAttLog
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtEndDateTime = new System.Windows.Forms.DateTimePicker();
            this.dtStartDateTime = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tvUserInfo = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnColse = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNotAll = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.fastSelect1 = new CHMS.FastSelect(this.components);
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel3.Size = new System.Drawing.Size(542, 57);
            this.panel3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtEndDateTime);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtStartDateTime);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(297, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 372);
            this.panel1.TabIndex = 3;
            // 
            // dtEndDateTime
            // 
            this.dtEndDateTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtEndDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEndDateTime.Location = new System.Drawing.Point(84, 44);
            this.dtEndDateTime.Name = "dtEndDateTime";
            this.dtEndDateTime.ShowUpDown = true;
            this.dtEndDateTime.Size = new System.Drawing.Size(149, 21);
            this.dtEndDateTime.TabIndex = 7;
            // 
            // dtStartDateTime
            // 
            this.dtStartDateTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtStartDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartDateTime.Location = new System.Drawing.Point(84, 6);
            this.dtStartDateTime.Name = "dtStartDateTime";
            this.dtStartDateTime.ShowUpDown = true;
            this.dtStartDateTime.Size = new System.Drawing.Size(149, 21);
            this.dtStartDateTime.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tvUserInfo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 372);
            this.panel2.TabIndex = 4;
            // 
            // tvUserInfo
            // 
            this.tvUserInfo.CheckBoxes = true;
            this.tvUserInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvUserInfo.Location = new System.Drawing.Point(0, 0);
            this.tvUserInfo.Name = "tvUserInfo";
            this.tvUserInfo.Size = new System.Drawing.Size(297, 372);
            this.tvUserInfo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 48);
            this.label2.Name = "label2";
            this.fastSelect1.SetSelectionSource(this.label2, null);
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "开始日期：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.fastSelect1.SetSelectionSource(this.label1, null);
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "开始日期：";
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
            this.btnSave.Text = "修正考勤数据";
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
            // frmCheckAttLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 429);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "frmCheckAttLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCheckAttLog";
            this.Load += new System.EventHandler(this.frmCheckAttLog_Load);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnColse;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNotAll;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView tvUserInfo;
        private System.Windows.Forms.DateTimePicker dtEndDateTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtStartDateTime;
        private System.Windows.Forms.Label label1;
        private FastSelect fastSelect1;
    }
}