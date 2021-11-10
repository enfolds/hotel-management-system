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
    public partial class childForm_adminData : Form
    {
        DBHelper DB = new DBHelper();
        private DataSet ds = new DataSet();
        private SqlDataAdapter da = null;
        public Admin admin = new Admin();

        public childForm_adminData()
        {
            InitializeComponent();
        }


        private void childForm_adminData_Load(object sender, EventArgs e)
        {
            acquired();
            //acquisition();
            //Initial();


        }


        private void button1_Click(object sender, EventArgs e)
        {
            string query = this.tbo_name.Text.Trim();
            StringBuilder sql = new StringBuilder("select * from Admin a join AdminRights r on a.AdminRightsId=r.AdminRightsId where 1=1");
            sql.AppendFormat(" and AdminName like '%{0}%'", query);
            da = new SqlDataAdapter(sql.ToString(), DB.Conn);
            if (ds.Tables["Admin"] != null)
            {
                ds.Tables["Admin"].Clear();
            }
            da.Fill(ds, "Admin");
            this.dgv_query.DataSource = ds.Tables["Admin"];

        }
        public void acquired()
        {
            this.dgv_query.AutoGenerateColumns = false;
            StringBuilder sql = new StringBuilder("select * from Admin a ");
            sql.AppendFormat(" join AdminRights r on a.AdminRightsId=r.AdminRightsId");
            this.ds = new DataSet();
            da = new SqlDataAdapter(sql.ToString(), DB.Conn);
            if (ds.Tables["Admin"] != null)
            {
                ds.Tables["Admin"].Clear();
            }
            da.Fill(ds, "Admin");
            this.dgv_query.DataSource = ds.Tables["Admin"];
        }

        /// <summary>
        /// 修改的加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsm_modification_Click(object sender, EventArgs e)
        {
            //Admin admin = new Admin();
            string account = this.dgv_query.SelectedRows[0].Cells["AdminName"].Value.ToString();
            StringBuilder sql = new StringBuilder("select * from Admin a join AdminRights r on a.AdminRightsId=r.AdminRightsId");
            sql.AppendFormat(" where AdminName='{0}'", account);
            SqlDataReader Reader = null;
            acquisition();
            try
            {
                Reader = DB.ExecuteReader(sql.ToString());
                if (Reader.Read())
                {
                    this.tbo_account.Text = Reader["AdminName"].ToString();
                    this.tbo_password.Text = Reader["AdminPwd"].ToString();
                    this.tbo_passworda.Text = Reader["AdminPwd"].ToString();
                    this.tbo_namea.Text = Reader["Name"].ToString();
                    if (Reader["Sex"].ToString().Equals("男"))
                    {
                        this.rbt_man.Checked = true;
                    }
                    else
                    {
                        this.rbt_female.Checked = true;
                    }
                    //admin.Sex1 = Reader["Sex"].ToString();
                    this.tbo_phone.Text = Reader["Phone"].ToString();
                    admin.AdminRights1 = Reader["AdminRightsId"].ToString();
                    StringBuilder sqll = new StringBuilder(" select AdminRightsType from AdminRights");
                    sqll.AppendFormat(" where AdminRightsId='{0}'", admin.AdminRights1);
                    this.cbo_permissions.Text = DB.ExecuteScalar(sqll.ToString()).ToString();
                    this.tbo_account.ReadOnly.ToString();
                }

                //modification modification = new modification();
                //childForm_adminData childForm_AdminData = new childForm_adminData();
                //modification.admin = admin;
                this.pnl_modification.Visible = true;
                //modification.tbo_account.ReadOnly = true;
                //modification.Show();
                //this.Hide();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }

        private void tsm_deletion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定删除吗？", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result != DialogResult.OK)
            {
                return;
            }
            string account = this.dgv_query.SelectedRows[0].Cells["AdminName"].Value.ToString();
            StringBuilder sql = new StringBuilder("delete from Admin");
            sql.AppendFormat(" where AdminName='{0}'", account);
            int reac = DB.ExecuteNonQuery(sql.ToString());
            if (reac > 0)
            {
                MessageBox.Show("删除成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                acquired();
            }
            else
            {
                MessageBox.Show("删除失败！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

        }
        /// <summary>
        /// 初始化的方法
        /// </summary>
        public void Initial()
        {
            this.tbo_account.Text = admin.AdminName1;
            this.tbo_password.Text = admin.AdminPwd1;
            this.tbo_passworda.Text = admin.AdminPwd1;
            this.tbo_name.Text = admin.Name1;
            if (admin.Sex1.Equals("男"))
            {
                this.rbt_man.Checked = true;
            }
            else
            {
                this.rbt_female.Checked = true;
            }
            this.tbo_phone.Text = admin.Phone1;
            StringBuilder sql = new StringBuilder("select AdminRightsType from AdminRights");
            sql.AppendFormat(" where AdminRightsId='{0}'", admin.AdminRights1);
            this.cbo_permissions.Text = DB.ExecuteScalar(sql.ToString()).ToString();
        }
        /// <summary>
        /// 获取权限的方法
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
            this.cbo_permissions.DataSource = ds.Tables["AdminRights"];
            this.cbo_permissions.ValueMember = "AdminRightsId";
            this.cbo_permissions.DisplayMember = "AdminRightsType";
        }
        /// <summary>
        /// 隐藏修改信息面板
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Hidden_Click(object sender, EventArgs e)
        {
            pnl_modification.Visible = false;

        }

        private void ucButton_submit_Click(object sender, EventArgs e)
        {
            Modifythe();
        }
        /// <summary>
        /// 修改的方法
        /// </summary>
        public void Modifythe()
        {
            if (!Judge())
            {
                return;
            }
            string name = this.tbo_account.Text.Trim();//用户名
            string password = this.tbo_password.Text.Trim();//密码
            string surname = this.tbo_namea.Text.Trim();//姓名
            string sex = "";
            sex = this.rbt_female.Checked ? "女" : "男";//性别
            string elephone = this.tbo_phone.Text.Trim();//电话
            string right = this.cbo_permissions.Text.Trim();//权限
            StringBuilder sqll = new StringBuilder("select AdminRightsId from AdminRights");
            sqll.AppendFormat(" where AdminRightsType='{0}'", right);
            int righta = (int)DB.ExecuteScalar(sqll.ToString());
            StringBuilder sql = new StringBuilder("update Admin set");
            sql.AppendFormat(" AdminPwd='{0}',Name='{1}',Sex='{2}',Phone='{3}',AdminRightsId='{4}'", password, surname, sex, elephone, righta);
            sql.AppendFormat(" where AdminName='{0}' ", name);
            int read = DB.ExecuteNonQuery(sql.ToString());
            if (read > 0)
            {
                MessageBox.Show("修改成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                pnl_modification.Visible = false;
                acquired();

            }
            else
            {
                MessageBox.Show("修改失败！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        public bool Judge()
        {
            if (string.IsNullOrEmpty(this.tbo_account.Text.Trim()))
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
            if (string.IsNullOrEmpty(this.tbo_namea.Text.Trim()))
            {
                MessageBox.Show("姓名不能为空！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tbo_namea.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(this.tbo_phone.Text.Trim()))
            {
                MessageBox.Show("电话不能为空！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tbo_phone.Focus();
                return false;
            }
            if (this.cbo_permissions.Text.Trim().Equals("请选择"))
            {
                MessageBox.Show("请选择您的权限！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cbo_permissions.Focus();
                return false;
            }
            return true;
        }
    }
}
