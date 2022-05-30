using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBD_library.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        public List<Post> Posts { get; set; }
        public List<Cinema> Cinemas { get; set; }
        public List<Registration> Registrations { get; set; }
        public List<BorrowRoom> BorrowRooms { get; set; }
        public List<BorrowBook> BorrowBooks { get; set; }
        public List<Book> Books { get; set; }
    }
}
