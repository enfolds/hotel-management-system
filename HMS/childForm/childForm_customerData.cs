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
    public partial class childForm_customerData : Form
    {
        // 数据库工具类
        DBHelper DB = new DBHelper();

        // 数据适配器
        private SqlDataAdapter da = null;

        // DataSet 数据集
        private DataSet ds = new DataSet();


        public childForm_customerData()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void childForm_customerData_Load(object sender, EventArgs e)
        {
            // 加载订单状态
            loadOrderStatus();

            // 加载住房记录
            this.dgv_CustomerData.AutoGenerateColumns = false;
            showCustomerData();
        }


        /// <summary>
        /// 加载订单状态
        /// </summary>
        public void loadOrderStatus()
        {
            StringBuilder sql = new StringBuilder("SELECT * FROM OrdeStatus");
            da = new SqlDataAdapter(sql.ToString(), DB.Conn);

            da.Fill(ds, "OrdeStatus");
            DataRow row = ds.Tables["OrdeStatus"].NewRow();
            row[0] = -1;
            row[1] = "请选择";
            ds.Tables["OrdeStatus"].Rows.InsertAt(row, 0);

            this.cob_OrderStatus.DataSource = ds.Tables["OrdeStatus"];
            this.cob_OrderStatus.ValueMember = "OrdeStatusId";
            this.cob_OrderStatus.DisplayMember = "OrdeStatusName";

        }


        /// <summary>
        /// 加载住房记录
        /// </summary>
        public void showCustomerData()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("SELECT *");
            sql.AppendFormat(" FROM HousingRecords HR");
            sql.AppendFormat(" INNER JOIN RoomData RD ON HR.RoomId = RD.RoomId");
            sql.AppendFormat(" INNER JOIN OrdeStatus OS ON HR.OrdeStatusId = OS.OrdeStatusId");
            sql.AppendFormat(" WHERE 1 = 1");

            // 订单号
            if (!txt_OrderId.Text.Trim().Equals(string.Empty))
            {
                sql.AppendFormat(" AND RecordId = '{0}'", this.txt_OrderId.Text);
            }

            // 订单状态
            if (!this.cob_OrderStatus.Text.Equals("请选择"))
            {
                sql.AppendFormat(" AND OS.OrdeStatusName = '{0}'", this.cob_OrderStatus.Text);
            }

            // 姓名
            if (!txt_Name.Text.Trim().Equals(string.Empty))
            {
                sql.AppendFormat(" AND Name LIKE '%{0}%'", this.txt_Name.Text);
            }

            // 手机号
            if (!txt_Phone.Text.Trim().Equals(string.Empty))
            {
                sql.AppendFormat(" AND Phone = '{0}'", this.txt_Phone.Text);
            }

            // 身份证号
            if (!txt_CardId.Text.Trim().Equals(string.Empty))
            {
                sql.AppendFormat(" AND CardId = '{0}'", this.txt_CardId.Text);
            }

            da = new SqlDataAdapter(sql.ToString(), DB.Conn);
            if (ds.Tables["HousingRecords"] != null)
            {
                ds.Tables["HousingRecords"].Clear();
            }

            da.Fill(ds, "HousingRecords");
            this.dgv_CustomerData.DataSource = ds.Tables["HousingRecords"];

        }


        /// <summary>
        /// 查询点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ucButton_Query_Click(object sender, EventArgs e)
        {
            showCustomerData();
        }


        /// <summary>
        /// 清空点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ucButton_Empty_Click(object sender, EventArgs e)
        {
            RemoveContent();
        }


        /// <summary>
        /// 清空方法
        /// </summary>
        public void RemoveContent()
        {
            //this.Controls.Add();
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
