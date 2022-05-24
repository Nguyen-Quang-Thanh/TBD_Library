using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBD_library.Data.Enums;

namespace TBD_library.Data.Entities
{
    public class Post
    {
        int Id              { get; set; }
        string Title        { get; set; }
        string Summary      { get; set; }
        string Conten       { get; set; }
        string Img          { get; set; }
        DateTime Created_at { get; set; }
        DateTime Updated_at { get; set; }
        string Slug         { get; set; }
        ePostStatus Status  { get; set; }
        Guid User_id        { get; set; }
    }
}
