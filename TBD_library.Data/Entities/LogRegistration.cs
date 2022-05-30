using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBD_library.Data.Entities
{
    public class LogRegistration
    {
        public int Id                      { get; set; }
        public string FullName             { get; set; }
        public string Email                { get; set; }
        public int Sdt                     { get; set; }
        public DateTime Registration_date  { get; set; }
        public int LogCinema_id            { get; set; }

        public LogCinema LogCinema { get; set; }
    }
}
