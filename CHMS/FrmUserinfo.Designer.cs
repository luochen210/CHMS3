namespace CHMS
{
    partial class FrmUserinfo
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvUserinfo = new System.Windows.Forms.DataGridView();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtAtt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.dtHiredday = new System.Windows.Forms.DateTimePicker();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.dtBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbDefaultdept = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSsn = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOfficePhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNationality = new System.Windows.Forms.TextBox();
            this.txtAttNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserinfo)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(814, 54);
            this.panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClose.Location = new System.Drawing.Point(321, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(107, 54);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDelete.Location = new System.Drawing.Point(214, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 54);
            this.btnDelete.TabIndex = 4;
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
            this.btnSave.TabIndex = 3;
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
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(814, 488);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvUserinfo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(417, 488);
            this.panel4.TabIndex = 1;
            // 
            // dgvUserinfo
            // 
            this.dgvUserinfo.AllowUserToAddRows = false;
            this.dgvUserinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserinfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.UserName,
            this.AttNumber,
            this.Mobile});
            this.dgvUserinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUserinfo.Location = new System.Drawing.Point(0, 0);
            this.dgvUserinfo.Name = "dgvUserinfo";
            this.dgvUserinfo.RowTemplate.Height = 23;
            this.dgvUserinfo.Size = new System.Drawing.Size(417, 488);
            this.dgvUserinfo.TabIndex = 1;
            this.dgvUserinfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserinfo_CellClick);
            // 
            // UserID
            // 
            this.UserID.DataPropertyName = "UserID";
            this.UserID.HeaderText = "编号";
            this.UserID.Name = "UserID";
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "Name";
            this.UserName.HeaderText = "姓名";
            this.UserName.Name = "UserName";
            // 
            // AttNumber
            // 
            this.AttNumber.DataPropertyName = "AttNumber";
            this.AttNumber.HeaderText = "卡内码";
            this.AttNumber.Name = "AttNumber";
            // 
            // Mobile
            // 
            this.Mobile.DataPropertyName = "Mobile";
            this.Mobile.HeaderText = "联系电话";
            this.Mobile.Name = "Mobile";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtAtt);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.cbRole);
            this.panel3.Controls.Add(this.dtHiredday);
            this.panel3.Controls.Add(this.cbGender);
            this.panel3.Controls.Add(this.dtBirthday);
            this.panel3.Controls.Add(this.txtPassword);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.cbDefaultdept);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtAddress);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.txtMobile);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txtSsn);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtTitle);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtOfficePhone);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtNationality);
            this.panel3.Controls.Add(this.txtAttNumber);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtName);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtUserID);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(417, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(397, 488);
            this.panel3.TabIndex = 0;
            // 
            // txtAtt
            // 
            this.txtAtt.BackColor = System.Drawing.Color.White;
            this.txtAtt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAtt.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAtt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAtt.Location = new System.Drawing.Point(76, 114);
            this.txtAtt.Name = "txtAtt";
            this.txtAtt.Size = new System.Drawing.Size(117, 23);
            this.txtAtt.TabIndex = 73;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(30, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 14);
            this.label13.TabIndex = 74;
            this.label13.Text = "工号:";
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(271, 190);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(116, 20);
            this.cbRole.TabIndex = 72;
            // 
            // dtHiredday
            // 
            this.dtHiredday.Location = new System.Drawing.Point(271, 154);
            this.dtHiredday.Name = "dtHiredday";
            this.dtHiredday.Size = new System.Drawing.Size(117, 21);
            this.dtHiredday.TabIndex = 70;
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(271, 42);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(117, 20);
            this.cbGender.TabIndex = 69;
            // 
            // dtBirthday
            // 
            this.dtBirthday.Location = new System.Drawing.Point(76, 190);
            this.dtBirthday.Name = "dtBirthday";
            this.dtBirthday.Size = new System.Drawing.Size(117, 21);
            this.dtBirthday.TabIndex = 68;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassword.Location = new System.Drawing.Point(271, 223);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(117, 23);
            this.txtPassword.TabIndex = 67;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(225, 226);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 14);
            this.label16.TabIndex = 66;
            this.label16.Text = "密码:";
            // 
            // cbDefaultdept
            // 
            this.cbDefaultdept.FormattingEnabled = true;
            this.cbDefaultdept.Location = new System.Drawing.Point(76, 226);
            this.cbDefaultdept.Name = "cbDefaultdept";
            this.cbDefaultdept.Size = new System.Drawing.Size(117, 20);
            this.cbDefaultdept.TabIndex = 65;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(2, 229);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 14);
            this.label15.TabIndex = 64;
            this.label15.Text = "所属部门:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(225, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 14);
            this.label5.TabIndex = 56;
            this.label5.Text = "民族:";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAddress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAddress.Location = new System.Drawing.Point(76, 293);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(312, 23);
            this.txtAddress.TabIndex = 54;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(2, 296);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 14);
            this.label14.TabIndex = 55;
            this.label14.Text = "家庭住址:";
            // 
            // txtMobile
            // 
            this.txtMobile.BackColor = System.Drawing.Color.White;
            this.txtMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMobile.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMobile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMobile.Location = new System.Drawing.Point(271, 117);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(117, 23);
            this.txtMobile.TabIndex = 52;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(225, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 14);
            this.label11.TabIndex = 53;
            this.label11.Text = "手机:";
            // 
            // txtSsn
            // 
            this.txtSsn.BackColor = System.Drawing.Color.White;
            this.txtSsn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSsn.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSsn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSsn.Location = new System.Drawing.Point(76, 261);
            this.txtSsn.Name = "txtSsn";
            this.txtSsn.Size = new System.Drawing.Size(312, 23);
            this.txtSsn.TabIndex = 50;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(16, 268);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 14);
            this.label12.TabIndex = 51;
            this.label12.Text = "身份证:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(197, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 14);
            this.label9.TabIndex = 49;
            this.label9.Text = "聘用日期:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(2, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 14);
            this.label10.TabIndex = 47;
            this.label10.Text = "出生日期:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(211, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 14);
            this.label6.TabIndex = 45;
            this.label6.Text = "权限组:";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.White;
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTitle.Location = new System.Drawing.Point(76, 152);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(117, 23);
            this.txtTitle.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(30, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 14);
            this.label8.TabIndex = 43;
            this.label8.Text = "职务:";
            // 
            // txtOfficePhone
            // 
            this.txtOfficePhone.BackColor = System.Drawing.Color.White;
            this.txtOfficePhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOfficePhone.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOfficePhone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtOfficePhone.Location = new System.Drawing.Point(271, 80);
            this.txtOfficePhone.Name = "txtOfficePhone";
            this.txtOfficePhone.Size = new System.Drawing.Size(117, 23);
            this.txtOfficePhone.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(197, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 14);
            this.label4.TabIndex = 41;
            this.label4.Text = "办公电话:";
            // 
            // txtNationality
            // 
            this.txtNationality.BackColor = System.Drawing.Color.White;
            this.txtNationality.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNationality.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNationality.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNationality.Location = new System.Drawing.Point(271, 3);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.Size = new System.Drawing.Size(117, 23);
            this.txtNationality.TabIndex = 38;
            // 
            // txtAttNumber
            // 
            this.txtAttNumber.BackColor = System.Drawing.Color.White;
            this.txtAttNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAttNumber.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAttNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAttNumber.Location = new System.Drawing.Point(76, 77);
            this.txtAttNumber.Name = "txtAttNumber";
            this.txtAttNumber.Size = new System.Drawing.Size(117, 23);
            this.txtAttNumber.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(16, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 14);
            this.label2.TabIndex = 37;
            this.label2.Text = "卡内码:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(225, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 14);
            this.label3.TabIndex = 35;
            this.label3.Text = "性别:";
            // 
            // txtName
            // 
            this.txtName.AcceptsReturn = true;
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtName.Location = new System.Drawing.Point(76, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(117, 23);
            this.txtName.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(24, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 33;
            this.label1.Text = "*姓名:";
            // 
            // txtUserID
            // 
            this.txtUserID.BackColor = System.Drawing.Color.White;
            this.txtUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserID.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUserID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUserID.Location = new System.Drawing.Point(76, 5);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(117, 23);
            this.txtUserID.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(23, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 14);
            this.label7.TabIndex = 31;
            this.label7.Text = "*编号:";
            // 
            // FrmUserinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 542);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmUserinfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "人员信息设置";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmUserinfo_FormClosed);
            this.Load += new System.EventHandler(this.frmUserinfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserinfo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvUserinfo;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSsn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOfficePhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNationality;
        private System.Windows.Forms.TextBox txtAttNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbDefaultdept;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtBirthday;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.DateTimePicker dtHiredday;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.TextBox txtAtt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
    }
}