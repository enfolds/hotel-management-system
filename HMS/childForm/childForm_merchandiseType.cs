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

    public partial class childForm_merchandiseType : Form
    {
        DBHelper er = new DBHelper();
        private const String Strcon = "Data Source=.;Initial Catalog=HMS;User ID=sa;Pwd=123";
        SqlConnection conn = new SqlConnection(Strcon);
        SqlDataAdapter da;
        DataSet ds = new DataSet();

        public childForm_merchandiseType()
        {
            InitializeComponent();
        }

        private void ucButton1_Click(object sender, EventArgs e)
        {
            GetRoom();
        }
        public void GetRoom()
        {
            int num = int.Parse(this.cbo_types_1.SelectedValue.ToString());
            StringBuilder der = new StringBuilder(" select GoodsTypeId,GoodsTypeName from GoodsType where 1=1 ");
            if (num != -1)
            {
                der.AppendFormat(" and GoodsTypeId = {0}", num);
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
            string Sql = " select * from GoodsType ";
            da = new SqlDataAdapter(Sql, er.Conn);
            da.Fill(ds, "GoodsType");
            DataRow row = ds.Tables["GoodsType"].NewRow();
            row[0] = -1;
            row[1] = "请选择";
            ds.Tables["GoodsType"].Rows.InsertAt(row, 0);
            this.cbo_types_1.DataSource = ds.Tables["GoodsType"];
            this.cbo_types_1.ValueMember = "GoodsTypeId";
            this.cbo_types_1.DisplayMember = "GoodsTypeName";
            GetRoom();
        }

        private void tsmi_add_Click(object sender, EventArgs e)
        {
            this.pnl_addType.Visible = true;
        }

        private void ucButton_submits_Click(object sender, EventArgs e)
        {
            string type = this.txt_add.Text.Trim();
            if (string.IsNullOrEmpty(type))
            {
                MessageBox.Show("类型不能为空！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            StringBuilder sb = new StringBuilder(" select GoodsTypeId from GoodsType where ");
            sb.AppendFormat(" GoodsTypeName = '{0}'",type);
            if (er.ExecuteScalar(sb.ToString())!=null)
            {
                MessageBox.Show("已有该类型！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            StringBuilder der = new StringBuilder(" insert into GoodsType(GoodsTypeName)");
            der.AppendFormat(" values('{0}')", type);
            int result = er.ExecuteNonQuery(der.ToString());
            if (result > 0)
            {
                MessageBox.Show("保存成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                this.pnl_addType.Visible = false;
            }
            else
            {
                MessageBox.Show("保存失败！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.pnl_addType.Visible = false;
        }


    }
}
