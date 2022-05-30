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
    public class PostInCategoryConfiguration : IEntityTypeConfiguration<PostInCategory>
    {
        public void Configure(EntityTypeBuilder<PostInCategory> builder)
        {
            builder.ToTable("PostInCategries");
            builder.HasKey(x => new {x.Post_id , x.Category_id});

            builder.HasOne(x => x.Post).WithMany(x => x.PostInCategories).HasForeignKey(x => x.Post_id);
            builder.HasOne(x => x.Category).WithMany(x => x.PostInCategories).HasForeignKey(x => x.Post_id);
        }
    }
}
