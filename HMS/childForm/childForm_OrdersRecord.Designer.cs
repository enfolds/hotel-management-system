namespace HMS.childForm
{
    partial class childForm_ordersRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(childForm_ordersRecord));
            this.pal_Left = new System.Windows.Forms.Panel();
            this.pal_Bottom = new System.Windows.Forms.Panel();
            this.pal_Top = new System.Windows.Forms.Panel();
            this.pal_Right = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox_OrderData = new System.Windows.Forms.GroupBox();
            this.dgv_OrderData = new System.Windows.Forms.DataGridView();
            this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_Conditions = new System.Windows.Forms.GroupBox();
            this.txt_RoomId = new System.Windows.Forms.TextBox();
            this.ucButton_Query = new HMS.UCButton();
            this.ucButton_Empty = new HMS.UCButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_RoomId = new System.Windows.Forms.Label();
            this.txt_OrderId = new System.Windows.Forms.TextBox();
            this.lab_OrderId = new System.Windows.Forms.Label();
            this.txt_GoodsName = new System.Windows.Forms.TextBox();
            this.lab_Name = new System.Windows.Forms.Label();
            this.groupBox_OrderData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderData)).BeginInit();
            this.groupBox_Conditions.SuspendLayout();
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
            // groupBox_OrderData
            // 
            this.groupBox_OrderData.Controls.Add(this.dgv_OrderData);
            this.groupBox_OrderData.Location = new System.Drawing.Point(66, 54);
            this.groupBox_OrderData.Name = "groupBox_OrderData";
            this.groupBox_OrderData.Size = new System.Drawing.Size(1131, 915);
            this.groupBox_OrderData.TabIndex = 11;
            this.groupBox_OrderData.TabStop = false;
            this.groupBox_OrderData.Text = "订单记录";
            // 
            // dgv_OrderData
            // 
            this.dgv_OrderData.AllowUserToAddRows = false;
            this.dgv_OrderData.AllowUserToResizeColumns = false;
            this.dgv_OrderData.AllowUserToResizeRows = false;
            this.dgv_OrderData.BackgroundColor = System.Drawing.Color.White;
            this.dgv_OrderData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_OrderData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_OrderData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderId,
            this.GoodsName,
            this.GoodsNum,
            this.RoomId,
            this.PaymentAmount,
            this.OrderTime});
            this.dgv_OrderData.Location = new System.Drawing.Point(22, 37);
            this.dgv_OrderData.Name = "dgv_OrderData";
            this.dgv_OrderData.ReadOnly = true;
            this.dgv_OrderData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_OrderData.RowHeadersVisible = false;
            this.dgv_OrderData.RowHeadersWidth = 51;
            this.dgv_OrderData.RowTemplate.Height = 29;
            this.dgv_OrderData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_OrderData.Size = new System.Drawing.Size(1085, 856);
            this.dgv_OrderData.TabIndex = 92;
            // 
            // OrderId
            // 
            this.OrderId.DataPropertyName = "OrderId";
            this.OrderId.FillWeight = 100.3135F;
            this.OrderId.HeaderText = "订单号";
            this.OrderId.MinimumWidth = 6;
            this.OrderId.Name = "OrderId";
            this.OrderId.ReadOnly = true;
            this.OrderId.Width = 230;
            // 
            // GoodsName
            // 
            this.GoodsName.DataPropertyName = "GoodsName";
            this.GoodsName.FillWeight = 99.65836F;
            this.GoodsName.HeaderText = "商品名";
            this.GoodsName.MinimumWidth = 6;
            this.GoodsName.Name = "GoodsName";
            this.GoodsName.ReadOnly = true;
            this.GoodsName.Width = 200;
            // 
            // GoodsNum
            // 
            this.GoodsNum.DataPropertyName = "GoodsNum";
            this.GoodsNum.FillWeight = 100.3225F;
            this.GoodsNum.HeaderText = "下单数量";
            this.GoodsNum.MinimumWidth = 6;
            this.GoodsNum.Name = "GoodsNum";
            this.GoodsNum.ReadOnly = true;
            this.GoodsNum.Width = 120;
            // 
            // RoomId
            // 
            this.RoomId.DataPropertyName = "RoomId";
            this.RoomId.FillWeight = 100.3298F;
            this.RoomId.HeaderText = "配送房间";
            this.RoomId.MinimumWidth = 6;
            this.RoomId.Name = "RoomId";
            this.RoomId.ReadOnly = true;
            this.RoomId.Width = 120;
            // 
            // PaymentAmount
            // 
            this.PaymentAmount.DataPropertyName = "PaymentAmount";
            this.PaymentAmount.FillWeight = 99.67817F;
            this.PaymentAmount.HeaderText = "消费金额";
            this.PaymentAmount.MinimumWidth = 6;
            this.PaymentAmount.Name = "PaymentAmount";
            this.PaymentAmount.ReadOnly = true;
            this.PaymentAmount.Width = 200;
            // 
            // OrderTime
            // 
            this.OrderTime.DataPropertyName = "OrderTime";
            this.OrderTime.FillWeight = 100.3405F;
            this.OrderTime.HeaderText = "下单时间";
            this.OrderTime.MinimumWidth = 6;
            this.OrderTime.Name = "OrderTime";
            this.OrderTime.ReadOnly = true;
            this.OrderTime.Width = 212;
            // 
            // groupBox_Conditions
            // 
            this.groupBox_Conditions.Controls.Add(this.txt_RoomId);
            this.groupBox_Conditions.Controls.Add(this.ucButton_Query);
            this.groupBox_Conditions.Controls.Add(this.ucButton_Empty);
            this.groupBox_Conditions.Controls.Add(this.label1);
            this.groupBox_Conditions.Controls.Add(this.lab_RoomId);
            this.groupBox_Conditions.Controls.Add(this.txt_OrderId);
            this.groupBox_Conditions.Controls.Add(this.lab_OrderId);
            this.groupBox_Conditions.Controls.Add(this.txt_GoodsName);
            this.groupBox_Conditions.Controls.Add(this.lab_Name);
            this.groupBox_Conditions.Location = new System.Drawing.Point(1220, 54);
            this.groupBox_Conditions.Name = "groupBox_Conditions";
            this.groupBox_Conditions.Size = new System.Drawing.Size(424, 432);
            this.groupBox_Conditions.TabIndex = 12;
            this.groupBox_Conditions.TabStop = false;
            this.groupBox_Conditions.Text = "查询条件";
            // 
            // txt_RoomId
            // 
            this.txt_RoomId.Location = new System.Drawing.Point(135, 202);
            this.txt_RoomId.Name = "txt_RoomId";
            this.txt_RoomId.Size = new System.Drawing.Size(172, 27);
            this.txt_RoomId.TabIndex = 107;
            // 
            // ucButton_Query
            // 
            this.ucButton_Query.BackColor = System.Drawing.Color.Transparent;
            this.ucButton_Query.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucButton_Query.BackgroundImage")));
            this.ucButton_Query.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ucButton_Query.Location = new System.Drawing.Point(75, 322);
            this.ucButton_Query.Name = "ucButton_Query";
            this.ucButton_Query.Size = new System.Drawing.Size(85, 45);
            this.ucButton_Query.TabIndex = 103;
            this.ucButton_Query.Click += new System.EventHandler(this.ucButton_Query_Click);
            // 
            // ucButton_Empty
            // 
            this.ucButton_Empty.BackColor = System.Drawing.Color.Transparent;
            this.ucButton_Empty.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucButton_Empty.BackgroundImage")));
            this.ucButton_Empty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ucButton_Empty.Location = new System.Drawing.Point(280, 322);
            this.ucButton_Empty.Name = "ucButton_Empty";
            this.ucButton_Empty.Size = new System.Drawing.Size(85, 45);
            this.ucButton_Empty.TabIndex = 106;
            this.ucButton_Empty.Click += new System.EventHandler(this.ucButton_Empty_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(313, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 104;
            this.label1.Text = "(支持模糊)";
            // 
            // lab_RoomId
            // 
            this.lab_RoomId.AutoSize = true;
            this.lab_RoomId.Location = new System.Drawing.Point(86, 205);
            this.lab_RoomId.Name = "lab_RoomId";
            this.lab_RoomId.Size = new System.Drawing.Size(43, 20);
            this.lab_RoomId.TabIndex = 105;
            this.lab_RoomId.Text = "房 号";
            // 
            // txt_OrderId
            // 
            this.txt_OrderId.Location = new System.Drawing.Point(135, 63);
            this.txt_OrderId.Name = "txt_OrderId";
            this.txt_OrderId.Size = new System.Drawing.Size(172, 27);
            this.txt_OrderId.TabIndex = 102;
            // 
            // lab_OrderId
            // 
            this.lab_OrderId.AutoSize = true;
            this.lab_OrderId.Location = new System.Drawing.Point(75, 66);
            this.lab_OrderId.Name = "lab_OrderId";
            this.lab_OrderId.Size = new System.Drawing.Size(54, 20);
            this.lab_OrderId.TabIndex = 100;
            this.lab_OrderId.Text = "订单号";
            // 
            // txt_GoodsName
            // 
            this.txt_GoodsName.Location = new System.Drawing.Point(135, 131);
            this.txt_GoodsName.Name = "txt_GoodsName";
            this.txt_GoodsName.Size = new System.Drawing.Size(172, 27);
            this.txt_GoodsName.TabIndex = 101;
            // 
            // lab_Name
            // 
            this.lab_Name.AutoSize = true;
            this.lab_Name.Location = new System.Drawing.Point(75, 134);
            this.lab_Name.Name = "lab_Name";
            this.lab_Name.Size = new System.Drawing.Size(54, 20);
            this.lab_Name.TabIndex = 99;
            this.lab_Name.Text = "商品名";
            // 
            // childForm_ordersRecord
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1710, 1030);
            this.Controls.Add(this.groupBox_Conditions);
            this.Controls.Add(this.groupBox_OrderData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pal_Bottom);
            this.Controls.Add(this.pal_Top);
            this.Controls.Add(this.pal_Right);
            this.Controls.Add(this.pal_Left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "childForm_ordersRecord";
            this.Text = "CustomerData";
            this.Load += new System.EventHandler(this.childForm_ordersRecord_Load);
            this.groupBox_OrderData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderData)).EndInit();
            this.groupBox_Conditions.ResumeLayout(false);
            this.groupBox_Conditions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pal_Left;
        private System.Windows.Forms.Panel pal_Bottom;
        private System.Windows.Forms.Panel pal_Top;
        private System.Windows.Forms.Panel pal_Right;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox_OrderData;
        private System.Windows.Forms.DataGridView dgv_OrderData;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderTime;
        private System.Windows.Forms.GroupBox groupBox_Conditions;
        private System.Windows.Forms.TextBox txt_RoomId;
        private UCButton ucButton_Query;
        private UCButton ucButton_Empty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_RoomId;
        private System.Windows.Forms.TextBox txt_OrderId;
        private System.Windows.Forms.Label lab_OrderId;
        private System.Windows.Forms.TextBox txt_GoodsName;
        private System.Windows.Forms.Label lab_Name;
    }
}