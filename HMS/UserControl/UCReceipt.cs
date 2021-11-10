using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class UCReceipt : UserControl
    {
        public UCReceipt()
        {
            InitializeComponent();
        }


        #region 属性

        [Category("数据"), Description("订单号"), Browsable(true)]
        public string RecordId
        {
            get { return lab_RecordId.Text; }
            set { lab_RecordId.Text = value; }
        }

        [Category("数据"), Description("打印时间"), Browsable(true)]
        public string PrintTime
        {
            get { return lab_PrintTime.Text; }
            set { lab_PrintTime.Text = value; }
        }

        [Category("数据"), Description("收银"), Browsable(true)]
        public string Cashier
        {
            get { return lab_Cashier.Text; }
            set { lab_Cashier.Text = value; }
        }

        [Category("数据"), Description("房间类型"), Browsable(true)]
        public string RoomType
        {
            get { return lab_RoomType.Text; }
            set { lab_RoomType.Text = value; }
        }

        [Category("数据"), Description("房价"), Browsable(true)]
        public string RoomPrice
        {
            get { return lab_RoomPrice.Text; }
            set { lab_RoomPrice.Text = value; }
        }

        [Category("数据"), Description("居住天数"), Browsable(true)]
        public string LivingDays
        {
            get { return lab_LivingDays.Text; }
            set { lab_LivingDays.Text = value; }
        }

        [Category("数据"), Description("金额"), Browsable(true)]
        public string PaymentAmount
        {
            get { return lab_PaymentAmount.Text; }
            set { lab_PaymentAmount.Text = value; }
        }

        [Category("数据"), Description("总额"), Browsable(true)]
        public string TotalAmount
        {
            get { return lab_TotalAmount.Text; }
            set { lab_TotalAmount.Text = value; }
        }

        [Category("数据"), Description("折后总额"), Browsable(true)]
        public string DiscountTotalAmount
        {
            get { return lab_DiscountTotalAmount.Text; }
            set { lab_DiscountTotalAmount.Text = value; }
        }

        #endregion

    }
}
