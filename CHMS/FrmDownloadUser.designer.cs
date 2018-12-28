namespace CHMS
{
    partial class FrmDownloadUser
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDownloadAttLogs = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lvCard = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.panel3 = new System.Windows.Forms.Panel();
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
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfrmMachines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.machinesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnDownloadAttLogs);
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 55);
            this.panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClose.Location = new System.Drawing.Point(200, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 55);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDownloadAttLogs
            // 
            this.btnDownloadAttLogs.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDownloadAttLogs.Location = new System.Drawing.Point(100, 0);
            this.btnDownloadAttLogs.Name = "btnDownloadAttLogs";
            this.btnDownloadAttLogs.Size = new System.Drawing.Size(100, 55);
            this.btnDownloadAttLogs.TabIndex = 5;
            this.btnDownloadAttLogs.Text = "下载数据";
            this.btnDownloadAttLogs.UseVisualStyleBackColor = true;
            this.btnDownloadAttLogs.Click += new System.EventHandler(this.btnDownloadAttLogs_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnConnect.Location = new System.Drawing.Point(0, 0);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 55);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "测试考勤机";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(788, 427);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lvCard);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(271, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(517, 427);
            this.panel4.TabIndex = 48;
            // 
            // lvCard
            // 
            this.lvCard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCard.GridLines = true;
            this.lvCard.Location = new System.Drawing.Point(0, 0);
            this.lvCard.Name = "lvCard";
            this.lvCard.Size = new System.Drawing.Size(517, 427);
            this.lvCard.TabIndex = 47;
            this.lvCard.UseCompatibleStateImageBehavior = false;
            this.lvCard.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "工号";
            this.columnHeader1.Width = 54;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "姓名";
            this.columnHeader2.Width = 41;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "卡号";
            this.columnHeader3.Width = 78;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "指纹索引";
            this.columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "指纹模板";
            this.columnHeader5.Width = 147;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "权限值";
            this.columnHeader6.Width = 92;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "考勤密码";
            this.columnHeader7.Width = 91;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "是否启用";
            this.columnHeader8.Width = 93;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvfrmMachines);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(271, 427);
            this.panel3.TabIndex = 47;
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
            this.dgvfrmMachines.Size = new System.Drawing.Size(271, 427);
            this.dgvfrmMachines.TabIndex = 0;
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
            // frmDownloadUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 482);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmDownloadUser";
            this.Text = "下载人员信息";
            this.Load += new System.EventHandler(this.frmDownloadUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfrmMachines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.machinesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView lvCard;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvfrmMachines;
        private System.Windows.Forms.Button btnDownloadAttLogs;
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
        private System.Windows.Forms.BindingSource machinesBindingSource;
        private System.Windows.Forms.Button btnClose;
    }
}