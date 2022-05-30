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
    public class LogRegistrationConfiguration : IEntityTypeConfiguration<LogRegistration>
    {
        public void Configure(EntityTypeBuilder<LogRegistration> builder)
        {
            builder.ToTable("LogRegistrations");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FullName).IsRequired().IsUnicode();
            builder.Property(x => x.Email).IsRequired(false);
            builder.Property(x => x.Sdt).IsRequired(false);
            builder.Property(x => x.Registration_date).IsRequired(false);
        }
    }
}
