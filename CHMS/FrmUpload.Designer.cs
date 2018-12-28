namespace CHMS
{
    partial class FrmUpload
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
            this.btnColse = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnNotAll = new System.Windows.Forms.Button();
            this.btnALL = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvfrmMachines = new System.Windows.Forms.DataGridView();
            this.stateDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machineNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialPortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baudrateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machineNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.tvUserInfo = new System.Windows.Forms.TreeView();
            this.fastSelect1 = new CHMS.FastSelect(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfrmMachines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.machinesBindingSource)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnColse);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnConnect);
            this.panel2.Controls.Add(this.btnNotAll);
            this.panel2.Controls.Add(this.btnALL);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(753, 55);
            this.panel2.TabIndex = 4;
            // 
            // btnColse
            // 
            this.btnColse.BackColor = System.Drawing.Color.IndianRed;
            this.btnColse.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnColse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnColse.Location = new System.Drawing.Point(400, 0);
            this.btnColse.Name = "btnColse";
            this.fastSelect1.SetSelectionSource(this.btnColse, null);
            this.btnColse.Size = new System.Drawing.Size(107, 55);
            this.btnColse.TabIndex = 15;
            this.btnColse.Text = "关闭";
            this.btnColse.UseVisualStyleBackColor = false;
            this.btnColse.Click += new System.EventHandler(this.btnColse_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSave.Location = new System.Drawing.Point(300, 0);
            this.btnSave.Name = "btnSave";
            this.fastSelect1.SetSelectionSource(this.btnSave, null);
            this.btnSave.Size = new System.Drawing.Size(100, 55);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "上传数据";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnConnect.Location = new System.Drawing.Point(200, 0);
            this.btnConnect.Name = "btnConnect";
            this.fastSelect1.SetSelectionSource(this.btnConnect, null);
            this.btnConnect.Size = new System.Drawing.Size(100, 55);
            this.btnConnect.TabIndex = 13;
            this.btnConnect.Text = "测试考勤机";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnNotAll
            // 
            this.btnNotAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNotAll.Location = new System.Drawing.Point(100, 0);
            this.btnNotAll.Name = "btnNotAll";
            this.fastSelect1.SetSelectionSource(this.btnNotAll, this.tvUserInfo);
            this.fastSelect1.SetSelectionType(this.btnNotAll, CHMS.SelectionType.反选);
            this.btnNotAll.Size = new System.Drawing.Size(100, 55);
            this.btnNotAll.TabIndex = 4;
            this.btnNotAll.Text = "反选";
            this.btnNotAll.UseVisualStyleBackColor = true;
            // 
            // btnALL
            // 
            this.btnALL.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnALL.Location = new System.Drawing.Point(0, 0);
            this.btnALL.Name = "btnALL";
            this.fastSelect1.SetSelectionSource(this.btnALL, this.tvUserInfo);
            this.fastSelect1.SetSelectionType(this.btnALL, CHMS.SelectionType.全选);
            this.btnALL.Size = new System.Drawing.Size(100, 55);
            this.btnALL.TabIndex = 3;
            this.btnALL.Text = "全选";
            this.btnALL.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 437);
            this.panel1.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(753, 437);
            this.panel4.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgvfrmMachines);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(210, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(543, 437);
            this.panel6.TabIndex = 4;
            // 
            // dgvfrmMachines
            // 
            this.dgvfrmMachines.AllowUserToAddRows = false;
            this.dgvfrmMachines.AutoGenerateColumns = false;
            this.dgvfrmMachines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfrmMachines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stateDataGridViewCheckBoxColumn,
            this.idxDataGridViewTextBoxColumn,
            this.machineNameDataGridViewTextBoxColumn,
            this.remarksDataGridViewTextBoxColumn,
            this.connectTypeDataGridViewTextBoxColumn,
            this.iPDataGridViewTextBoxColumn,
            this.serialPortDataGridViewTextBoxColumn,
            this.portDataGridViewTextBoxColumn,
            this.baudrateDataGridViewTextBoxColumn,
            this.machineNumberDataGridViewTextBoxColumn,
            this.commPasswordDataGridViewTextBoxColumn,
            this.snDataGridViewTextBoxColumn});
            this.dgvfrmMachines.DataSource = this.machinesBindingSource;
            this.dgvfrmMachines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvfrmMachines.Location = new System.Drawing.Point(0, 0);
            this.dgvfrmMachines.Name = "dgvfrmMachines";
            this.dgvfrmMachines.RowHeadersVisible = false;
            this.dgvfrmMachines.RowTemplate.Height = 23;
            this.dgvfrmMachines.Size = new System.Drawing.Size(543, 437);
            this.dgvfrmMachines.TabIndex = 2;
            // 
            // stateDataGridViewCheckBoxColumn
            // 
            this.stateDataGridViewCheckBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewCheckBoxColumn.HeaderText = "选择";
            this.stateDataGridViewCheckBoxColumn.Name = "stateDataGridViewCheckBoxColumn";
            this.stateDataGridViewCheckBoxColumn.Width = 50;
            // 
            // idxDataGridViewTextBoxColumn
            // 
            this.idxDataGridViewTextBoxColumn.DataPropertyName = "Idx";
            this.idxDataGridViewTextBoxColumn.HeaderText = "编号";
            this.idxDataGridViewTextBoxColumn.Name = "idxDataGridViewTextBoxColumn";
            this.idxDataGridViewTextBoxColumn.Width = 60;
            // 
            // machineNameDataGridViewTextBoxColumn
            // 
            this.machineNameDataGridViewTextBoxColumn.DataPropertyName = "MachineName";
            this.machineNameDataGridViewTextBoxColumn.HeaderText = "设备名称";
            this.machineNameDataGridViewTextBoxColumn.Name = "machineNameDataGridViewTextBoxColumn";
            this.machineNameDataGridViewTextBoxColumn.Width = 80;
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            this.remarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks";
            this.remarksDataGridViewTextBoxColumn.HeaderText = "连接状态";
            this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            this.remarksDataGridViewTextBoxColumn.Width = 80;
            // 
            // connectTypeDataGridViewTextBoxColumn
            // 
            this.connectTypeDataGridViewTextBoxColumn.DataPropertyName = "ConnectType";
            this.connectTypeDataGridViewTextBoxColumn.HeaderText = "ConnectType";
            this.connectTypeDataGridViewTextBoxColumn.Name = "connectTypeDataGridViewTextBoxColumn";
            this.connectTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // iPDataGridViewTextBoxColumn
            // 
            this.iPDataGridViewTextBoxColumn.DataPropertyName = "IP";
            this.iPDataGridViewTextBoxColumn.HeaderText = "IP";
            this.iPDataGridViewTextBoxColumn.Name = "iPDataGridViewTextBoxColumn";
            this.iPDataGridViewTextBoxColumn.Visible = false;
            // 
            // serialPortDataGridViewTextBoxColumn
            // 
            this.serialPortDataGridViewTextBoxColumn.DataPropertyName = "SerialPort";
            this.serialPortDataGridViewTextBoxColumn.HeaderText = "SerialPort";
            this.serialPortDataGridViewTextBoxColumn.Name = "serialPortDataGridViewTextBoxColumn";
            this.serialPortDataGridViewTextBoxColumn.Visible = false;
            // 
            // portDataGridViewTextBoxColumn
            // 
            this.portDataGridViewTextBoxColumn.DataPropertyName = "Port";
            this.portDataGridViewTextBoxColumn.HeaderText = "Port";
            this.portDataGridViewTextBoxColumn.Name = "portDataGridViewTextBoxColumn";
            this.portDataGridViewTextBoxColumn.Visible = false;
            // 
            // baudrateDataGridViewTextBoxColumn
            // 
            this.baudrateDataGridViewTextBoxColumn.DataPropertyName = "Baudrate";
            this.baudrateDataGridViewTextBoxColumn.HeaderText = "Baudrate";
            this.baudrateDataGridViewTextBoxColumn.Name = "baudrateDataGridViewTextBoxColumn";
            this.baudrateDataGridViewTextBoxColumn.Visible = false;
            // 
            // machineNumberDataGridViewTextBoxColumn
            // 
            this.machineNumberDataGridViewTextBoxColumn.DataPropertyName = "MachineNumber";
            this.machineNumberDataGridViewTextBoxColumn.HeaderText = "MachineNumber";
            this.machineNumberDataGridViewTextBoxColumn.Name = "machineNumberDataGridViewTextBoxColumn";
            this.machineNumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // commPasswordDataGridViewTextBoxColumn
            // 
            this.commPasswordDataGridViewTextBoxColumn.DataPropertyName = "CommPassword";
            this.commPasswordDataGridViewTextBoxColumn.HeaderText = "CommPassword";
            this.commPasswordDataGridViewTextBoxColumn.Name = "commPasswordDataGridViewTextBoxColumn";
            this.commPasswordDataGridViewTextBoxColumn.Visible = false;
            // 
            // snDataGridViewTextBoxColumn
            // 
            this.snDataGridViewTextBoxColumn.DataPropertyName = "sn";
            this.snDataGridViewTextBoxColumn.HeaderText = "sn";
            this.snDataGridViewTextBoxColumn.Name = "snDataGridViewTextBoxColumn";
            this.snDataGridViewTextBoxColumn.Visible = false;
            // 
            // machinesBindingSource
            // 
            this.machinesBindingSource.DataSource = typeof(Models.Machines);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tvUserInfo);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(210, 437);
            this.panel5.TabIndex = 3;
            // 
            // tvUserInfo
            // 
            this.tvUserInfo.CheckBoxes = true;
            this.tvUserInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvUserInfo.Location = new System.Drawing.Point(0, 0);
            this.tvUserInfo.Name = "tvUserInfo";
            this.tvUserInfo.Size = new System.Drawing.Size(210, 437);
            this.tvUserInfo.TabIndex = 3;
            // 
            // frmUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 492);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmUpload";
            this.Text = "上传人事信息";
            this.Load += new System.EventHandler(this.frmUpload_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfrmMachines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.machinesBindingSource)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnNotAll;
        private System.Windows.Forms.Button btnALL;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.BindingSource machinesBindingSource;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.DataGridView dgvfrmMachines;
        private System.Windows.Forms.DataGridViewCheckBoxColumn stateDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialPortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn portDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baudrateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnColse;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TreeView tvUserInfo;
        private FastSelect fastSelect1;
    }
}