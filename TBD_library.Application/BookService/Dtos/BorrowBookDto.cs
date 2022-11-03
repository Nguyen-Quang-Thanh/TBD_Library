using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBD_library.Data.Enums;

namespace TBD_library.Application.BookService.Dtos
{
    internal class BorrowBookDto
    {
        private int id;
        private DateTime borrowed_date;
        private DateTime borrowed_time;
        private DateTime giveBack_date;
        private eBorrowBookStatus status;
        private string userName;

        public BorrowBookDto(int id, DateTime borrowed_date, DateTime borrowed_time, DateTime giveBack_date, eBorrowBookStatus status, string userName)
        {
            this.id = id;
            this.borrowed_date = borrowed_date;
            this.borrowed_time = borrowed_time;
            this.giveBack_date = giveBack_date;
            this.status = status;
            this.userName = userName;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Borrowed_date { get => borrowed_date; set => borrowed_date = value; }
        public DateTime Borrowed_time { get => borrowed_time; set => borrowed_time = value; }
        public DateTime GiveBack_date { get => giveBack_date; set => giveBack_date = value; }
        public eBorrowBookStatus Status { get => status; set => status = value; }
        public string UserName { get => userName; set => userName = value; }
    }
}
