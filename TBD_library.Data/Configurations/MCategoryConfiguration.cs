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
    public class MCategoryConfiguration : IEntityTypeConfiguration<MCategory>
    {
        public void Configure(EntityTypeBuilder<MCategory> builder)
        {
            builder.ToTable("MCategories");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).IsRequired().IsUnicode();
            builder.Property(x => x.Description).IsRequired().IsUnicode();
        }
    }
}
