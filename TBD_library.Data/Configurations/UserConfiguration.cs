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
    public  class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.StudentCode).IsRequired();
            builder.Property(x => x.status).IsRequired().HasDefaultValue(eUserStatus.allowed);
            builder.Property(x => x.Majors).IsRequired(false);
            builder.Property(x => x.ShouldLock).IsRequired(false);
        }
    }
}
