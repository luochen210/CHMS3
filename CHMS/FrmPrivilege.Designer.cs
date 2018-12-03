namespace CHMS
{
    partial class FrmPrivilege
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnColse = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNotAll = new System.Windows.Forms.Button();
            this.btnALL = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvModule = new System.Windows.Forms.DataGridView();
            this.ModuleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModuleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvRole = new System.Windows.Forms.DataGridView();
            this.Idx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dgvFunc = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtOprTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdx = new System.Windows.Forms.TextBox();
            this.txtOpr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCDesc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Isownprivilege = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModule)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunc)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnColse);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnNotAll);
            this.panel2.Controls.Add(this.btnALL);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(731, 55);
            this.panel2.TabIndex = 5;
            // 
            // btnColse
            // 
            this.btnColse.BackColor = System.Drawing.Color.IndianRed;
            this.btnColse.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnColse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnColse.Location = new System.Drawing.Point(300, 0);
            this.btnColse.Name = "btnColse";
            this.btnColse.Size = new System.Drawing.Size(107, 55);
            this.btnColse.TabIndex = 15;
            this.btnColse.Text = "关闭";
            this.btnColse.UseVisualStyleBackColor = false;
            this.btnColse.Click += new System.EventHandler(this.btnColse_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSave.Location = new System.Drawing.Point(200, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 55);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNotAll
            // 
            this.btnNotAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNotAll.Location = new System.Drawing.Point(100, 0);
            this.btnNotAll.Name = "btnNotAll";
            this.btnNotAll.Size = new System.Drawing.Size(100, 55);
            this.btnNotAll.TabIndex = 4;
            this.btnNotAll.Text = "反选";
            this.btnNotAll.UseVisualStyleBackColor = true;
            this.btnNotAll.Click += new System.EventHandler(this.btnNotAll_Click);
            // 
            // btnALL
            // 
            this.btnALL.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnALL.Location = new System.Drawing.Point(0, 0);
            this.btnALL.Name = "btnALL";
            this.btnALL.Size = new System.Drawing.Size(100, 55);
            this.btnALL.TabIndex = 3;
            this.btnALL.Text = "全选";
            this.btnALL.UseVisualStyleBackColor = true;
            this.btnALL.Click += new System.EventHandler(this.btnALL_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 426);
            this.panel1.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvModule);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 175);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(275, 251);
            this.panel5.TabIndex = 1;
            // 
            // dgvModule
            // 
            this.dgvModule.AllowUserToAddRows = false;
            this.dgvModule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ModuleID,
            this.ModuleName});
            this.dgvModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvModule.Location = new System.Drawing.Point(0, 0);
            this.dgvModule.Name = "dgvModule";
            this.dgvModule.RowTemplate.Height = 23;
            this.dgvModule.Size = new System.Drawing.Size(275, 251);
            this.dgvModule.TabIndex = 1;
            this.dgvModule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModule_CellClick);
            // 
            // ModuleID
            // 
            this.ModuleID.DataPropertyName = "Id";
            this.ModuleID.HeaderText = "模块ID";
            this.ModuleID.Name = "ModuleID";
            this.ModuleID.Width = 80;
            // 
            // ModuleName
            // 
            this.ModuleName.DataPropertyName = "Name";
            this.ModuleName.HeaderText = "模块名称";
            this.ModuleName.Name = "ModuleName";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvRole);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(275, 175);
            this.panel4.TabIndex = 0;
            // 
            // dgvRole
            // 
            this.dgvRole.AllowUserToAddRows = false;
            this.dgvRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRole.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idx,
            this.CName});
            this.dgvRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRole.Location = new System.Drawing.Point(0, 0);
            this.dgvRole.Name = "dgvRole";
            this.dgvRole.RowTemplate.Height = 23;
            this.dgvRole.Size = new System.Drawing.Size(275, 175);
            this.dgvRole.TabIndex = 1;
            this.dgvRole.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRole_CellClick);
            // 
            // Idx
            // 
            this.Idx.DataPropertyName = "Idx";
            this.Idx.HeaderText = "ID号";
            this.Idx.Name = "Idx";
            this.Idx.Width = 80;
            // 
            // CName
            // 
            this.CName.DataPropertyName = "CName";
            this.CName.HeaderText = "名称";
            this.CName.Name = "CName";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(275, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(456, 426);
            this.panel3.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dgvFunc);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 175);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(456, 251);
            this.panel7.TabIndex = 1;
            // 
            // dgvFunc
            // 
            this.dgvFunc.AllowUserToAddRows = false;
            this.dgvFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Isownprivilege,
            this.No,
            this.funName});
            this.dgvFunc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFunc.Location = new System.Drawing.Point(0, 0);
            this.dgvFunc.Name = "dgvFunc";
            this.dgvFunc.RowTemplate.Height = 23;
            this.dgvFunc.Size = new System.Drawing.Size(456, 251);
            this.dgvFunc.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtOprTime);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.txtNotes);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.txtIdx);
            this.panel6.Controls.Add(this.txtOpr);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.txtCDesc);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(456, 175);
            this.panel6.TabIndex = 0;
            // 
            // txtOprTime
            // 
            this.txtOprTime.Enabled = false;
            this.txtOprTime.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOprTime.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtOprTime.Location = new System.Drawing.Point(86, 127);
            this.txtOprTime.Name = "txtOprTime";
            this.txtOprTime.Size = new System.Drawing.Size(108, 23);
            this.txtOprTime.TabIndex = 134;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(10, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 14);
            this.label7.TabIndex = 133;
            this.label7.Text = "操作时间:";
            // 
            // txtNotes
            // 
            this.txtNotes.Enabled = false;
            this.txtNotes.Font = new System.Drawing.Font("宋体", 11F);
            this.txtNotes.Location = new System.Drawing.Point(265, 26);
            this.txtNotes.MaxLength = 50;
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(179, 125);
            this.txtNotes.TabIndex = 131;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 11F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(273, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 132;
            this.label4.Text = "备注:";
            // 
            // txtIdx
            // 
            this.txtIdx.Enabled = false;
            this.txtIdx.Location = new System.Drawing.Point(86, 6);
            this.txtIdx.Name = "txtIdx";
            this.txtIdx.Size = new System.Drawing.Size(108, 21);
            this.txtIdx.TabIndex = 130;
            // 
            // txtOpr
            // 
            this.txtOpr.Enabled = false;
            this.txtOpr.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOpr.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtOpr.Location = new System.Drawing.Point(86, 86);
            this.txtOpr.Name = "txtOpr";
            this.txtOpr.Size = new System.Drawing.Size(108, 23);
            this.txtOpr.TabIndex = 129;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(24, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 14);
            this.label2.TabIndex = 128;
            this.label2.Text = "操作员:";
            // 
            // txtCDesc
            // 
            this.txtCDesc.Enabled = false;
            this.txtCDesc.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCDesc.Location = new System.Drawing.Point(86, 45);
            this.txtCDesc.Name = "txtCDesc";
            this.txtCDesc.Size = new System.Drawing.Size(108, 23);
            this.txtCDesc.TabIndex = 127;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(24, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 14);
            this.label6.TabIndex = 126;
            this.label6.Text = "组ID号:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(10, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 14);
            this.label3.TabIndex = 125;
            this.label3.Text = "组别名称:";
            // 
            // Isownprivilege
            // 
            this.Isownprivilege.DataPropertyName = "Isownprivilege";
            this.Isownprivilege.FalseValue = "False";
            this.Isownprivilege.HeaderText = "使用";
            this.Isownprivilege.Name = "Isownprivilege";
            this.Isownprivilege.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Isownprivilege.TrueValue = "True";
            // 
            // No
            // 
            this.No.DataPropertyName = "No";
            this.No.HeaderText = "菜单ID";
            this.No.Name = "No";
            // 
            // funName
            // 
            this.funName.DataPropertyName = "Name";
            this.funName.HeaderText = "菜单名称";
            this.funName.Name = "funName";
            // 
            // frmPrivilege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 481);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmPrivilege";
            this.Text = "权限配置";
            this.Load += new System.EventHandler(this.frmPrivilege_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModule)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunc)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnColse;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNotAll;
        private System.Windows.Forms.Button btnALL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgvModule;
        private System.Windows.Forms.DataGridView dgvFunc;
        private System.Windows.Forms.DataGridView dgvRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idx;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.TextBox txtIdx;
        private System.Windows.Forms.TextBox txtOpr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCDesc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOprTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModuleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModuleName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Isownprivilege;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn funName;
    }
}