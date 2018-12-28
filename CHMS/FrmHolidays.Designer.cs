namespace CHMS
{
    partial class FrmHolidays
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labHolidayid = new System.Windows.Forms.Label();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLeaveClass = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvHolidays = new System.Windows.Forms.DataGridView();
            this.holidaysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.holidayDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaveNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holidayidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaveIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHolidays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.holidaysBindingSource)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(656, 55);
            this.panel1.TabIndex = 4;
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
            this.panel2.Controls.Add(this.labHolidayid);
            this.panel2.Controls.Add(this.dtEndDate);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dtStartDate);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbLeaveClass);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(425, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 379);
            this.panel2.TabIndex = 5;
            // 
            // labHolidayid
            // 
            this.labHolidayid.AutoSize = true;
            this.labHolidayid.Location = new System.Drawing.Point(31, 137);
            this.labHolidayid.Name = "labHolidayid";
            this.labHolidayid.Size = new System.Drawing.Size(0, 12);
            this.labHolidayid.TabIndex = 15;
            this.labHolidayid.Visible = false;
            // 
            // dtEndDate
            // 
            this.dtEndDate.Location = new System.Drawing.Point(77, 83);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(130, 21);
            this.dtEndDate.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "结束日期：";
            // 
            // dtStartDate
            // 
            this.dtStartDate.Location = new System.Drawing.Point(77, 47);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(130, 21);
            this.dtStartDate.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "开始日期：";
            // 
            // cbLeaveClass
            // 
            this.cbLeaveClass.FormattingEnabled = true;
            this.cbLeaveClass.Location = new System.Drawing.Point(77, 12);
            this.cbLeaveClass.Name = "cbLeaveClass";
            this.cbLeaveClass.Size = new System.Drawing.Size(130, 20);
            this.cbLeaveClass.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "所属假期：";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvHolidays);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(425, 379);
            this.panel3.TabIndex = 6;
            // 
            // dgvHolidays
            // 
            this.dgvHolidays.AllowUserToAddRows = false;
            this.dgvHolidays.AutoGenerateColumns = false;
            this.dgvHolidays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHolidays.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.holidayDateDataGridViewTextBoxColumn,
            this.leaveNameDataGridViewTextBoxColumn,
            this.holidayidDataGridViewTextBoxColumn,
            this.leaveIdDataGridViewTextBoxColumn});
            this.dgvHolidays.DataSource = this.holidaysBindingSource;
            this.dgvHolidays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHolidays.Location = new System.Drawing.Point(0, 0);
            this.dgvHolidays.Name = "dgvHolidays";
            this.dgvHolidays.RowTemplate.Height = 23;
            this.dgvHolidays.Size = new System.Drawing.Size(425, 379);
            this.dgvHolidays.TabIndex = 0;
            this.dgvHolidays.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHolidays_CellClick);
            // 
            // holidaysBindingSource
            // 
            this.holidaysBindingSource.DataSource = typeof(Models.Holidays);
            // 
            // holidayDateDataGridViewTextBoxColumn
            // 
            this.holidayDateDataGridViewTextBoxColumn.DataPropertyName = "HolidayDate";
            this.holidayDateDataGridViewTextBoxColumn.HeaderText = "日期";
            this.holidayDateDataGridViewTextBoxColumn.Name = "holidayDateDataGridViewTextBoxColumn";
            // 
            // leaveNameDataGridViewTextBoxColumn
            // 
            this.leaveNameDataGridViewTextBoxColumn.DataPropertyName = "LeaveName";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.leaveNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.leaveNameDataGridViewTextBoxColumn.HeaderText = "假期名称";
            this.leaveNameDataGridViewTextBoxColumn.Name = "leaveNameDataGridViewTextBoxColumn";
            // 
            // holidayidDataGridViewTextBoxColumn
            // 
            this.holidayidDataGridViewTextBoxColumn.DataPropertyName = "Holidayid";
            this.holidayidDataGridViewTextBoxColumn.HeaderText = "Holidayid";
            this.holidayidDataGridViewTextBoxColumn.Name = "holidayidDataGridViewTextBoxColumn";
            this.holidayidDataGridViewTextBoxColumn.Visible = false;
            // 
            // leaveIdDataGridViewTextBoxColumn
            // 
            this.leaveIdDataGridViewTextBoxColumn.DataPropertyName = "LeaveId";
            this.leaveIdDataGridViewTextBoxColumn.HeaderText = "LeaveId";
            this.leaveIdDataGridViewTextBoxColumn.Name = "leaveIdDataGridViewTextBoxColumn";
            this.leaveIdDataGridViewTextBoxColumn.Visible = false;
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
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClose.Location = new System.Drawing.Point(321, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(107, 55);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmHolidays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 434);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmHolidays";
            this.Text = "假日录入";
            this.Load += new System.EventHandler(this.frmHolidays_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHolidays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.holidaysBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvHolidays;
        private System.Windows.Forms.ComboBox cbLeaveClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource holidaysBindingSource;
        private System.Windows.Forms.Label labHolidayid;
        private System.Windows.Forms.DataGridViewTextBoxColumn holidayDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaveNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn holidayidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaveIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
    }
}