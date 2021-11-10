namespace HMS.childForm
{
    partial class childForm_merchandiseType
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(childForm_merchandiseType));
            this.pal_Left = new System.Windows.Forms.Panel();
            this.pal_Bottom = new System.Windows.Forms.Panel();
            this.pal_Top = new System.Windows.Forms.Panel();
            this.pal_Right = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnl_addType = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_add = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.ucButton_submits = new HMS.UCButton();
            this.txt_add = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvtype = new System.Windows.Forms.DataGridView();
            this.GoodsTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucButton1 = new HMS.UCButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_types_1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnl_addType.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtype)).BeginInit();
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
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(623, 491);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(464, 48);
            this.label2.TabIndex = 8;
            this.label2.Text = "抱歉，该功能正在开发中！";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(50, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1610, 970);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Load);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(677, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(927, 653);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnl_addType);
            this.groupBox1.Controls.Add(this.dgvtype);
            this.groupBox1.Controls.Add(this.ucButton1);
            this.groupBox1.Controls.Add(this.cbo_types_1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(46, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 653);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "商品类型";
            // 
            // pnl_addType
            // 
            this.pnl_addType.BackColor = System.Drawing.Color.Gainsboro;
            this.pnl_addType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_addType.ContextMenuStrip = this.contextMenuStrip1;
            this.pnl_addType.Controls.Add(this.button1);
            this.pnl_addType.Controls.Add(this.ucButton_submits);
            this.pnl_addType.Controls.Add(this.txt_add);
            this.pnl_addType.Controls.Add(this.label3);
            this.pnl_addType.Location = new System.Drawing.Point(69, 201);
            this.pnl_addType.Name = "pnl_addType";
            this.pnl_addType.Size = new System.Drawing.Size(414, 230);
            this.pnl_addType.TabIndex = 12;
            this.pnl_addType.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_add});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 28);
            // 
            // tsmi_add
            // 
            this.tsmi_add.Name = "tsmi_add";
            this.tsmi_add.Size = new System.Drawing.Size(138, 24);
            this.tsmi_add.Text = "添加类型";
            this.tsmi_add.Click += new System.EventHandler(this.tsmi_add_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(239, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 52);
            this.button1.TabIndex = 10;
            this.button1.Text = "返回";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ucButton_submits
            // 
            this.ucButton_submits.BackColor = System.Drawing.Color.Transparent;
            this.ucButton_submits.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucButton_submits.BackgroundImage")));
            this.ucButton_submits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ucButton_submits.Location = new System.Drawing.Point(67, 161);
            this.ucButton_submits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucButton_submits.Name = "ucButton_submits";
            this.ucButton_submits.Size = new System.Drawing.Size(94, 52);
            this.ucButton_submits.TabIndex = 9;
            this.ucButton_submits.Click += new System.EventHandler(this.ucButton_submits_Click);
            // 
            // txt_add
            // 
            this.txt_add.Location = new System.Drawing.Point(186, 72);
            this.txt_add.Name = "txt_add";
            this.txt_add.Size = new System.Drawing.Size(165, 30);
            this.txt_add.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "添加类型:";
            // 
            // dgvtype
            // 
            this.dgvtype.AllowUserToAddRows = false;
            this.dgvtype.AllowUserToResizeColumns = false;
            this.dgvtype.AllowUserToResizeRows = false;
            this.dgvtype.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtype.BackgroundColor = System.Drawing.Color.White;
            this.dgvtype.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvtype.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtype.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GoodsTypeId,
            this.GoodsTypeName});
            this.dgvtype.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvtype.Location = new System.Drawing.Point(54, 133);
            this.dgvtype.Name = "dgvtype";
            this.dgvtype.ReadOnly = true;
            this.dgvtype.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvtype.RowHeadersVisible = false;
            this.dgvtype.RowHeadersWidth = 51;
            this.dgvtype.RowTemplate.Height = 29;
            this.dgvtype.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvtype.Size = new System.Drawing.Size(444, 369);
            this.dgvtype.TabIndex = 11;
            // 
            // GoodsTypeId
            // 
            this.GoodsTypeId.DataPropertyName = "GoodsTypeId";
            this.GoodsTypeId.HeaderText = "类型编号";
            this.GoodsTypeId.MinimumWidth = 6;
            this.GoodsTypeId.Name = "GoodsTypeId";
            this.GoodsTypeId.ReadOnly = true;
            // 
            // GoodsTypeName
            // 
            this.GoodsTypeName.DataPropertyName = "GoodsTypeName";
            this.GoodsTypeName.HeaderText = "商品类型";
            this.GoodsTypeName.MinimumWidth = 6;
            this.GoodsTypeName.Name = "GoodsTypeName";
            this.GoodsTypeName.ReadOnly = true;
            // 
            // ucButton1
            // 
            this.ucButton1.BackColor = System.Drawing.Color.Transparent;
            this.ucButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucButton1.BackgroundImage")));
            this.ucButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ucButton1.Location = new System.Drawing.Point(388, 52);
            this.ucButton1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.ucButton1.Name = "ucButton1";
            this.ucButton1.Size = new System.Drawing.Size(84, 45);
            this.ucButton1.TabIndex = 10;
            this.ucButton1.Click += new System.EventHandler(this.ucButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "商品类型";
            // 
            // cbo_types_1
            // 
            this.cbo_types_1.FormattingEnabled = true;
            this.cbo_types_1.Location = new System.Drawing.Point(182, 62);
            this.cbo_types_1.Name = "cbo_types_1";
            this.cbo_types_1.Size = new System.Drawing.Size(151, 31);
            this.cbo_types_1.TabIndex = 9;
            // 
            // childForm_merchandiseType
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1710, 1030);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pal_Bottom);
            this.Controls.Add(this.pal_Top);
            this.Controls.Add(this.pal_Right);
            this.Controls.Add(this.pal_Left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "childForm_merchandiseType";
            this.Text = "childForm_home";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnl_addType.ResumeLayout(false);
            this.pnl_addType.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtype)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pal_Left;
        private System.Windows.Forms.Panel pal_Bottom;
        private System.Windows.Forms.Panel pal_Top;
        private System.Windows.Forms.Panel pal_Right;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvtype;
        private UCButton ucButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_add;
        private System.Windows.Forms.Panel pnl_addType;
        private System.Windows.Forms.TextBox txt_add;
        private System.Windows.Forms.Label label3;
        private UCButton ucButton_submits;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsTypeName;
        private System.Windows.Forms.ComboBox cbo_types_1;
    }
}