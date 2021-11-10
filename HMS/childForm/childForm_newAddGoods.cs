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
    public partial class childForm_newAddGoods : Form
    {

        DBHelper er = new DBHelper();

        private const string strcon = " Data Source=.;Initial Catalog=HMS;User ID=sa;Password=123";
        SqlConnection conn = new SqlConnection(strcon);
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        public childForm_newAddGoods()
        {
            InitializeComponent();
        }


        private void childForm_newAddDishes_Load(object sender, EventArgs e)
        {

            string Sql = " select * from GoodsType";
            da = new SqlDataAdapter(Sql, er.Conn);
            da.Fill(ds, "GoodsType");
            DataRow row = ds.Tables["GoodsType"].NewRow();
            row[0] = -1;
            row[1] = "请选择";
            ds.Tables["GoodsType"].Rows.InsertAt(row, 0);
            this.comboBox1.DataSource = ds.Tables["GoodsType"];
            this.comboBox1.ValueMember = "GoodsTypeId";
            this.comboBox1.DisplayMember = "GoodsTypeName";

        }
        private void ucButton_submit_Click(object sender, EventArgs e)
        {

            if (this.comboBox1.SelectedValue.ToString() == "-1" || string.IsNullOrEmpty(this.comboBox1.Text))
            {
                MessageBox.Show("商品类型不能为空！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if (string.IsNullOrEmpty(textBox3.Text.Trim()))
            {
                MessageBox.Show("商品名称不能为空！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            StringBuilder ders = new StringBuilder(" select * from GoodsData where ");
            ders.AppendFormat(" GoodsName = '{0}'", textBox3.Text.Trim());

            if (er.ExecuteScalar(ders.ToString()) != null)
            {
                MessageBox.Show("已有该商品！");
                return;
            }
            if (string.IsNullOrEmpty(textBox2.Text.Trim()))
            {
                MessageBox.Show("商品价格不能为空！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }

            string type = comboBox1.Text.Trim();
            string name = textBox3.Text.Trim();
            string price = textBox2.Text.Trim();
            StringBuilder der = new StringBuilder(" select GoodsTypeId from GoodsType ");
            der.AppendFormat(" where GoodsTypeName = '{0}'", type);
            int result = (int)er.ExecuteScalar(der.ToString());
            StringBuilder sb = new StringBuilder(" insert into GoodsData(GoodsTypeId,GoodsName,GoodsPrice)");
            sb.AppendFormat(" values ( {0},'{1}',{2})", result, name, price);
            int result_ = er.ExecuteNonQuery(sb.ToString());
            if (result_ > 0)
            {
                MessageBox.Show("保存成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                MessageBox.Show("保存失败！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void ucButton_empty_Click(object sender, EventArgs e)
        {
            this.comboBox1.Text = "";
            this.textBox3.Text = "";
            this.textBox2.Text = "";

        }


    }
}
