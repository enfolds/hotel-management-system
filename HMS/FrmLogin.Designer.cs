
namespace HMS
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pbo_Login = new System.Windows.Forms.PictureBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_UserPwd = new System.Windows.Forms.TextBox();
            this.ucButton_Login = new HMS.UCButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbo_Login)).BeginInit();
            this.SuspendLayout();
            // 
            // pbo_Login
            // 
            this.pbo_Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbo_Login.Image = ((System.Drawing.Image)(resources.GetObject("pbo_Login.Image")));
            this.pbo_Login.Location = new System.Drawing.Point(0, 0);
            this.pbo_Login.Name = "pbo_Login";
            this.pbo_Login.Size = new System.Drawing.Size(1321, 746);
            this.pbo_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbo_Login.TabIndex = 0;
            this.pbo_Login.TabStop = false;
            // 
            // txt_UserName
            // 
            this.txt_UserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.txt_UserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_UserName.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_UserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txt_UserName.Location = new System.Drawing.Point(801, 303);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(316, 22);
            this.txt_UserName.TabIndex = 2;
            // 
            // txt_UserPwd
            // 
            this.txt_UserPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.txt_UserPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_UserPwd.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_UserPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txt_UserPwd.Location = new System.Drawing.Point(801, 420);
            this.txt_UserPwd.Name = "txt_UserPwd";
            this.txt_UserPwd.Size = new System.Drawing.Size(316, 22);
            this.txt_UserPwd.TabIndex = 3;
            this.txt_UserPwd.UseSystemPasswordChar = true;
            // 
            // ucButton_Login
            // 
            this.ucButton_Login.BackColor = System.Drawing.Color.White;
            this.ucButton_Login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucButton_Login.BackgroundImage")));
            this.ucButton_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ucButton_Login.Location = new System.Drawing.Point(781, 519);
            this.ucButton_Login.Name = "ucButton_Login";
            this.ucButton_Login.Size = new System.Drawing.Size(359, 58);
            this.ucButton_Login.TabIndex = 4;
            this.ucButton_Login.Click += new System.EventHandler(this.ucButton_Login_Click);
            this.ucButton_Login.MouseLeave += new System.EventHandler(this.ucButton_Login_MouseLeave);
            this.ucButton_Login.MouseHover += new System.EventHandler(this.ucButton_Login_MouseHover);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 746);
            this.Controls.Add(this.ucButton_Login);
            this.Controls.Add(this.txt_UserPwd);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.pbo_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "酒店管理系统";
            ((System.ComponentModel.ISupportInitialize)(this.pbo_Login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbo_Login;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_UserPwd;
        private UCButton ucButton_Login;
    }
}

