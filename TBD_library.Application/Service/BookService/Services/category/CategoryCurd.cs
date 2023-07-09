using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBD_library.Application.BookService.Dtos;
using TBD_library.Data.EF;
using TBD_library.Data.Entities;

namespace TBD_library.Application.BookService.Services.category
{
    public class CategoryCurd
    {
        CategoryService categoryService = new CategoryService();
        public readonly TBD_libraryDBContext dbContext;
        public async Task<int> create(BookCategoryDto categoryDto)
        {
            var categoty = new BCategory
            {
                Title = categoryDto.Title,
                Description = categoryDto.Description
            };
            dbContext.BCategories.Add(categoty);
            return await dbContext.SaveChangesAsync();
        }
        public async Task<int> update(BookCategoryDto categoryDto)
        {
            var category = await dbContext.BCategories.FirstOrDefaultAsync(x => x.Id.Equals(categoryDto.Id));
            if(category != null)
            {
                category.Title = categoryDto.Title;
                category.Description = categoryDto.Description;
            }
            return await dbContext.SaveChangesAsync();
        }
        public int delete(int id)
        {
            return 0;
        }
    }
}
