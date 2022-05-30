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
        public int Id                  { get; set; }
        public DateTime Create_at      { get; set; }
        public DateTime watching_date  { get; set; }
        public int RegistrationNumber  { get; set; } //lượng người tham dự
        public int RegistrationLimit   { get; set; } //giới hạn người tham dự
        public string Slug             { get; set; }
        public eCinemaStatus Status    { get; set; }
        public Guid User_id            { get; set; }
        public int Movie_id            { get; set; }


        public List<Registration> Registrations { get; set; }
        public User User { get; set; }
        public Movie Movie { get; set; }
    }
}
