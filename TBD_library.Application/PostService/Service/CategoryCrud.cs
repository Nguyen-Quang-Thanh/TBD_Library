using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TBD_library.Application.PostService.Dtos;
using TBD_library.Data.EF;
using TBD_library.Data.Entities;

namespace TBD_library.Application.PostService.Service
{
    public class CategoryCrud
    {
        private readonly TBD_libraryDBContext dbContext;
        public async Task<int> create(CategoryDto caregoryDto)
        {
            var caregoryNew = new Category()
            {
                Title = caregoryDto.Title,
                Description = caregoryDto.Description
            };
            dbContext.Categories.Add(caregoryNew);
            return await dbContext.SaveChangesAsync();
        }

        public async Task<int> update(CategoryDto categoryDto)
        {
            var category = await dbContext.Categories.FirstOrDefaultAsync(x => x.Id == categoryDto.Id);
            if (category == null)
            {
               throw new Exception($"can't find a category with id : {categoryDto.Id}");
            }
            else
            {
                category.Title = categoryDto.Title;
                category.Description = categoryDto.Description;
            }
            return await dbContext.SaveChangesAsync();
        }

        public async Task<int> delete(int id)
        {
            var category = await dbContext.Categories.FirstOrDefaultAsync(x => x.Id == id);
            var postInCategory = await dbContext.PostInCategories.FirstOrDefaultAsync(x => x.Category_id == id);
            if (category == null)
            {
                new Exception($"can't find a category with id : {id}");
            }
            else
            {
                if (postInCategory != null)
                {
                    dbContext.PostInCategories.RemoveRange(postInCategory);
                }
                dbContext.Categories.RemoveRange(category);
            }
            return await dbContext.SaveChangesAsync();
        }
    }
}
