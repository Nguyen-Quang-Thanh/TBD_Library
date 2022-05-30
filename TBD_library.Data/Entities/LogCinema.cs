using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBD_library.Data.Entities
{
    public class LogCinema
    {
        public int Id                     { get; set; }
        public string NameLibarian        { get; set; }
        public string MovieName           { get; set; }
        public DateTime Watching_date     { get; set; }
        public TimeSpan Time              { get; set; }
        public int RegistrationNumber     { get; set; }

        public  List<LogRegistration> LogRegistrations { get; set; }
    }
}