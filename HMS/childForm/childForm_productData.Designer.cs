namespace HMS.childForm
{
    partial class childForm_productData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(childForm_productData));
            this.pal_Left = new System.Windows.Forms.Panel();
            this.pal_Bottom = new System.Windows.Forms.Panel();
            this.pal_Top = new System.Windows.Forms.Panel();
            this.pal_Right = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnl_modifications1s = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Hidden = new System.Windows.Forms.Button();
            this.ucButton1s = new HMS.UCButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_prices_1 = new System.Windows.Forms.TextBox();
            this.txt_num_1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_name_1 = new System.Windows.Forms.TextBox();
            this.txt_type_1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvtype = new System.Windows.Forms.DataGridView();
            this.GoodsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodssPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.cbo_name_1 = new System.Windows.Forms.ComboBox();
            this.ucButton_submit = new HMS.UCButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnl_modifications1s.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtype)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(50, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1610, 970);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Load);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnl_modifications1s);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_price);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dgvtype);
            this.groupBox1.Controls.Add(this.cbo_name_1);
            this.groupBox1.Controls.Add(this.ucButton_submit);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(46, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 621);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "商品列表";
            // 
            // pnl_modifications1s
            // 
            this.pnl_modifications1s.BackColor = System.Drawing.Color.Silver;
            this.pnl_modifications1s.Controls.Add(this.panel2);
            this.pnl_modifications1s.Controls.Add(this.ucButton1s);
            this.pnl_modifications1s.Controls.Add(this.label5);
            this.pnl_modifications1s.Controls.Add(this.txt_prices_1);
            this.pnl_modifications1s.Controls.Add(this.txt_num_1);
            this.pnl_modifications1s.Controls.Add(this.label8);
            this.pnl_modifications1s.Controls.Add(this.txt_name_1);
            this.pnl_modifications1s.Controls.Add(this.txt_type_1);
            this.pnl_modifications1s.Controls.Add(this.label7);
            this.pnl_modifications1s.Controls.Add(this.label6);
            this.pnl_modifications1s.Location = new System.Drawing.Point(94, 142);
            this.pnl_modifications1s.Name = "pnl_modifications1s";
            this.pnl_modifications1s.Size = new System.Drawing.Size(437, 400);
            this.pnl_modifications1s.TabIndex = 28;
            this.pnl_modifications1s.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btn_Hidden);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(437, 40);
            this.panel2.TabIndex = 39;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 30);
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(49, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 23);
            this.label9.TabIndex = 37;
            this.label9.Text = "删除商品类型";
            // 
            // btn_Hidden
            // 
            this.btn_Hidden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.btn_Hidden.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Hidden.FlatAppearance.BorderSize = 0;
            this.btn_Hidden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Hidden.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Hidden.Image = ((System.Drawing.Image)(resources.GetObject("btn_Hidden.Image")));
            this.btn_Hidden.Location = new System.Drawing.Point(397, 0);
            this.btn_Hidden.Name = "btn_Hidden";
            this.btn_Hidden.Size = new System.Drawing.Size(40, 40);
            this.btn_Hidden.TabIndex = 16;
            this.btn_Hidden.UseVisualStyleBackColor = false;
            this.btn_Hidden.Click += new System.EventHandler(this.btn_Hidden_Click);
            // 
            // ucButton1s
            // 
            this.ucButton1s.BackColor = System.Drawing.Color.Transparent;
            this.ucButton1s.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucButton1s.BackgroundImage")));
            this.ucButton1s.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ucButton1s.Location = new System.Drawing.Point(137, 343);
            this.ucButton1s.Name = "ucButton1s";
            this.ucButton1s.Size = new System.Drawing.Size(130, 45);
            this.ucButton1s.TabIndex = 34;
            this.ucButton1s.Click += new System.EventHandler(this.ucButton1s_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "商品编号：";
            // 
            // txt_prices_1
            // 
            this.txt_prices_1.Location = new System.Drawing.Point(232, 271);
            this.txt_prices_1.Name = "txt_prices_1";
            this.txt_prices_1.Size = new System.Drawing.Size(125, 30);
            this.txt_prices_1.TabIndex = 7;
            // 
            // txt_num_1
            // 
            this.txt_num_1.Location = new System.Drawing.Point(232, 72);
            this.txt_num_1.Name = "txt_num_1";
            this.txt_num_1.Size = new System.Drawing.Size(125, 30);
            this.txt_num_1.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 23);
            this.label8.TabIndex = 3;
            this.label8.Text = "商品价格：";
            // 
            // txt_name_1
            // 
            this.txt_name_1.Location = new System.Drawing.Point(232, 202);
            this.txt_name_1.Name = "txt_name_1";
            this.txt_name_1.Size = new System.Drawing.Size(125, 30);
            this.txt_name_1.TabIndex = 5;
            // 
            // txt_type_1
            // 
            this.txt_type_1.Location = new System.Drawing.Point(232, 131);
            this.txt_type_1.Name = "txt_type_1";
            this.txt_type_1.Size = new System.Drawing.Size(125, 30);
            this.txt_type_1.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "商品名称：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "商品类型：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "（低于此价格）";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "商品类型：";
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(94, 69);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(81, 30);
            this.txt_price.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "价格：";
            // 
            // dgvtype
            // 
            this.dgvtype.AllowUserToAddRows = false;
            this.dgvtype.AllowUserToResizeColumns = false;
            this.dgvtype.AllowUserToResizeRows = false;
            this.dgvtype.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtype.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.dgvtype.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvtype.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtype.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GoodsId,
            this.GoodsTypeName,
            this.GoodsName,
            this.GoodssPrice});
            this.dgvtype.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvtype.Location = new System.Drawing.Point(15, 109);
            this.dgvtype.Name = "dgvtype";
            this.dgvtype.ReadOnly = true;
            this.dgvtype.RowHeadersVisible = false;
            this.dgvtype.RowHeadersWidth = 51;
            this.dgvtype.RowTemplate.Height = 29;
            this.dgvtype.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvtype.Size = new System.Drawing.Size(625, 451);
            this.dgvtype.TabIndex = 10;
            // 
            // GoodsId
            // 
            this.GoodsId.DataPropertyName = "GoodsId";
            this.GoodsId.HeaderText = "商品编号";
            this.GoodsId.MinimumWidth = 6;
            this.GoodsId.Name = "GoodsId";
            this.GoodsId.ReadOnly = true;
            // 
            // GoodsTypeName
            // 
            this.GoodsTypeName.DataPropertyName = "GoodsTypeName";
            this.GoodsTypeName.HeaderText = "商品类型";
            this.GoodsTypeName.MinimumWidth = 6;
            this.GoodsTypeName.Name = "GoodsTypeName";
            this.GoodsTypeName.ReadOnly = true;
            // 
            // GoodsName
            // 
            this.GoodsName.DataPropertyName = "GoodsName";
            this.GoodsName.HeaderText = "商品名称";
            this.GoodsName.MinimumWidth = 6;
            this.GoodsName.Name = "GoodsName";
            this.GoodsName.ReadOnly = true;
            // 
            // GoodssPrice
            // 
            this.GoodssPrice.DataPropertyName = "GoodssPrice";
            this.GoodssPrice.HeaderText = "商品价格";
            this.GoodssPrice.MinimumWidth = 6;
            this.GoodssPrice.Name = "GoodssPrice";
            this.GoodssPrice.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_delete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 28);
            // 
            // tsmi_delete
            // 
            this.tsmi_delete.Name = "tsmi_delete";
            this.tsmi_delete.Size = new System.Drawing.Size(108, 24);
            this.tsmi_delete.Text = "删除";
            this.tsmi_delete.Click += new System.EventHandler(this.tsmi_delete_Click);
            // 
            // cbo_name_1
            // 
            this.cbo_name_1.FormattingEnabled = true;
            this.cbo_name_1.Location = new System.Drawing.Point(417, 67);
            this.cbo_name_1.Name = "cbo_name_1";
            this.cbo_name_1.Size = new System.Drawing.Size(130, 31);
            this.cbo_name_1.TabIndex = 9;
            // 
            // ucButton_submit
            // 
            this.ucButton_submit.BackColor = System.Drawing.Color.Transparent;
            this.ucButton_submit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucButton_submit.BackgroundImage")));
            this.ucButton_submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ucButton_submit.Location = new System.Drawing.Point(555, 56);
            this.ucButton_submit.Margin = new System.Windows.Forms.Padding(5);
            this.ucButton_submit.Name = "ucButton_submit";
            this.ucButton_submit.Size = new System.Drawing.Size(85, 45);
            this.ucButton_submit.TabIndex = 7;
            this.ucButton_submit.Click += new System.EventHandler(this.ucButton_submit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(714, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(876, 551);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // childForm_productData
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1710, 1030);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pal_Bottom);
            this.Controls.Add(this.pal_Top);
            this.Controls.Add(this.pal_Right);
            this.Controls.Add(this.pal_Left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "childForm_productData";
            this.Text = "childForm_home";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnl_modifications1s.ResumeLayout(false);
            this.pnl_modifications1s.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtype)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private UCButton ucButton_submit;
        private System.Windows.Forms.DataGridView dgvtype;
        private System.Windows.Forms.ComboBox cbo_name_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodssPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_delete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_prices_1;
        private System.Windows.Forms.TextBox txt_type_1;
        private System.Windows.Forms.TextBox txt_name_1;
        private System.Windows.Forms.TextBox txt_num_1;
        private System.Windows.Forms.Panel pnl_modifications1s;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Hidden;
        private UCButton ucButton1s;
    }
}