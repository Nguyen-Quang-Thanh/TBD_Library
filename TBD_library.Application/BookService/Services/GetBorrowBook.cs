using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBD_library.Application.UserService.Services;
using TBD_library.Data.EF;

namespace TBD_library.Application.BookService.Services
{
    public class GetBorrowBook
    {
        private readonly TBD_libraryDBContext dBContext;
        GetUser getUser = new GetUser();
        public string getBorrowStudentById(int id)
        {
            string userName = "";
            var name = dBContext.BorrowBooks.Where(x => x.Id == id).Select(x => x.User_id);
            if (name != null)
            {
                foreach(var item in name)
                {
                    userName = getUser.getUserNameById(item);
                }
            }
            return userName;
        }
    }
}
