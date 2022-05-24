using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBD_library.Data.Enums;

namespace TBD_library.Data.Entities
{
     public class Registration
     {
         DateTime Registration_date { get; set; }
         eRegistrationStatus Status { get; set; }
         int Cinema_id              { get; set; }
         Guid User_id               { get; set; }
     }
}
