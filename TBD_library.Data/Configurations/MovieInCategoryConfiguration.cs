using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBD_library.Data.Entities;
using TBD_library.Data.Enums;

namespace TBD_library.Data.Configurations
{
    public class MovieInCategoryConfiguration : IEntityTypeConfiguration<MovieInCategory>
    {
        public void Configure(EntityTypeBuilder<MovieInCategory> builder)
        {
            builder.ToTable("MovieInCategories");
            builder.HasKey(x => new {x.Movie_id , x.MCategory_id});
        }
    }
}
