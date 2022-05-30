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
    public class BorrowInRoomConfiguration : IEntityTypeConfiguration<BorrowInRoom>
    {
        public void Configure(EntityTypeBuilder<BorrowInRoom> builder)
        {
            builder.ToTable("BorrowInRoom");
            builder.HasKey(x => new { x.Borrow_id, x.Room_id });

            builder.HasOne(x => x.BorrowRoom).WithMany(x => x.BorrowInRooms).HasForeignKey(x => x.Borrow_id);
            builder.HasOne(x => x.Room).WithMany(x => x.BorrowInRooms).HasForeignKey(x => x.Room_id);
        }
    }
}
