using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBD_library.Data.Enums;

namespace TBD_library.Data.Entities
{
    public class Cinema
    {
        int Id                  { get; set; }
        DateTime Create_at      { get; set; }
        DateTime watching_date  { get; set; }
        int RegistrationNumber  { get; set; } //lượng người tham dự
        int RegistrationLimit   { get; set; } //giới hạn người tham dự
        string Slug             { get; set; }
        eCinemaStatus Status    { get; set; }
        Guid User_id            { get; set; }
        int Movie_id            { get; set; }

    }
}
