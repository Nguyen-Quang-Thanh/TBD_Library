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
        public int Id              { get; set; }
        public string Title        { get; set; }
        public string Summary      { get; set; }
        public string Conten       { get; set; }
        public string Img          { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
        public string Slug         { get; set; }
        public int ViewCount       { get; set; }
        public ePostStatus Status  { get; set; }
        public Guid User_id        { get; set; }

        public User User { get; set; }
        public List<PostInCategory> PostInCategories { set; get; }

    }
}
