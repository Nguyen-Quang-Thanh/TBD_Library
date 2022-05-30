using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBD_library.Data.Entities
{
    public class PostInCategory
    {
       public int Post_id      { get; set; }
       public int Category_id  { get; set; }
       public Post Post        { get; set; }
       public Category Category { get; set; }

    }
}
