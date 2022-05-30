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
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Books");
            builder.HasKey(x => x.Id);
            builder.Property( x => x.Name ).IsRequired().IsUnicode();
            builder.Property( x => x.Description).IsRequired().IsUnicode();
            builder.Property( x => x.Summary).IsRequired().IsUnicode();
            builder.Property( x => x.Author).IsRequired(false).IsUnicode();
            builder.Property( x => x.Publisher).IsRequired(false).IsUnicode();
            builder.Property( x => x.Img).IsRequired(false);
            builder.Property( x => x.Created_at).IsRequired(false).HasDefaultValue(DateTime.Now);
            builder.Property( x => x.Status).IsRequired(false).HasDefaultValue(eBookStatus.NotBorrwed);
            builder.Property(x => x.BorrowCount).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.Slug).IsRequired(false);
        }
    }
}
