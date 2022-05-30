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
         public int Id                     { get; set; }
         public DateTime Registration_date { get; set; }
         public eRegistrationStatus Status { get; set; }
         public int Cinema_id              { get; set; }
         public Guid User_id               { get; set; }

        public User User { get; set; }
        public Cinema Cinema { get; set; }
     }
}
