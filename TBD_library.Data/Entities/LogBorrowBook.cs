using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBD_library.Data.Entities
{
    public class LogBorrowBook
    {
        public int Id                  { get; set; }
        public string FullName         { get; set; }
        public string Email            { get; set; }
        public int Sdt                 { get; set; }
        public string NameBook         { get; set; }
        public DateTime Borrowed_date  { get; set; }
        public string Status           { get; set; }
    }
}
