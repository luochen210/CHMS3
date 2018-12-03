namespace CHMS
{
    partial class FrmRun
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnColse = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtStartdate = new System.Windows.Forms.DateTimePicker();
            this.cbUnits = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCyle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRunID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvRun = new System.Windows.Forms.DataGridView();
            this.RunID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RunName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Startdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cyle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dgvSchclassSelect = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Starttime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvSchclass = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Schclassid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Schname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRun)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchclassSelect)).BeginInit();
            this.panel4.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(836, 54);
            this.panel1.TabIndex = 2;
            // 
            // btnColse
            // 
            this.btnColse.BackColor = System.Drawing.Color.IndianRed;
            this.btnColse.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnColse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnColse.Location = new System.Drawing.Point(321, 0);
            this.btnColse.Name = "btnColse";
            this.btnColse.Size = new System.Drawing.Size(107, 54);
            this.btnColse.TabIndex = 6;
            this.btnColse.Text = "关闭";
            this.btnColse.UseVisualStyleBackColor = false;
            this.btnColse.Click += new System.EventHandler(this.btnColse_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDelete.Location = new System.Drawing.Point(214, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 54);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSave.Location = new System.Drawing.Point(107, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 54);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 54);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtStartdate);
            this.panel2.Controls.Add(this.cbUnits);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtCyle);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtRunID);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(625, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 464);
            this.panel2.TabIndex = 3;
            // 
            // dtStartdate
            // 
            this.dtStartdate.Location = new System.Drawing.Point(77, 83);
            this.dtStartdate.Name = "dtStartdate";
            this.dtStartdate.Size = new System.Drawing.Size(121, 21);
            this.dtStartdate.TabIndex = 10;
            // 
            // cbUnits
            // 
            this.cbUnits.FormattingEnabled = true;
            this.cbUnits.Location = new System.Drawing.Point(77, 154);
            this.cbUnits.Name = "cbUnits";
            this.cbUnits.Size = new System.Drawing.Size(121, 20);
            this.cbUnits.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "周期单位：";
            // 
            // txtCyle
            // 
            this.txtCyle.Location = new System.Drawing.Point(77, 121);
            this.txtCyle.Name = "txtCyle";
            this.txtCyle.Size = new System.Drawing.Size(120, 21);
            this.txtCyle.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "周期数：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "开始日期：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(77, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(120, 21);
            this.txtName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "班次名称：";
            // 
            // txtRunID
            // 
            this.txtRunID.Location = new System.Drawing.Point(77, 12);
            this.txtRunID.Name = "txtRunID";
            this.txtRunID.Size = new System.Drawing.Size(120, 21);
            this.txtRunID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "班次编号：";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(625, 464);
            this.panel3.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(392, 464);
            this.panel5.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgvRun);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(392, 321);
            this.panel6.TabIndex = 2;
            // 
            // dgvRun
            // 
            this.dgvRun.AllowUserToAddRows = false;
            this.dgvRun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRun.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RunID,
            this.RunName,
            this.Startdate,
            this.Cyle});
            this.dgvRun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRun.Location = new System.Drawing.Point(0, 0);
            this.dgvRun.Name = "dgvRun";
            this.dgvRun.RowHeadersVisible = false;
            this.dgvRun.RowTemplate.Height = 23;
            this.dgvRun.Size = new System.Drawing.Size(392, 321);
            this.dgvRun.TabIndex = 0;
            this.dgvRun.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRun_CellClick);
            // 
            // RunID
            // 
            this.RunID.DataPropertyName = "RunID";
            this.RunID.HeaderText = "班次编号";
            this.RunID.Name = "RunID";
            // 
            // RunName
            // 
            this.RunName.DataPropertyName = "Name";
            this.RunName.HeaderText = "班次名称";
            this.RunName.Name = "RunName";
            // 
            // Startdate
            // 
            this.Startdate.DataPropertyName = "Startdate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.Startdate.DefaultCellStyle = dataGridViewCellStyle1;
            this.Startdate.HeaderText = "开始日期";
            this.Startdate.Name = "Startdate";
            // 
            // Cyle
            // 
            this.Cyle.DataPropertyName = "Cyle";
            this.Cyle.HeaderText = "周期数";
            this.Cyle.Name = "Cyle";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dgvSchclassSelect);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 321);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(392, 143);
            this.panel7.TabIndex = 1;
            // 
            // dgvSchclassSelect
            // 
            this.dgvSchclassSelect.AllowUserToAddRows = false;
            this.dgvSchclassSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchclassSelect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Starttime,
            this.Endtime});
            this.dgvSchclassSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSchclassSelect.Location = new System.Drawing.Point(0, 0);
            this.dgvSchclassSelect.Name = "dgvSchclassSelect";
            this.dgvSchclassSelect.RowHeadersVisible = false;
            this.dgvSchclassSelect.RowTemplate.Height = 23;
            this.dgvSchclassSelect.Size = new System.Drawing.Size(392, 143);
            this.dgvSchclassSelect.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Schclassid";
            this.dataGridViewTextBoxColumn1.HeaderText = "时段ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Schname";
            this.dataGridViewTextBoxColumn2.HeaderText = "时段名称";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
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
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvSchclass);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(392, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(233, 464);
            this.panel4.TabIndex = 1;
            // 
            // dgvSchclass
            // 
            this.dgvSchclass.AllowUserToAddRows = false;
            this.dgvSchclass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchclass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Schclassid,
            this.Schname});
            this.dgvSchclass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSchclass.Location = new System.Drawing.Point(0, 0);
            this.dgvSchclass.Name = "dgvSchclass";
            this.dgvSchclass.RowHeadersVisible = false;
            this.dgvSchclass.RowTemplate.Height = 23;
            this.dgvSchclass.Size = new System.Drawing.Size(233, 464);
            this.dgvSchclass.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IsShow";
            this.Column1.HeaderText = "选择";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Schclassid
            // 
            this.Schclassid.DataPropertyName = "Schclassid";
            this.Schclassid.HeaderText = "时段ID";
            this.Schclassid.Name = "Schclassid";
            this.Schclassid.Width = 80;
            // 
            // Schname
            // 
            this.Schname.DataPropertyName = "Schname";
            this.Schname.HeaderText = "时段名称";
            this.Schname.Name = "Schname";
            // 
            // frmRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 518);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmRun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "班次管理";
            this.Load += new System.EventHandler(this.frmRun_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRun)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchclassSelect)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchclass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCyle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRunID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUnits;
        private System.Windows.Forms.DateTimePicker dtStartdate;
        private System.Windows.Forms.Button btnColse;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvRun;
        private System.Windows.Forms.DataGridViewTextBoxColumn RunID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RunName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Startdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cyle;
        private System.Windows.Forms.DataGridView dgvSchclass;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Schclassid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Schname;
        private System.Windows.Forms.DataGridView dgvSchclassSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Starttime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endtime;
    }
}