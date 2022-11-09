using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBD_library.Data.EF;

namespace TBD_library.Application.UserService.Services
{
    public class GetUser
    {
        public readonly TBD_libraryDBContext dbContext;
        public string getUserNameById(Guid id)
        {
            string name ="";
            var userName = dbContext.Users.Where(x => x.Id == id).Select(x => x.UserName);
            if (userName != null)
            {
                foreach(var item in userName)
                {
                    name = item;
                }
                return name;
            }
            else
            {
                throw new Exception("don't find with this id");
            }
        }
    }
}
