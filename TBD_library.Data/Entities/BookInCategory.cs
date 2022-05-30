using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBD_library.Data.Entities
{
    public class BookInCategory
    {
        public int Book_id        { get; set;}
        public int BCategory_id   { get; set;}

        public Book Book { get; set;}
        public BCategory BCategory { get; set;}
    }
}
