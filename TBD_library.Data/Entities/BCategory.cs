using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBD_library.Data.Entities
{
    public class BCategory
    {
        public int Id              { get; set; }
        public string Title        { get; set; }
        public string Description  { get; set; }

        public List<BookInCategory> BookInCategories { get; set; }
    }
}
