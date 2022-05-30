using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBD_library.Data.Entities
{
    public class BorrowInRoom
    {
        public int Borrow_id {get;set;}
        public int Room_id { get; set; }

        public Room Room { get; set; }
        public BorrowRoom BorrowRoom { get; set; }
    }
}
