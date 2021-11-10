namespace HMS.childForm
{
    partial class childForm_goodsData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(childForm_goodsData));
            this.pal_Left = new System.Windows.Forms.Panel();
            this.pal_Bottom = new System.Windows.Forms.Panel();
            this.pal_Top = new System.Windows.Forms.Panel();
            this.pal_Right = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox_GoodsData = new System.Windows.Forms.GroupBox();
            this.dgv_GoodsData = new System.Windows.Forms.DataGridView();
            this.GoodsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsSales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_Query = new System.Windows.Forms.GroupBox();
            this.cob_QueryGoodsType = new System.Windows.Forms.ComboBox();
            this.ucButton_Query = new HMS.UCButton();
            this.ucButton_Empty = new HMS.UCButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_QueryGoodsType = new System.Windows.Forms.Label();
            this.txt_QueryGoodsId = new System.Windows.Forms.TextBox();
            this.lab_QueryGoodsId = new System.Windows.Forms.Label();
            this.txt_QueryGoodsName = new System.Windows.Forms.TextBox();
            this.lab_QueryGoodsName = new System.Windows.Forms.Label();
            this.groupBox_Management = new System.Windows.Forms.GroupBox();
            this.txt_GoodsSales = new System.Windows.Forms.TextBox();
            this.lab_GoodsSales = new System.Windows.Forms.Label();
            this.num_GoodsStock = new System.Windows.Forms.NumericUpDown();
            this.cob_GoodsType = new System.Windows.Forms.ComboBox();
            this.lab_GoodsType = new System.Windows.Forms.Label();
            this.lab_GoodsStock = new System.Windows.Forms.Label();
            this.txt_GoodsPrice = new System.Windows.Forms.TextBox();
            this.lab_GoodsPrice = new System.Windows.Forms.Label();
            this.txt_GoodsId = new System.Windows.Forms.TextBox();
            this.lab_GoodsId = new System.Windows.Forms.Label();
            this.ucButton_Submit = new HMS.UCButton();
            this.txt_GoodsName = new System.Windows.Forms.TextBox();
            this.lab_GoodsName = new System.Windows.Forms.Label();
            this.groupBox_GoodsData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GoodsData)).BeginInit();
            this.groupBox_Query.SuspendLayout();
            this.groupBox_Management.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_GoodsStock)).BeginInit();
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
            // groupBox_GoodsData
            // 
            this.groupBox_GoodsData.Controls.Add(this.dgv_GoodsData);
            this.groupBox_GoodsData.Location = new System.Drawing.Point(73, 54);
            this.groupBox_GoodsData.Name = "groupBox_GoodsData";
            this.groupBox_GoodsData.Size = new System.Drawing.Size(898, 915);
            this.groupBox_GoodsData.TabIndex = 11;
            this.groupBox_GoodsData.TabStop = false;
            this.groupBox_GoodsData.Text = "商品列表";
            // 
            // dgv_GoodsData
            // 
            this.dgv_GoodsData.AllowUserToAddRows = false;
            this.dgv_GoodsData.AllowUserToResizeColumns = false;
            this.dgv_GoodsData.AllowUserToResizeRows = false;
            this.dgv_GoodsData.BackgroundColor = System.Drawing.Color.White;
            this.dgv_GoodsData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_GoodsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_GoodsData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GoodsId,
            this.GoodsName,
            this.GoodsTypeName,
            this.GoodsPrice,
            this.GoodsSales,
            this.GoodsStock});
            this.dgv_GoodsData.Location = new System.Drawing.Point(27, 37);
            this.dgv_GoodsData.Name = "dgv_GoodsData";
            this.dgv_GoodsData.ReadOnly = true;
            this.dgv_GoodsData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_GoodsData.RowHeadersVisible = false;
            this.dgv_GoodsData.RowHeadersWidth = 51;
            this.dgv_GoodsData.RowTemplate.Height = 29;
            this.dgv_GoodsData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_GoodsData.Size = new System.Drawing.Size(833, 856);
            this.dgv_GoodsData.TabIndex = 92;
            this.dgv_GoodsData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_GoodsData_CellContentClick);
            // 
            // GoodsId
            // 
            this.GoodsId.DataPropertyName = "GoodsId";
            this.GoodsId.FillWeight = 100.3135F;
            this.GoodsId.HeaderText = "商品ID";
            this.GoodsId.MinimumWidth = 6;
            this.GoodsId.Name = "GoodsId";
            this.GoodsId.ReadOnly = true;
            this.GoodsId.Width = 120;
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
            // GoodsTypeName
            // 
            this.GoodsTypeName.DataPropertyName = "GoodsTypeName";
            this.GoodsTypeName.FillWeight = 100.3298F;
            this.GoodsTypeName.HeaderText = "类型";
            this.GoodsTypeName.MinimumWidth = 6;
            this.GoodsTypeName.Name = "GoodsTypeName";
            this.GoodsTypeName.ReadOnly = true;
            this.GoodsTypeName.Width = 150;
            // 
            // GoodsPrice
            // 
            this.GoodsPrice.DataPropertyName = "GoodsPrice";
            this.GoodsPrice.FillWeight = 99.67817F;
            this.GoodsPrice.HeaderText = "价格";
            this.GoodsPrice.MinimumWidth = 6;
            this.GoodsPrice.Name = "GoodsPrice";
            this.GoodsPrice.ReadOnly = true;
            this.GoodsPrice.Width = 120;
            // 
            // GoodsSales
            // 
            this.GoodsSales.DataPropertyName = "GoodsSales";
            this.GoodsSales.FillWeight = 100.3405F;
            this.GoodsSales.HeaderText = "销量";
            this.GoodsSales.MinimumWidth = 6;
            this.GoodsSales.Name = "GoodsSales";
            this.GoodsSales.ReadOnly = true;
            this.GoodsSales.Width = 120;
            // 
            // GoodsStock
            // 
            this.GoodsStock.DataPropertyName = "GoodsStock";
            this.GoodsStock.HeaderText = "库存";
            this.GoodsStock.MinimumWidth = 6;
            this.GoodsStock.Name = "GoodsStock";
            this.GoodsStock.ReadOnly = true;
            this.GoodsStock.Width = 120;
            // 
            // groupBox_Query
            // 
            this.groupBox_Query.Controls.Add(this.cob_QueryGoodsType);
            this.groupBox_Query.Controls.Add(this.ucButton_Query);
            this.groupBox_Query.Controls.Add(this.ucButton_Empty);
            this.groupBox_Query.Controls.Add(this.label1);
            this.groupBox_Query.Controls.Add(this.lab_QueryGoodsType);
            this.groupBox_Query.Controls.Add(this.txt_QueryGoodsId);
            this.groupBox_Query.Controls.Add(this.lab_QueryGoodsId);
            this.groupBox_Query.Controls.Add(this.txt_QueryGoodsName);
            this.groupBox_Query.Controls.Add(this.lab_QueryGoodsName);
            this.groupBox_Query.Location = new System.Drawing.Point(998, 54);
            this.groupBox_Query.Name = "groupBox_Query";
            this.groupBox_Query.Size = new System.Drawing.Size(633, 380);
            this.groupBox_Query.TabIndex = 12;
            this.groupBox_Query.TabStop = false;
            this.groupBox_Query.Text = "商品查询";
            // 
            // cob_QueryGoodsType
            // 
            this.cob_QueryGoodsType.FormattingEnabled = true;
            this.cob_QueryGoodsType.Location = new System.Drawing.Point(226, 175);
            this.cob_QueryGoodsType.Name = "cob_QueryGoodsType";
            this.cob_QueryGoodsType.Size = new System.Drawing.Size(172, 28);
            this.cob_QueryGoodsType.TabIndex = 135;
            // 
            // ucButton_Query
            // 
            this.ucButton_Query.BackColor = System.Drawing.Color.Transparent;
            this.ucButton_Query.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucButton_Query.BackgroundImage")));
            this.ucButton_Query.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ucButton_Query.Location = new System.Drawing.Point(178, 298);
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
            this.ucButton_Empty.Location = new System.Drawing.Point(383, 298);
            this.ucButton_Empty.Name = "ucButton_Empty";
            this.ucButton_Empty.Size = new System.Drawing.Size(85, 45);
            this.ucButton_Empty.TabIndex = 106;
            this.ucButton_Empty.Click += new System.EventHandler(this.ucButton_Empty_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(404, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 104;
            this.label1.Text = "(支持模糊)";
            // 
            // lab_QueryGoodsType
            // 
            this.lab_QueryGoodsType.AutoSize = true;
            this.lab_QueryGoodsType.Location = new System.Drawing.Point(177, 178);
            this.lab_QueryGoodsType.Name = "lab_QueryGoodsType";
            this.lab_QueryGoodsType.Size = new System.Drawing.Size(43, 20);
            this.lab_QueryGoodsType.TabIndex = 105;
            this.lab_QueryGoodsType.Text = "类 型";
            // 
            // txt_QueryGoodsId
            // 
            this.txt_QueryGoodsId.Location = new System.Drawing.Point(226, 117);
            this.txt_QueryGoodsId.Name = "txt_QueryGoodsId";
            this.txt_QueryGoodsId.Size = new System.Drawing.Size(172, 27);
            this.txt_QueryGoodsId.TabIndex = 102;
            // 
            // lab_QueryGoodsId
            // 
            this.lab_QueryGoodsId.AutoSize = true;
            this.lab_QueryGoodsId.Location = new System.Drawing.Point(166, 120);
            this.lab_QueryGoodsId.Name = "lab_QueryGoodsId";
            this.lab_QueryGoodsId.Size = new System.Drawing.Size(54, 20);
            this.lab_QueryGoodsId.TabIndex = 100;
            this.lab_QueryGoodsId.Text = "商品ID";
            // 
            // txt_QueryGoodsName
            // 
            this.txt_QueryGoodsName.Location = new System.Drawing.Point(226, 66);
            this.txt_QueryGoodsName.Name = "txt_QueryGoodsName";
            this.txt_QueryGoodsName.Size = new System.Drawing.Size(172, 27);
            this.txt_QueryGoodsName.TabIndex = 101;
            // 
            // lab_QueryGoodsName
            // 
            this.lab_QueryGoodsName.AutoSize = true;
            this.lab_QueryGoodsName.Location = new System.Drawing.Point(166, 69);
            this.lab_QueryGoodsName.Name = "lab_QueryGoodsName";
            this.lab_QueryGoodsName.Size = new System.Drawing.Size(54, 20);
            this.lab_QueryGoodsName.TabIndex = 99;
            this.lab_QueryGoodsName.Text = "商品名";
            // 
            // groupBox_Management
            // 
            this.groupBox_Management.Controls.Add(this.txt_GoodsSales);
            this.groupBox_Management.Controls.Add(this.lab_GoodsSales);
            this.groupBox_Management.Controls.Add(this.num_GoodsStock);
            this.groupBox_Management.Controls.Add(this.cob_GoodsType);
            this.groupBox_Management.Controls.Add(this.lab_GoodsType);
            this.groupBox_Management.Controls.Add(this.lab_GoodsStock);
            this.groupBox_Management.Controls.Add(this.txt_GoodsPrice);
            this.groupBox_Management.Controls.Add(this.lab_GoodsPrice);
            this.groupBox_Management.Controls.Add(this.txt_GoodsId);
            this.groupBox_Management.Controls.Add(this.lab_GoodsId);
            this.groupBox_Management.Controls.Add(this.ucButton_Submit);
            this.groupBox_Management.Controls.Add(this.txt_GoodsName);
            this.groupBox_Management.Controls.Add(this.lab_GoodsName);
            this.groupBox_Management.Location = new System.Drawing.Point(998, 463);
            this.groupBox_Management.Name = "groupBox_Management";
            this.groupBox_Management.Size = new System.Drawing.Size(633, 397);
            this.groupBox_Management.TabIndex = 136;
            this.groupBox_Management.TabStop = false;
            this.groupBox_Management.Text = "商品管理";
            // 
            // txt_GoodsSales
            // 
            this.txt_GoodsSales.Location = new System.Drawing.Point(404, 56);
            this.txt_GoodsSales.Name = "txt_GoodsSales";
            this.txt_GoodsSales.ReadOnly = true;
            this.txt_GoodsSales.Size = new System.Drawing.Size(172, 27);
            this.txt_GoodsSales.TabIndex = 146;
            // 
            // lab_GoodsSales
            // 
            this.lab_GoodsSales.AutoSize = true;
            this.lab_GoodsSales.Location = new System.Drawing.Point(355, 63);
            this.lab_GoodsSales.Name = "lab_GoodsSales";
            this.lab_GoodsSales.Size = new System.Drawing.Size(43, 20);
            this.lab_GoodsSales.TabIndex = 145;
            this.lab_GoodsSales.Text = "销 量";
            // 
            // num_GoodsStock
            // 
            this.num_GoodsStock.Location = new System.Drawing.Point(404, 189);
            this.num_GoodsStock.Name = "num_GoodsStock";
            this.num_GoodsStock.Size = new System.Drawing.Size(172, 27);
            this.num_GoodsStock.TabIndex = 144;
            // 
            // cob_GoodsType
            // 
            this.cob_GoodsType.FormattingEnabled = true;
            this.cob_GoodsType.Location = new System.Drawing.Point(126, 193);
            this.cob_GoodsType.Name = "cob_GoodsType";
            this.cob_GoodsType.Size = new System.Drawing.Size(172, 28);
            this.cob_GoodsType.TabIndex = 143;
            // 
            // lab_GoodsType
            // 
            this.lab_GoodsType.AutoSize = true;
            this.lab_GoodsType.Location = new System.Drawing.Point(77, 196);
            this.lab_GoodsType.Name = "lab_GoodsType";
            this.lab_GoodsType.Size = new System.Drawing.Size(43, 20);
            this.lab_GoodsType.TabIndex = 142;
            this.lab_GoodsType.Text = "类 型";
            // 
            // lab_GoodsStock
            // 
            this.lab_GoodsStock.AutoSize = true;
            this.lab_GoodsStock.Location = new System.Drawing.Point(355, 196);
            this.lab_GoodsStock.Name = "lab_GoodsStock";
            this.lab_GoodsStock.Size = new System.Drawing.Size(43, 20);
            this.lab_GoodsStock.TabIndex = 140;
            this.lab_GoodsStock.Text = "库 存";
            // 
            // txt_GoodsPrice
            // 
            this.txt_GoodsPrice.Location = new System.Drawing.Point(404, 127);
            this.txt_GoodsPrice.Name = "txt_GoodsPrice";
            this.txt_GoodsPrice.Size = new System.Drawing.Size(172, 27);
            this.txt_GoodsPrice.TabIndex = 139;
            // 
            // lab_GoodsPrice
            // 
            this.lab_GoodsPrice.AutoSize = true;
            this.lab_GoodsPrice.Location = new System.Drawing.Point(355, 130);
            this.lab_GoodsPrice.Name = "lab_GoodsPrice";
            this.lab_GoodsPrice.Size = new System.Drawing.Size(43, 20);
            this.lab_GoodsPrice.TabIndex = 138;
            this.lab_GoodsPrice.Text = "价 格";
            // 
            // txt_GoodsId
            // 
            this.txt_GoodsId.Location = new System.Drawing.Point(126, 60);
            this.txt_GoodsId.Name = "txt_GoodsId";
            this.txt_GoodsId.ReadOnly = true;
            this.txt_GoodsId.Size = new System.Drawing.Size(172, 27);
            this.txt_GoodsId.TabIndex = 137;
            // 
            // lab_GoodsId
            // 
            this.lab_GoodsId.AutoSize = true;
            this.lab_GoodsId.Location = new System.Drawing.Point(66, 63);
            this.lab_GoodsId.Name = "lab_GoodsId";
            this.lab_GoodsId.Size = new System.Drawing.Size(54, 20);
            this.lab_GoodsId.TabIndex = 136;
            this.lab_GoodsId.Text = "商品ID";
            // 
            // ucButton_Submit
            // 
            this.ucButton_Submit.BackColor = System.Drawing.Color.Transparent;
            this.ucButton_Submit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucButton_Submit.BackgroundImage")));
            this.ucButton_Submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ucButton_Submit.Location = new System.Drawing.Point(491, 313);
            this.ucButton_Submit.Name = "ucButton_Submit";
            this.ucButton_Submit.Size = new System.Drawing.Size(85, 45);
            this.ucButton_Submit.TabIndex = 103;
            this.ucButton_Submit.Click += new System.EventHandler(this.ucButton_Submit_Click);
            // 
            // txt_GoodsName
            // 
            this.txt_GoodsName.Location = new System.Drawing.Point(126, 131);
            this.txt_GoodsName.Name = "txt_GoodsName";
            this.txt_GoodsName.Size = new System.Drawing.Size(172, 27);
            this.txt_GoodsName.TabIndex = 101;
            // 
            // lab_GoodsName
            // 
            this.lab_GoodsName.AutoSize = true;
            this.lab_GoodsName.Location = new System.Drawing.Point(66, 134);
            this.lab_GoodsName.Name = "lab_GoodsName";
            this.lab_GoodsName.Size = new System.Drawing.Size(54, 20);
            this.lab_GoodsName.TabIndex = 99;
            this.lab_GoodsName.Text = "商品名";
            // 
            // childForm_goodsData
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1710, 1030);
            this.Controls.Add(this.groupBox_Management);
            this.Controls.Add(this.groupBox_Query);
            this.Controls.Add(this.groupBox_GoodsData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pal_Bottom);
            this.Controls.Add(this.pal_Top);
            this.Controls.Add(this.pal_Right);
            this.Controls.Add(this.pal_Left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "childForm_goodsData";
            this.Text = "CustomerData";
            this.Load += new System.EventHandler(this.childForm_goodsData_Load);
            this.groupBox_GoodsData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GoodsData)).EndInit();
            this.groupBox_Query.ResumeLayout(false);
            this.groupBox_Query.PerformLayout();
            this.groupBox_Management.ResumeLayout(false);
            this.groupBox_Management.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_GoodsStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pal_Left;
        private System.Windows.Forms.Panel pal_Bottom;
        private System.Windows.Forms.Panel pal_Top;
        private System.Windows.Forms.Panel pal_Right;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox_GoodsData;
        private System.Windows.Forms.DataGridView dgv_GoodsData;
        private System.Windows.Forms.GroupBox groupBox_Query;
        private UCButton ucButton_Query;
        private UCButton ucButton_Empty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_QueryGoodsType;
        private System.Windows.Forms.TextBox txt_QueryGoodsId;
        private System.Windows.Forms.Label lab_QueryGoodsId;
        private System.Windows.Forms.TextBox txt_QueryGoodsName;
        private System.Windows.Forms.Label lab_QueryGoodsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsStock;
        private System.Windows.Forms.ComboBox cob_QueryGoodsType;
        private System.Windows.Forms.GroupBox groupBox_Management;
        private System.Windows.Forms.NumericUpDown num_GoodsStock;
        private System.Windows.Forms.ComboBox cob_GoodsType;
        private System.Windows.Forms.Label lab_GoodsType;
        private System.Windows.Forms.Label lab_GoodsStock;
        private System.Windows.Forms.TextBox txt_GoodsPrice;
        private System.Windows.Forms.Label lab_GoodsPrice;
        private System.Windows.Forms.TextBox txt_GoodsId;
        private System.Windows.Forms.Label lab_GoodsId;
        private UCButton ucButton_Submit;
        private System.Windows.Forms.TextBox txt_GoodsName;
        private System.Windows.Forms.Label lab_GoodsName;
        private System.Windows.Forms.TextBox txt_GoodsSales;
        private System.Windows.Forms.Label lab_GoodsSales;
    }
}