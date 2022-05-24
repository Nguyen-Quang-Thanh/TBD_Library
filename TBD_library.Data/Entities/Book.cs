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
        int Id               { get; set; }
        string Name          { get; set; }
        string Description   { get; set; }
        string Summary       { get; set; }
        string Author        { get; set; }
        string Publisher     { get; set; }
        string Img           { get; set; }
        DateTime Created_at  { get; set; }
        eBookStatus Status   { get; set; }
        string Slug          { get; set; }
        int User_id          { get; set; }
        int BorrowBook_id    { get; set; }
    }                                   
}
