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
        public DateTime Room_date { get; set; }

        //sessionTime thời gian có thể thuê phòng trong ngày chia thành 5 phân đoạn
        //1 ,2 buổi sáng 3 ,4 buổi chiều và 5 là buổi tối
        public int SessionTime { get; set; }
        public eRoomStatus Status  { get; set; }

        public List<BorrowInRoom> BorrowInRooms { get; set; }
    }
}
