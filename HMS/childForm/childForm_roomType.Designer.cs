namespace HMS.childForm
{
    partial class childForm_roomType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(childForm_roomType));
            this.pal_Left = new System.Windows.Forms.Panel();
            this.pal_Bottom = new System.Windows.Forms.Panel();
            this.pal_Top = new System.Windows.Forms.Panel();
            this.pal_Right = new System.Windows.Forms.Panel();
            this.dgvRoom = new System.Windows.Forms.DataGridView();
            this.RoomTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_add = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cbonum = new System.Windows.Forms.ComboBox();
            this.ucButton_submit = new HMS.UCButton();
            this.ptb_hotel1 = new System.Windows.Forms.PictureBox();
            this.pnl_modifications1 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Hidden = new System.Windows.Forms.Button();
            this.txt_types1 = new System.Windows.Forms.TextBox();
            this.ucButton1s = new HMS.UCButton();
            this.lbl_password = new System.Windows.Forms.Label();
            this.ptb_hotel2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_hotel1)).BeginInit();
            this.pnl_modifications1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_hotel2)).BeginInit();
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
            this.pal_Bottom.Size = new System.Drawing.Size(1662, 30);
            this.pal_Bottom.TabIndex = 2;
            // 
            // pal_Top
            // 
            this.pal_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pal_Top.Location = new System.Drawing.Point(0, 0);
            this.pal_Top.Name = "pal_Top";
            this.pal_Top.Size = new System.Drawing.Size(1662, 30);
            this.pal_Top.TabIndex = 1;
            // 
            // pal_Right
            // 
            this.pal_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.pal_Right.Location = new System.Drawing.Point(1662, 0);
            this.pal_Right.Name = "pal_Right";
            this.pal_Right.Size = new System.Drawing.Size(50, 1030);
            this.pal_Right.TabIndex = 1;
            // 
            // dgvRoom
            // 
            this.dgvRoom.AllowUserToAddRows = false;
            this.dgvRoom.AllowUserToResizeColumns = false;
            this.dgvRoom.AllowUserToResizeRows = false;
            this.dgvRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoom.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvRoom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomTypeId,
            this.RoomTypeName});
            this.dgvRoom.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvRoom.Location = new System.Drawing.Point(178, 144);
            this.dgvRoom.Name = "dgvRoom";
            this.dgvRoom.ReadOnly = true;
            this.dgvRoom.RowHeadersVisible = false;
            this.dgvRoom.RowHeadersWidth = 51;
            this.dgvRoom.RowTemplate.Height = 29;
            this.dgvRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoom.Size = new System.Drawing.Size(437, 378);
            this.dgvRoom.TabIndex = 5;
            // 
            // RoomTypeId
            // 
            this.RoomTypeId.DataPropertyName = "RoomTypeId";
            this.RoomTypeId.HeaderText = "类型编号";
            this.RoomTypeId.MinimumWidth = 6;
            this.RoomTypeId.Name = "RoomTypeId";
            this.RoomTypeId.ReadOnly = true;
            // 
            // RoomTypeName
            // 
            this.RoomTypeName.DataPropertyName = "RoomTypeName";
            this.RoomTypeName.HeaderText = "房间类型";
            this.RoomTypeName.MinimumWidth = 6;
            this.RoomTypeName.Name = "RoomTypeName";
            this.RoomTypeName.ReadOnly = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(178, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "房间类型";
            // 
            // cbonum
            // 
            this.cbonum.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbonum.FormattingEnabled = true;
            this.cbonum.Location = new System.Drawing.Point(322, 81);
            this.cbonum.Name = "cbonum";
            this.cbonum.Size = new System.Drawing.Size(151, 31);
            this.cbonum.TabIndex = 7;
            // 
            // ucButton_submit
            // 
            this.ucButton_submit.BackColor = System.Drawing.Color.Transparent;
            this.ucButton_submit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucButton_submit.BackgroundImage")));
            this.ucButton_submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ucButton_submit.Location = new System.Drawing.Point(530, 64);
            this.ucButton_submit.Name = "ucButton_submit";
            this.ucButton_submit.Size = new System.Drawing.Size(85, 45);
            this.ucButton_submit.TabIndex = 19;
            this.ucButton_submit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ucButton_submit_MouseClick);
            // 
            // ptb_hotel1
            // 
            this.ptb_hotel1.Image = ((System.Drawing.Image)(resources.GetObject("ptb_hotel1.Image")));
            this.ptb_hotel1.Location = new System.Drawing.Point(645, 64);
            this.ptb_hotel1.Name = "ptb_hotel1";
            this.ptb_hotel1.Size = new System.Drawing.Size(967, 727);
            this.ptb_hotel1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_hotel1.TabIndex = 20;
            this.ptb_hotel1.TabStop = false;
            // 
            // pnl_modifications1
            // 
            this.pnl_modifications1.BackColor = System.Drawing.Color.Silver;
            this.pnl_modifications1.Controls.Add(this.panel1);
            this.pnl_modifications1.Controls.Add(this.txt_types1);
            this.pnl_modifications1.Controls.Add(this.ucButton1s);
            this.pnl_modifications1.Controls.Add(this.lbl_password);
            this.pnl_modifications1.Location = new System.Drawing.Point(258, 192);
            this.pnl_modifications1.Name = "pnl_modifications1";
            this.pnl_modifications1.Size = new System.Drawing.Size(247, 279);
            this.pnl_modifications1.TabIndex = 27;
            this.pnl_modifications1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_Hidden);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 40);
            this.panel1.TabIndex = 39;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(49, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "添加房间类型";
            // 
            // btn_Hidden
            // 
            this.btn_Hidden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.btn_Hidden.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Hidden.FlatAppearance.BorderSize = 0;
            this.btn_Hidden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Hidden.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Hidden.Image = ((System.Drawing.Image)(resources.GetObject("btn_Hidden.Image")));
            this.btn_Hidden.Location = new System.Drawing.Point(207, 0);
            this.btn_Hidden.Name = "btn_Hidden";
            this.btn_Hidden.Size = new System.Drawing.Size(40, 40);
            this.btn_Hidden.TabIndex = 16;
            this.btn_Hidden.UseVisualStyleBackColor = false;
            this.btn_Hidden.Click += new System.EventHandler(this.btn_Hidden_Click);
            // 
            // txt_types1
            // 
            this.txt_types1.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_types1.Location = new System.Drawing.Point(23, 126);
            this.txt_types1.Name = "txt_types1";
            this.txt_types1.Size = new System.Drawing.Size(209, 30);
            this.txt_types1.TabIndex = 38;
            // 
            // ucButton1s
            // 
            this.ucButton1s.BackColor = System.Drawing.Color.Transparent;
            this.ucButton1s.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucButton1s.BackgroundImage")));
            this.ucButton1s.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ucButton1s.Location = new System.Drawing.Point(64, 179);
            this.ucButton1s.Name = "ucButton1s";
            this.ucButton1s.Size = new System.Drawing.Size(130, 45);
            this.ucButton1s.TabIndex = 34;
            this.ucButton1s.Click += new System.EventHandler(this.ucButton1s_Click);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_password.Location = new System.Drawing.Point(96, 69);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(72, 27);
            this.lbl_password.TabIndex = 19;
            this.lbl_password.Text = "类型：";
            // 
            // ptb_hotel2
            // 
            this.ptb_hotel2.Image = ((System.Drawing.Image)(resources.GetObject("ptb_hotel2.Image")));
            this.ptb_hotel2.Location = new System.Drawing.Point(645, 64);
            this.ptb_hotel2.Name = "ptb_hotel2";
            this.ptb_hotel2.Size = new System.Drawing.Size(967, 727);
            this.ptb_hotel2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_hotel2.TabIndex = 4;
            this.ptb_hotel2.TabStop = false;
            // 
            // childForm_roomType
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1712, 1030);
            this.Controls.Add(this.pnl_modifications1);
            this.Controls.Add(this.ucButton_submit);
            this.Controls.Add(this.cbonum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRoom);
            this.Controls.Add(this.ptb_hotel2);
            this.Controls.Add(this.pal_Left);
            this.Controls.Add(this.pal_Bottom);
            this.Controls.Add(this.pal_Top);
            this.Controls.Add(this.pal_Right);
            this.Controls.Add(this.ptb_hotel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "childForm_roomType";
            this.Text = "k,k";
            this.Load += new System.EventHandler(this.childForm_roomType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_hotel1)).EndInit();
            this.pnl_modifications1.ResumeLayout(false);
            this.pnl_modifications1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_hotel2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pal_Left;
        private System.Windows.Forms.Panel pal_Bottom;
        private System.Windows.Forms.Panel pal_Top;
        private System.Windows.Forms.Panel pal_Right;
        private System.Windows.Forms.DataGridView dgvRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbonum;
        private UCButton ucButton_submit;
        private System.Windows.Forms.PictureBox ptb_hotel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_add;
        private System.Windows.Forms.Panel pnl_modifications1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Hidden;
        public System.Windows.Forms.TextBox txt_types1;
        private UCButton ucButton1s;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomTypeName;
        private System.Windows.Forms.PictureBox ptb_hotel2;
    }
}