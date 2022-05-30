﻿using Microsoft.EntityFrameworkCore;
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
    public class CinemaConfiguration : IEntityTypeConfiguration<Cinema>
    {
        public void Configure(EntityTypeBuilder<Cinema> builder)
        {
            builder.ToTable("Cinemas");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Create_at).IsRequired().HasDefaultValue(DateTime.Now);
            builder.Property(x => x.watching_date).IsRequired();
            builder.Property(x => x.RegistrationNumber).IsRequired(false);
            builder.Property(x => x.RegistrationLimit).IsRequired(false);
            builder.Property(x => x.Slug).IsRequired(false);
            builder.Property(x => x.Status).IsRequired().HasDefaultValue(eCinemaStatus.allowed);

            builder.HasOne(x => x.User).WithMany(x => x.Cinemas).HasForeignKey(x => x.User_id);
            builder.HasOne(x => x.Movie).WithMany(x => x.Cinemas).HasForeignKey(x => x.Movie_id);
        }
    }
}
