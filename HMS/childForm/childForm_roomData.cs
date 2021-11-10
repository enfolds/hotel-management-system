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
    public partial class childForm_roomData : Form
    {
       
        DBHelper er = new DBHelper();
        private const String Strcon = "Data Source=.;Initial Catalog=HMS;User ID=sa;Pwd=123";
        SqlConnection conn = new SqlConnection(Strcon);
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        public childForm_roomData()
        {
            InitializeComponent();
        }

        private void childForm_roomData_Load(object sender, EventArgs e)
        {
            this.dgvRoom.AutoGenerateColumns = false;
            string Sql = " select * from RoomType";
            da = new SqlDataAdapter(Sql, er.Conn);
            da.Fill(ds, "RoomType");
            DataRow row = ds.Tables["RoomType"].NewRow();
            row[0] = -1;
            row[1] = "请选择";
            ds.Tables["RoomType"].Rows.InsertAt(row, 0);
            this.cboroom_name.DataSource = ds.Tables["RoomType"];
            this.cboroom_name.ValueMember = "RoomTypeId";
            this.cboroom_name.DisplayMember = "RoomTypeName";

            string sql_ = "select * from RoomStatus";
            this.ds = new DataSet();
            da = new SqlDataAdapter(sql_, er.Conn);
            da.Fill(ds, "RoomStatu");
            DataRow row_ = ds.Tables["RoomStatu"].NewRow();
            row_[0] = -1;
            row_[1] = "请选择";
            ds.Tables["RoomStatu"].Rows.InsertAt(row_, 0);
            this.cbo_state.DataSource = ds.Tables["RoomStatu"];
            this.cbo_state.ValueMember = "RoomStatusId";
            this.cbo_state.DisplayMember = "RoomStatusName";

            string Sqls = " select * from RoomStatus";
            da = new SqlDataAdapter(Sqls, er.Conn);
            da.Fill(ds, "RoomStatus");
            DataRow rows = ds.Tables["RoomStatus"].NewRow();
            rows[0] = -1;
            rows[1] = "请选择";
            ds.Tables["RoomStatus"].Rows.InsertAt(rows, 0);
            this.cbostate.DataSource = ds.Tables["RoomStatus"];
            this.cbostate.ValueMember = "RoomStatusId";
            this.cbostate.DisplayMember = "RoomStatusName";
            GetRoom();
        }
        public void GetRoom()
        {
            int num = int.Parse(this.cboroom_name.SelectedValue.ToString());
            int nums = int.Parse(this.cbostate.SelectedValue.ToString());
            StringBuilder der = new StringBuilder(" select RoomId,(select RoomTypeName from RoomType where  RoomType.RoomTypeId=RoomData.RoomTypeId)RoomTypeName,RoomPrice,(select RoomStatusName from RoomStatus where  RoomStatus.RoomStatusId=RoomData.RoomStatusId)RoomStatusName from RoomData where 1=1 ");
            if (num != -1)
            {
                der.AppendFormat(" and RoomTypeId = {0}", num);
            }
            if (nums != -1)
            {
                der.AppendFormat(" and RoomStatusId = {0}", nums);
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
            GetRoom();
        }

        private void tsmiModify_Click(object sender, EventArgs e)
        {
            this.tbo_RoomNumber.ReadOnly = true;
            this.tbo_price.ReadOnly = true;
            this.txt_types.ReadOnly = true;
            this.pnl_modifications.Visible = true;
            tbo_RoomNumber.Text = this.dgvRoom.SelectedRows[0].Cells["RoomId"].Value.ToString();
            tbo_price.Text = this.dgvRoom.SelectedRows[0].Cells["RoomPrice"].Value.ToString();
            cbo_state.Text = this.dgvRoom.SelectedRows[0].Cells["RoomStatusName"].Value.ToString();
            txt_types.Text = this.dgvRoom.SelectedRows[0].Cells["RoomTypeName"].Value.ToString();
        }

        private void ucButton1_Click(object sender, EventArgs e)
        {
            this.ptb_hotel3.Visible = false;
            this.pictureBox1.Visible = false;
            this.ptb_failure.Visible = false;
            this.ptb_hotel4.Visible = true;
            UpdateRoom();
        }
        public void UpdateRoom()
        {
            string name = this.tbo_RoomNumber.Text.Trim();
            string types = this.txt_types.Text.Trim();
            StringBuilder der = new StringBuilder(" select RoomTypeId from RoomType ");
            der.AppendFormat(" where RoomTypeName = '{0}'", types);
            int type_s = (int)er.ExecuteScalar(der.ToString());

            string price = this.tbo_price.Text.Trim();
            string states = this.cbo_state.Text.Trim();
            StringBuilder ders = new StringBuilder(" select RoomStatusId from RoomStatus ");
            ders.AppendFormat(" where RoomStatusName = '{0}'", states);
            int state_s = (int)er.ExecuteScalar(ders.ToString());

            StringBuilder sb = new StringBuilder(" update RoomData set ");
            sb.AppendFormat(" RoomTypeId = {0},", type_s);
            sb.AppendFormat(" RoomPrice = {0},", price);
            sb.AppendFormat(" RoomStatusId = {0} ", state_s);
            sb.AppendFormat(" where RoomId = {0} ", name);
            int result_s = er.ExecuteNonQuery(sb.ToString());
            if (result_s > 0)
            {
                MessageBox.Show("房号" + name + "状态修改成功为" + states + "", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                this.pnl_modifications.Visible = false;
                GetRoom();
                this.pictureBox1.Visible = false;
                this.ptb_failure.Visible = false;
                this.ptb_hotel4.Visible = false;
                this.ptb_hotel3.Visible = true;
            }
            else
            {
                MessageBox.Show("修改失败！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                this.ptb_hotel4.Visible = false;
                this.ptb_hotel3.Visible = false;
                this.pictureBox1.Visible = false;
                this.ptb_failure.Visible = true;
            }
        }

        private void ucButton_emptying_Click(object sender, EventArgs e)
        {
            this.tbo_RoomNumber.Text = "";
            this.txt_types.Text = "";
            this.tbo_price.Text = "";
            this.cbo_state.Text = "";
        }

        private void ucButton_submit_Click(object sender, EventArgs e)
        {
            //this.ptb_failure.Visible = false;
            //this.ptb_hotel3.Visible = false;
            //this.pictureBox1.Visible = false;
            //this.ptb_hotel4.Visible = true;
        }

        private void btn_Hidden_Click(object sender, EventArgs e)
        {
            this.pnl_modifications.Visible = false;
        }

    }
}
