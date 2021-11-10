using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Models
{
    class RoomData
    {
        // 房间号
        private int roomId;

        // 房间类型
        private int roomTypeId;

        // 房间价格
        private double roomPrice;

        // 房间状态
        private int roomStatusId;

        //房间类型名
        private string roomTypeName;

        // 房间状态名
        private string roomStatusName;

        public int RoomId { get => roomId; set => roomId = value; }

        public int RoomTypeId { get => roomTypeId; set => roomTypeId = value; }

        public double RoomPrice { get => roomPrice; set => roomPrice = value; }

        public int RoomStatusId { get => roomStatusId; set => roomStatusId = value; }

        public string RoomTypeName { get => roomTypeName; set => roomTypeName = value; }

        public string RoomStatusName { get => roomStatusName; set => roomStatusName = value; }
    }
}
