namespace HMS.childForm
{
    partial class childForm_newAddRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(childForm_newAddRoom));
            this.pal_Left = new System.Windows.Forms.Panel();
            this.pal_Bottom = new System.Windows.Forms.Panel();
            this.pal_Top = new System.Windows.Forms.Panel();
            this.pal_Right = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.ucButton_empty = new HMS.UCButton();
            this.ucButton_submit = new HMS.UCButton();
            this.ptb_htoels = new System.Windows.Forms.PictureBox();
            this.ptb_hotel = new System.Windows.Forms.PictureBox();
            this.ptb_hotelS1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_htoels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_hotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_hotelS1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(73, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "房间号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(56, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "房间类型：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(90, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "价格：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(90, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "状态：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboState);
            this.panel1.Controls.Add(this.cboType);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.ucButton_empty);
            this.panel1.Controls.Add(this.ucButton_submit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(18, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 455);
            this.panel1.TabIndex = 18;
            // 
            // cboState
            // 
            this.cboState.FormattingEnabled = true;
            this.cboState.Location = new System.Drawing.Point(157, 274);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(178, 28);
            this.cboState.TabIndex = 102;
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(157, 119);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(178, 28);
            this.cboType.TabIndex = 101;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(157, 198);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(178, 27);
            this.txtPrice.TabIndex = 99;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(157, 39);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(178, 27);
            this.txtName.TabIndex = 98;
            // 
            // ucButton_empty
            // 
            this.ucButton_empty.BackColor = System.Drawing.Color.Transparent;
            this.ucButton_empty.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucButton_empty.BackgroundImage")));
            this.ucButton_empty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ucButton_empty.Location = new System.Drawing.Point(250, 377);
            this.ucButton_empty.Name = "ucButton_empty";
            this.ucButton_empty.Size = new System.Drawing.Size(85, 45);
            this.ucButton_empty.TabIndex = 19;
            this.ucButton_empty.Click += new System.EventHandler(this.ucButton_empty_Click);
            // 
            // ucButton_submit
            // 
            this.ucButton_submit.BackColor = System.Drawing.Color.Transparent;
            this.ucButton_submit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucButton_submit.BackgroundImage")));
            this.ucButton_submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ucButton_submit.Location = new System.Drawing.Point(90, 377);
            this.ucButton_submit.Name = "ucButton_submit";
            this.ucButton_submit.Size = new System.Drawing.Size(85, 45);
            this.ucButton_submit.TabIndex = 18;
            this.ucButton_submit.Load += new System.EventHandler(this.ucButton_submit_Load);
            this.ucButton_submit.Click += new System.EventHandler(this.ucButton_submit_Click);
            // 
            // ptb_htoels
            // 
            this.ptb_htoels.Image = ((System.Drawing.Image)(resources.GetObject("ptb_htoels.Image")));
            this.ptb_htoels.Location = new System.Drawing.Point(620, 63);
            this.ptb_htoels.Name = "ptb_htoels";
            this.ptb_htoels.Size = new System.Drawing.Size(1001, 784);
            this.ptb_htoels.TabIndex = 19;
            this.ptb_htoels.TabStop = false;
            // 
            // ptb_hotel
            // 
            this.ptb_hotel.Image = ((System.Drawing.Image)(resources.GetObject("ptb_hotel.Image")));
            this.ptb_hotel.Location = new System.Drawing.Point(620, 63);
            this.ptb_hotel.Name = "ptb_hotel";
            this.ptb_hotel.Size = new System.Drawing.Size(1001, 784);
            this.ptb_hotel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_hotel.TabIndex = 20;
            this.ptb_hotel.TabStop = false;
            this.ptb_hotel.Visible = false;
            // 
            // ptb_hotelS1
            // 
            this.ptb_hotelS1.Image = ((System.Drawing.Image)(resources.GetObject("ptb_hotelS1.Image")));
            this.ptb_hotelS1.Location = new System.Drawing.Point(620, 63);
            this.ptb_hotelS1.Name = "ptb_hotelS1";
            this.ptb_hotelS1.Size = new System.Drawing.Size(1001, 784);
            this.ptb_hotelS1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_hotelS1.TabIndex = 21;
            this.ptb_hotelS1.TabStop = false;
            this.ptb_hotelS1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(116, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 513);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "发布房间";
            // 
            // childForm_newAddRoom
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1710, 1030);
            this.Controls.Add(this.ptb_htoels);
            this.Controls.Add(this.pal_Left);
            this.Controls.Add(this.pal_Bottom);
            this.Controls.Add(this.pal_Top);
            this.Controls.Add(this.pal_Right);
            this.Controls.Add(this.ptb_hotel);
            this.Controls.Add(this.ptb_hotelS1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "childForm_newAddRoom";
            this.Text = "childForm_home";
            this.Load += new System.EventHandler(this.childForm_newAddRoom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_htoels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_hotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_hotelS1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pal_Left;
        private System.Windows.Forms.Panel pal_Bottom;
        private System.Windows.Forms.Panel pal_Top;
        private System.Windows.Forms.Panel pal_Right;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private UCButton ucButton_submit;
        private UCButton ucButton_empty;
        private System.Windows.Forms.PictureBox ptb_htoels;
        private System.Windows.Forms.PictureBox ptb_hotel;
        private System.Windows.Forms.PictureBox ptb_hotelS1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.ComboBox cboType;
    }
}