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
    public class LogCinemaConfiguration : IEntityTypeConfiguration<LogCinema>
    {
        public void Configure(EntityTypeBuilder<LogCinema> builder)
        {
            builder.ToTable("LogCinemas");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.MovieName).IsRequired().IsUnicode();
            builder.Property(x => x.Watching_date).IsRequired();
            builder.Property(x => x.Time).IsRequired();
            builder.Property(x => x.RegistrationNumber).IsRequired();
        }
    }
}
