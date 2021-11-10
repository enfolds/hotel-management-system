namespace HMS.childForm
{
    partial class childForm_nweGoodsOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(childForm_nweGoodsOrder));
            this.pal_Left = new System.Windows.Forms.Panel();
            this.pal_Bottom = new System.Windows.Forms.Panel();
            this.pal_Top = new System.Windows.Forms.Panel();
            this.pal_Right = new System.Windows.Forms.Panel();
            this.ucButton_Submit = new HMS.UCButton();
            this.ucButton_empty = new HMS.UCButton();
            this.lab_Divider = new System.Windows.Forms.Label();
            this.lab_title = new System.Windows.Forms.Label();
            this.dgv_GoodsData = new System.Windows.Forms.DataGridView();
            this.GoodsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsSales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_OrderData = new System.Windows.Forms.GroupBox();
            this.ptb_Background = new System.Windows.Forms.PictureBox();
            this.groupBox_Checkstand = new System.Windows.Forms.GroupBox();
            this.lab_OrderId = new System.Windows.Forms.Label();
            this.txt_OrderId = new System.Windows.Forms.TextBox();
            this.lab_RoomType = new System.Windows.Forms.Label();
            this.cob_RoomId = new System.Windows.Forms.ComboBox();
            this.cob_GoodsType = new System.Windows.Forms.ComboBox();
            this.lab_Amount = new System.Windows.Forms.Label();
            this.txt_PaymentAmount = new System.Windows.Forms.TextBox();
            this.lab_GoodsNum = new System.Windows.Forms.Label();
            this.num_GoodsNum = new System.Windows.Forms.NumericUpDown();
            this.lab_GoodsType = new System.Windows.Forms.Label();
            this.txt_GoodsName = new System.Windows.Forms.TextBox();
            this.lab_GoodsPrice = new System.Windows.Forms.Label();
            this.lab_GoodsName = new System.Windows.Forms.Label();
            this.txt_GoodsPrice = new System.Windows.Forms.TextBox();
            this.groupBox_RoomData = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GoodsData)).BeginInit();
            this.groupBox_OrderData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Background)).BeginInit();
            this.groupBox_Checkstand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_GoodsNum)).BeginInit();
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
            this.lab_title.Size = new System.Drawing.Size(71, 36);
            this.lab_title.TabIndex = 30;
            this.lab_title.Text = "订餐";
            // 
            // dgv_GoodsData
            // 
            this.dgv_GoodsData.AllowUserToAddRows = false;
            this.dgv_GoodsData.AllowUserToResizeColumns = false;
            this.dgv_GoodsData.AllowUserToResizeRows = false;
            this.dgv_GoodsData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_GoodsData.BackgroundColor = System.Drawing.Color.White;
            this.dgv_GoodsData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_GoodsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_GoodsData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GoodsName,
            this.GoodsPrice,
            this.GoodsTypeName,
            this.GoodsSales,
            this.GoodsStock});
            this.dgv_GoodsData.Location = new System.Drawing.Point(22, 40);
            this.dgv_GoodsData.Name = "dgv_GoodsData";
            this.dgv_GoodsData.ReadOnly = true;
            this.dgv_GoodsData.RowHeadersVisible = false;
            this.dgv_GoodsData.RowHeadersWidth = 51;
            this.dgv_GoodsData.RowTemplate.Height = 29;
            this.dgv_GoodsData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_GoodsData.Size = new System.Drawing.Size(492, 637);
            this.dgv_GoodsData.TabIndex = 54;
            this.dgv_GoodsData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_RoomData_CellContentClick);
            // 
            // GoodsName
            // 
            this.GoodsName.DataPropertyName = "GoodsName";
            this.GoodsName.HeaderText = "商品名";
            this.GoodsName.MinimumWidth = 6;
            this.GoodsName.Name = "GoodsName";
            this.GoodsName.ReadOnly = true;
            // 
            // GoodsPrice
            // 
            this.GoodsPrice.DataPropertyName = "GoodsPrice";
            this.GoodsPrice.HeaderText = "价格";
            this.GoodsPrice.MinimumWidth = 6;
            this.GoodsPrice.Name = "GoodsPrice";
            this.GoodsPrice.ReadOnly = true;
            // 
            // GoodsTypeName
            // 
            this.GoodsTypeName.DataPropertyName = "GoodsTypeName";
            this.GoodsTypeName.HeaderText = "类型";
            this.GoodsTypeName.MinimumWidth = 6;
            this.GoodsTypeName.Name = "GoodsTypeName";
            this.GoodsTypeName.ReadOnly = true;
            // 
            // GoodsSales
            // 
            this.GoodsSales.DataPropertyName = "GoodsSales";
            this.GoodsSales.HeaderText = "销量";
            this.GoodsSales.MinimumWidth = 6;
            this.GoodsSales.Name = "GoodsSales";
            this.GoodsSales.ReadOnly = true;
            // 
            // GoodsStock
            // 
            this.GoodsStock.DataPropertyName = "GoodsStock";
            this.GoodsStock.HeaderText = "库存";
            this.GoodsStock.MinimumWidth = 6;
            this.GoodsStock.Name = "GoodsStock";
            this.GoodsStock.ReadOnly = true;
            // 
            // groupBox_OrderData
            // 
            this.groupBox_OrderData.Controls.Add(this.ptb_Background);
            this.groupBox_OrderData.Controls.Add(this.groupBox_Checkstand);
            this.groupBox_OrderData.Location = new System.Drawing.Point(74, 137);
            this.groupBox_OrderData.Name = "groupBox_OrderData";
            this.groupBox_OrderData.Size = new System.Drawing.Size(994, 692);
            this.groupBox_OrderData.TabIndex = 90;
            this.groupBox_OrderData.TabStop = false;
            this.groupBox_OrderData.Text = "订单信息";
            // 
            // ptb_Background
            // 
            this.ptb_Background.BackColor = System.Drawing.Color.Transparent;
            this.ptb_Background.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptb_Background.BackgroundImage")));
            this.ptb_Background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptb_Background.Location = new System.Drawing.Point(262, 40);
            this.ptb_Background.Name = "ptb_Background";
            this.ptb_Background.Size = new System.Drawing.Size(527, 378);
            this.ptb_Background.TabIndex = 123;
            this.ptb_Background.TabStop = false;
            // 
            // groupBox_Checkstand
            // 
            this.groupBox_Checkstand.Controls.Add(this.lab_OrderId);
            this.groupBox_Checkstand.Controls.Add(this.txt_OrderId);
            this.groupBox_Checkstand.Controls.Add(this.lab_RoomType);
            this.groupBox_Checkstand.Controls.Add(this.cob_RoomId);
            this.groupBox_Checkstand.Controls.Add(this.cob_GoodsType);
            this.groupBox_Checkstand.Controls.Add(this.lab_Amount);
            this.groupBox_Checkstand.Controls.Add(this.txt_PaymentAmount);
            this.groupBox_Checkstand.Controls.Add(this.lab_GoodsNum);
            this.groupBox_Checkstand.Controls.Add(this.num_GoodsNum);
            this.groupBox_Checkstand.Controls.Add(this.lab_GoodsType);
            this.groupBox_Checkstand.Controls.Add(this.txt_GoodsName);
            this.groupBox_Checkstand.Controls.Add(this.lab_GoodsPrice);
            this.groupBox_Checkstand.Controls.Add(this.lab_GoodsName);
            this.groupBox_Checkstand.Controls.Add(this.txt_GoodsPrice);
            this.groupBox_Checkstand.Location = new System.Drawing.Point(32, 424);
            this.groupBox_Checkstand.Name = "groupBox_Checkstand";
            this.groupBox_Checkstand.Size = new System.Drawing.Size(928, 253);
            this.groupBox_Checkstand.TabIndex = 122;
            this.groupBox_Checkstand.TabStop = false;
            this.groupBox_Checkstand.Text = "收银台";
            // 
            // lab_OrderId
            // 
            this.lab_OrderId.AutoSize = true;
            this.lab_OrderId.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lab_OrderId.Location = new System.Drawing.Point(73, 41);
            this.lab_OrderId.Name = "lab_OrderId";
            this.lab_OrderId.Size = new System.Drawing.Size(61, 23);
            this.lab_OrderId.TabIndex = 136;
            this.lab_OrderId.Text = "订单号";
            // 
            // txt_OrderId
            // 
            this.txt_OrderId.Location = new System.Drawing.Point(140, 41);
            this.txt_OrderId.Name = "txt_OrderId";
            this.txt_OrderId.ReadOnly = true;
            this.txt_OrderId.Size = new System.Drawing.Size(262, 27);
            this.txt_OrderId.TabIndex = 135;
            // 
            // lab_RoomType
            // 
            this.lab_RoomType.AutoSize = true;
            this.lab_RoomType.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lab_RoomType.Location = new System.Drawing.Point(516, 143);
            this.lab_RoomType.Name = "lab_RoomType";
            this.lab_RoomType.Size = new System.Drawing.Size(78, 23);
            this.lab_RoomType.TabIndex = 110;
            this.lab_RoomType.Text = "配送房间";
            // 
            // cob_RoomId
            // 
            this.cob_RoomId.FormattingEnabled = true;
            this.cob_RoomId.Location = new System.Drawing.Point(600, 141);
            this.cob_RoomId.Name = "cob_RoomId";
            this.cob_RoomId.Size = new System.Drawing.Size(262, 28);
            this.cob_RoomId.TabIndex = 111;
            // 
            // cob_GoodsType
            // 
            this.cob_GoodsType.FormattingEnabled = true;
            this.cob_GoodsType.Location = new System.Drawing.Point(600, 41);
            this.cob_GoodsType.Name = "cob_GoodsType";
            this.cob_GoodsType.Size = new System.Drawing.Size(262, 28);
            this.cob_GoodsType.TabIndex = 134;
            this.cob_GoodsType.SelectedIndexChanged += new System.EventHandler(this.cob_GoodsType_SelectedIndexChanged);
            // 
            // lab_Amount
            // 
            this.lab_Amount.AutoSize = true;
            this.lab_Amount.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lab_Amount.Location = new System.Drawing.Point(90, 198);
            this.lab_Amount.Name = "lab_Amount";
            this.lab_Amount.Size = new System.Drawing.Size(44, 23);
            this.lab_Amount.TabIndex = 131;
            this.lab_Amount.Text = "费用";
            // 
            // txt_PaymentAmount
            // 
            this.txt_PaymentAmount.Location = new System.Drawing.Point(140, 197);
            this.txt_PaymentAmount.Name = "txt_PaymentAmount";
            this.txt_PaymentAmount.ReadOnly = true;
            this.txt_PaymentAmount.Size = new System.Drawing.Size(262, 27);
            this.txt_PaymentAmount.TabIndex = 132;
            // 
            // lab_GoodsNum
            // 
            this.lab_GoodsNum.AutoSize = true;
            this.lab_GoodsNum.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lab_GoodsNum.Location = new System.Drawing.Point(550, 99);
            this.lab_GoodsNum.Name = "lab_GoodsNum";
            this.lab_GoodsNum.Size = new System.Drawing.Size(44, 23);
            this.lab_GoodsNum.TabIndex = 130;
            this.lab_GoodsNum.Text = "数量";
            // 
            // num_GoodsNum
            // 
            this.num_GoodsNum.Location = new System.Drawing.Point(600, 95);
            this.num_GoodsNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_GoodsNum.Name = "num_GoodsNum";
            this.num_GoodsNum.Size = new System.Drawing.Size(262, 27);
            this.num_GoodsNum.TabIndex = 129;
            this.num_GoodsNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_GoodsNum.ValueChanged += new System.EventHandler(this.num_GoodsNum_ValueChanged);
            // 
            // lab_GoodsType
            // 
            this.lab_GoodsType.AutoSize = true;
            this.lab_GoodsType.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lab_GoodsType.Location = new System.Drawing.Point(550, 44);
            this.lab_GoodsType.Name = "lab_GoodsType";
            this.lab_GoodsType.Size = new System.Drawing.Size(44, 23);
            this.lab_GoodsType.TabIndex = 127;
            this.lab_GoodsType.Text = "类型";
            // 
            // txt_GoodsName
            // 
            this.txt_GoodsName.Location = new System.Drawing.Point(140, 98);
            this.txt_GoodsName.Name = "txt_GoodsName";
            this.txt_GoodsName.ReadOnly = true;
            this.txt_GoodsName.Size = new System.Drawing.Size(262, 27);
            this.txt_GoodsName.TabIndex = 123;
            // 
            // lab_GoodsPrice
            // 
            this.lab_GoodsPrice.AutoSize = true;
            this.lab_GoodsPrice.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lab_GoodsPrice.Location = new System.Drawing.Point(90, 153);
            this.lab_GoodsPrice.Name = "lab_GoodsPrice";
            this.lab_GoodsPrice.Size = new System.Drawing.Size(44, 23);
            this.lab_GoodsPrice.TabIndex = 124;
            this.lab_GoodsPrice.Text = "价格";
            // 
            // lab_GoodsName
            // 
            this.lab_GoodsName.AutoSize = true;
            this.lab_GoodsName.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lab_GoodsName.Location = new System.Drawing.Point(73, 99);
            this.lab_GoodsName.Name = "lab_GoodsName";
            this.lab_GoodsName.Size = new System.Drawing.Size(61, 23);
            this.lab_GoodsName.TabIndex = 122;
            this.lab_GoodsName.Text = "商品名";
            // 
            // txt_GoodsPrice
            // 
            this.txt_GoodsPrice.Location = new System.Drawing.Point(140, 149);
            this.txt_GoodsPrice.Name = "txt_GoodsPrice";
            this.txt_GoodsPrice.ReadOnly = true;
            this.txt_GoodsPrice.Size = new System.Drawing.Size(262, 27);
            this.txt_GoodsPrice.TabIndex = 125;
            // 
            // groupBox_RoomData
            // 
            this.groupBox_RoomData.Controls.Add(this.dgv_GoodsData);
            this.groupBox_RoomData.Location = new System.Drawing.Point(1101, 137);
            this.groupBox_RoomData.Name = "groupBox_RoomData";
            this.groupBox_RoomData.Size = new System.Drawing.Size(533, 692);
            this.groupBox_RoomData.TabIndex = 91;
            this.groupBox_RoomData.TabStop = false;
            this.groupBox_RoomData.Text = "商品表";
            // 
            // childForm_nweGoodsOrder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1710, 1030);
            this.Controls.Add(this.groupBox_OrderData);
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
            this.Name = "childForm_nweGoodsOrder";
            this.Text = "EditGuestData";
            this.Load += new System.EventHandler(this.childForm_order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GoodsData)).EndInit();
            this.groupBox_OrderData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Background)).EndInit();
            this.groupBox_Checkstand.ResumeLayout(false);
            this.groupBox_Checkstand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_GoodsNum)).EndInit();
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
        private System.Windows.Forms.DataGridView dgv_GoodsData;
        private System.Windows.Forms.GroupBox groupBox_OrderData;
        private System.Windows.Forms.GroupBox groupBox_RoomData;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsStock;
        private System.Windows.Forms.GroupBox groupBox_Checkstand;
        private System.Windows.Forms.Label lab_Amount;
        private System.Windows.Forms.TextBox txt_PaymentAmount;
        private System.Windows.Forms.Label lab_GoodsNum;
        private System.Windows.Forms.NumericUpDown num_GoodsNum;
        private System.Windows.Forms.Label lab_GoodsType;
        private System.Windows.Forms.TextBox txt_GoodsName;
        private System.Windows.Forms.Label lab_GoodsPrice;
        private System.Windows.Forms.Label lab_GoodsName;
        private System.Windows.Forms.TextBox txt_GoodsPrice;
        private System.Windows.Forms.ComboBox cob_GoodsType;
        private System.Windows.Forms.Label lab_RoomType;
        private System.Windows.Forms.ComboBox cob_RoomId;
        private System.Windows.Forms.PictureBox ptb_Background;
        private System.Windows.Forms.Label lab_OrderId;
        private System.Windows.Forms.TextBox txt_OrderId;
    }
}