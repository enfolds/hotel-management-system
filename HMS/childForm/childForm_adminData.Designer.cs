namespace HMS.childForm
{
    partial class childForm_adminData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(childForm_adminData));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pal_Left = new System.Windows.Forms.Panel();
            this.pal_Bottom = new System.Windows.Forms.Panel();
            this.pal_Top = new System.Windows.Forms.Panel();
            this.pal_Right = new System.Windows.Forms.Panel();
            this.lbl_name = new System.Windows.Forms.Label();
            this.tbo_name = new System.Windows.Forms.TextBox();
            this.ucButton_query = new HMS.UCButton();
            this.lbl_support = new System.Windows.Forms.Label();
            this.dgv_query = new System.Windows.Forms.DataGridView();
            this.AdminName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdminRightsType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdminPwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cms_shortcuts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsm_modification = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_deletion = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_modification = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Hidden = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ucButton_emptying = new HMS.UCButton();
            this.ucButton_submit = new HMS.UCButton();
            this.cbo_permissions = new System.Windows.Forms.ComboBox();
            this.rbt_female = new System.Windows.Forms.RadioButton();
            this.rbt_man = new System.Windows.Forms.RadioButton();
            this.tbo_phone = new System.Windows.Forms.TextBox();
            this.tbo_passworda = new System.Windows.Forms.TextBox();
            this.tbo_namea = new System.Windows.Forms.TextBox();
            this.tbo_password = new System.Windows.Forms.TextBox();
            this.tbo_account = new System.Windows.Forms.TextBox();
            this.lbl_permissions = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_Sex = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_passworda = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_account = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_query)).BeginInit();
            this.cms_shortcuts.SuspendLayout();
            this.pnl_modification.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_name.Location = new System.Drawing.Point(616, 140);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(58, 20);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "用户名:";
            // 
            // tbo_name
            // 
            this.tbo_name.Location = new System.Drawing.Point(680, 137);
            this.tbo_name.Name = "tbo_name";
            this.tbo_name.Size = new System.Drawing.Size(162, 27);
            this.tbo_name.TabIndex = 4;
            // 
            // ucButton_query
            // 
            this.ucButton_query.BackColor = System.Drawing.Color.Transparent;
            this.ucButton_query.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucButton_query.BackgroundImage")));
            this.ucButton_query.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ucButton_query.Location = new System.Drawing.Point(876, 122);
            this.ucButton_query.Name = "ucButton_query";
            this.ucButton_query.Size = new System.Drawing.Size(85, 45);
            this.ucButton_query.TabIndex = 5;
            this.ucButton_query.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_support
            // 
            this.lbl_support.AutoSize = true;
            this.lbl_support.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_support.Location = new System.Drawing.Point(987, 147);
            this.lbl_support.Name = "lbl_support";
            this.lbl_support.Size = new System.Drawing.Size(103, 20);
            this.lbl_support.TabIndex = 6;
            this.lbl_support.Text = "(支持模糊查询)";
            // 
            // dgv_query
            // 
            this.dgv_query.AllowUserToAddRows = false;
            this.dgv_query.AllowUserToResizeColumns = false;
            this.dgv_query.AllowUserToResizeRows = false;
            this.dgv_query.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_query.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_query.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv_query.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_query.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AdminName,
            this.Namea,
            this.Sex,
            this.Phone,
            this.AdminRightsType,
            this.AdminPwd});
            this.dgv_query.ContextMenuStrip = this.cms_shortcuts;
            this.dgv_query.Location = new System.Drawing.Point(429, 191);
            this.dgv_query.Name = "dgv_query";
            this.dgv_query.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_query.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_query.RowHeadersVisible = false;
            this.dgv_query.RowHeadersWidth = 51;
            this.dgv_query.RowTemplate.Height = 29;
            this.dgv_query.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_query.Size = new System.Drawing.Size(861, 459);
            this.dgv_query.TabIndex = 7;
            // 
            // AdminName
            // 
            this.AdminName.DataPropertyName = "AdminName";
            this.AdminName.HeaderText = "账户";
            this.AdminName.MinimumWidth = 6;
            this.AdminName.Name = "AdminName";
            this.AdminName.ReadOnly = true;
            this.AdminName.Width = 172;
            // 
            // Namea
            // 
            this.Namea.DataPropertyName = "Name";
            this.Namea.HeaderText = "姓名";
            this.Namea.MinimumWidth = 6;
            this.Namea.Name = "Namea";
            this.Namea.ReadOnly = true;
            this.Namea.Width = 172;
            // 
            // Sex
            // 
            this.Sex.DataPropertyName = "Sex";
            this.Sex.HeaderText = "性别";
            this.Sex.MinimumWidth = 6;
            this.Sex.Name = "Sex";
            this.Sex.ReadOnly = true;
            this.Sex.Width = 171;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "电话";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Width = 172;
            // 
            // AdminRightsType
            // 
            this.AdminRightsType.DataPropertyName = "AdminRightsType";
            this.AdminRightsType.HeaderText = "权限";
            this.AdminRightsType.MinimumWidth = 6;
            this.AdminRightsType.Name = "AdminRightsType";
            this.AdminRightsType.ReadOnly = true;
            this.AdminRightsType.Width = 172;
            // 
            // AdminPwd
            // 
            this.AdminPwd.DataPropertyName = "AdminPwd";
            this.AdminPwd.HeaderText = "密码";
            this.AdminPwd.MinimumWidth = 6;
            this.AdminPwd.Name = "AdminPwd";
            this.AdminPwd.ReadOnly = true;
            this.AdminPwd.Visible = false;
            this.AdminPwd.Width = 125;
            // 
            // cms_shortcuts
            // 
            this.cms_shortcuts.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms_shortcuts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_modification,
            this.tsm_deletion});
            this.cms_shortcuts.Name = "contextMenuStrip1";
            this.cms_shortcuts.Size = new System.Drawing.Size(211, 80);
            // 
            // tsm_modification
            // 
            this.tsm_modification.Name = "tsm_modification";
            this.tsm_modification.Size = new System.Drawing.Size(210, 24);
            this.tsm_modification.Text = "修改";
            this.tsm_modification.Click += new System.EventHandler(this.tsm_modification_Click);
            // 
            // tsm_deletion
            // 
            this.tsm_deletion.Name = "tsm_deletion";
            this.tsm_deletion.Size = new System.Drawing.Size(210, 24);
            this.tsm_deletion.Text = "删除";
            this.tsm_deletion.Click += new System.EventHandler(this.tsm_deletion_Click);
            // 
            // pnl_modification
            // 
            this.pnl_modification.BackColor = System.Drawing.Color.Gainsboro;
            this.pnl_modification.Controls.Add(this.panel1);
            this.pnl_modification.Controls.Add(this.ucButton_emptying);
            this.pnl_modification.Controls.Add(this.ucButton_submit);
            this.pnl_modification.Controls.Add(this.cbo_permissions);
            this.pnl_modification.Controls.Add(this.rbt_female);
            this.pnl_modification.Controls.Add(this.rbt_man);
            this.pnl_modification.Controls.Add(this.tbo_phone);
            this.pnl_modification.Controls.Add(this.tbo_passworda);
            this.pnl_modification.Controls.Add(this.tbo_namea);
            this.pnl_modification.Controls.Add(this.tbo_password);
            this.pnl_modification.Controls.Add(this.tbo_account);
            this.pnl_modification.Controls.Add(this.lbl_permissions);
            this.pnl_modification.Controls.Add(this.lbl_phone);
            this.pnl_modification.Controls.Add(this.lbl_Sex);
            this.pnl_modification.Controls.Add(this.label1);
            this.pnl_modification.Controls.Add(this.lbl_passworda);
            this.pnl_modification.Controls.Add(this.lbl_password);
            this.pnl_modification.Controls.Add(this.lbl_account);
            this.pnl_modification.Controls.Add(this.panel2);
            this.pnl_modification.Location = new System.Drawing.Point(606, 122);
            this.pnl_modification.Name = "pnl_modification";
            this.pnl_modification.Size = new System.Drawing.Size(530, 550);
            this.pnl_modification.TabIndex = 8;
            this.pnl_modification.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_Hidden);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 40);
            this.panel1.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(49, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "修改管理员信息";
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
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(11, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // ucButton_emptying
            // 
            this.ucButton_emptying.BackColor = System.Drawing.Color.Transparent;
            this.ucButton_emptying.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucButton_emptying.BackgroundImage")));
            this.ucButton_emptying.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ucButton_emptying.Location = new System.Drawing.Point(305, 424);
            this.ucButton_emptying.Name = "ucButton_emptying";
            this.ucButton_emptying.Size = new System.Drawing.Size(85, 45);
            this.ucButton_emptying.TabIndex = 35;
            // 
            // ucButton_submit
            // 
            this.ucButton_submit.BackColor = System.Drawing.Color.Transparent;
            this.ucButton_submit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucButton_submit.BackgroundImage")));
            this.ucButton_submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ucButton_submit.Location = new System.Drawing.Point(181, 424);
            this.ucButton_submit.Name = "ucButton_submit";
            this.ucButton_submit.Size = new System.Drawing.Size(85, 45);
            this.ucButton_submit.TabIndex = 34;
            this.ucButton_submit.Click += new System.EventHandler(this.ucButton_submit_Click);
            // 
            // cbo_permissions
            // 
            this.cbo_permissions.FormattingEnabled = true;
            this.cbo_permissions.Location = new System.Drawing.Point(178, 376);
            this.cbo_permissions.Name = "cbo_permissions";
            this.cbo_permissions.Size = new System.Drawing.Size(212, 28);
            this.cbo_permissions.TabIndex = 33;
            // 
            // rbt_female
            // 
            this.rbt_female.AutoSize = true;
            this.rbt_female.Location = new System.Drawing.Point(284, 283);
            this.rbt_female.Name = "rbt_female";
            this.rbt_female.Size = new System.Drawing.Size(45, 24);
            this.rbt_female.TabIndex = 31;
            this.rbt_female.Text = "女";
            this.rbt_female.UseVisualStyleBackColor = true;
            // 
            // rbt_man
            // 
            this.rbt_man.AutoSize = true;
            this.rbt_man.Checked = true;
            this.rbt_man.Location = new System.Drawing.Point(194, 283);
            this.rbt_man.Name = "rbt_man";
            this.rbt_man.Size = new System.Drawing.Size(45, 24);
            this.rbt_man.TabIndex = 30;
            this.rbt_man.TabStop = true;
            this.rbt_man.Text = "男";
            this.rbt_man.UseVisualStyleBackColor = true;
            // 
            // tbo_phone
            // 
            this.tbo_phone.Location = new System.Drawing.Point(181, 333);
            this.tbo_phone.Name = "tbo_phone";
            this.tbo_phone.Size = new System.Drawing.Size(209, 27);
            this.tbo_phone.TabIndex = 29;
            // 
            // tbo_passworda
            // 
            this.tbo_passworda.Location = new System.Drawing.Point(181, 182);
            this.tbo_passworda.Name = "tbo_passworda";
            this.tbo_passworda.Size = new System.Drawing.Size(209, 27);
            this.tbo_passworda.TabIndex = 28;
            this.tbo_passworda.UseSystemPasswordChar = true;
            // 
            // tbo_namea
            // 
            this.tbo_namea.Location = new System.Drawing.Point(181, 231);
            this.tbo_namea.Name = "tbo_namea";
            this.tbo_namea.Size = new System.Drawing.Size(209, 27);
            this.tbo_namea.TabIndex = 27;
            // 
            // tbo_password
            // 
            this.tbo_password.Location = new System.Drawing.Point(181, 132);
            this.tbo_password.Name = "tbo_password";
            this.tbo_password.Size = new System.Drawing.Size(209, 27);
            this.tbo_password.TabIndex = 26;
            this.tbo_password.UseSystemPasswordChar = true;
            // 
            // tbo_account
            // 
            this.tbo_account.Location = new System.Drawing.Point(181, 76);
            this.tbo_account.Name = "tbo_account";
            this.tbo_account.ReadOnly = true;
            this.tbo_account.Size = new System.Drawing.Size(209, 27);
            this.tbo_account.TabIndex = 25;
            // 
            // lbl_permissions
            // 
            this.lbl_permissions.AutoSize = true;
            this.lbl_permissions.Location = new System.Drawing.Point(121, 379);
            this.lbl_permissions.Name = "lbl_permissions";
            this.lbl_permissions.Size = new System.Drawing.Size(54, 20);
            this.lbl_permissions.TabIndex = 24;
            this.lbl_permissions.Text = "权限：";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Location = new System.Drawing.Point(121, 336);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(54, 20);
            this.lbl_phone.TabIndex = 23;
            this.lbl_phone.Text = "电话：";
            // 
            // lbl_Sex
            // 
            this.lbl_Sex.AutoSize = true;
            this.lbl_Sex.Location = new System.Drawing.Point(121, 285);
            this.lbl_Sex.Name = "lbl_Sex";
            this.lbl_Sex.Size = new System.Drawing.Size(54, 20);
            this.lbl_Sex.TabIndex = 22;
            this.lbl_Sex.Text = "性别：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "姓名：";
            // 
            // lbl_passworda
            // 
            this.lbl_passworda.AutoSize = true;
            this.lbl_passworda.Location = new System.Drawing.Point(91, 185);
            this.lbl_passworda.Name = "lbl_passworda";
            this.lbl_passworda.Size = new System.Drawing.Size(84, 20);
            this.lbl_passworda.TabIndex = 20;
            this.lbl_passworda.Text = "确认密码：";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(121, 135);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(54, 20);
            this.lbl_password.TabIndex = 19;
            this.lbl_password.Text = "密码：";
            // 
            // lbl_account
            // 
            this.lbl_account.AutoSize = true;
            this.lbl_account.Location = new System.Drawing.Point(121, 79);
            this.lbl_account.Name = "lbl_account";
            this.lbl_account.Size = new System.Drawing.Size(54, 20);
            this.lbl_account.TabIndex = 18;
            this.lbl_account.Text = "账户：";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(181, 264);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 63);
            this.panel2.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(272, 680);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1110, 314);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // childForm_adminData
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1710, 1030);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnl_modification);
            this.Controls.Add(this.dgv_query);
            this.Controls.Add(this.lbl_support);
            this.Controls.Add(this.ucButton_query);
            this.Controls.Add(this.tbo_name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.pal_Left);
            this.Controls.Add(this.pal_Bottom);
            this.Controls.Add(this.pal_Top);
            this.Controls.Add(this.pal_Right);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "childForm_adminData";
            this.Text = "childForm_home";
            this.Load += new System.EventHandler(this.childForm_adminData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_query)).EndInit();
            this.cms_shortcuts.ResumeLayout(false);
            this.pnl_modification.ResumeLayout(false);
            this.pnl_modification.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pal_Left;
        private System.Windows.Forms.Panel pal_Bottom;
        private System.Windows.Forms.Panel pal_Top;
        private System.Windows.Forms.Panel pal_Right;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox tbo_name;
        private UCButton ucButton_query;
        private System.Windows.Forms.Label lbl_support;
        private System.Windows.Forms.ContextMenuStrip cms_shortcuts;
        private System.Windows.Forms.ToolStripMenuItem tsm_modification;
        private System.Windows.Forms.ToolStripMenuItem tsm_deletion;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdminName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdminRightsType;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdminPwd;
        public System.Windows.Forms.DataGridView dgv_query;
        private System.Windows.Forms.Panel pnl_modification;
        private UCButton ucButton_emptying;
        private UCButton ucButton_submit;
        private System.Windows.Forms.ComboBox cbo_permissions;
        private System.Windows.Forms.RadioButton rbt_female;
        private System.Windows.Forms.RadioButton rbt_man;
        private System.Windows.Forms.TextBox tbo_phone;
        private System.Windows.Forms.TextBox tbo_passworda;
        private System.Windows.Forms.TextBox tbo_namea;
        private System.Windows.Forms.TextBox tbo_password;
        public System.Windows.Forms.TextBox tbo_account;
        private System.Windows.Forms.Label lbl_permissions;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lbl_Sex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_passworda;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_account;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Hidden;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}