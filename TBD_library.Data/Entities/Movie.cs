using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBD_library.Data.Entities
{
    public class Movie
    {
        public int Id           { get; set; }
        public string Name      { get; set; }
        public string Summary   { get; set; }
        public string Img       { get; set; }
        public string Trailer   { get; set; }
        public TimeSpan Time    { get; set; }
    }
}
