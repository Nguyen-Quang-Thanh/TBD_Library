using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBD_library.Application.BookService.Interfaces;
using TBD_library.Application.UserService.Services;
using TBD_library.Data.EF;
using TBD_library.Data.Enums;

namespace TBD_library.Application.BookService.Services.borrow
{
    public class BorrowService : BorrowCurd, IBorrow
    {
        private readonly TBD_libraryDBContext dbContext;
        GetUser getUser = new GetUser();
        public string getStudentById(int id)
        {
            string userName = "";
            var name = dbContext.BorrowBooks.Where(x => x.Id == id).Select(x => x.User_id);
            if (name != null)
            {
                foreach (var item in name)
                {
                    userName = getUser.getUserNameById(item);
                }
            }
            return userName;
        }
        public List<string> getNotBorrowNameBooks()
        {
            List<string> nameList = new List<string>();
            var names = dbContext.Books.Where(x => x.Status.Equals(eBookStatus.NotBorrwed)).Select(x => x.Name);
            if (names != null)
            {
                foreach (var item in names)
                {
                    nameList.Add(item);
                }
            }
            else
            {
                throw new Exception("List name not borrow book is empty");
            }
            return nameList;
        }
        public List<string> getBorrowNameBooks()
        {
            List<string> nameList = new List<string>();
            var names = dbContext.Books.Where(x => x.Status.Equals(eBookStatus.Borrwed)).Select(x => x.Name);
            if (names != null)
            {
                foreach (var item in names)
                {
                    nameList.Add(item);
                }
            }
            else
            {
                throw new Exception("List name borrow book is empty");
            }
            return nameList;
        }
        public List<string> getAllStudentName()
        {
            List<string> nameList = new List<string>();
            var users_id = dbContext.BorrowBooks.Select(x => x.User_id);
            if (users_id != null)
            {
                foreach (var item in users_id)
                {
                    nameList.Add(getUser.getUserNameById(item));
                }
            }
            return nameList;
        }
    }
}
