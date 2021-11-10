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
    public partial class childForm_goodsData : Form
    {
        // 数据库工具类
        DBHelper DB = new DBHelper();

        // 数据适配器
        private SqlDataAdapter da = null;

        // DataSet 数据集
        private DataSet ds = new DataSet();


        public childForm_goodsData()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void childForm_goodsData_Load(object sender, EventArgs e)
        {
            // 加载商品类型
            loadRoomType();

            this.dgv_GoodsData.AutoGenerateColumns = false;
            loadGoodsData();

        }


        /// <summary>
        /// 加载商品类型
        /// </summary>
        public void loadRoomType()
        {
            StringBuilder sql = new StringBuilder("SELECT * FROM GoodsType");
            da = new SqlDataAdapter(sql.ToString(), DB.Conn);

            da.Fill(ds, "QueryGoodsType");
            DataRow row = ds.Tables["QueryGoodsType"].NewRow();
            row[0] = -1;
            row[1] = "请选择";
            ds.Tables["QueryGoodsType"].Rows.InsertAt(row, 0);

            this.cob_QueryGoodsType.DataSource = ds.Tables["QueryGoodsType"];
            this.cob_QueryGoodsType.ValueMember = "GoodsTypeId";
            this.cob_QueryGoodsType.DisplayMember = "GoodsTypeName";
        }


        /// <summary>
        /// 加载商品信息
        /// </summary>
        public void loadGoodsData()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("SELECT *");
            sql.AppendFormat(" FROM GoodsData GD");
            sql.AppendFormat(" INNER JOIN GoodsType GT ON GT.GoodsTypeId = GD.GoodsTypeId");
            sql.AppendFormat(" WHERE 1 = 1");

            // 商品ID
            if (!txt_QueryGoodsId.Text.Trim().Equals(string.Empty))
            {
                sql.AppendFormat(" AND OrderId = '{0}'", this.txt_QueryGoodsId.Text);
            }

            // 商品名
            if (!txt_QueryGoodsName.Text.Trim().Equals(string.Empty))
            {
                sql.AppendFormat(" AND GoodsName LIKE '%{0}%'", this.txt_QueryGoodsName.Text);
            }

            // 类型
            if (!this.cob_QueryGoodsType.Text.Equals("请选择"))
            {
                sql.AppendFormat(" AND GT.GoodsTypeName = '{0}'", this.cob_QueryGoodsType.Text);
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
        /// 查询点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ucButton_Query_Click(object sender, EventArgs e)
        {
            loadGoodsData();
        }


        /// <summary>
        /// 清空点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ucButton_Empty_Click(object sender, EventArgs e)
        {
            this.txt_QueryGoodsName.Text = "";
            this.txt_QueryGoodsId.Text = "";
            this.cob_QueryGoodsType.Text = "请选择";
        }


        /// <summary>
        /// 数据传递
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_GoodsData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgv_GoodsData.Rows.Count <= 0)
            {
                return;
            }

            this.txt_GoodsId.Text = this.dgv_GoodsData.SelectedRows[0].Cells["GoodsId"].Value.ToString();
            this.txt_GoodsSales.Text = this.dgv_GoodsData.SelectedRows[0].Cells["GoodsSales"].Value.ToString();
            this.txt_GoodsName.Text = this.dgv_GoodsData.SelectedRows[0].Cells["GoodsName"].Value.ToString();
            this.txt_GoodsPrice.Text = this.dgv_GoodsData.SelectedRows[0].Cells["GoodsPrice"].Value.ToString();

            // 库存
            int GoodsStock = int.Parse(this.dgv_GoodsData.SelectedRows[0].Cells["GoodsStock"].Value.ToString());
            this.num_GoodsStock.Value = GoodsStock;

            // 商品类型
            string goodsType = this.dgv_GoodsData.SelectedRows[0].Cells["GoodsTypeName"].Value.ToString();

            if (!txt_GoodsId.Text.Trim().Equals(string.Empty))
            {
                this.cob_GoodsType.Text = goodsType;
            }

            StringBuilder sql = new StringBuilder();
            sql.AppendFormat(" SELECT * FROM GoodsType");
            sql.AppendFormat(" WHERE 1 =1 ");

            da = new SqlDataAdapter(sql.ToString(), DB.Conn);

            da.Fill(ds, "GoodsType");
            DataRow row = ds.Tables["GoodsType"].NewRow();
            row[0] = -1;
            row[1] = "请选择";
            ds.Tables["GoodsType"].Rows.InsertAt(row, 0);

            this.cob_GoodsType.DataSource = ds.Tables["GoodsType"];
            this.cob_GoodsType.ValueMember = "GoodsTypeId";
            this.cob_GoodsType.DisplayMember = "GoodsTypeName";

            // 默认选择的商品类型
            this.cob_GoodsType.Text = goodsType;

        }


        /// <summary>
        /// 提交点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ucButton_Submit_Click(object sender, EventArgs e)
        {
            // 商品名称
            string goodsName = this.txt_GoodsName.Text;

            // 价格
            double goodsPrice = double.Parse(this.txt_GoodsPrice.Text);

            // 类型
            int goodsType = this.cob_GoodsType.SelectedIndex;

            // 库存
            int goodsStock = int.Parse(this.num_GoodsStock.Value.ToString());

            StringBuilder sql = new StringBuilder();

            sql.Length = 0;
            sql.AppendFormat("UPDATE GoodsData");
            sql.AppendFormat(" SET");
            sql.AppendFormat(" GoodsName = '{0}',", goodsName);
            sql.AppendFormat(" GoodsPrice = '{0}',", goodsPrice);
            sql.AppendFormat(" GoodsTypeId = '{0}',", goodsType);
            sql.AppendFormat(" GoodsStock = '{0}'", goodsStock);
            sql.AppendFormat(" WHERE GoodsId = '{0}'", this.txt_GoodsId.Text);
            int result_ = DB.ExecuteNonQuery(sql.ToString());

            if (result_ > 0)
            {
                MessageBox.Show("商品更新成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Question);

                // 加载商品信息
                loadGoodsData();
            }
            else
            {
                MessageBox.Show("商品更新失败！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

        }


    }
}
