using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBD_library.Data.Entities
{
    public class Role : IdentityRole<Guid>
    {
        public string Discription { get; set; }
    }
}
