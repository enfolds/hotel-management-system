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
    public partial class childForm_checkOut : Form
    {
        // 数据库工具类
        DBHelper DB = new DBHelper();

        // 数据适配器
        private SqlDataAdapter da = null;

        // DataSet 数据集
        private DataSet ds = new DataSet();


        public childForm_checkOut()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void childForm_checkOut_Load(object sender, EventArgs e)
        {
            // 显示客房记录
            this.dgv_HousingRecordsData.AutoGenerateColumns = false;
            housingRecords();
        }

        /// <summary>
        /// 加载住房记录
        /// </summary>
        public void housingRecords()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("SELECT *");
            sql.AppendFormat(" FROM HousingRecords HR");
            sql.AppendFormat(" INNER JOIN RoomData RD ON HR.RoomId = RD.RoomId");
            sql.AppendFormat(" INNER JOIN RoomStatus RS ON HR.RoomStatusId = RS.RoomStatusId");
            sql.AppendFormat(" INNER JOIN RoomType RT ON RD.RoomTypeId = RT.RoomTypeId");
            sql.AppendFormat(" INNER JOIN OrdeStatus OS ON HR.OrdeStatusId = OS.OrdeStatusId");
            sql.AppendFormat(" WHERE 1 = 1 AND HR.RoomStatusId = '2'");

            // 姓名
            if (!txt_QueryName.Text.Trim().Equals(string.Empty))
            {
                sql.AppendFormat(" AND Name LIKE '%{0}%'", this.txt_QueryName.Text);
            }

            // 手机号
            if (!txt_QueryPhone.Text.Trim().Equals(string.Empty))
            {
                sql.AppendFormat(" AND Phone = '{0}'", this.txt_QueryPhone.Text);
            }

            // 身份证号
            if (!txt_QueryCardId.Text.Trim().Equals(string.Empty))
            {
                sql.AppendFormat(" AND CardId = '{0}'", this.txt_QueryCardId.Text);
            }

            da = new SqlDataAdapter(sql.ToString(), DB.Conn);
            if (ds.Tables["HousingRecords"] != null)
            {
                ds.Tables["HousingRecords"].Clear();
            }

            da.Fill(ds, "HousingRecords");
            this.dgv_HousingRecordsData.DataSource = ds.Tables["HousingRecords"];

        }


        /// <summary>
        /// 查询点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ucButton_Query_Click(object sender, EventArgs e)
        {
            housingRecords();
        }


        /// <summary>
        /// 数据传递
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_HousingRecordsData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txt_RecordId.Text = this.dgv_HousingRecordsData.SelectedRows[0].Cells["RecordId"].Value.ToString();
                this.txt_RoomTypeName.Text = this.dgv_HousingRecordsData.SelectedRows[0].Cells["RoomTypeName"].Value.ToString();
                this.txt_RoomId.Text = this.dgv_HousingRecordsData.SelectedRows[0].Cells["RoomId"].Value.ToString();
                this.txt_RoomPrice.Text = this.dgv_HousingRecordsData.SelectedRows[0].Cells["RoomPrice"].Value.ToString();
                this.txt_CheckInTime.Text = this.dgv_HousingRecordsData.SelectedRows[0].Cells["CheckInTime"].Value.ToString();
                this.txt_CheckOutTime.Text = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                this.txt_Name.Text = this.dgv_HousingRecordsData.SelectedRows[0].Cells["Name_"].Value.ToString();
                this.txt_CardId.Text = this.dgv_HousingRecordsData.SelectedRows[0].Cells["CardId"].Value.ToString();

                // 计算居住时长
                DateTime StartTime = Convert.ToDateTime(this.txt_CheckInTime.Text); // 开始时间
                DateTime EndTime = DateTime.Now; // 结束时间
                TimeSpan ts1 = new TimeSpan(StartTime.Ticks);
                TimeSpan ts2 = new TimeSpan(EndTime.Ticks);
                TimeSpan ts = ts1.Subtract(ts2).Duration();
                //string dateDiff = ts.Days.ToString() + "天" + ts.Hours.ToString() + "小时" + ts.Minutes.ToString() + "分钟" + ts.Seconds.ToString() + "秒";

                this.txt_LivingDays.Text = ts.Days.ToString() + "天" + ts.Hours.ToString() + "小时";

                // 截取天数
                double day = int.Parse(ts.Days.ToString());

                // 截取小时
                double hour = int.Parse(ts.Hours.ToString());

                // 获取房价
                double roomPrice = double.Parse(this.txt_RoomPrice.Text);

                // 费用
                double paymentAmount = 0.0;

                if (day * 0 == 0 && hour > 0)
                {
                    paymentAmount = (roomPrice * day) + roomPrice;
                }
                else if (day * 0 == 0 && hour < 0)
                {
                    paymentAmount = roomPrice * day;
                }
                else if (day * 0 == 0 && hour == 0)
                {
                    paymentAmount = roomPrice;
                }

                this.txt_PaymentAmount.Text = paymentAmount.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        /// <summary>
        /// 提交事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ucButton_Submit_Click(object sender, EventArgs e)
        {
            // 非空验证
            if (this.txt_RecordId.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("还没有选择需要退的客房哦！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 订单编号
            string recordId = this.txt_RecordId.Text.ToString();

            // 退房时间
            string checkOutTime = this.txt_CheckOutTime.Text;

            // 订单状态 1 已完成
            int ordeStatusId = 1;

            // 费用
            double paymentAmount = double.Parse(this.txt_PaymentAmount.Text);

            // 房号
            int roomId = int.Parse(this.txt_RoomId.Text);

            // 房间状态 4 未打扫
            int roomStatusId = 4;


            // 修改订单状态
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("UPDATE HousingRecords");
            sql.AppendFormat(" SET RoomStatusId = NULL,CheckOutTime = '{0}',OrdeStatusId = '{1}',PaymentAmount = '{2}'", checkOutTime, ordeStatusId, paymentAmount);
            sql.AppendFormat(" WHERE RecordId = '{0}'", recordId);

            int result = DB.ExecuteNonQuery(sql.ToString());

            if (result > 0)
            {
                MessageBox.Show("房号 " + roomId + " 退房成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 修改房间状态
                sql.Length = 0;
                sql.AppendFormat("UPDATE RoomData");
                sql.AppendFormat(" SET RoomStatusId = '{0}'", roomStatusId);
                sql.AppendFormat(" WHERE RoomId = '{0}'", roomId);

                int result_ = DB.ExecuteNonQuery(sql.ToString());

                if (result_ > 0)
                {
                    DialogResult isPrint = MessageBox.Show("要打印小票吗？", "提示操作", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (isPrint == DialogResult.Yes)
                    {
                        printReceipt();
                    }

                    // 刷新记录
                    housingRecords();

                    // 清空内容
                    RemoveContent();
                }
                else
                {
                    MessageBox.Show("房号状态变更失败！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("退房失败！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        /// <summary>
        /// 打印小票方法
        /// </summary>
        public void printReceipt()
        {
            // 显示小票面板
            pal_Receipt.Visible = true;

            // 传数据到控件
            ucReceipt.RecordId = this.txt_RecordId.Text;
            ucReceipt.PrintTime = DateTime.Now.ToString();
            ucReceipt.Cashier = "前台";
            ucReceipt.RoomType = this.txt_RoomTypeName.Text;
            ucReceipt.RoomPrice = this.txt_RoomPrice.Text;
            ucReceipt.LivingDays = this.txt_LivingDays.Text;
            ucReceipt.PaymentAmount = this.txt_PaymentAmount.Text;
            ucReceipt.TotalAmount = this.txt_PaymentAmount.Text;
            ucReceipt.DiscountTotalAmount = this.txt_PaymentAmount.Text;

        }


        /// <summary>
        /// <summary>
        /// 隐藏小票点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_HiddenpalReceipt_Click(object sender, EventArgs e)
        {
            pal_Receipt.Visible = false;
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
            foreach (Control con in groupBox2.Controls)//遍历控件类集合
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

            foreach (Control con in groupBox1.Controls)//遍历控件类集合
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
