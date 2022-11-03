using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBD_library.Application.UserService.Dtos
{
    public class UserDto
    {
        private Guid id;
        private string userName;
        private string email;
        private string phoneNumber;
        private int studentCode;

        public UserDto(Guid id, string userName, string email, string phoneNumber, int studentCode)
        {
            this.id = id;
            this.userName = userName;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.studentCode = studentCode;
        }

        public Guid Id { get => id; set => id = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public int StudentCode { get => studentCode; set => studentCode = value; }
    }
}
