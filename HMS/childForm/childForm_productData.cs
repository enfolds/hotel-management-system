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
    public partial class childForm_productData : Form
    {
        DBHelper er = new DBHelper();
        private const String Strcon = "Data Source=.;Initial Catalog=HMS;User ID=sa;Pwd=123";
        SqlConnection conn = new SqlConnection(Strcon);
        SqlDataAdapter da;
        DataSet ds = new DataSet();

        public childForm_productData()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ucButton_submit_Click(object sender, EventArgs e)
        {
            GetRoom();

        }

        public void GetRoom()
        {
            double price = 0;
            int num = (int)this.cbo_name_1.SelectedValue;
            if (!string.IsNullOrEmpty(txt_price.Text))
            {
                price = Convert.ToDouble(txt_price.Text);

            }
            StringBuilder der = new StringBuilder(" select GoodsId,(select GoodsTypeName from GoodsType where GoodsType.GoodsTypeId=GoodsData.GoodsTypeId)GoodsTypeName,GoodsName,GoodssPrice from GoodsData where 1 =1 ");
            if (num != -1)
            {
                der.AppendFormat(" and GoodsTypeId = {0}", num);
            }
            if (price > 0)
            {
                der.AppendFormat(" and GoodssPrice <= {0}", price);
            }
            da = new SqlDataAdapter(der.ToString(), er.Conn);
            if (ds.Tables["GoodsData"] != null)
            {
                ds.Tables["GoodsData"].Clear();
            }
            da.Fill(ds, "GoodsData");
            this.dgvtype.DataSource = ds.Tables["GoodsData"];
        }
        private void panel1_Load(object sender, PaintEventArgs e)
        {
            this.dgvtype.AutoGenerateColumns = false;
            string Sqls = " select * from GoodsType ";
            da = new SqlDataAdapter(Sqls, er.Conn);
            da.Fill(ds, "GoodsType");
            DataRow rows = ds.Tables["GoodsType"].NewRow();
            rows[0] = -1;
            rows[1] = "请选择";
            ds.Tables["GoodsType"].Rows.InsertAt(rows, 0);
            this.cbo_name_1.DataSource = ds.Tables["GoodsType"];
            this.cbo_name_1.ValueMember = "GoodsTypeId";
            this.cbo_name_1.DisplayMember = "GoodsTypeName";
            GetRoom();
        }

        private void tsmi_delete_Click(object sender, EventArgs e)
        {
            this.pnl_modifications1s.Visible = true;
            txt_num_1.Text = this.dgvtype.SelectedRows[0].Cells["GoodsId"].Value.ToString();
            txt_type_1.Text = this.dgvtype.SelectedRows[0].Cells["GoodsTypeName"].Value.ToString();
            txt_name_1.Text = this.dgvtype.SelectedRows[0].Cells["GoodsName"].Value.ToString();
            txt_prices_1.Text = this.dgvtype.SelectedRows[0].Cells["GoodssPrice"].Value.ToString();
        }
        public void Delete()
        {
            string num = this.txt_num_1.Text.Trim();
            string type = this.txt_type_1.Text.Trim();
            string name = this.txt_name_1.Text.Trim();
            string price = this.txt_prices_1.Text.Trim();
            StringBuilder der = new StringBuilder(" delete GoodsData where ");
            der.AppendFormat(" GoodsId = {0}",num);
            der.AppendFormat(" and GoodsTypeId = (select GoodsTypeId from GoodsType where GoodsTypeName='{0}')", type);
            der.AppendFormat(" and GoodsName ='{0}'",name);
            der.AppendFormat(" and GoodssPrice ={0}",price);
            int result = er.ExecuteNonQuery(der.ToString());
            if (result > 0)
            {
                MessageBox.Show("删除成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                this.pnl_modifications1s.Visible = false;
                GetRoom();
            }
            else 
            {
                MessageBox.Show("删除失败！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void btn_Hidden_Click(object sender, EventArgs e)
        {
            this.pnl_modifications1s.Visible = false;
        }

        private void ucButton1s_Click(object sender, EventArgs e)
        {
            Delete();
        }
    }
}
