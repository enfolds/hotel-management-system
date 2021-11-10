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
    public partial class childForm_nweGoodsOrder : Form
    {
        // 数据库工具类
        DBHelper DB = new DBHelper();

        // 数据适配器
        private SqlDataAdapter da = null;

        // DataSet 数据集
        private DataSet ds = new DataSet();


        public childForm_nweGoodsOrder()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void childForm_order_Load(object sender, EventArgs e)
        {
            this.dgv_GoodsData.AutoGenerateColumns = false;

            // 加载商品类型
            loadGoodsType();

            // 加载房号
            loadRoomId();
        }


        /// <summary>
        /// 加载商品类型
        /// </summary>
        public void loadGoodsType()
        {
            StringBuilder sql = new StringBuilder("SELECT * FROM GoodsType");
            da = new SqlDataAdapter(sql.ToString(), DB.Conn);

            da.Fill(ds, "GoodsType");
            DataRow row = ds.Tables["GoodsType"].NewRow();
            row[0] = -1;
            row[1] = "请选择";
            ds.Tables["GoodsType"].Rows.InsertAt(row, 0);

            this.cob_GoodsType.DataSource = ds.Tables["GoodsType"];
            this.cob_GoodsType.ValueMember = "GoodsTypeId";
            this.cob_GoodsType.DisplayMember = "GoodsTypeName";
        }


        /// <summary>
        /// 加载配送房间
        /// </summary>
        public void loadRoomId()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("SELECT RoomId");
            sql.AppendFormat(" FROM RoomData WHERE RoomStatusId =( ");
            sql.AppendFormat("  SELECT RoomStatusId");
            sql.AppendFormat("  FROM RoomStatus ");
            sql.AppendFormat("  WHERE RoomStatusName = '已入住'");
            sql.AppendFormat(" )");
            da = new SqlDataAdapter(sql.ToString(), DB.Conn);

            da.Fill(ds, "RoomData");
            //DataRow row = ds.Tables["GoodsType"].NewRow();
            //row[0] = -1;
            //row[1] = "请选择";
            //ds.Tables["RoomData"].Rows.InsertAt(row, 0);

            this.cob_RoomId.DataSource = ds.Tables["RoomData"];
            this.cob_RoomId.ValueMember = "RoomId";
            //this.cob_RoomId.DataSource = ds.Tables["RoomData"];
            //this.cob_RoomId.ValueMember = "RoomData";
            //this.cob_RoomId.DisplayMember = "RoomId";
        }


        /// <summary>
        /// 根据商品类型查询商品信息
        /// </summary>
        public void loadGoodsData()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("SELECT *");
            sql.AppendFormat(" FROM GoodsData GD");
            sql.AppendFormat(" INNER JOIN GoodsType GT ON GT.GoodsTypeId = GD.GoodsTypeId");
            sql.AppendFormat(" WHERE 1 =1 AND GoodsStock >= 1");

            if (!this.cob_GoodsType.Text.Equals("请选择"))
            {
                sql.AppendFormat(" AND GT.GoodsTypeName = '{0}'", this.cob_GoodsType.Text);
            }

            da = new SqlDataAdapter(sql.ToString(), DB.Conn);
            if (ds.Tables["GoodsData"] != null)
            {
                ds.Tables["GoodsData"].Clear();
            }

            da.Fill(ds, "GoodsData");
            this.dgv_GoodsData.DataSource = ds.Tables["GoodsData"];

        }


        /// <summary>
        /// 验证
        /// </summary>
        /// <returns></returns>
        public bool CheckInput()
        {
            // 商品名称
            if (this.txt_GoodsName.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请选择订餐商品！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }


        /// <summary>
        /// 动态SQL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cob_GoodsType_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadGoodsData();
        }


        /// <summary>
        /// 数据传递
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_RoomData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgv_GoodsData.Rows.Count <= 0)
            {
                return;
            }

            this.txt_GoodsName.Text = this.dgv_GoodsData.SelectedRows[0].Cells["GoodsName"].Value.ToString();
            this.txt_GoodsPrice.Text = this.dgv_GoodsData.SelectedRows[0].Cells["GoodsPrice"].Value.ToString();

            // 随机数
            Random randow = new Random();

            // 订单号
            string orderId = "DR" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString().PadLeft(2, '0') + DateTime.Now.Day.ToString().PadLeft(2, '0') + randow.Next(1000, 9999).ToString();
            this.txt_OrderId.Text = orderId;

            // 计算商品费用方法
            PaymentAmount();

        }


        /// <summary>
        /// 下单数量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void num_GoodsNum_ValueChanged(object sender, EventArgs e)
        {
            PaymentAmount();
        }


        /// <summary>
        /// 计算商品费用
        /// </summary>

        public void PaymentAmount()
        {
            if (this.txt_GoodsName.Text.Trim().Equals(string.Empty))
            {
                return;
            }

            // 商品单价
            double unitPrice = double.Parse(this.txt_GoodsPrice.Text.ToString());

            // 下单数量
            int goodsNum = int.Parse(this.num_GoodsNum.Value.ToString());

            // 费用
            this.txt_PaymentAmount.Text = (unitPrice * goodsNum).ToString();

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

            // 订单号
            string orderId = this.txt_OrderId.Text;

            // 商品名称
            StringBuilder sql = new StringBuilder("SELECT GoodsId FROM GoodsData");
            sql.AppendFormat(" WHERE GoodsName = '{0}'", this.txt_GoodsName.Text);
            int goodsId = (int)DB.ExecuteScalar(sql.ToString());

            // 商品数量
            int goodsNum = int.Parse(this.num_GoodsNum.Value.ToString());

            // 房号
            int roomId = int.Parse(this.cob_RoomId.SelectedValue.ToString());

            // 费用
            double aymentAmount = double.Parse(this.txt_PaymentAmount.Text.ToString());

            // 下单时间 (获取系统当前时间)
            string orderTime = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // 商品库存
            sql.Length = 0;
            sql.AppendFormat("SELECT GoodsStock FROM GoodsData");
            sql.AppendFormat(" WHERE GoodsId = {0}", goodsId);
            int goodsStock = (int)DB.ExecuteScalar(sql.ToString());

            if (goodsStock < goodsNum)
            {
                MessageBox.Show("商品 " + this.txt_GoodsName.Text + " 库存小于下单数量，订餐失败！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }


            // 新增订单
            sql.Length = 0;
            sql.AppendFormat("INSERT INTO SalesRecords");
            sql.AppendFormat(" VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", orderId, goodsId, goodsNum, roomId, aymentAmount, orderTime);

            int result = DB.ExecuteNonQuery(sql.ToString());

            if (result > 0)
            {
                MessageBox.Show("客房 " + roomId + " 订餐成功 ！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Question);

                // 库存
                goodsStock = goodsStock - goodsNum;

                // 商品销量
                sql.Length = 0;
                sql.AppendFormat("SELECT GoodsSales FROM GoodsData");
                sql.AppendFormat(" WHERE GoodsId = {0}", goodsId);
                int goodsSales = (int)DB.ExecuteScalar(sql.ToString());
                goodsSales += goodsNum;

                // 商品信息同步
                sql.Length = 0;
                sql.AppendFormat("UPDATE GoodsData");
                sql.AppendFormat(" SET");
                sql.AppendFormat(" GoodsStock = '{0}',", goodsStock);
                sql.AppendFormat(" GoodsSales = '{0}'", goodsSales);
                sql.AppendFormat(" WHERE GoodsId = '{0}'", goodsId);
                DB.ExecuteNonQuery(sql.ToString());

                int result_ = DB.ExecuteNonQuery(sql.ToString());

                if (result_ < 0)
                {
                    MessageBox.Show("商品信息同步失败！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }

                // 清空方法
                RemoveContent();

                // 默认请选择
                this.cob_GoodsType.Text = "请选择";

                // 加载商品信息
                loadGoodsData();

            }
            else
            {
                MessageBox.Show("订餐失败！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
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
            foreach (Control con in groupBox_Checkstand.Controls)//遍历控件类集合
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
