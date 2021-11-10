namespace HMS.childForm
{
    partial class childForm_reservation
    {
        /// <summary>
        ///// Required designer variable.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(childForm_reservation));
            this.pal_Left = new System.Windows.Forms.Panel();
            this.pal_Bottom = new System.Windows.Forms.Panel();
            this.pal_Top = new System.Windows.Forms.Panel();
            this.pal_Right = new System.Windows.Forms.Panel();
            this.ucButton_Submit = new HMS.UCButton();
            this.ucButton_empty = new HMS.UCButton();
            this.lab_Divider = new System.Windows.Forms.Label();
            this.lab_title = new System.Windows.Forms.Label();
            this.dgv_RoomData = new System.Windows.Forms.DataGridView();
            this.RoomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomStatusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_UserData = new System.Windows.Forms.GroupBox();
            this.pal_Data = new System.Windows.Forms.Panel();
            this.groupBox_1 = new System.Windows.Forms.GroupBox();
            this.pal_Sex = new System.Windows.Forms.Panel();
            this.rdo_Mr = new System.Windows.Forms.RadioButton();
            this.rdo_Ms = new System.Windows.Forms.RadioButton();
            this.lab_CardId = new System.Windows.Forms.Label();
            this.lab_Phone = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lab_Sex = new System.Windows.Forms.Label();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.lab_Name = new System.Windows.Forms.Label();
            this.txt_CardId = new System.Windows.Forms.TextBox();
            this.groupBox_2 = new System.Windows.Forms.GroupBox();
            this.lab_CheckInTime = new System.Windows.Forms.Label();
            this.date_CheckInTime = new System.Windows.Forms.MonthCalendar();
            this.lab_RoomType = new System.Windows.Forms.Label();
            this.cob_RoomType = new System.Windows.Forms.ComboBox();
            this.txt_RoomId = new System.Windows.Forms.TextBox();
            this.lab_RoomPrice = new System.Windows.Forms.Label();
            this.lab_RoomId = new System.Windows.Forms.Label();
            this.txt_RoomPrice = new System.Windows.Forms.TextBox();
            this.groupBox_RoomData = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RoomData)).BeginInit();
            this.groupBox_UserData.SuspendLayout();
            this.pal_Data.SuspendLayout();
            this.groupBox_1.SuspendLayout();
            this.pal_Sex.SuspendLayout();
            this.groupBox_2.SuspendLayout();
            this.groupBox_RoomData.SuspendLayout();
            this.SuspendLayout();
            // 
            // pal_Left
            // 
            this.pal_Left.Location = new System.Drawing.Point(0, 0);
            this.pal_Left.Name = "pal_Left";
            this.pal_Left.Size = new System.Drawing.Size(50, 1030);
            this.pal_Left.TabIndex = 0;
            // 
            // pal_Bottom
            // 
            this.pal_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pal_Bottom.Location = new System.Drawing.Point(0, 1000);
            this.pal_Bottom.Name = "pal_Bottom";
            this.pal_Bottom.Size = new System.Drawing.Size(1660, 30);
            this.pal_Bottom.TabIndex = 2;
            // 
            // pal_Top
            // 
            this.pal_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pal_Top.Location = new System.Drawing.Point(0, 0);
            this.pal_Top.Name = "pal_Top";
            this.pal_Top.Size = new System.Drawing.Size(1660, 30);
            this.pal_Top.TabIndex = 1;
            // 
            // pal_Right
            // 
            this.pal_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.pal_Right.Location = new System.Drawing.Point(1660, 0);
            this.pal_Right.Name = "pal_Right";
            this.pal_Right.Size = new System.Drawing.Size(50, 1030);
            this.pal_Right.TabIndex = 1;
            // 
            // ucButton_Submit
            // 
            this.ucButton_Submit.BackColor = System.Drawing.Color.Transparent;
            this.ucButton_Submit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucButton_Submit.BackgroundImage")));
            this.ucButton_Submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ucButton_Submit.Location = new System.Drawing.Point(1336, 877);
            this.ucButton_Submit.Name = "ucButton_Submit";
            this.ucButton_Submit.Size = new System.Drawing.Size(85, 45);
            this.ucButton_Submit.TabIndex = 27;
            this.ucButton_Submit.Click += new System.EventHandler(this.ucButton_submit_Click);
            // 
            // ucButton_empty
            // 
            this.ucButton_empty.BackColor = System.Drawing.Color.Transparent;
            this.ucButton_empty.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucButton_empty.BackgroundImage")));
            this.ucButton_empty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ucButton_empty.Location = new System.Drawing.Point(1549, 877);
            this.ucButton_empty.Name = "ucButton_empty";
            this.ucButton_empty.Size = new System.Drawing.Size(85, 45);
            this.ucButton_empty.TabIndex = 28;
            this.ucButton_empty.Click += new System.EventHandler(this.ucButton_empty_Click);
            // 
            // lab_Divider
            // 
            this.lab_Divider.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lab_Divider.Location = new System.Drawing.Point(74, 81);
            this.lab_Divider.Name = "lab_Divider";
            this.lab_Divider.Size = new System.Drawing.Size(1560, 2);
            this.lab_Divider.TabIndex = 29;
            // 
            // lab_title
            // 
            this.lab_title.AutoSize = true;
            this.lab_title.Font = new System.Drawing.Font("微软雅黑 Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lab_title.Location = new System.Drawing.Point(161, 60);
            this.lab_title.Name = "lab_title";
            this.lab_title.Size = new System.Drawing.Size(127, 36);
            this.lab_title.TabIndex = 30;
            this.lab_title.Text = "客房预定";
            // 
            // dgv_RoomData
            // 
            this.dgv_RoomData.AllowUserToAddRows = false;
            this.dgv_RoomData.AllowUserToResizeColumns = false;
            this.dgv_RoomData.AllowUserToResizeRows = false;
            this.dgv_RoomData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_RoomData.BackgroundColor = System.Drawing.Color.White;
            this.dgv_RoomData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_RoomData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_RoomData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomId,
            this.RoomTypeName,
            this.RoomPrice,
            this.RoomStatusName});
            this.dgv_RoomData.Location = new System.Drawing.Point(22, 40);
            this.dgv_RoomData.Name = "dgv_RoomData";
            this.dgv_RoomData.ReadOnly = true;
            this.dgv_RoomData.RowHeadersVisible = false;
            this.dgv_RoomData.RowHeadersWidth = 51;
            this.dgv_RoomData.RowTemplate.Height = 29;
            this.dgv_RoomData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_RoomData.Size = new System.Drawing.Size(492, 637);
            this.dgv_RoomData.TabIndex = 54;
            this.dgv_RoomData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_RoomData_CellContentClick);
            // 
            // RoomId
            // 
            this.RoomId.DataPropertyName = "RoomId";
            this.RoomId.HeaderText = "房号";
            this.RoomId.MinimumWidth = 6;
            this.RoomId.Name = "RoomId";
            this.RoomId.ReadOnly = true;
            // 
            // RoomTypeName
            // 
            this.RoomTypeName.DataPropertyName = "RoomTypeName";
            this.RoomTypeName.HeaderText = "房间类型";
            this.RoomTypeName.MinimumWidth = 6;
            this.RoomTypeName.Name = "RoomTypeName";
            this.RoomTypeName.ReadOnly = true;
            // 
            // RoomPrice
            // 
            this.RoomPrice.DataPropertyName = "RoomPrice";
            this.RoomPrice.HeaderText = "房间价格";
            this.RoomPrice.MinimumWidth = 6;
            this.RoomPrice.Name = "RoomPrice";
            this.RoomPrice.ReadOnly = true;
            // 
            // RoomStatusName
            // 
            this.RoomStatusName.DataPropertyName = "RoomStatusName";
            this.RoomStatusName.HeaderText = "房间状态";
            this.RoomStatusName.MinimumWidth = 6;
            this.RoomStatusName.Name = "RoomStatusName";
            this.RoomStatusName.ReadOnly = true;
            // 
            // groupBox_UserData
            // 
            this.groupBox_UserData.Controls.Add(this.pal_Data);
            this.groupBox_UserData.Location = new System.Drawing.Point(74, 137);
            this.groupBox_UserData.Name = "groupBox_UserData";
            this.groupBox_UserData.Size = new System.Drawing.Size(994, 692);
            this.groupBox_UserData.TabIndex = 90;
            this.groupBox_UserData.TabStop = false;
            this.groupBox_UserData.Text = "住客信息表";
            // 
            // pal_Data
            // 
            this.pal_Data.Controls.Add(this.groupBox_1);
            this.pal_Data.Controls.Add(this.groupBox_2);
            this.pal_Data.Location = new System.Drawing.Point(17, 40);
            this.pal_Data.Name = "pal_Data";
            this.pal_Data.Size = new System.Drawing.Size(959, 632);
            this.pal_Data.TabIndex = 89;
            // 
            // groupBox_1
            // 
            this.groupBox_1.Controls.Add(this.pal_Sex);
            this.groupBox_1.Controls.Add(this.lab_CardId);
            this.groupBox_1.Controls.Add(this.lab_Phone);
            this.groupBox_1.Controls.Add(this.txt_Name);
            this.groupBox_1.Controls.Add(this.lab_Sex);
            this.groupBox_1.Controls.Add(this.txt_Phone);
            this.groupBox_1.Controls.Add(this.lab_Name);
            this.groupBox_1.Controls.Add(this.txt_CardId);
            this.groupBox_1.Location = new System.Drawing.Point(26, 24);
            this.groupBox_1.Name = "groupBox_1";
            this.groupBox_1.Size = new System.Drawing.Size(904, 250);
            this.groupBox_1.TabIndex = 90;
            this.groupBox_1.TabStop = false;
            this.groupBox_1.Text = "用户基本信息";
            // 
            // pal_Sex
            // 
            this.pal_Sex.Controls.Add(this.rdo_Mr);
            this.pal_Sex.Controls.Add(this.rdo_Ms);
            this.pal_Sex.Location = new System.Drawing.Point(113, 129);
            this.pal_Sex.Name = "pal_Sex";
            this.pal_Sex.Size = new System.Drawing.Size(262, 29);
            this.pal_Sex.TabIndex = 95;
            // 
            // rdo_Mr
            // 
            this.rdo_Mr.AutoSize = true;
            this.rdo_Mr.Checked = true;
            this.rdo_Mr.Location = new System.Drawing.Point(34, 3);
            this.rdo_Mr.Name = "rdo_Mr";
            this.rdo_Mr.Size = new System.Drawing.Size(60, 24);
            this.rdo_Mr.TabIndex = 32;
            this.rdo_Mr.TabStop = true;
            this.rdo_Mr.Text = "先生";
            this.rdo_Mr.UseVisualStyleBackColor = true;
            // 
            // rdo_Ms
            // 
            this.rdo_Ms.AutoSize = true;
            this.rdo_Ms.Location = new System.Drawing.Point(149, 2);
            this.rdo_Ms.Name = "rdo_Ms";
            this.rdo_Ms.Size = new System.Drawing.Size(60, 24);
            this.rdo_Ms.TabIndex = 33;
            this.rdo_Ms.TabStop = true;
            this.rdo_Ms.Text = "女士";
            this.rdo_Ms.UseVisualStyleBackColor = true;
            // 
            // lab_CardId
            // 
            this.lab_CardId.AutoSize = true;
            this.lab_CardId.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lab_CardId.Location = new System.Drawing.Point(477, 134);
            this.lab_CardId.Name = "lab_CardId";
            this.lab_CardId.Size = new System.Drawing.Size(78, 23);
            this.lab_CardId.TabIndex = 93;
            this.lab_CardId.Text = "身份证号";
            // 
            // lab_Phone
            // 
            this.lab_Phone.AutoSize = true;
            this.lab_Phone.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lab_Phone.Location = new System.Drawing.Point(511, 83);
            this.lab_Phone.Name = "lab_Phone";
            this.lab_Phone.Size = new System.Drawing.Size(44, 23);
            this.lab_Phone.TabIndex = 94;
            this.lab_Phone.Text = "手机";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(113, 79);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(262, 27);
            this.txt_Name.TabIndex = 96;
            // 
            // lab_Sex
            // 
            this.lab_Sex.AutoSize = true;
            this.lab_Sex.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lab_Sex.Location = new System.Drawing.Point(63, 135);
            this.lab_Sex.Name = "lab_Sex";
            this.lab_Sex.Size = new System.Drawing.Size(44, 23);
            this.lab_Sex.TabIndex = 92;
            this.lab_Sex.Text = "性别";
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(561, 79);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(262, 27);
            this.txt_Phone.TabIndex = 97;
            // 
            // lab_Name
            // 
            this.lab_Name.AutoSize = true;
            this.lab_Name.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lab_Name.Location = new System.Drawing.Point(63, 79);
            this.lab_Name.Name = "lab_Name";
            this.lab_Name.Size = new System.Drawing.Size(44, 23);
            this.lab_Name.TabIndex = 91;
            this.lab_Name.Text = "姓名";
            // 
            // txt_CardId
            // 
            this.txt_CardId.Location = new System.Drawing.Point(561, 134);
            this.txt_CardId.Name = "txt_CardId";
            this.txt_CardId.Size = new System.Drawing.Size(262, 27);
            this.txt_CardId.TabIndex = 98;
            // 
            // groupBox_2
            // 
            this.groupBox_2.Controls.Add(this.lab_CheckInTime);
            this.groupBox_2.Controls.Add(this.date_CheckInTime);
            this.groupBox_2.Controls.Add(this.lab_RoomType);
            this.groupBox_2.Controls.Add(this.cob_RoomType);
            this.groupBox_2.Controls.Add(this.txt_RoomId);
            this.groupBox_2.Controls.Add(this.lab_RoomPrice);
            this.groupBox_2.Controls.Add(this.lab_RoomId);
            this.groupBox_2.Controls.Add(this.txt_RoomPrice);
            this.groupBox_2.Location = new System.Drawing.Point(26, 302);
            this.groupBox_2.Name = "groupBox_2";
            this.groupBox_2.Size = new System.Drawing.Size(904, 298);
            this.groupBox_2.TabIndex = 91;
            this.groupBox_2.TabStop = false;
            this.groupBox_2.Text = "房间预定信息";
            // 
            // lab_CheckInTime
            // 
            this.lab_CheckInTime.AutoSize = true;
            this.lab_CheckInTime.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lab_CheckInTime.Location = new System.Drawing.Point(477, 53);
            this.lab_CheckInTime.Name = "lab_CheckInTime";
            this.lab_CheckInTime.Size = new System.Drawing.Size(78, 23);
            this.lab_CheckInTime.TabIndex = 106;
            this.lab_CheckInTime.Text = "入住时间";
            // 
            // date_CheckInTime
            // 
            this.date_CheckInTime.Location = new System.Drawing.Point(561, 52);
            this.date_CheckInTime.Name = "date_CheckInTime";
            this.date_CheckInTime.TabIndex = 105;
            // 
            // lab_RoomType
            // 
            this.lab_RoomType.AutoSize = true;
            this.lab_RoomType.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lab_RoomType.Location = new System.Drawing.Point(29, 58);
            this.lab_RoomType.Name = "lab_RoomType";
            this.lab_RoomType.Size = new System.Drawing.Size(78, 23);
            this.lab_RoomType.TabIndex = 99;
            this.lab_RoomType.Text = "房间类型";
            // 
            // cob_RoomType
            // 
            this.cob_RoomType.FormattingEnabled = true;
            this.cob_RoomType.Location = new System.Drawing.Point(113, 53);
            this.cob_RoomType.Name = "cob_RoomType";
            this.cob_RoomType.Size = new System.Drawing.Size(262, 28);
            this.cob_RoomType.TabIndex = 100;
            this.cob_RoomType.SelectedIndexChanged += new System.EventHandler(this.cob_RoomType_SelectedIndexChanged);
            // 
            // txt_RoomId
            // 
            this.txt_RoomId.Location = new System.Drawing.Point(113, 108);
            this.txt_RoomId.Name = "txt_RoomId";
            this.txt_RoomId.ReadOnly = true;
            this.txt_RoomId.Size = new System.Drawing.Size(262, 27);
            this.txt_RoomId.TabIndex = 102;
            // 
            // lab_RoomPrice
            // 
            this.lab_RoomPrice.AutoSize = true;
            this.lab_RoomPrice.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lab_RoomPrice.Location = new System.Drawing.Point(63, 163);
            this.lab_RoomPrice.Name = "lab_RoomPrice";
            this.lab_RoomPrice.Size = new System.Drawing.Size(44, 23);
            this.lab_RoomPrice.TabIndex = 103;
            this.lab_RoomPrice.Text = "价格";
            // 
            // lab_RoomId
            // 
            this.lab_RoomId.AutoSize = true;
            this.lab_RoomId.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lab_RoomId.Location = new System.Drawing.Point(63, 112);
            this.lab_RoomId.Name = "lab_RoomId";
            this.lab_RoomId.Size = new System.Drawing.Size(44, 23);
            this.lab_RoomId.TabIndex = 90;
            this.lab_RoomId.Text = "房号";
            // 
            // txt_RoomPrice
            // 
            this.txt_RoomPrice.Location = new System.Drawing.Point(113, 159);
            this.txt_RoomPrice.Name = "txt_RoomPrice";
            this.txt_RoomPrice.ReadOnly = true;
            this.txt_RoomPrice.Size = new System.Drawing.Size(262, 27);
            this.txt_RoomPrice.TabIndex = 104;
            // 
            // groupBox_RoomData
            // 
            this.groupBox_RoomData.Controls.Add(this.dgv_RoomData);
            this.groupBox_RoomData.Location = new System.Drawing.Point(1101, 137);
            this.groupBox_RoomData.Name = "groupBox_RoomData";
            this.groupBox_RoomData.Size = new System.Drawing.Size(533, 692);
            this.groupBox_RoomData.TabIndex = 91;
            this.groupBox_RoomData.TabStop = false;
            this.groupBox_RoomData.Text = "房价表";
            // 
            // childForm_reservation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1710, 1030);
            this.Controls.Add(this.groupBox_UserData);
            this.Controls.Add(this.groupBox_RoomData);
            this.Controls.Add(this.lab_title);
            this.Controls.Add(this.lab_Divider);
            this.Controls.Add(this.ucButton_empty);
            this.Controls.Add(this.ucButton_Submit);
            this.Controls.Add(this.pal_Left);
            this.Controls.Add(this.pal_Bottom);
            this.Controls.Add(this.pal_Top);
            this.Controls.Add(this.pal_Right);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "childForm_reservation";
            this.Text = "EditGuestData";
            this.Load += new System.EventHandler(this.childForm_reservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RoomData)).EndInit();
            this.groupBox_UserData.ResumeLayout(false);
            this.pal_Data.ResumeLayout(false);
            this.groupBox_1.ResumeLayout(false);
            this.groupBox_1.PerformLayout();
            this.pal_Sex.ResumeLayout(false);
            this.pal_Sex.PerformLayout();
            this.groupBox_2.ResumeLayout(false);
            this.groupBox_2.PerformLayout();
            this.groupBox_RoomData.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pal_Left;
        private System.Windows.Forms.Panel pal_Bottom;
        private System.Windows.Forms.Panel pal_Top;
        private System.Windows.Forms.Panel pal_Right;
        private UCButton ucButton_Submit;
        private UCButton ucButton_empty;
        private System.Windows.Forms.Label lab_Divider;
        private System.Windows.Forms.Label lab_title;
        private System.Windows.Forms.DataGridView dgv_RoomData;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomStatusName;
        private System.Windows.Forms.GroupBox groupBox_UserData;
        private System.Windows.Forms.GroupBox groupBox_RoomData;
        private System.Windows.Forms.Panel pal_Data;
        private System.Windows.Forms.GroupBox groupBox_1;
        private System.Windows.Forms.Panel pal_Sex;
        private System.Windows.Forms.RadioButton rdo_Mr;
        private System.Windows.Forms.RadioButton rdo_Ms;
        private System.Windows.Forms.Label lab_CardId;
        private System.Windows.Forms.Label lab_Phone;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lab_Sex;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.Label lab_Name;
        private System.Windows.Forms.TextBox txt_CardId;
        private System.Windows.Forms.GroupBox groupBox_2;
        private System.Windows.Forms.Label lab_RoomType;
        private System.Windows.Forms.ComboBox cob_RoomType;
        private System.Windows.Forms.TextBox txt_RoomId;
        private System.Windows.Forms.Label lab_RoomPrice;
        private System.Windows.Forms.Label lab_RoomId;
        private System.Windows.Forms.TextBox txt_RoomPrice;
        private System.Windows.Forms.Label lab_CheckInTime;
        private System.Windows.Forms.MonthCalendar date_CheckInTime;
    }
}