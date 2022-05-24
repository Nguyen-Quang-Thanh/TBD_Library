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
        int BorrowRoom_id   { get; set; }
        string RoomName     { get; set; }
        eRoomStatus Status  { get; set; }
    }
}
