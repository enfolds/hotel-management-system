using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace HMS.childForm
{
    public partial class childForm_newAddAdmin : Form
    {

        DBHelper DB = new DBHelper();
        private DataSet ds = new DataSet();
        private SqlDataAdapter da = null;
        public childForm_newAddAdmin()
        {
            InitializeComponent();
        }
        private void childForm_newAddAdmin_Load(object sender, EventArgs e)
        {
            acquisition();
        }
        /// <summary>
        /// 判断为空
        /// </summary>
        /// <returns></returns>
        public bool Judge()
        {
            if (string.IsNullOrEmpty(this.tbo_name.Text.Trim()))
            {
                MessageBox.Show("用户名不能为空！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tbo_name.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(this.tbo_password.Text.Trim()))
            {
                MessageBox.Show("密码不能为空！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tbo_password.Focus();
                return false;
            }
            if (!this.tbo_password.Text.Trim().Equals(this.tbo_passworda.Text.Trim()))
            {
                MessageBox.Show("密码不一致！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tbo_passworda.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(this.tbo_surname.Text.Trim()))
            {
                MessageBox.Show("姓名不能为空！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tbo_surname.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(this.tbo_elephone.Text.Trim()))
            {
                MessageBox.Show("电话不能为空！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tbo_elephone.Focus();
                return false;
            }
            if (this.cbo_jurisdiction.Text.Trim().Equals("请选择"))
            {
                MessageBox.Show("请选择您的权限！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cbo_jurisdiction.Focus();
                return false;
            }
            return true;
        }
        /// <summary>
        /// 增加的方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void ucButton_submit_Click_1(object sender, EventArgs e)
        {
            if (!Judge())
            {
                return;
            }
            string name = this.tbo_name.Text.Trim();//用户名
            string password = this.tbo_password.Text.Trim();//密码
            string surname = this.tbo_surname.Text.Trim();//姓名
            string sex = "";
            sex = this.rbt_female.Checked ? "女" : "男";//性别
            string elephone = this.tbo_elephone.Text.Trim();//电话
            string right = this.cbo_jurisdiction.Text.Trim();//权限
            StringBuilder sqll = new StringBuilder("select AdminRightsId from AdminRights");
            sqll.AppendFormat(" where AdminRightsType='{0}'", right);
            int righta = (int)DB.ExecuteScalar(sqll.ToString());
            StringBuilder sql = new StringBuilder("insert into Admin(AdminName,AdminPwd,Name,Sex,Phone,AdminRightsId)");
            sql.AppendFormat(" values ('{0}','{1}','{2}','{3}','{4}','{5}')", name, password, surname, sex, elephone, righta);
            int reta = DB.ExecuteNonQuery(sql.ToString());
            if (reta > 0)
            {
                MessageBox.Show("添加成功！欢迎管理员 ," + name + " !", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Controls.Add();
                foreach (Control con in this.Controls)//遍历控件类集合
                {
                    TextBox text = con as TextBox;//获取TextBox对象
                    RadioButton rdo = con as RadioButton;//获取RadioButton对象
                    CheckBox che = con as CheckBox;//获取CheckBox对象

                    if (text != null)//文本框清空
                    {
                        text.Text = "";
                    }
                    if (che != null)//多选框全不选
                    {
                        che.Checked = false;
                    }

                }
            }
            else
            {
                MessageBox.Show("添加失败！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ucButton_empty_Click(object sender, EventArgs e)
        {
            //this.Controls.Add();
            foreach (Control con in this.Controls)//遍历控件类集合
            {
                TextBox text = con as TextBox;//获取TextBox对象
                RadioButton rdo = con as RadioButton;//获取RadioButton对象
                CheckBox che = con as CheckBox;//获取CheckBox对象

                if (text != null)//文本框清空
                {
                    text.Text = "";
                }
                if (che != null)//多选框全不选
                {
                    che.Checked = false;
                }

            }
        }
        /// <summary>
        /// 显示权限的方法
        /// </summary>
        public void acquisition()
        {
            string sql = "select * from AdminRights where AdminRightsId != 1";
            this.ds = new DataSet();
            da = new SqlDataAdapter(sql, DB.Conn);
            da.Fill(ds, "AdminRights");
            DataRow row = ds.Tables["AdminRights"].NewRow();
            row[0] = -1;
            row[1] = "请选择";
            ds.Tables["AdminRights"].Rows.InsertAt(row, 0);
            this.cbo_jurisdiction.DataSource = ds.Tables["AdminRights"];
            this.cbo_jurisdiction.ValueMember = "AdminRightsId";
            this.cbo_jurisdiction.DisplayMember = "AdminRightsType";
        }

    }
}

