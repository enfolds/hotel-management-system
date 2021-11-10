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
    public partial class childForm_roomType : Form
    {
        DBHelper er = new DBHelper();
        private const String Strcon = "Data Source=.;Initial Catalog=HMS;User ID=sa;Pwd=123";
        SqlConnection conn = new SqlConnection(Strcon);
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        public childForm_roomType()
        {
            InitializeComponent();
        }
        private void childForm_roomType_Load(object sender, EventArgs e)
        {
            this.dgvRoom.AutoGenerateColumns = false;
            string Sql = " select * from RoomType";
            da = new SqlDataAdapter(Sql, er.Conn);
            da.Fill(ds, "RoomType");
            DataRow row = ds.Tables["RoomType"].NewRow();
            row[0] = -1;
            row[1] = "请选择";
            ds.Tables["RoomType"].Rows.InsertAt(row, 0);
            this.cbonum.DataSource = ds.Tables["RoomType"];
            this.cbonum.ValueMember = "RoomTypeId";
            this.cbonum.DisplayMember = "RoomTypeName";
            GetRoom();
        }
        public void GetRoom()
        {
            int num = int.Parse(this.cbonum.SelectedValue.ToString());
            StringBuilder der = new StringBuilder(" select  RoomTypeId,RoomTypeName from RoomType where 1=1 ");
            if (num != -1)
            {
                der.AppendFormat(" and RoomTypeId = {0}", num);
            }
            da = new SqlDataAdapter(der.ToString(), er.Conn);
            if (ds.Tables["RoomData"] != null)
            {
                ds.Tables["RoomData"].Clear();
            }
            da.Fill(ds, "RoomData");
            this.dgvRoom.DataSource = ds.Tables["RoomData"];
        }


        private void ucButton_submit_MouseClick(object sender, MouseEventArgs e)
        {
            //this.ptb_hotel1.Visible = true;
            //this.ptb_hotel2.Visible = false;
            if (string.IsNullOrEmpty(this.cbonum.Text.Trim()))
            {
                MessageBox.Show("房间类型不能为空！");
                //this.ptb_hotel1.Visible = true;
                //this.ptb_hotel2.Visible = false;
                return;
            }
            GetRoom();
        }
        private void tsmi_add_Click(object sender, EventArgs e)
        {
            this.pnl_modifications1.Visible = true;
        }

        private void ucButton1s_Click(object sender, EventArgs e)
        {

            string type = txt_types1.Text.Trim();

            if (string.IsNullOrEmpty(type))
            {
                MessageBox.Show("类型不能为空！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            StringBuilder der = new StringBuilder(" select RoomTypeId from RoomType ");
            der.AppendFormat(" where RoomTypeName = '{0}'", type);
            if (er.ExecuteScalar(der.ToString()) != null)
            {
                MessageBox.Show("已有该类型！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            StringBuilder sb = new StringBuilder(" insert into RoomType(RoomTypeName)");
            sb.AppendFormat(" values ( '{0}' )", type);
            int result = er.ExecuteNonQuery(sb.ToString());

            if (result > 0)
            {
                MessageBox.Show("类型添加成功!该类型为：" + type + "", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                this.pnl_modifications1.Visible = false;
                GetRoom();
                this.txt_types1.Text = "";
            }
            else
            {
                MessageBox.Show("添加失败！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

        }

        private void btn_Hidden_Click(object sender, EventArgs e)
        {
            this.pnl_modifications1.Visible = false;
        }
    }
}
