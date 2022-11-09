using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBD_library.Application.BookService.Dtos;
using TBD_library.Application.BookService.Interfaces;
using TBD_library.Application.BookService.Services.borrow;
using TBD_library.Application.UserService.Services;
using TBD_library.Data.EF;
using TBD_library.Data.Enums;

namespace TBD_library.Application.BookService.Services.book
{
    public class BookSevice : BookCurd, IBook
    {
        private GetUser getUser = new GetUser();
        private readonly TBD_libraryDBContext dbContext;
        private BorrowService borrowService = new BorrowService();
        public List<BookDto> getAll()
        {
            List<BookDto> bookList = new List<BookDto>();
            var books = dbContext.Books.Select(x => x);
            if (books != null)
            {
                foreach (var item in books)
                {
                    bookList.Add(new BookDto(item.Id, item.Name, item.Description, item.Author, item.Publisher,
                                    item.Img, item.Created_at, item.Status, item.BorrowCount, getUser.getUserNameById(item.User_id),
                                    borrowService.getStudentById(item.BorrowBook_id)));
                }
            }
            else
            {
                throw new Exception("get table book fail");
            }
            return bookList;
        }
        public string getNameById(int id)
        {
            string name = "";
            var nameBook = dbContext.Books.Where(x => x.Id == id).Select(x => x.Name);
            if (nameBook != null)
            {
                foreach (var item in nameBook)
                {
                    name = item;
                }
            }
            else
            {
                throw new Exception("id don't valid");
            }
            return name;
        }
        public List<string> getAllName()
        {
            List<string> nameList = new List<string>();
            var names = dbContext.Books.Select(x => x.Name);
            if (names != null)
            {
                foreach (var item in names)
                {
                    nameList.Add(item);
                }
            }
            else
            {
                throw new Exception("list name book is Empty");
            }
            return nameList;
        }
        public List<BookDto> getAllByName(string name)
        {
            List<BookDto> books = new List<BookDto>();
            var names = dbContext.Books.Select(x => x).Where(x => x.Name.Equals(name));
            if (names != null)
            {
                foreach (var item in names)
                {
                    books.Add(new BookDto(item.Id, item.Name, item.Description, item.Author, item.Publisher, item.Img, item.Created_at, item.Status, item.BorrowCount, getUser.getUserNameById(item.User_id), borrowService.getStudentById(item.BorrowBook_id)));
                }
            }
            return books;
        }
    }
}
