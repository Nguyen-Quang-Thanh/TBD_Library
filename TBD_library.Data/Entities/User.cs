using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBD_library.Data.Enums;

namespace TBD_library.Data.Entities
{
    public class User : IdentityUser<Guid>
    {
        public string Majors { get; set; } // ngành học
        public string ShouldLock { get; set; } // nên khóa
        public int StudentCode { get; set; }
        public eUserStatus status { get; set; } // trạng thái được phép hay bị cấm sử dụng dịch vụ
        public List<Post> Posts { get; set; }
        public List<Cinema> Cinemas { get; set; }
        public List<Registration> Registrations { get; set; }
        public List<BorrowRoom> BorrowRooms { get; set; }
        public List<BorrowBook> BorrowBooks { get; set; }
        public List<Book> Books { get; set; }
    }
}
