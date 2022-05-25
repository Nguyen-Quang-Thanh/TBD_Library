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
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.ToTable("Movies");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().IsUnicode();
            builder.Property(x=>x.Summary).IsRequired().IsUnicode();
            builder.Property(x=>x.Img).IsRequired(false);
            builder.Property(x=>x.Trailer).IsRequired(false);
            builder.Property(x => x.Time).IsRequired();
        }
    }
}
