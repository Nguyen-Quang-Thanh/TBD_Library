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
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categoties");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).IsRequired().IsUnicode().HasMaxLength(250);
            builder.Property(x => x.Description).IsRequired().IsUnicode();
        }
    }
}
