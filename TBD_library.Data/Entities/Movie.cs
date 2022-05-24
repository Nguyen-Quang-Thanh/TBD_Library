using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBD_library.Data.Entities
{
    public class Movie
    {
        int Id           { get; set; }
        string Name      { get; set; }
        string Summary   { get; set; }
        string Img       { get; set; }
        string Trailer    { get; set; }
        DateTime Time    { get; set; }
    }
}
