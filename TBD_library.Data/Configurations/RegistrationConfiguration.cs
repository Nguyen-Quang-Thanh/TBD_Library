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
    public class RegistrationConfiguration : IEntityTypeConfiguration<Registration>
    {
        public void Configure(EntityTypeBuilder<Registration> builder)
        {
            builder.ToTable("Registrations");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Registration_date).IsRequired().HasDefaultValue(DateTime.Now);
            builder.Property(x => x.Status).IsRequired().HasDefaultValue(eRegistrationStatus.partake);

            builder.HasOne(x => x.User).WithMany(x => x.Registrations).HasForeignKey(x => x.User_id);
            builder.HasOne(x => x.Cinema).WithMany(x => x.Registrations).HasForeignKey(x => x.Cinema_id);
        }
    }
}
