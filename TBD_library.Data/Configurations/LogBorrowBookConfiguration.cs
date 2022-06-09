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
    public class LogBorrowBookConfiguration : IEntityTypeConfiguration<LogBorrowBook>
    {
        public void Configure(EntityTypeBuilder<LogBorrowBook> builder)
        {
            builder.ToTable("LogBorrowBooks");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Borrowed_date).IsRequired();
            builder.Property( x=> x.Email).IsRequired(false);
            builder.Property( x=> x.Sdt).IsRequired();
            builder.Property( x=> x.NameBook).IsRequired(false).IsUnicode();
            builder.Property(x => x.Status).IsRequired(false);
        }
    }
}
