namespace CHMS
{
    partial class FrmSchclass
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCheckOutTime2 = new System.Windows.Forms.TextBox();
            this.txtCheckOutTime1 = new System.Windows.Forms.TextBox();
            this.txtCheckInTime2 = new System.Windows.Forms.TextBox();
            this.txtCheckInTime1 = new System.Windows.Forms.TextBox();
            this.linkLabelColor = new System.Windows.Forms.LinkLabel();
            this.btnColor = new System.Windows.Forms.Button();
            this.chkCheckOut = new System.Windows.Forms.CheckBox();
            this.chkCheckIn = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAutoBind = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSchname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEndTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEarlyMinutes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLateMinutes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSchclassId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvSchclass = new System.Windows.Forms.DataGridView();
            this.Schclassid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Schname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Starttime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnColse = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchclass)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnColse);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 55);
            this.panel1.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 55);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtCheckOutTime2);
            this.panel2.Controls.Add(this.txtCheckOutTime1);
            this.panel2.Controls.Add(this.txtCheckInTime2);
            this.panel2.Controls.Add(this.txtCheckInTime1);
            this.panel2.Controls.Add(this.linkLabelColor);
            this.panel2.Controls.Add(this.btnColor);
            this.panel2.Controls.Add(this.chkCheckOut);
            this.panel2.Controls.Add(this.chkCheckIn);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtAutoBind);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.txtStartTime);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtSchname);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtEndTime);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtEarlyMinutes);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtLateMinutes);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtSchclassId);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(510, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 457);
            this.panel2.TabIndex = 2;
            // 
            // txtCheckOutTime2
            // 
            this.txtCheckOutTime2.Location = new System.Drawing.Point(120, 301);
            this.txtCheckOutTime2.Name = "txtCheckOutTime2";
            this.txtCheckOutTime2.Size = new System.Drawing.Size(100, 21);
            this.txtCheckOutTime2.TabIndex = 31;
            // 
            // txtCheckOutTime1
            // 
            this.txtCheckOutTime1.Location = new System.Drawing.Point(120, 271);
            this.txtCheckOutTime1.Name = "txtCheckOutTime1";
            this.txtCheckOutTime1.Size = new System.Drawing.Size(100, 21);
            this.txtCheckOutTime1.TabIndex = 30;
            // 
            // txtCheckInTime2
            // 
            this.txtCheckInTime2.Location = new System.Drawing.Point(120, 238);
            this.txtCheckInTime2.Name = "txtCheckInTime2";
            this.txtCheckInTime2.Size = new System.Drawing.Size(100, 21);
            this.txtCheckInTime2.TabIndex = 29;
            // 
            // txtCheckInTime1
            // 
            this.txtCheckInTime1.Location = new System.Drawing.Point(120, 202);
            this.txtCheckInTime1.Name = "txtCheckInTime1";
            this.txtCheckInTime1.Size = new System.Drawing.Size(100, 21);
            this.txtCheckInTime1.TabIndex = 28;
            // 
            // linkLabelColor
            // 
            this.linkLabelColor.AutoSize = true;
            this.linkLabelColor.Location = new System.Drawing.Point(107, 403);
            this.linkLabelColor.Name = "linkLabelColor";
            this.linkLabelColor.Size = new System.Drawing.Size(125, 12);
            this.linkLabelColor.TabIndex = 27;
            this.linkLabelColor.TabStop = true;
            this.linkLabelColor.Text = "更改此时段显示的颜色";
            this.linkLabelColor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelColor_LinkClicked);
            this.linkLabelColor.Click += new System.EventHandler(this.linkLabelColor_Click);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.Location = new System.Drawing.Point(29, 398);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 26;
            this.btnColor.UseVisualStyleBackColor = false;
            // 
            // chkCheckOut
            // 
            this.chkCheckOut.AutoSize = true;
            this.chkCheckOut.Location = new System.Drawing.Point(148, 375);
            this.chkCheckOut.Name = "chkCheckOut";
            this.chkCheckOut.Size = new System.Drawing.Size(72, 16);
            this.chkCheckOut.TabIndex = 25;
            this.chkCheckOut.Text = "必须签退";
            this.chkCheckOut.UseVisualStyleBackColor = true;
            // 
            // chkCheckIn
            // 
            this.chkCheckIn.AutoSize = true;
            this.chkCheckIn.Location = new System.Drawing.Point(64, 376);
            this.chkCheckIn.Name = "chkCheckIn";
            this.chkCheckIn.Size = new System.Drawing.Size(72, 16);
            this.chkCheckIn.TabIndex = 24;
            this.chkCheckIn.Text = "必须签到";
            this.chkCheckIn.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 22;
            this.label7.Text = "开始签退时间：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "结束签到时间：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "结束时间签退：";
            // 
            // txtAutoBind
            // 
            this.txtAutoBind.Location = new System.Drawing.Point(120, 334);
            this.txtAutoBind.Name = "txtAutoBind";
            this.txtAutoBind.Size = new System.Drawing.Size(100, 21);
            this.txtAutoBind.TabIndex = 15;
            this.txtAutoBind.Text = "1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 337);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 12);
            this.label11.TabIndex = 14;
            this.label11.Text = "记多少工作日：";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(27, 205);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(89, 12);
            this.label20.TabIndex = 12;
            this.label20.Text = "开始签到时间：";
            // 
            // txtStartTime
            // 
            this.txtStartTime.Location = new System.Drawing.Point(120, 73);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(100, 21);
            this.txtStartTime.TabIndex = 11;
            this.txtStartTime.Text = "09:00:00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "上班时间：";
            // 
            // txtSchname
            // 
            this.txtSchname.Location = new System.Drawing.Point(120, 40);
            this.txtSchname.Name = "txtSchname";
            this.txtSchname.Size = new System.Drawing.Size(100, 21);
            this.txtSchname.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "班次时段名称：";
            // 
            // txtEndTime
            // 
            this.txtEndTime.Location = new System.Drawing.Point(120, 106);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(100, 21);
            this.txtEndTime.TabIndex = 7;
            this.txtEndTime.Text = "18:00:00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "下班时间：";
            // 
            // txtEarlyMinutes
            // 
            this.txtEarlyMinutes.Location = new System.Drawing.Point(120, 172);
            this.txtEarlyMinutes.Name = "txtEarlyMinutes";
            this.txtEarlyMinutes.Size = new System.Drawing.Size(100, 21);
            this.txtEarlyMinutes.TabIndex = 5;
            this.txtEarlyMinutes.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "记早退时间(分钟)：";
            // 
            // txtLateMinutes
            // 
            this.txtLateMinutes.Location = new System.Drawing.Point(120, 139);
            this.txtLateMinutes.Name = "txtLateMinutes";
            this.txtLateMinutes.Size = new System.Drawing.Size(100, 21);
            this.txtLateMinutes.TabIndex = 3;
            this.txtLateMinutes.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "记迟到时间(分钟)：";
            // 
            // txtSchclassId
            // 
            this.txtSchclassId.Location = new System.Drawing.Point(120, 7);
            this.txtSchclassId.Name = "txtSchclassId";
            this.txtSchclassId.Size = new System.Drawing.Size(100, 21);
            this.txtSchclassId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "班次时段ID：";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvSchclass);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(510, 457);
            this.panel3.TabIndex = 3;
            // 
            // dgvSchclass
            // 
            this.dgvSchclass.AllowUserToAddRows = false;
            this.dgvSchclass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchclass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Schclassid,
            this.Schname,
            this.Starttime,
            this.Endtime});
            this.dgvSchclass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSchclass.Location = new System.Drawing.Point(0, 0);
            this.dgvSchclass.Name = "dgvSchclass";
            this.dgvSchclass.RowTemplate.Height = 23;
            this.dgvSchclass.Size = new System.Drawing.Size(510, 457);
            this.dgvSchclass.TabIndex = 0;
            this.dgvSchclass.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSchclass_CellClick);
            // 
            // Schclassid
            // 
            this.Schclassid.DataPropertyName = "Schclassid";
            this.Schclassid.HeaderText = "时段ID";
            this.Schclassid.Name = "Schclassid";
            // 
            // Schname
            // 
            this.Schname.DataPropertyName = "Schname";
            this.Schname.HeaderText = "时段名称";
            this.Schname.Name = "Schname";
            // 
            // Starttime
            // 
            this.Starttime.DataPropertyName = "Starttime";
            this.Starttime.HeaderText = "上班时间";
            this.Starttime.Name = "Starttime";
            // 
            // Endtime
            // 
            this.Endtime.DataPropertyName = "Endtime";
            this.Endtime.HeaderText = "下班时间";
            this.Endtime.Name = "Endtime";
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSave.Location = new System.Drawing.Point(107, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 55);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDelete.Location = new System.Drawing.Point(214, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 55);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnColse
            // 
            this.btnColse.BackColor = System.Drawing.Color.IndianRed;
            this.btnColse.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnColse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnColse.Location = new System.Drawing.Point(321, 0);
            this.btnColse.Name = "btnColse";
            this.btnColse.Size = new System.Drawing.Size(107, 55);
            this.btnColse.TabIndex = 6;
            this.btnColse.Text = "关闭";
            this.btnColse.UseVisualStyleBackColor = false;
            this.btnColse.Click += new System.EventHandler(this.btnColse_Click);
            // 
            // frmSchclass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 512);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmSchclass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "班次时段设置";
            this.Load += new System.EventHandler(this.frmSchclass_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchclass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvSchclass;
        private System.Windows.Forms.TextBox txtSchclassId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAutoBind;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSchname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEndTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEarlyMinutes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLateMinutes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkCheckOut;
        private System.Windows.Forms.CheckBox chkCheckIn;
        private System.Windows.Forms.LinkLabel linkLabelColor;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Schclassid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Schname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Starttime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endtime;
        private System.Windows.Forms.TextBox txtCheckOutTime2;
        private System.Windows.Forms.TextBox txtCheckOutTime1;
        private System.Windows.Forms.TextBox txtCheckInTime2;
        private System.Windows.Forms.TextBox txtCheckInTime1;
        private System.Windows.Forms.Button btnColse;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
    }
}