namespace HMS.childForm
{
    partial class childForm_dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(childForm_dashboard));
            this.pal_Left = new System.Windows.Forms.Panel();
            this.pal_Top = new System.Windows.Forms.Panel();
            this.pal_Right = new System.Windows.Forms.Panel();
            this.ptb_RoomcColor = new System.Windows.Forms.PictureBox();
            this.ptb_Data = new System.Windows.Forms.PictureBox();
            this.lab_RoomNumber = new System.Windows.Forms.Label();
            this.lab_AvailableRoom = new System.Windows.Forms.Label();
            this.lab_TodayTurnover = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_RoomcColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // pal_Left
            // 
            this.pal_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pal_Left.Location = new System.Drawing.Point(0, 0);
            this.pal_Left.Name = "pal_Left";
            this.pal_Left.Size = new System.Drawing.Size(50, 1030);
            this.pal_Left.TabIndex = 0;
            this.pal_Left.Visible = false;
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
            this.pal_Right.Visible = false;
            // 
            // ptb_RoomcColor
            // 
            this.ptb_RoomcColor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptb_RoomcColor.BackgroundImage")));
            this.ptb_RoomcColor.Location = new System.Drawing.Point(1280, 52);
            this.ptb_RoomcColor.Name = "ptb_RoomcColor";
            this.ptb_RoomcColor.Size = new System.Drawing.Size(380, 315);
            this.ptb_RoomcColor.TabIndex = 24;
            this.ptb_RoomcColor.TabStop = false;
            // 
            // ptb_Data
            // 
            this.ptb_Data.Image = ((System.Drawing.Image)(resources.GetObject("ptb_Data.Image")));
            this.ptb_Data.Location = new System.Drawing.Point(50, 52);
            this.ptb_Data.Name = "ptb_Data";
            this.ptb_Data.Size = new System.Drawing.Size(1165, 150);
            this.ptb_Data.TabIndex = 25;
            this.ptb_Data.TabStop = false;
            // 
            // lab_RoomNumber
            // 
            this.lab_RoomNumber.AutoSize = true;
            this.lab_RoomNumber.BackColor = System.Drawing.Color.White;
            this.lab_RoomNumber.Font = new System.Drawing.Font("站酷小薇LOGO体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lab_RoomNumber.Location = new System.Drawing.Point(189, 116);
            this.lab_RoomNumber.Name = "lab_RoomNumber";
            this.lab_RoomNumber.Size = new System.Drawing.Size(56, 32);
            this.lab_RoomNumber.TabIndex = 26;
            this.lab_RoomNumber.Text = "xxx";
            // 
            // lab_AvailableRoom
            // 
            this.lab_AvailableRoom.AutoSize = true;
            this.lab_AvailableRoom.BackColor = System.Drawing.Color.White;
            this.lab_AvailableRoom.Font = new System.Drawing.Font("站酷小薇LOGO体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lab_AvailableRoom.Location = new System.Drawing.Point(587, 116);
            this.lab_AvailableRoom.Name = "lab_AvailableRoom";
            this.lab_AvailableRoom.Size = new System.Drawing.Size(56, 32);
            this.lab_AvailableRoom.TabIndex = 27;
            this.lab_AvailableRoom.Text = "xxx";
            // 
            // lab_TodayTurnover
            // 
            this.lab_TodayTurnover.AutoSize = true;
            this.lab_TodayTurnover.BackColor = System.Drawing.Color.White;
            this.lab_TodayTurnover.Font = new System.Drawing.Font("站酷小薇LOGO体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lab_TodayTurnover.Location = new System.Drawing.Point(989, 116);
            this.lab_TodayTurnover.Name = "lab_TodayTurnover";
            this.lab_TodayTurnover.Size = new System.Drawing.Size(56, 32);
            this.lab_TodayTurnover.TabIndex = 28;
            this.lab_TodayTurnover.Text = "xxx";
            // 
            // childForm_dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1710, 1030);
            this.Controls.Add(this.lab_TodayTurnover);
            this.Controls.Add(this.lab_AvailableRoom);
            this.Controls.Add(this.lab_RoomNumber);
            this.Controls.Add(this.ptb_Data);
            this.Controls.Add(this.ptb_RoomcColor);
            this.Controls.Add(this.pal_Top);
            this.Controls.Add(this.pal_Right);
            this.Controls.Add(this.pal_Left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "childForm_dashboard";
            this.Text = "Workbench";
            this.Load += new System.EventHandler(this.childForm_workbench_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_RoomcColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pal_Left;
        private System.Windows.Forms.Panel pal_Top;
        private System.Windows.Forms.Panel pal_Right;
        private System.Windows.Forms.PictureBox ptb_RoomcColor;
        private System.Windows.Forms.PictureBox ptb_Data;
        private System.Windows.Forms.Label lab_RoomNumber;
        private System.Windows.Forms.Label lab_AvailableRoom;
        private System.Windows.Forms.Label lab_TodayTurnover;
    }
}