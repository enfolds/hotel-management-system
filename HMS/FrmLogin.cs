using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class FrmLogin : Form
    {
        // 数据库工具类
        DBHelper DB = new DBHelper();

        public FrmLogin()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 非空验证
        /// </summary>
        /// <returns></returns>
        public bool CheckInput()
        {
            // 用户名
            if (this.txt_UserName.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入用户名！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            // 密码
            if (this.txt_UserPwd.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入密码！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;

        }


        /// <summary>
        /// 登录方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ucButton_Login_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {
                return;
            }

            // 账号
            string userName = this.txt_UserName.Text.Trim();

            // 密码
            string userPwd = this.txt_UserPwd.Text.Trim();

            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("SELECT COUNT(*) FROM Admin");
            sql.AppendFormat(" WHERE AdminName = '{0}' AND AdminPwd = '{1}'", userName, userPwd);
            int result_ad = (int)DB.ExecuteScalar(sql.ToString());

            if (result_ad > 0)
            {
                FrmMain frm = new FrmMain();
                frm.userName = userName;
                frm.Show();
                this.Hide();
                return;
            }

            MessageBox.Show("账号或密码错误！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        // <summary>
        /// 登录按钮悬浮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ucButton_Login_MouseHover(object sender, EventArgs e)
        {
            ucButton_Login.BackgroundImage = Image.FromFile(@"..\..\..\Resources\images\login_hover.png");
        }


        /// <summary>
        /// 登录按钮离开事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ucButton_Login_MouseLeave(object sender, EventArgs e)
        {
            ucButton_Login.BackgroundImage = Image.FromFile(@"..\..\..\Resources\images\login.png");
        }


    }
}
