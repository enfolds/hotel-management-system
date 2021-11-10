using System.ComponentModel;
using System.Windows.Forms;

namespace HMS
{
    public partial class UCRoomInfo : UserControl
    {
        public UCRoomInfo()
        {
            InitializeComponent();
        }


        #region 属性
        [Category("数据"), Description("房间编号"), Browsable(true)]
        public string RoomId
        {
            get { return lab_RoomId.Text; }
            set { lab_RoomId.Text = value; }
        }

        [Category("数据"), Description("房间类型"), Browsable(true)]
        public string RoomTypeName
        {
            get { return lab_RoomTypeName.Text; }
            set { lab_RoomTypeName.Text = value; }
        }

        [Category("数据"), Description("价格"), Browsable(true)]
        public string RoomPrice
        {
            get { return lab_RoomPrice.Text; }
            set { lab_RoomPrice.Text = value; }
        }

        [Category("数据"), Description("房间状态"), Browsable(true)]
        public string RoomStateName
        {
            get { return lab_RoomStateName.Text; }
            set { lab_RoomStateName.Text = value; }
        }

        #endregion

    }
}
