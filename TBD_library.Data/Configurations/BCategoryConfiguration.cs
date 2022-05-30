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
    public class BCategoryConfiguration : IEntityTypeConfiguration<BCategory>
    {
        public void Configure(EntityTypeBuilder<BCategory> builder)
        {
            builder.ToTable("BCategories");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).IsRequired().IsUnicode().HasMaxLength(100);
            builder.Property(x => x.Description).IsRequired().IsUnicode().HasMaxLength(250);
        }
    }
}
