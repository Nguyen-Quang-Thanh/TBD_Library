using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBD_library.Data.Entities
{
    public class BorrowRoom
    {
         public int Id                     { get; set; }
         public DateTime Borrow_date       { get; set; }
         public TimeSpan Time              { get; set; }
         public int ParticipantNumber      { get; set; } // số người tham gia
         public Guid User_id               { get; set; }

        public List<BorrowInRoom> BorrowInRooms { get;set; }
        public User Users { get; set; }
    }
}
