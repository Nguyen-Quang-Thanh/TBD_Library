using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBD_library.Data.Enums;

namespace TBD_library.Data.Entities
{
    public class Book
    {
        public int Id               { get; set; }
        public string Name          { get; set; }
        public string Description   { get; set; }
        public string Summary       { get; set; }
        public string Author        { get; set; }
        public string Publisher     { get; set; }
        public string Img           { get; set; }
        public DateTime Created_at  { get; set; }
        public eBookStatus Status   { get; set; }
        public int BorrowCount      { get; set; }
        public string Slug          { get; set; }
        public Guid User_id         { get; set; }
        public int? BorrowBook_id   { get; set; }
    }                                   
}
