using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBD_library.Data.Enums
{
    public enum eCinemaStatus
    {
        allowed, // cho phép đăng ký --  allow registration watching movie
        NoAllowed, // không cho phép -- don't allow registration
        full, // now this room are full
    }
}
