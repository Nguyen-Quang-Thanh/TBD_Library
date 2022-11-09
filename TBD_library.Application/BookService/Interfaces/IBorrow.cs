using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBD_library.Application.BookService.Interfaces
{
    public interface IBorrow
    {
        string getStudentById(int id);
        List<string> getNotBorrowNameBooks();
        List<string> getBorrowNameBooks();
        List<string> getAllStudentName();
    }
}
