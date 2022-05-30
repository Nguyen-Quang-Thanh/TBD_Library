using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBD_library.Data.Entities
{
    public class MovieInCategory
    {
        public int Movie_id        { get; set; }
        public int MCategory_id    { get; set; }

        public Movie Movie { get; set; }
        public MCategory MCategory { get; set; }
    }
}
