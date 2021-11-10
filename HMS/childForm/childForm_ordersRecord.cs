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
    public partial class childForm_ordersRecord : Form
    {
        // 数据库工具类
        DBHelper DB = new DBHelper();

        // 数据适配器
        private SqlDataAdapter da = null;

        // DataSet 数据集
        private DataSet ds = new DataSet();


        public childForm_ordersRecord()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void childForm_ordersRecord_Load(object sender, EventArgs e)
        {
            this.dgv_OrderData.AutoGenerateColumns = false;
            loadOrderData();
        }


        /// <summary>
        /// 加载订单记录
        /// </summary>
        public void loadOrderData()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("SELECT *");
            sql.AppendFormat(" FROM SalesRecords SR");
            sql.AppendFormat(" INNER JOIN GoodsData GD ON GD.GoodsId = SR.GoodsId");
            sql.AppendFormat(" WHERE 1 = 1");

            // 订单号
            if (!txt_OrderId.Text.Trim().Equals(string.Empty))
            {
                sql.AppendFormat(" AND OrderId = '{0}'", this.txt_OrderId.Text);
            }

            // 商品名
            if (!txt_GoodsName.Text.Trim().Equals(string.Empty))
            {
                sql.AppendFormat(" AND GoodsName LIKE '%{0}%'", this.txt_GoodsName.Text);
            }

            // 房号
            if (!txt_RoomId.Text.Trim().Equals(string.Empty))
            {
                sql.AppendFormat(" AND RoomId = '{0}'", this.txt_RoomId.Text);
            }

            da = new SqlDataAdapter(sql.ToString(), DB.Conn);
            if (ds.Tables["SalesRecords"] != null)
            {
                ds.Tables["SalesRecords"].Clear();
            }

            da.Fill(ds, "SalesRecords");
            this.dgv_OrderData.DataSource = ds.Tables["SalesRecords"];

        }


        /// <summary>
        /// 查询点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ucButton_Query_Click(object sender, EventArgs e)
        {
            loadOrderData();
        }


        /// <summary>
        /// 清空点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ucButton_Empty_Click(object sender, EventArgs e)
        {
            this.txt_GoodsName.Text = "";
            this.txt_OrderId.Text = "";
            this.txt_RoomId.Text = "";
        }


    }
}
