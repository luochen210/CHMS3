namespace CHMS
{
    partial class FrmDeartments
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvDeartments = new System.Windows.Forms.DataGridView();
            this.DEPTID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEPTNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUPDEPTNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUPDEPTID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSUPDEPTID = new System.Windows.Forms.TextBox();
            this.txtDEPTNAME = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDEPTID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddUnderling = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeartments)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnAddUnderling);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 55);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(692, 441);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvDeartments);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(465, 441);
            this.panel4.TabIndex = 1;
            // 
            // dgvDeartments
            // 
            this.dgvDeartments.AllowUserToAddRows = false;
            this.dgvDeartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeartments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DEPTID,
            this.DEPTNAME,
            this.SUPDEPTNAME,
            this.SUPDEPTID});
            this.dgvDeartments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeartments.Location = new System.Drawing.Point(0, 0);
            this.dgvDeartments.Name = "dgvDeartments";
            this.dgvDeartments.RowTemplate.Height = 23;
            this.dgvDeartments.Size = new System.Drawing.Size(465, 441);
            this.dgvDeartments.TabIndex = 0;
            this.dgvDeartments.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvDeartments_RowPostPaint);
            this.dgvDeartments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeartments_CellClick);
            // 
            // DEPTID
            // 
            this.DEPTID.DataPropertyName = "DEPTID";
            this.DEPTID.HeaderText = "部门编号";
            this.DEPTID.Name = "DEPTID";
            // 
            // DEPTNAME
            // 
            this.DEPTNAME.DataPropertyName = "DEPTNAME";
            this.DEPTNAME.HeaderText = "部门名称";
            this.DEPTNAME.Name = "DEPTNAME";
            // 
            // SUPDEPTNAME
            // 
            this.SUPDEPTNAME.DataPropertyName = "SUPDEPTNAME";
            this.SUPDEPTNAME.HeaderText = "所属上级";
            this.SUPDEPTNAME.Name = "SUPDEPTNAME";
            // 
            // SUPDEPTID
            // 
            this.SUPDEPTID.HeaderText = "SUPDEPTID";
            this.SUPDEPTID.Name = "SUPDEPTID";
            this.SUPDEPTID.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtSUPDEPTID);
            this.panel3.Controls.Add(this.txtDEPTNAME);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtDEPTID);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(465, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 441);
            this.panel3.TabIndex = 0;
            // 
            // txtSUPDEPTID
            // 
            this.txtSUPDEPTID.BackColor = System.Drawing.Color.White;
            this.txtSUPDEPTID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSUPDEPTID.Enabled = false;
            this.txtSUPDEPTID.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSUPDEPTID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSUPDEPTID.Location = new System.Drawing.Point(87, 19);
            this.txtSUPDEPTID.Name = "txtSUPDEPTID";
            this.txtSUPDEPTID.Size = new System.Drawing.Size(54, 23);
            this.txtSUPDEPTID.TabIndex = 32;
            // 
            // txtDEPTNAME
            // 
            this.txtDEPTNAME.BackColor = System.Drawing.Color.White;
            this.txtDEPTNAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDEPTNAME.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDEPTNAME.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDEPTNAME.Location = new System.Drawing.Point(87, 54);
            this.txtDEPTNAME.Name = "txtDEPTNAME";
            this.txtDEPTNAME.Size = new System.Drawing.Size(117, 23);
            this.txtDEPTNAME.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 31;
            this.label1.Text = "部门名称:";
            // 
            // txtDEPTID
            // 
            this.txtDEPTID.BackColor = System.Drawing.Color.White;
            this.txtDEPTID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDEPTID.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDEPTID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDEPTID.Location = new System.Drawing.Point(147, 19);
            this.txtDEPTID.Name = "txtDEPTID";
            this.txtDEPTID.Size = new System.Drawing.Size(54, 23);
            this.txtDEPTID.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(12, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 14);
            this.label7.TabIndex = 29;
            this.label7.Text = "部门编号:";
            // 
            // btnAddUnderling
            // 
            this.btnAddUnderling.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddUnderling.Location = new System.Drawing.Point(0, 0);
            this.btnAddUnderling.Name = "btnAddUnderling";
            this.btnAddUnderling.Size = new System.Drawing.Size(107, 55);
            this.btnAddUnderling.TabIndex = 6;
            this.btnAddUnderling.Text = "新增下属";
            this.btnAddUnderling.UseVisualStyleBackColor = true;
            this.btnAddUnderling.Click += new System.EventHandler(this.btnAddUnderling_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdd.Location = new System.Drawing.Point(107, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 55);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "新增同级";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSave.Location = new System.Drawing.Point(214, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 55);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDelete.Location = new System.Drawing.Point(321, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 55);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClose.Location = new System.Drawing.Point(428, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(107, 55);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmDeartments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 496);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmDeartments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "部门信息管理";
            this.Load += new System.EventHandler(this.frmDeartments_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeartments)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtDEPTNAME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDEPTID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSUPDEPTID;
        private System.Windows.Forms.DataGridView dgvDeartments;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPTID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPTNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUPDEPTNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUPDEPTID;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddUnderling;
    }
}