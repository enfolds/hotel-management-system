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
    public partial class childForm_reservation : Form
    {
        // 数据库工具类
        DBHelper DB = new DBHelper();

        // 数据适配器
        private SqlDataAdapter da = null;

        // DataSet 数据集
        private DataSet ds = new DataSet();


        public childForm_reservation()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void childForm_reservation_Load(object sender, EventArgs e)
        {
            this.dgv_RoomData.AutoGenerateColumns = false;
            loadRoomType();
        }


        /// <summary>
        /// 加载房间类型
        /// </summary>
        public void loadRoomType()
        {
            StringBuilder sql = new StringBuilder("SELECT * FROM RoomType");
            da = new SqlDataAdapter(sql.ToString(), DB.Conn);

            da.Fill(ds, "RoomType");
            DataRow row = ds.Tables["RoomType"].NewRow();
            row[0] = -1;
            row[1] = "请选择";
            ds.Tables["RoomType"].Rows.InsertAt(row, 0);

            this.cob_RoomType.DataSource = ds.Tables["RoomType"];
            this.cob_RoomType.ValueMember = "RoomTypeId";
            this.cob_RoomType.DisplayMember = "RoomTypeName";
        }


        /// <summary>
        /// 根据房间类型查询房间信息
        /// </summary>
        public void showRoomData()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("SELECT *");
            sql.AppendFormat(" FROM RoomData RD");
            sql.AppendFormat(" INNER JOIN RoomStatus RS ON RS.RoomStatusId = RD.RoomStatusId");
            sql.AppendFormat(" INNER JOIN RoomType RT ON RD.RoomTypeId = RT.RoomTypeId");
            sql.AppendFormat(" WHERE 1 =1 AND RS.RoomStatusId = '1'");

            if (!this.cob_RoomType.Text.Equals("请选择"))
            {
                sql.AppendFormat(" AND RT.RoomTypeName = '{0}'", this.cob_RoomType.Text);
            }

            da = new SqlDataAdapter(sql.ToString(), DB.Conn);
            if (ds.Tables["RoomData"] != null)
            {
                ds.Tables["RoomData"].Clear();
            }

            da.Fill(ds, "RoomData");
            this.dgv_RoomData.DataSource = ds.Tables["RoomData"];
        }


        /// <summary>
        /// 验证
        /// </summary>
        /// <returns></returns>
        public bool CheckInput()
        {
            // 姓名
            if (this.txt_Name.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请填写姓名！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            // 手机号
            if (this.txt_Phone.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请填写手机号！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            // 身份证号
            if (this.txt_CardId.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请填身份证号！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            // 房间类型
            if (this.cob_RoomType.Text.Trim().Equals("请选择"))
            {
                MessageBox.Show("请选择房间类型！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            // 房号
            if (this.txt_RoomId.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请选择房间！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            // 入住时间
            if (date_CheckInTime.SelectionStart < DateTime.Now)
            {
                MessageBox.Show("入住时间不能小于当前日期！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }


        /// <summary>
        /// 动态SQL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cob_RoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            showRoomData();
        }


        /// <summary>
        /// 数据传递
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_RoomData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgv_RoomData.Rows.Count <= 0)
            {
                return;
            }

            this.txt_RoomId.Text = this.dgv_RoomData.SelectedRows[0].Cells["RoomId"].Value.ToString();
            this.txt_RoomPrice.Text = this.dgv_RoomData.SelectedRows[0].Cells["RoomPrice"].Value.ToString();


        }


        /// <summary>
        /// 提交点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ucButton_submit_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {
                return;
            }

            // 随机数
            Random randow = new Random();

            // 订单号
            string recordId = "HR" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString().PadLeft(2, '0') + DateTime.Now.Day.ToString().PadLeft(2, '0') + randow.Next(1000, 9999).ToString();

            // 姓名
            string name = this.txt_Name.Text;

            // 性别
            string sex = this.rdo_Mr.Checked ? "男" : "女";

            // 手机号
            string phone = this.txt_Phone.Text;

            // 身份证号
            string cardId = this.txt_CardId.Text;

            // 房间状态 3 已预定
            int roomStatusId = 3;

            // 房间类型
            StringBuilder sql = new StringBuilder("SELECT RoomTypeId FROM RoomType");
            sql.AppendFormat(" WHERE RoomTypeName = '{0}'", this.cob_RoomType.Text);
            int roomTypeId = (int)DB.ExecuteScalar(sql.ToString());

            // 房号
            string roomId = this.txt_RoomId.Text;

            // 预定入住时间
            string checkInTime = "预定入住时间：" + this.date_CheckInTime.SelectionStart.ToString("yyyy-MM-dd");

            // 订单状态 未完成
            int ordeStatusId = 2;

            sql.Length = 0;
            sql.AppendFormat("INSERT INTO HousingRecords(RecordId,Name,Sex,Phone,CardId,RoomId,RoomStatusId,CheckInTime,OrdeStatusId)");
            sql.AppendFormat(" VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", recordId, name, sex, phone, cardId, roomId, roomStatusId, checkInTime, ordeStatusId);

            int result = DB.ExecuteNonQuery(sql.ToString());

            if (result > 0)
            {
                MessageBox.Show("预约成功房号 " + roomId + "，" + checkInTime + " ！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Question);

                sql.Length = 0;
                sql.AppendFormat("UPDATE RoomData");
                sql.AppendFormat(" SET RoomStatusId = '{0}'", roomStatusId);
                sql.AppendFormat(" WHERE RoomId = '{0}'", roomId);
                DB.ExecuteNonQuery(sql.ToString());

                int result_ = DB.ExecuteNonQuery(sql.ToString());

                if (result_ > 0)
                {
                    MessageBox.Show("客房 " + roomId + " 状态已变更为已预定！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    MessageBox.Show("修改房间状态失败！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }

            }
            else
            {
                MessageBox.Show("办理预定失败，请重新操作！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

        }


        /// <summary>
        /// 清空点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ucButton_empty_Click(object sender, EventArgs e)
        {
            RemoveContent();
        }


        /// <summary>
        /// 清空方法
        /// </summary>
        public void RemoveContent()
        {
            //this.Controls.Add();
            foreach (Control con in groupBox_1.Controls)//遍历控件类集合
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

            foreach (Control con in groupBox_2.Controls)//遍历控件类集合
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

    }
}
