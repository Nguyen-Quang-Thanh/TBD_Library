using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBD_library.Data.Entities
{
    public class LogRegistration
    {
        string FullName             { get; set; }
        string Email                { get; set; }
        int Sdt                     { get; set; }
        DateTime Registration_date  { get; set; }
        int LogCinema_id            { get; set; }
    }
}
