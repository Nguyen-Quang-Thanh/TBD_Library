using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBD_library.Application.BookService.Dtos;

namespace TBD_library.Application.BookService.Interfaces
{
    public interface IBook
    {
        List<BookDto> getAll();
        string getNameById(int id);
        List<string> getAllName();
        List<BookDto> getAllByName(string name);
    }
}
