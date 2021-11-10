namespace HMS.childForm
{
    partial class childForm_customerData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(childForm_customerData));
            this.pal_Left = new System.Windows.Forms.Panel();
            this.pal_Bottom = new System.Windows.Forms.Panel();
            this.pal_Top = new System.Windows.Forms.Panel();
            this.pal_Right = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ucButton_Empty = new HMS.UCButton();
            this.cob_OrderStatus = new System.Windows.Forms.ComboBox();
            this.lab_OrderStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ucButton_Query = new HMS.UCButton();
            this.dgv_CustomerData = new System.Windows.Forms.DataGridView();
            this.RecordId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckInTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckOutTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdeStatusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_OrderId = new System.Windows.Forms.TextBox();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.txt_CardId = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lab_OrderId = new System.Windows.Forms.Label();
            this.lab_CardId = new System.Windows.Forms.Label();
            this.lab_Phone = new System.Windows.Forms.Label();
            this.lab_Name = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CustomerData)).BeginInit();
            this.SuspendLayout();
            // 
            // pal_Left
            // 
            this.pal_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pal_Left.Location = new System.Drawing.Point(0, 0);
            this.pal_Left.Name = "pal_Left";
            this.pal_Left.Size = new System.Drawing.Size(50, 1030);
            this.pal_Left.TabIndex = 0;
            // 
            // pal_Bottom
            // 
            this.pal_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pal_Bottom.Location = new System.Drawing.Point(50, 1000);
            this.pal_Bottom.Name = "pal_Bottom";
            this.pal_Bottom.Size = new System.Drawing.Size(1610, 30);
            this.pal_Bottom.TabIndex = 2;
            // 
            // pal_Top
            // 
            this.pal_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pal_Top.Location = new System.Drawing.Point(50, 0);
            this.pal_Top.Name = "pal_Top";
            this.pal_Top.Size = new System.Drawing.Size(1610, 30);
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
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ucButton_Empty);
            this.groupBox1.Controls.Add(this.cob_OrderStatus);
            this.groupBox1.Controls.Add(this.lab_OrderStatus);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ucButton_Query);
            this.groupBox1.Controls.Add(this.dgv_CustomerData);
            this.groupBox1.Controls.Add(this.txt_OrderId);
            this.groupBox1.Controls.Add(this.txt_Phone);
            this.groupBox1.Controls.Add(this.txt_CardId);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Controls.Add(this.lab_OrderId);
            this.groupBox1.Controls.Add(this.lab_CardId);
            this.groupBox1.Controls.Add(this.lab_Phone);
            this.groupBox1.Controls.Add(this.lab_Name);
            this.groupBox1.Location = new System.Drawing.Point(56, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1598, 945);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "客房记录";
            // 
            // ucButton_Empty
            // 
            this.ucButton_Empty.BackColor = System.Drawing.Color.Transparent;
            this.ucButton_Empty.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucButton_Empty.BackgroundImage")));
            this.ucButton_Empty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ucButton_Empty.Location = new System.Drawing.Point(1493, 26);
            this.ucButton_Empty.Name = "ucButton_Empty";
            this.ucButton_Empty.Size = new System.Drawing.Size(85, 45);
            this.ucButton_Empty.TabIndex = 97;
            this.ucButton_Empty.Click += new System.EventHandler(this.ucButton_Empty_Click);
            // 
            // cob_OrderStatus
            // 
            this.cob_OrderStatus.FormattingEnabled = true;
            this.cob_OrderStatus.Location = new System.Drawing.Point(367, 42);
            this.cob_OrderStatus.Name = "cob_OrderStatus";
            this.cob_OrderStatus.Size = new System.Drawing.Size(125, 28);
            this.cob_OrderStatus.TabIndex = 96;
            // 
            // lab_OrderStatus
            // 
            this.lab_OrderStatus.AutoSize = true;
            this.lab_OrderStatus.Location = new System.Drawing.Point(292, 46);
            this.lab_OrderStatus.Name = "lab_OrderStatus";
            this.lab_OrderStatus.Size = new System.Drawing.Size(69, 20);
            this.lab_OrderStatus.TabIndex = 95;
            this.lab_OrderStatus.Text = "订单状态";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(707, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 94;
            this.label1.Text = "(支持模糊)";
            // 
            // ucButton_Query
            // 
            this.ucButton_Query.BackColor = System.Drawing.Color.Transparent;
            this.ucButton_Query.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucButton_Query.BackgroundImage")));
            this.ucButton_Query.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ucButton_Query.Location = new System.Drawing.Point(1345, 26);
            this.ucButton_Query.Name = "ucButton_Query";
            this.ucButton_Query.Size = new System.Drawing.Size(85, 45);
            this.ucButton_Query.TabIndex = 93;
            this.ucButton_Query.Click += new System.EventHandler(this.ucButton_Query_Click);
            // 
            // dgv_CustomerData
            // 
            this.dgv_CustomerData.AllowUserToAddRows = false;
            this.dgv_CustomerData.AllowUserToResizeColumns = false;
            this.dgv_CustomerData.AllowUserToResizeRows = false;
            this.dgv_CustomerData.BackgroundColor = System.Drawing.Color.White;
            this.dgv_CustomerData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_CustomerData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CustomerData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RecordId,
            this.Name_,
            this.Sex,
            this.Phone,
            this.CardId,
            this.RoomId,
            this.CheckInTime,
            this.CheckOutTime,
            this.OrdeStatusName,
            this.PaymentAmount});
            this.dgv_CustomerData.Location = new System.Drawing.Point(18, 95);
            this.dgv_CustomerData.Name = "dgv_CustomerData";
            this.dgv_CustomerData.ReadOnly = true;
            this.dgv_CustomerData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_CustomerData.RowHeadersVisible = false;
            this.dgv_CustomerData.RowHeadersWidth = 51;
            this.dgv_CustomerData.RowTemplate.Height = 29;
            this.dgv_CustomerData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_CustomerData.Size = new System.Drawing.Size(1560, 828);
            this.dgv_CustomerData.TabIndex = 92;
            // 
            // RecordId
            // 
            this.RecordId.DataPropertyName = "RecordId";
            this.RecordId.FillWeight = 100.3135F;
            this.RecordId.HeaderText = "订单号";
            this.RecordId.MinimumWidth = 6;
            this.RecordId.Name = "RecordId";
            this.RecordId.ReadOnly = true;
            this.RecordId.Width = 182;
            // 
            // Name_
            // 
            this.Name_.DataPropertyName = "Name";
            this.Name_.FillWeight = 99.65836F;
            this.Name_.HeaderText = "姓名";
            this.Name_.MinimumWidth = 6;
            this.Name_.Name = "Name_";
            this.Name_.ReadOnly = true;
            this.Name_.Width = 155;
            // 
            // Sex
            // 
            this.Sex.DataPropertyName = "Sex";
            this.Sex.FillWeight = 100.3225F;
            this.Sex.HeaderText = "性别";
            this.Sex.MinimumWidth = 6;
            this.Sex.Name = "Sex";
            this.Sex.ReadOnly = true;
            this.Sex.Width = 80;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.FillWeight = 99.66638F;
            this.Phone.HeaderText = "手机号";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Width = 165;
            // 
            // CardId
            // 
            this.CardId.DataPropertyName = "CardId";
            this.CardId.FillWeight = 100.3298F;
            this.CardId.HeaderText = "身份证号";
            this.CardId.MinimumWidth = 6;
            this.CardId.Name = "CardId";
            this.CardId.ReadOnly = true;
            this.CardId.Width = 220;
            // 
            // RoomId
            // 
            this.RoomId.DataPropertyName = "RoomId";
            this.RoomId.FillWeight = 99.67291F;
            this.RoomId.HeaderText = "房号";
            this.RoomId.MinimumWidth = 6;
            this.RoomId.Name = "RoomId";
            this.RoomId.ReadOnly = true;
            this.RoomId.Width = 110;
            // 
            // CheckInTime
            // 
            this.CheckInTime.DataPropertyName = "CheckInTime";
            this.CheckInTime.FillWeight = 99.67817F;
            this.CheckInTime.HeaderText = "入住时间";
            this.CheckInTime.MinimumWidth = 6;
            this.CheckInTime.Name = "CheckInTime";
            this.CheckInTime.ReadOnly = true;
            this.CheckInTime.Width = 200;
            // 
            // CheckOutTime
            // 
            this.CheckOutTime.DataPropertyName = "CheckOutTime";
            this.CheckOutTime.FillWeight = 100.3405F;
            this.CheckOutTime.HeaderText = "退房时间";
            this.CheckOutTime.MinimumWidth = 6;
            this.CheckOutTime.Name = "CheckOutTime";
            this.CheckOutTime.ReadOnly = true;
            this.CheckOutTime.Width = 200;
            // 
            // OrdeStatusName
            // 
            this.OrdeStatusName.DataPropertyName = "OrdeStatusName";
            this.OrdeStatusName.FillWeight = 99.68243F;
            this.OrdeStatusName.HeaderText = "订单状态";
            this.OrdeStatusName.MinimumWidth = 6;
            this.OrdeStatusName.Name = "OrdeStatusName";
            this.OrdeStatusName.ReadOnly = true;
            this.OrdeStatusName.Width = 125;
            // 
            // PaymentAmount
            // 
            this.PaymentAmount.DataPropertyName = "PaymentAmount";
            this.PaymentAmount.HeaderText = "消费金额";
            this.PaymentAmount.MinimumWidth = 6;
            this.PaymentAmount.Name = "PaymentAmount";
            this.PaymentAmount.ReadOnly = true;
            this.PaymentAmount.Width = 120;
            // 
            // txt_OrderId
            // 
            this.txt_OrderId.Location = new System.Drawing.Point(99, 43);
            this.txt_OrderId.Name = "txt_OrderId";
            this.txt_OrderId.Size = new System.Drawing.Size(172, 27);
            this.txt_OrderId.TabIndex = 91;
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(870, 44);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(172, 27);
            this.txt_Phone.TabIndex = 90;
            // 
            // txt_CardId
            // 
            this.txt_CardId.Location = new System.Drawing.Point(1145, 42);
            this.txt_CardId.Name = "txt_CardId";
            this.txt_CardId.Size = new System.Drawing.Size(172, 27);
            this.txt_CardId.TabIndex = 89;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(576, 41);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(125, 27);
            this.txt_Name.TabIndex = 88;
            // 
            // lab_OrderId
            // 
            this.lab_OrderId.AutoSize = true;
            this.lab_OrderId.Location = new System.Drawing.Point(39, 47);
            this.lab_OrderId.Name = "lab_OrderId";
            this.lab_OrderId.Size = new System.Drawing.Size(54, 20);
            this.lab_OrderId.TabIndex = 87;
            this.lab_OrderId.Text = "订单号";
            // 
            // lab_CardId
            // 
            this.lab_CardId.AutoSize = true;
            this.lab_CardId.Location = new System.Drawing.Point(1070, 45);
            this.lab_CardId.Name = "lab_CardId";
            this.lab_CardId.Size = new System.Drawing.Size(69, 20);
            this.lab_CardId.TabIndex = 86;
            this.lab_CardId.Text = "身份证号";
            // 
            // lab_Phone
            // 
            this.lab_Phone.AutoSize = true;
            this.lab_Phone.Location = new System.Drawing.Point(810, 48);
            this.lab_Phone.Name = "lab_Phone";
            this.lab_Phone.Size = new System.Drawing.Size(54, 20);
            this.lab_Phone.TabIndex = 85;
            this.lab_Phone.Text = "手机号";
            // 
            // lab_Name
            // 
            this.lab_Name.AutoSize = true;
            this.lab_Name.Location = new System.Drawing.Point(527, 44);
            this.lab_Name.Name = "lab_Name";
            this.lab_Name.Size = new System.Drawing.Size(43, 20);
            this.lab_Name.TabIndex = 84;
            this.lab_Name.Text = "姓 名";
            // 
            // childForm_customerData
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1710, 1030);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pal_Bottom);
            this.Controls.Add(this.pal_Top);
            this.Controls.Add(this.pal_Right);
            this.Controls.Add(this.pal_Left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "childForm_customerData";
            this.Text = "CustomerData";
            this.Load += new System.EventHandler(this.childForm_customerData_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CustomerData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pal_Left;
        private System.Windows.Forms.Panel pal_Bottom;
        private System.Windows.Forms.Panel pal_Top;
        private System.Windows.Forms.Panel pal_Right;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private UCButton ucButton_Empty;
        private System.Windows.Forms.ComboBox cob_OrderStatus;
        private System.Windows.Forms.Label lab_OrderStatus;
        private System.Windows.Forms.Label label1;
        private UCButton ucButton_Query;
        private System.Windows.Forms.DataGridView dgv_CustomerData;
        private System.Windows.Forms.TextBox txt_OrderId;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.TextBox txt_CardId;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lab_OrderId;
        private System.Windows.Forms.Label lab_CardId;
        private System.Windows.Forms.Label lab_Phone;
        private System.Windows.Forms.Label lab_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckInTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckOutTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdeStatusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentAmount;
    }
}