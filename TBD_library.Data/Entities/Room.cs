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
        public eRoomStatus Status  { get; set; }
        public int BorrowRoom_id { get; set; }
    }
}
