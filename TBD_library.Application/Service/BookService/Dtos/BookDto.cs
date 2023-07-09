using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBD_library.Data.Enums;

namespace TBD_library.Application.BookService.Dtos
{
    public class BookDto
    {
        private int id;
        private string name;
        private string description;
        private string author;
        private string publisher;
        private string img;
        private DateTime create_at;
        private eBookStatus status;
        private int borrowCount;
        private string userNameCreate;
        private string? borrowStudent;

        public BookDto(int id, string name, string description, string author, string publisher, string img, DateTime create_at, eBookStatus status, int borrowCount, string userNameCreate, string? borrowStudent)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.author = author;
            this.publisher = publisher;
            this.img = img;
            this.create_at = create_at;
            this.status = status;
            this.borrowCount = borrowCount;
            this.userNameCreate = userNameCreate;
            this.borrowStudent = borrowStudent;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Author { get => author; set => author = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public string Img { get => img; set => img = value; }
        public DateTime Create_at { get => create_at; set => create_at = value; }
        public eBookStatus Status { get => status; set => status = value; }
        public int BorrowCount { get => borrowCount; set => borrowCount = value; }
        public string UserNameCreate { get => userNameCreate; set => userNameCreate = value; }
        public string? BorrowStudent { get => borrowStudent; set => borrowStudent = value; }

    }
}
