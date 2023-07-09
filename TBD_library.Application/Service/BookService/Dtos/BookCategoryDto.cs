using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBD_library.Data.Enums;

namespace TBD_library.Application.BookService.Dtos
{
    public class BookCategoryDto
    {
        private int id;
        private string title;
        private string description;

        public BookCategoryDto(int id, string title, string description)
        {
            this.id = id;
            this.title = title;
            this.description = description;
        }

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
    }
}
