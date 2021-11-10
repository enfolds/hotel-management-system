using HMS.Models;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HMS.childForm
{
    public partial class childForm_dashboard : Form
    {
        // 数据库工具类
        DBHelper DB = new DBHelper();

        int x = 50;  //房间控件定位x
        int y = 230;  //房间控件定位y

        public childForm_dashboard()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void childForm_workbench_Load(object sender, EventArgs e)
        {
            // 工作台数据
            OperatinalData();

            // 创建房间
            CreatRoom();

        }


        /// <summary>
        /// 工作台数据
        /// </summary>
        public void OperatinalData()
        {
            StringBuilder sql = new StringBuilder();

            // 客房总数
            sql.AppendFormat("SElECT COUNT(*) FROM RoomData");
            int roomNumber = (int)DB.ExecuteScalar(sql.ToString());
            this.lab_RoomNumber.Text = roomNumber.ToString();

            // 剩余客房数量
            sql.Length = 0;
            sql.AppendFormat("SElECT COUNT(*) FROM RoomData");
            sql.AppendFormat(" WHERE RoomStatusId = '1'");
            int availableRoom = (int)DB.ExecuteScalar(sql.ToString());
            this.lab_AvailableRoom.Text = availableRoom.ToString();

            // 今日营业额
            sql.Length = 0;
            string nowTime = System.DateTime.Now.ToString("yyyy-MM-dd");
            sql.AppendFormat("SElECT SUM(RoomPrice)");
            sql.AppendFormat(" FROM RoomData RA");
            sql.AppendFormat(" INNER JOIN HousingRecords HR ON RA.RoomId = HR.RoomId");
            sql.AppendFormat(" WHERE CheckInTime LIKE '{0}%' AND RA.RoomStatusId = '2'", nowTime);
            string todayTurnover = DB.ExecuteScalar(sql.ToString()).ToString();

            if (todayTurnover != null&&todayTurnover!="")
            {
                this.lab_TodayTurnover.Text = todayTurnover.ToString();
            }
            else
            {
                this.lab_TodayTurnover.Text = "0";
            }

        }


        /// <summary>
        /// 创建房间
        /// </summary>
        public void CreatRoom()
        {
            try
            {
                StringBuilder sql = new StringBuilder();

                // 获取房间数量
                sql.AppendFormat("SElECT COUNT(*) FROM RoomData");
                int roomNumber = (int)DB.ExecuteScalar(sql.ToString());

                // 声明房间对象数组
                RoomData[] roomDatas = new RoomData[roomNumber];

                sql.Length = 0;
                sql.AppendFormat("SElECT *");
                sql.AppendFormat("FROM RoomData RD");
                sql.AppendFormat(" INNER JOIN RoomStatus RS ON RS.RoomStatusId = RD.RoomStatusId");
                sql.AppendFormat(" INNER JoIN RoomType RT ON RT.RoomTypeId = RD.RoomTypeId");
                SqlDataReader reader = DB.ExecuteReader(sql.ToString());

                // 房间初始数量
                int i = 0;

                while (reader.Read())
                {
                    roomDatas[i] = new RoomData();
                    roomDatas[i].RoomId = (int)reader["RoomId"];
                    roomDatas[i].RoomPrice = (double)reader["RoomPrice"];
                    roomDatas[i].RoomStatusName = (string)reader["RoomStatusName"];
                    roomDatas[i].RoomTypeName = (string)reader["RoomTypeName"];
                    roomDatas[i].RoomStatusId = (int)reader["RoomStatusId"];

                    UCRoomInfo roomInfo = new UCRoomInfo();
                    roomInfo.RoomId = roomDatas[i].RoomId.ToString();
                    roomInfo.RoomPrice = roomDatas[i].RoomPrice.ToString();
                    roomInfo.RoomStateName = reader["RoomStatusName"].ToString();
                    roomInfo.RoomTypeName = reader["RoomTypeName"].ToString();

                    switch (roomDatas[i].RoomStatusId)
                    {
                        case 1:
                            roomInfo.BackColor = Color.LightSkyBlue; // 未入住
                            break;

                        case 2:
                            roomInfo.BackColor = Color.Orange; // 已入住
                            break;

                        case 3:
                            roomInfo.BackColor = Color.Wheat; // 已预定
                            break;

                        case 4:
                            roomInfo.BackColor = Color.CadetBlue; // 未打扫
                            break;

                        case 5:
                            roomInfo.BackColor = Color.Tomato; // 维修中
                            break;

                        case 6:
                            roomInfo.BackColor = Color.DarkSlateGray; // 已停用
                            break;
                    }

                    roomInfo.Location = new Point(x, y);
                    this.Controls.Add(roomInfo);
                    x += 200;
                    i++;

                    if (i % 6 == 0)
                    {
                        x = 50;
                        y = 410;
                    }

                    if (i % 6 == 0 && i / 6 == 2)
                    {
                        x = 50;
                        y = 590;
                    }

                    if (i % 6 == 0 && i / 6 == 3)
                    {
                        x = 50;
                        y = 770;
                    }

                    if (i % 6 == 0 && i / 6 == 4)
                    {
                        x = 50;
                        y = 950;
                    }

                }

                DB.Close(reader);
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

        }


    }
}
