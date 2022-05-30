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
    public class BorrowBookConfiguration : IEntityTypeConfiguration<BorrowBook>
    {
        public void Configure(EntityTypeBuilder<BorrowBook> builder)
        {
            builder.ToTable("BorrowBooks");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Borrowed_date).IsRequired().HasDefaultValue(DateTime.Now);
            builder.Property(x => x.Borrowed_time).IsRequired(false);
            builder.Property(x => x.GiveBack_date).IsRequired(false);
            builder.Property(x => x.Status).IsRequired().HasDefaultValue(eBorrowBookStatus.borrowing);
        }
    }
}
