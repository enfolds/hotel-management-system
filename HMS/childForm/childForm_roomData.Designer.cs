namespace HMS.childForm
{
    partial class childForm_roomData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(childForm_roomData));
            this.pal_Left = new System.Windows.Forms.Panel();
            this.pal_Bottom = new System.Windows.Forms.Panel();
            this.pal_Top = new System.Windows.Forms.Panel();
            this.pal_Right = new System.Windows.Forms.Panel();
            this.dgvRoom = new System.Windows.Forms.DataGridView();
            this.RoomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomStatusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiModify = new System.Windows.Forms.ToolStripMenuItem();
            this.ucButton_submit = new HMS.UCButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_modifications = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Hidden = new System.Windows.Forms.Button();
            this.txt_types = new System.Windows.Forms.TextBox();
            this.cbo_state = new System.Windows.Forms.ComboBox();
            this.ucButton1 = new HMS.UCButton();
            this.tbo_price = new System.Windows.Forms.TextBox();
            this.tbo_RoomNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_passworda = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_account = new System.Windows.Forms.Label();
            this.ptb_hotel3 = new System.Windows.Forms.PictureBox();
            this.ptb_failure = new System.Windows.Forms.PictureBox();
            this.ptb_hotel4 = new System.Windows.Forms.PictureBox();
            this.cboroom_name = new System.Windows.Forms.ComboBox();
            this.cbostate = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.pnl_modifications.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_hotel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_failure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_hotel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.RoomId,
            this.RoomTypeName,
            this.RoomPrice,
            this.RoomStatusName});
            this.dgvRoom.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvRoom.Location = new System.Drawing.Point(89, 118);
            this.dgvRoom.Name = "dgvRoom";
            this.dgvRoom.ReadOnly = true;
            this.dgvRoom.RowHeadersVisible = false;
            this.dgvRoom.RowHeadersWidth = 51;
            this.dgvRoom.RowTemplate.Height = 29;
            this.dgvRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoom.Size = new System.Drawing.Size(572, 609);
            this.dgvRoom.TabIndex = 4;
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
            this.RoomTypeName.HeaderText = "类型";
            this.RoomTypeName.MinimumWidth = 6;
            this.RoomTypeName.Name = "RoomTypeName";
            this.RoomTypeName.ReadOnly = true;
            // 
            // RoomPrice
            // 
            this.RoomPrice.DataPropertyName = "RoomPrice";
            this.RoomPrice.HeaderText = "价格";
            this.RoomPrice.MinimumWidth = 6;
            this.RoomPrice.Name = "RoomPrice";
            this.RoomPrice.ReadOnly = true;
            // 
            // RoomStatusName
            // 
            this.RoomStatusName.DataPropertyName = "RoomStatusName";
            this.RoomStatusName.HeaderText = "状态";
            this.RoomStatusName.MinimumWidth = 6;
            this.RoomStatusName.Name = "RoomStatusName";
            this.RoomStatusName.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiModify});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 28);
            // 
            // tsmiModify
            // 
            this.tsmiModify.Name = "tsmiModify";
            this.tsmiModify.Size = new System.Drawing.Size(108, 24);
            this.tsmiModify.Text = "修改";
            this.tsmiModify.Click += new System.EventHandler(this.tsmiModify_Click);
            // 
            // ucButton_submit
            // 
            this.ucButton_submit.BackColor = System.Drawing.Color.Transparent;
            this.ucButton_submit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucButton_submit.BackgroundImage")));
            this.ucButton_submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ucButton_submit.Location = new System.Drawing.Point(576, 50);
            this.ucButton_submit.Name = "ucButton_submit";
            this.ucButton_submit.Size = new System.Drawing.Size(85, 45);
            this.ucButton_submit.TabIndex = 20;
            this.ucButton_submit.Click += new System.EventHandler(this.ucButton_submit_Click);
            this.ucButton_submit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ucButton_submit_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(89, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "房间类型";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(332, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "房间状态";
            // 
            // pnl_modifications
            // 
            this.pnl_modifications.BackColor = System.Drawing.Color.Silver;
            this.pnl_modifications.Controls.Add(this.panel1);
            this.pnl_modifications.Controls.Add(this.txt_types);
            this.pnl_modifications.Controls.Add(this.cbo_state);
            this.pnl_modifications.Controls.Add(this.ucButton1);
            this.pnl_modifications.Controls.Add(this.tbo_price);
            this.pnl_modifications.Controls.Add(this.tbo_RoomNumber);
            this.pnl_modifications.Controls.Add(this.label3);
            this.pnl_modifications.Controls.Add(this.lbl_passworda);
            this.pnl_modifications.Controls.Add(this.lbl_password);
            this.pnl_modifications.Controls.Add(this.lbl_account);
            this.pnl_modifications.Location = new System.Drawing.Point(108, 175);
            this.pnl_modifications.Name = "pnl_modifications";
            this.pnl_modifications.Size = new System.Drawing.Size(530, 518);
            this.pnl_modifications.TabIndex = 26;
            this.pnl_modifications.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_Hidden);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 40);
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
            this.label4.Text = "修改房间状态";
            // 
            // btn_Hidden
            // 
            this.btn_Hidden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.btn_Hidden.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Hidden.FlatAppearance.BorderSize = 0;
            this.btn_Hidden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Hidden.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Hidden.Image = ((System.Drawing.Image)(resources.GetObject("btn_Hidden.Image")));
            this.btn_Hidden.Location = new System.Drawing.Point(490, 0);
            this.btn_Hidden.Name = "btn_Hidden";
            this.btn_Hidden.Size = new System.Drawing.Size(40, 40);
            this.btn_Hidden.TabIndex = 16;
            this.btn_Hidden.UseVisualStyleBackColor = false;
            this.btn_Hidden.Click += new System.EventHandler(this.btn_Hidden_Click);
            // 
            // txt_types
            // 
            this.txt_types.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_types.Location = new System.Drawing.Point(177, 193);
            this.txt_types.Name = "txt_types";
            this.txt_types.Size = new System.Drawing.Size(209, 30);
            this.txt_types.TabIndex = 38;
            // 
            // cbo_state
            // 
            this.cbo_state.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbo_state.FormattingEnabled = true;
            this.cbo_state.Location = new System.Drawing.Point(177, 373);
            this.cbo_state.Name = "cbo_state";
            this.cbo_state.Size = new System.Drawing.Size(208, 31);
            this.cbo_state.TabIndex = 37;
            // 
            // ucButton1
            // 
            this.ucButton1.BackColor = System.Drawing.Color.Transparent;
            this.ucButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucButton1.BackgroundImage")));
            this.ucButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ucButton1.Location = new System.Drawing.Point(195, 448);
            this.ucButton1.Name = "ucButton1";
            this.ucButton1.Size = new System.Drawing.Size(130, 45);
            this.ucButton1.TabIndex = 34;
            this.ucButton1.Click += new System.EventHandler(this.ucButton1_Click);
            // 
            // tbo_price
            // 
            this.tbo_price.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbo_price.Location = new System.Drawing.Point(177, 285);
            this.tbo_price.Name = "tbo_price";
            this.tbo_price.Size = new System.Drawing.Size(209, 30);
            this.tbo_price.TabIndex = 28;
            // 
            // tbo_RoomNumber
            // 
            this.tbo_RoomNumber.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbo_RoomNumber.Location = new System.Drawing.Point(177, 94);
            this.tbo_RoomNumber.Name = "tbo_RoomNumber";
            this.tbo_RoomNumber.Size = new System.Drawing.Size(209, 30);
            this.tbo_RoomNumber.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(116, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "状态：";
            // 
            // lbl_passworda
            // 
            this.lbl_passworda.AutoSize = true;
            this.lbl_passworda.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_passworda.Location = new System.Drawing.Point(116, 288);
            this.lbl_passworda.Name = "lbl_passworda";
            this.lbl_passworda.Size = new System.Drawing.Size(61, 23);
            this.lbl_passworda.TabIndex = 20;
            this.lbl_passworda.Text = "价格：";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_password.Location = new System.Drawing.Point(116, 193);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(61, 23);
            this.lbl_password.TabIndex = 19;
            this.lbl_password.Text = "类型：";
            // 
            // lbl_account
            // 
            this.lbl_account.AutoSize = true;
            this.lbl_account.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_account.Location = new System.Drawing.Point(116, 97);
            this.lbl_account.Name = "lbl_account";
            this.lbl_account.Size = new System.Drawing.Size(61, 23);
            this.lbl_account.TabIndex = 18;
            this.lbl_account.Text = "房号：";
            // 
            // ptb_hotel3
            // 
            this.ptb_hotel3.Image = ((System.Drawing.Image)(resources.GetObject("ptb_hotel3.Image")));
            this.ptb_hotel3.Location = new System.Drawing.Point(753, 118);
            this.ptb_hotel3.Name = "ptb_hotel3";
            this.ptb_hotel3.Size = new System.Drawing.Size(875, 575);
            this.ptb_hotel3.TabIndex = 27;
            this.ptb_hotel3.TabStop = false;
            this.ptb_hotel3.Visible = false;
            // 
            // ptb_failure
            // 
            this.ptb_failure.Image = ((System.Drawing.Image)(resources.GetObject("ptb_failure.Image")));
            this.ptb_failure.Location = new System.Drawing.Point(753, 118);
            this.ptb_failure.Name = "ptb_failure";
            this.ptb_failure.Size = new System.Drawing.Size(875, 575);
            this.ptb_failure.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_failure.TabIndex = 28;
            this.ptb_failure.TabStop = false;
            this.ptb_failure.Visible = false;
            // 
            // ptb_hotel4
            // 
            this.ptb_hotel4.Image = ((System.Drawing.Image)(resources.GetObject("ptb_hotel4.Image")));
            this.ptb_hotel4.Location = new System.Drawing.Point(753, 118);
            this.ptb_hotel4.Name = "ptb_hotel4";
            this.ptb_hotel4.Size = new System.Drawing.Size(875, 575);
            this.ptb_hotel4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_hotel4.TabIndex = 29;
            this.ptb_hotel4.TabStop = false;
            // 
            // cboroom_name
            // 
            this.cboroom_name.FormattingEnabled = true;
            this.cboroom_name.Location = new System.Drawing.Point(173, 64);
            this.cboroom_name.Name = "cboroom_name";
            this.cboroom_name.Size = new System.Drawing.Size(134, 28);
            this.cboroom_name.TabIndex = 102;
            // 
            // cbostate
            // 
            this.cbostate.FormattingEnabled = true;
            this.cbostate.Location = new System.Drawing.Point(416, 66);
            this.cbostate.Name = "cbostate";
            this.cbostate.Size = new System.Drawing.Size(134, 28);
            this.cbostate.TabIndex = 103;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(753, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(875, 575);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // childForm_roomData
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1712, 1030);
            this.Controls.Add(this.cbostate);
            this.Controls.Add(this.cboroom_name);
            this.Controls.Add(this.pnl_modifications);
            this.Controls.Add(this.ptb_hotel4);
            this.Controls.Add(this.ptb_hotel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucButton_submit);
            this.Controls.Add(this.dgvRoom);
            this.Controls.Add(this.pal_Left);
            this.Controls.Add(this.pal_Bottom);
            this.Controls.Add(this.pal_Top);
            this.Controls.Add(this.pal_Right);
            this.Controls.Add(this.ptb_failure);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "childForm_roomData";
            this.Text = "childForm_home";
            this.Load += new System.EventHandler(this.childForm_roomData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.pnl_modifications.ResumeLayout(false);
            this.pnl_modifications.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_hotel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_failure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_hotel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pal_Left;
        private System.Windows.Forms.Panel pal_Bottom;
        private System.Windows.Forms.Panel pal_Top;
        private System.Windows.Forms.Panel pal_Right;
        private UCButton ucButton_submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiModify;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomStatusName;
        public System.Windows.Forms.DataGridView dgvRoom;
        private System.Windows.Forms.Panel pnl_modifications;
        private UCButton ucButton1;
        private System.Windows.Forms.TextBox tbo_price;
        public System.Windows.Forms.TextBox tbo_RoomNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_passworda;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_account;
        private System.Windows.Forms.ComboBox cbo_state;
        public System.Windows.Forms.TextBox txt_types;
        private System.Windows.Forms.PictureBox ptb_hotel3;
        private System.Windows.Forms.PictureBox ptb_failure;
        private System.Windows.Forms.PictureBox ptb_hotel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Hidden;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cboroom_name;
        private System.Windows.Forms.ComboBox cbostate;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}