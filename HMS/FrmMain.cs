using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMS.childForm;
using System.Data.SqlClient;

namespace HMS
{
    public partial class FrmMain : Form
    {
        // 数据库工具类
        DBHelper DB = new DBHelper();

        // 登录角色
        public string userName;

        public FrmMain()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            // 播放欢迎提示语
            greeting();

            // 显示当前管理员
            this.lab_AdminName.Text = userName;

            // 默认显示仪表盘
            childForm_dashboard frm = new childForm_dashboard();
            openChildForm(frm);
        }


        /// <summary>
        /// 子窗体方法
        /// </summary>
        /// <param name="childForm"></param>
        private void openChildForm(Form childForm)
        {
            foreach (Control item in this.pal_childForm.Controls)
            {
                if (item is Form)
                {
                    ((Form)item).Close();
                }
            }

            childForm.TopLevel = false;
            //panel_childForm.Controls.Add(childForm);
            //childForm.MdiParent = this;
            childForm.Parent = this.pal_childForm;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.Show();
        }


        /// <summary>
        /// 隐藏菜单
        /// </summary>
        public void pal_initialize()
        {
            pal_MenuCustomer.Visible = false;
            pal_MenuRoom.Visible = false;
            pal_MenuRoomService.Visible = false;
            pal_MenuKitchen.Visible = false;
            pal_MenuSet.Visible = false;
        }


        /// <summary>
        /// 住客管理菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_MenuCustomer_Click(object sender, EventArgs e)
        {
            if (pal_MenuCustomer.Visible == true)
            {
                pal_MenuCustomer.Visible = false;
            }
            else if (pal_MenuCustomer.Visible == false)
            {
                pal_MenuCustomer.Visible = true;
            }

            pal_MenuRoom.Visible = false;
            pal_MenuSet.Visible = false;
            pal_MenuRoomService.Visible = false;
            pal_MenuKitchen.Visible = false;
            pal_MenuSet.Visible = false;
        }


        /// <summary>
        /// 客房管理菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_MenuRoom_Click(object sender, EventArgs e)
        {
            if (pal_MenuRoom.Visible == true)
            {
                pal_MenuRoom.Visible = false;
            }
            else if (pal_MenuRoom.Visible == false)
            {
                pal_MenuRoom.Visible = true;
            }

            pal_MenuCustomer.Visible = false;
            pal_MenuSet.Visible = false;
            pal_MenuRoomService.Visible = false;
            pal_MenuKitchen.Visible = false;
            pal_MenuSet.Visible = false;
        }


        /// <summary>
        /// 客房服务菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_MenuCanteen_Click(object sender, EventArgs e)
        {
            if (pal_MenuRoomService.Visible == true)
            {
                pal_MenuRoomService.Visible = false;
            }
            else if (pal_MenuRoomService.Visible == false)
            {
                pal_MenuRoomService.Visible = true;
            }

            pal_MenuCustomer.Visible = false;
            pal_MenuRoom.Visible = false;
            pal_MenuSet.Visible = false;
            pal_MenuKitchen.Visible = false;
            pal_MenuSet.Visible = false;
        }


        /// <summary>
        /// 库存管理菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_MenuKitchen_Click(object sender, EventArgs e)
        {
            if (pal_MenuKitchen.Visible == true)
            {
                pal_MenuKitchen.Visible = false;
            }
            else if (pal_MenuKitchen.Visible == false)
            {
                pal_MenuKitchen.Visible = true;
            }

            pal_MenuCustomer.Visible = false;
            pal_MenuRoom.Visible = false;
            pal_MenuSet.Visible = false;
            pal_MenuRoomService.Visible = false;
            pal_MenuSet.Visible = false;
        }


        /// <summary>
        /// 系统设置菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_MenuSet_Click(object sender, EventArgs e)
        {
            if (pal_MenuSet.Visible == true)
            {
                pal_MenuSet.Visible = false;
            }
            else if (pal_MenuSet.Visible == false)
            {
                pal_MenuSet.Visible = true;
            }

            pal_MenuCustomer.Visible = false;
            pal_MenuRoom.Visible = false;
            pal_MenuRoomService.Visible = false;
            pal_MenuKitchen.Visible = false;
        }


        /// <summary>
        /// 系统时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void time_Tick(object sender, EventArgs e)
        {
            DateTime nowTime = System.DateTime.Now.ToLocalTime();
            lab_Time.Text = nowTime.ToString();
        }


        /// <summary>
        /// 退出窗体事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            pal_initialize();
            DialogResult result = MessageBox.Show("确定要退出系统吗？", "提示操作", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        /// <summary>
        /// 注销登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            pal_initialize();
            DialogResult result = MessageBox.Show("确定要注销登录？", "提示操作", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                FrmLogin frm = new FrmLogin();
                frm.Show();
                this.Hide();
            }
        }


        /// <summary>
        /// 窗体最大事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Max__Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                //WindowState = FormWindowState.Maximized;
            }
            else
            {
                //WindowState = FormWindowState.Normal;
            }
        }


        /// <summary>
        /// 窗体最小事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Min__Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        /// <summary>
        /// 登录问候事件
        /// </summary>
        public void greeting()
        {
            // 系统当前时间
            int time = DateTime.Now.Hour;

            if (time >= 6 && time <= 12)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"..\..\..\Resources\Music\Music_01.wav");
                player.Play();
            }
            else if (time >= 13 && time <= 19)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"..\..\..\Resources\Music\Music_02.wav");
                player.Play();
            }
            else if (time >= 20 || time < 6)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"..\..\..\Resources\Music\Music_03.wav");
                player.Play();
            }

        }


        /// <summary>
        /// 仪表盘
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pal_initialize();
            childForm_dashboard frm = new childForm_dashboard();
            openChildForm(frm);
        }


        /// <summary>
        /// 客户入住
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CheckIn_Click(object sender, EventArgs e)
        {
            childForm_checkIn frm = new childForm_checkIn();
            openChildForm(frm);
        }


        /// <summary>
        /// 退房操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CheckOout_Click(object sender, EventArgs e)
        {
            childForm_checkOut frm = new childForm_checkOut();
            openChildForm(frm);
        }


        /// <summary>
        /// 客房预定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Reservation_Click(object sender, EventArgs e)
        {
            childForm_reservation frm = new childForm_reservation();
            openChildForm(frm);
        }


        /// <summary>
        /// 入住记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CustomerData_Click(object sender, EventArgs e)
        {
            childForm_customerData frm = new childForm_customerData();
            openChildForm(frm);
        }


        /// <summary>
        /// 发布房间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_NewAddRoom_Click(object sender, EventArgs e)
        {
            childForm_newAddRoom frm = new childForm_newAddRoom();
            openChildForm(frm);
        }


        /// <summary>
        /// 客房类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_RoomType_Click(object sender, EventArgs e)
        {
            childForm_roomType frm = new childForm_roomType();
            openChildForm(frm);
        }


        /// <summary>
        /// 客房列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_RoomData_Click(object sender, EventArgs e)
        {
            childForm_roomData frm = new childForm_roomData();
            openChildForm(frm);
        }


        /// <summary>
        /// 送餐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Meals_Click(object sender, EventArgs e)
        {
            childForm_nweGoodsOrder frm = new childForm_nweGoodsOrder();
            openChildForm(frm);
        }


        /// <summary>
        /// 订单记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OrderRecord_Click(object sender, EventArgs e)
        {
            childForm_ordersRecord frm = new childForm_ordersRecord();
            openChildForm(frm);
        }


        /// <summary>
        /// 商品发布
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_NewAddDGoods_Click(object sender, EventArgs e)
        {
            childForm_newAddGoods frm = new childForm_newAddGoods();
            openChildForm(frm);
        }


        /// <summary>
        /// 商品类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_GoodsType_Click(object sender, EventArgs e)
        {
            childForm_merchandiseType frm = new childForm_merchandiseType();
            openChildForm(frm);
        }


        /// <summary>
        /// 商品列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_GoodsData_Click(object sender, EventArgs e)
        {
            childForm_goodsData frm = new childForm_goodsData();
            openChildForm(frm);
        }


        /// <summary>
        /// 关于
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_About_Click(object sender, EventArgs e)
        {
            pal_initialize();
            childForm_about frm = new childForm_about();
            openChildForm(frm);
        }


        /// <summary>
        /// 新建用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_NewAddAdmin_Click(object sender, EventArgs e)
        {
            childForm_newAddAdmin frm = new childForm_newAddAdmin();
            openChildForm(frm);
        }


        /// <summary>
        /// 用户列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AdminData_Click(object sender, EventArgs e)
        {
            childForm_adminData frm = new childForm_adminData();
            openChildForm(frm);
        }

    }
}
