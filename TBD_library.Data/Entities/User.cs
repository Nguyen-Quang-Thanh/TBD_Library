using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBD_library.Data.Entities
{
    public class User
    {
        public List<Post> Posts { get; set; }
        public List<Book> Books { get; set; }
        public List<BorrowBook> BorrowBooks { get; set; }
        public List<BorrowRoom> BorrowRooms { set; get; }
        public List<Registration> Registrations { set; get; }
        public List<Cinema> Cinemas { set; get; }   
    }
}
