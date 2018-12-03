namespace CHMS
{
    partial class FrmRptSpeday
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnXls = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnNotAll = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvSpedayLog = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tvUserInfo = new System.Windows.Forms.TreeView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.fastSelect1 = new CHMS.FastSelect(this.components);
            this.Idx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labIDX = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpedayLog)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnXls);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnQuery);
            this.panel1.Controls.Add(this.btnNotAll);
            this.panel1.Controls.Add(this.btnAll);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 55);
            this.panel1.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClose.Location = new System.Drawing.Point(570, 0);
            this.btnClose.Name = "btnClose";
            this.fastSelect1.SetSelectionSource(this.btnClose, null);
            this.btnClose.Size = new System.Drawing.Size(93, 55);
            this.btnClose.TabIndex = 60;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDelete.Location = new System.Drawing.Point(477, 0);
            this.btnDelete.Name = "btnDelete";
            this.fastSelect1.SetSelectionSource(this.btnDelete, null);
            this.btnDelete.Size = new System.Drawing.Size(93, 55);
            this.btnDelete.TabIndex = 59;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnXls
            // 
            this.btnXls.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnXls.Location = new System.Drawing.Point(384, 0);
            this.btnXls.Name = "btnXls";
            this.fastSelect1.SetSelectionSource(this.btnXls, null);
            this.btnXls.Size = new System.Drawing.Size(93, 55);
            this.btnXls.TabIndex = 57;
            this.btnXls.Text = "导出";
            this.btnXls.UseVisualStyleBackColor = true;
            this.btnXls.Click += new System.EventHandler(this.btnXls_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPrint.Location = new System.Drawing.Point(288, 0);
            this.btnPrint.Name = "btnPrint";
            this.fastSelect1.SetSelectionSource(this.btnPrint, null);
            this.btnPrint.Size = new System.Drawing.Size(96, 55);
            this.btnPrint.TabIndex = 56;
            this.btnPrint.Text = "打印";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnQuery.Location = new System.Drawing.Point(192, 0);
            this.btnQuery.Name = "btnQuery";
            this.fastSelect1.SetSelectionSource(this.btnQuery, null);
            this.btnQuery.Size = new System.Drawing.Size(96, 55);
            this.btnQuery.TabIndex = 55;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnNotAll
            // 
            this.btnNotAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNotAll.Location = new System.Drawing.Point(96, 0);
            this.btnNotAll.Name = "btnNotAll";
            this.fastSelect1.SetSelectionSource(this.btnNotAll, this.tvUserInfo);
            this.fastSelect1.SetSelectionType(this.btnNotAll, CHMS.SelectionType.反选);
            this.btnNotAll.Size = new System.Drawing.Size(96, 55);
            this.btnNotAll.TabIndex = 54;
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
            this.btnAll.Size = new System.Drawing.Size(96, 55);
            this.btnAll.TabIndex = 47;
            this.btnAll.Text = "全选";
            this.btnAll.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(772, 441);
            this.panel2.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvSpedayLog);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(200, 37);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(572, 404);
            this.panel5.TabIndex = 2;
            // 
            // dgvSpedayLog
            // 
            this.dgvSpedayLog.AllowUserToAddRows = false;
            this.dgvSpedayLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpedayLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idx,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7});
            this.dgvSpedayLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSpedayLog.Location = new System.Drawing.Point(0, 0);
            this.dgvSpedayLog.Name = "dgvSpedayLog";
            this.dgvSpedayLog.RowTemplate.Height = 23;
            this.dgvSpedayLog.Size = new System.Drawing.Size(572, 404);
            this.dgvSpedayLog.TabIndex = 0;
            this.dgvSpedayLog.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSpedayLog_CellClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tvUserInfo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 37);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 404);
            this.panel4.TabIndex = 1;
            // 
            // tvUserInfo
            // 
            this.tvUserInfo.CheckBoxes = true;
            this.tvUserInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvUserInfo.Location = new System.Drawing.Point(0, 0);
            this.tvUserInfo.Name = "tvUserInfo";
            this.tvUserInfo.Size = new System.Drawing.Size(200, 404);
            this.tvUserInfo.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labIDX);
            this.panel3.Controls.Add(this.dtEndDate);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.dtStartDate);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(772, 37);
            this.panel3.TabIndex = 0;
            // 
            // dtEndDate
            // 
            this.dtEndDate.Location = new System.Drawing.Point(290, 6);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(115, 21);
            this.dtEndDate.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 10);
            this.label4.Name = "label4";
            this.fastSelect1.SetSelectionSource(this.label4, null);
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 55;
            this.label4.Text = "结束日期：";
            // 
            // dtStartDate
            // 
            this.dtStartDate.Location = new System.Drawing.Point(85, 6);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(122, 21);
            this.dtStartDate.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 11);
            this.label3.Name = "label3";
            this.fastSelect1.SetSelectionSource(this.label3, null);
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 53;
            this.label3.Text = "开始日期：";
            // 
            // Idx
            // 
            this.Idx.DataPropertyName = "Idx";
            this.Idx.HeaderText = "IDX";
            this.Idx.Name = "Idx";
            this.Idx.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Userid";
            this.Column1.HeaderText = "工号";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "姓名";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SpecdayDate";
            this.Column3.HeaderText = "日期";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "LeaveName";
            this.Column4.HeaderText = "假期类型";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Remark";
            this.Column5.HeaderText = "请假描述";
            this.Column5.Name = "Column5";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Approver";
            this.Column7.HeaderText = "批准人";
            this.Column7.Name = "Column7";
            // 
            // labIDX
            // 
            this.labIDX.AutoSize = true;
            this.labIDX.Location = new System.Drawing.Point(461, 15);
            this.labIDX.Name = "labIDX";
            this.fastSelect1.SetSelectionSource(this.labIDX, null);
            this.labIDX.Size = new System.Drawing.Size(0, 12);
            this.labIDX.TabIndex = 1;
            this.labIDX.Visible = false;
            // 
            // frmRptSpeday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 496);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmRptSpeday";
            this.Text = "frmRptSpeday";
            this.Load += new System.EventHandler(this.frmRptSpeday_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpedayLog)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXls;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnNotAll;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.Label label4;
        private FastSelect fastSelect1;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvSpedayLog;
        private System.Windows.Forms.TreeView tvUserInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label labIDX;
    }
}