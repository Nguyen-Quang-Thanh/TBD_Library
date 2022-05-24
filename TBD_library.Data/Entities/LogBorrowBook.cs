using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBD_library.Data.Entities
{
    public class LogBorrowBook
    {
        string FullName         { get; set; }
        string Email            { get; set; }
        int Sdt                 { get; set; }
        string NameBook         { get; set; }
        DateTime Borrowed_date  { get; set; }
        string Status           { get; set; }
    }
}
