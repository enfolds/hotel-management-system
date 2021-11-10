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
    public partial class childForm_newAddRoom : Form
    {
        DBHelper er = new DBHelper();
        private const String Strcon = "Data Source=.;Initial Catalog=HMS;User ID=sa;Pwd=123";
        SqlConnection conn = new SqlConnection(Strcon);
        SqlDataAdapter da;
        public DataSet ds = new DataSet();
        public childForm_newAddRoom()
        {
            InitializeComponent();
        }


        private void childForm_newAddRoom_Load(object sender, EventArgs e)
        {
            string Sql = " select * from RoomStatus";
            da = new SqlDataAdapter(Sql, er.Conn);
            da.Fill(ds, "RoomStatus");
            DataRow row = ds.Tables["RoomStatus"].NewRow();
            row[0] = -1;
            row[1] = "请选择";
            ds.Tables["RoomStatus"].Rows.InsertAt(row, 0);
            this.cboState.DataSource = ds.Tables["RoomStatus"];
            this.cboState.ValueMember = "RoomStatusId";
            this.cboState.DisplayMember = "RoomStatusName";

            string Sqls = " select * from RoomType";
            da = new SqlDataAdapter(Sqls, er.Conn);
            da.Fill(ds, "RoomType");
            DataRow rows = ds.Tables["RoomType"].NewRow();
            rows[0] = -1;
            rows[1] = "请选择";
            ds.Tables["RoomType"].Rows.InsertAt(rows, 0);
            this.cboType.DataSource = ds.Tables["RoomType"];
            this.cboType.ValueMember = "RoomTypeId";
            this.cboType.DisplayMember = "RoomTypeName";
        }
       
        public void AddRoom()
        {
            string names = txtName.Text.Trim();
            if (string.IsNullOrEmpty(names))
            {
                MessageBox.Show("房间号不能为空！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            
            StringBuilder stringBuilder = new StringBuilder(" select * from RoomData ");
            stringBuilder.AppendFormat(" where RoomId = '{0}'", names);
            if (er.ExecuteScalar(stringBuilder.ToString()) != null)
            {
                MessageBox.Show("已有该房间！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if (this.cboType.SelectedValue.ToString() == "-1" || string.IsNullOrEmpty(cboType.Text))
            {
                MessageBox.Show("房间类型不能为空！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            string prices = txtPrice.Text.Trim();
            if (string.IsNullOrEmpty(prices))
            {
                MessageBox.Show("价格不能为空！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if (this.cboState.SelectedValue.ToString() == "-1" || string.IsNullOrEmpty(cboType.Text))
            {
                MessageBox.Show("房间状态不能为空！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            string types = this.cboType.Text.Trim();
            StringBuilder der = new StringBuilder(" select RoomTypeId from RoomType ");
            der.AppendFormat(" where RoomTypeName = '{0}'", types);
            int type_ = (int)er.ExecuteScalar(der.ToString());
            
            string state = this.cboState.Text.Trim();
            StringBuilder ders = new StringBuilder(" select RoomStatusId from RoomStatus ");
            ders.AppendFormat(" where RoomStatusName = '{0}'", state);
            int state_ = (int)er.ExecuteScalar(ders.ToString());
           
            StringBuilder sb = new StringBuilder(" insert into RoomData(RoomId,RoomTypeId,RoomPrice,RoomStatusId)");
            sb.AppendFormat(" values ({0},{1},{2},{3})", names, type_, prices, state_);
            int result = er.ExecuteNonQuery(sb.ToString());
            
            if (result > 0)
            {
                MessageBox.Show("房号" + names + "添加成功!", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                this.txtName.Text = "";
                this.txtPrice.Text = "";
                this.cboState.Text = "";
                this.cboType.Text = "";
                this.ptb_hotelS1.Visible = false;
                this.ptb_hotel.Visible = true;
                this.ptb_htoels.Visible = false;
            }
            else
            {
                MessageBox.Show("保存失败！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                this.ptb_hotelS1.Visible = true;
            }
        }
       

        private void ucButton_empty_Click(object sender, EventArgs e)
        {
            this.txtName.Text = "";
            this.txtPrice.Text = "";
            this.cboState.Text = "";
            this.cboType.Text = "";
            
        }

        private void ucButton_submit_Click(object sender, EventArgs e)
        {
            AddRoom();
        }

        private void ucButton_submit_Load(object sender, EventArgs e)
        {

        }
    }
}
