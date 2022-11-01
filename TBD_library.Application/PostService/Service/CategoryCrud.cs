using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBD_library.Application.PostService.Dtos;
using TBD_library.Data.EF;

namespace TBD_library.Application.PostService.Service
{
    public class CategoryCrud
    {
        private readonly TBD_libraryDBContext dbContext;
        public async Task<int> create(CategoryDto caregory)
        {
            var caregoryNew = new CategoryDto()
            {
                Title = caregory.Title,
                Description = caregory.Description
            };
            dbContext.Add(caregory);
            return await dbContext.SaveChangesAsync();
        }
    }
}
