using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBD_library.Data.Entities
{
    public class BorrowRoom
    {
         int Id                     { get; set; }
         DateTime Borrow_date       { get; set; }
         DateTime Time              { get; set; }
         int ParticipantNumber      { get; set; } // số người tham gia
         int User_id                { get; set; }
    }
}
