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
    public class BorrowRoomConfiguration : IEntityTypeConfiguration<BorrowRoom>
    {
        public void Configure(EntityTypeBuilder<BorrowRoom> builder)
        {
            builder.ToTable("BorrowRooms");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Borrow_date).IsRequired().HasDefaultValue(DateTime.Now);
            builder.Property(x => x.Time).IsRequired(false);
            builder.Property(x => x.ParticipantNumber).IsRequired(false);

            builder.HasOne(x => x.User).WithMany(x => x.BorrowRooms).HasForeignKey(x => x.User_id);


        }
    }
}
