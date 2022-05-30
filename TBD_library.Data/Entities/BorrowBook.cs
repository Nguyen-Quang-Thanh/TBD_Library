using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBD_library.Data.Enums;

namespace TBD_library.Data.Entities
{
    public class BorrowBook
    {
        public int Id                  { get; set; }
        public DateTime Borrowed_date  { get; set; }
        public DateTime Borrowed_time  { get; set; }
        public DateTime GiveBack_date  { get; set; }
        public eBorrowBookStatus Status{ get; set; }
        public Guid User_id            { get; set; }

    }
}
