using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBD_library.Data.Entities
{
    public class LogCinema
    {
        int Id                     { get; set; }
        string NameLibarian        { get; set; }
        string MovieName           { get; set; }
        DateTime Watching_date     { get; set; }
        DateTime time              { get; set; }
        int RegistrationNumber     { get; set; }
    }
}