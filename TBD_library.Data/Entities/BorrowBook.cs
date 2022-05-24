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
        int Id                  { get; set; }
        DateTime Borrowed_date  { get; set; }
        DateTime Borrowed_time  { get; set; }
        DateTime GiveBack_date  { get; set; }
        eBorrowBookStatus Status{ get; set; }
        int User_id             { get; set; }

    }
}
