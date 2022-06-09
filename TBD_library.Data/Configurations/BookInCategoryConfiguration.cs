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
    public class BookInCategoryConfiguration : IEntityTypeConfiguration<BookInCategory>
    {
        public void Configure(EntityTypeBuilder<BookInCategory> builder)
        {
            builder.ToTable("BookInCategories");
            builder.HasKey(x => new { x.Book_id, x.BCategory_id });

            builder.HasOne(x => x.Book).WithMany(x => x.BookInCategories).HasForeignKey(x => x.Book_id).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.BCategory).WithMany(x => x.BookInCategories).HasForeignKey(x => x.BCategory_id).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
