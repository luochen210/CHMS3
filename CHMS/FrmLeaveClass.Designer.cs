namespace CHMS
{
    partial class FrmLeaveClass
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvLeaveClass = new System.Windows.Forms.DataGridView();
            this.LeaveId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaveName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.linkLabelColor = new System.Windows.Forms.LinkLabel();
            this.btnColor = new System.Windows.Forms.Button();
            this.chkClassify = new System.Windows.Forms.CheckBox();
            this.txtReportSymbol = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRemaindProc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMinUnit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLeaveName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLeaveId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveClass)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 55);
            this.panel1.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 55);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(715, 393);
            this.panel2.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvLeaveClass);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(461, 393);
            this.panel4.TabIndex = 1;
            // 
            // dgvLeaveClass
            // 
            this.dgvLeaveClass.AllowUserToAddRows = false;
            this.dgvLeaveClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeaveClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LeaveId,
            this.LeaveName,
            this.MinUnit});
            this.dgvLeaveClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLeaveClass.Location = new System.Drawing.Point(0, 0);
            this.dgvLeaveClass.Name = "dgvLeaveClass";
            this.dgvLeaveClass.RowTemplate.Height = 23;
            this.dgvLeaveClass.Size = new System.Drawing.Size(461, 393);
            this.dgvLeaveClass.TabIndex = 0;
            this.dgvLeaveClass.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLeaveClass_CellClick);
            // 
            // LeaveId
            // 
            this.LeaveId.DataPropertyName = "LeaveId";
            this.LeaveId.HeaderText = "假类编号";
            this.LeaveId.Name = "LeaveId";
            // 
            // LeaveName
            // 
            this.LeaveName.DataPropertyName = "LeaveName";
            this.LeaveName.HeaderText = "假类名称";
            this.LeaveName.Name = "LeaveName";
            // 
            // MinUnit
            // 
            this.MinUnit.DataPropertyName = "MinUnit";
            this.MinUnit.HeaderText = "最小单位";
            this.MinUnit.Name = "MinUnit";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.linkLabelColor);
            this.panel3.Controls.Add(this.btnColor);
            this.panel3.Controls.Add(this.chkClassify);
            this.panel3.Controls.Add(this.txtReportSymbol);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtRemaindProc);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtUnit);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtMinUnit);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtLeaveName);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtLeaveId);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(461, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(254, 393);
            this.panel3.TabIndex = 0;
            // 
            // linkLabelColor
            // 
            this.linkLabelColor.AutoSize = true;
            this.linkLabelColor.Location = new System.Drawing.Point(115, 218);
            this.linkLabelColor.Name = "linkLabelColor";
            this.linkLabelColor.Size = new System.Drawing.Size(125, 12);
            this.linkLabelColor.TabIndex = 29;
            this.linkLabelColor.TabStop = true;
            this.linkLabelColor.Text = "更改此假类显示的颜色";
            this.linkLabelColor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelColor_LinkClicked);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.Location = new System.Drawing.Point(33, 215);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 28;
            this.btnColor.UseVisualStyleBackColor = false;
            // 
            // chkClassify
            // 
            this.chkClassify.AutoSize = true;
            this.chkClassify.Location = new System.Drawing.Point(117, 245);
            this.chkClassify.Name = "chkClassify";
            this.chkClassify.Size = new System.Drawing.Size(108, 16);
            this.chkClassify.TabIndex = 16;
            this.chkClassify.Text = "是否计算为请假";
            this.chkClassify.UseVisualStyleBackColor = true;
            // 
            // txtReportSymbol
            // 
            this.txtReportSymbol.Location = new System.Drawing.Point(117, 180);
            this.txtReportSymbol.Name = "txtReportSymbol";
            this.txtReportSymbol.Size = new System.Drawing.Size(113, 21);
            this.txtReportSymbol.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "报表中的表示符号：";
            // 
            // txtRemaindProc
            // 
            this.txtRemaindProc.Location = new System.Drawing.Point(117, 143);
            this.txtRemaindProc.Name = "txtRemaindProc";
            this.txtRemaindProc.Size = new System.Drawing.Size(113, 21);
            this.txtRemaindProc.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "舍入控制：";
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(117, 109);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(113, 21);
            this.txtUnit.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "统计单位：";
            // 
            // txtMinUnit
            // 
            this.txtMinUnit.Location = new System.Drawing.Point(117, 75);
            this.txtMinUnit.Name = "txtMinUnit";
            this.txtMinUnit.Size = new System.Drawing.Size(113, 21);
            this.txtMinUnit.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "最小统计单位：";
            // 
            // txtLeaveName
            // 
            this.txtLeaveName.Location = new System.Drawing.Point(117, 41);
            this.txtLeaveName.Name = "txtLeaveName";
            this.txtLeaveName.Size = new System.Drawing.Size(113, 21);
            this.txtLeaveName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "假类名称：";
            // 
            // txtLeaveId
            // 
            this.txtLeaveId.Location = new System.Drawing.Point(117, 7);
            this.txtLeaveId.Name = "txtLeaveId";
            this.txtLeaveId.Size = new System.Drawing.Size(113, 21);
            this.txtLeaveId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "假类编号：";
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSave.Location = new System.Drawing.Point(100, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 55);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDelete.Location = new System.Drawing.Point(200, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 55);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClose.Location = new System.Drawing.Point(300, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 55);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmLeaveClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 448);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmLeaveClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "假期类别设置";
            this.Load += new System.EventHandler(this.frmLeaveClass_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveClass)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvLeaveClass;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtReportSymbol;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRemaindProc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMinUnit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLeaveName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLeaveId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkClassify;
        private System.Windows.Forms.LinkLabel linkLabelColor;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaveId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaveName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinUnit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
    }
}