using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBD_library.Data.Enums;

namespace TBD_library.Data.Entities
{
    public class Room
    {
        public int Id              { get; set; }
        public string RoomName     { get; set; }
        public DateTime Room_date  { get; set; }

        // SessionTime phân đoạn thời gian ra 5 khoản ( 1,2 sáng 3,4 chiều 5 là tối)
        public int SessionTime     { get; set; }
        public eRoomStatus Status  { get; set; }
        public List<BorrowInRoom> BorrowInRooms { get;set }
    }
}
