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
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable("Posts");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).IsRequired().IsUnicode().HasMaxLength(250);
            builder.Property(x => x.Summary).IsRequired();
            builder.Property(x => x.Conten).IsRequired().IsUnicode();
            builder.Property(x => x.Img).IsRequired(false);
            builder.Property(x => x.Created_at).IsRequired().HasDefaultValue(DateTime.Now);
            builder.Property(x => x.Updated_at).IsRequired(false);
            builder.Property(x => x.Slug).IsRequired(false);
            builder.Property(x => x.ViewCount).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.Status).IsRequired(false);

            builder.HasOne(x => x.User).WithMany(x => x.Posts).HasForeignKey(x => x.User_id);

        }
    }
}
