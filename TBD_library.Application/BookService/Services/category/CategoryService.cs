using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBD_library.Application.BookService.Dtos;
using TBD_library.Data.EF;

namespace TBD_library.Application.BookService.Services.category
{
    public class CategoryService
    {
        public readonly TBD_libraryDBContext dbContext;
        public List<BookCategoryDto> getAll()
        {
            List<BookCategoryDto> categoryList = new List<BookCategoryDto>();
            var categorys = dbContext.BCategories.Select(x => x);
            if(categorys != null)
            {
                foreach(var item in categorys)
                {
                    categoryList.Add(new BookCategoryDto(item.Id,item.Title,item.Description));
                }
            }
            return categoryList;
        }
        public List<string> getAllTitle()
        {
            List<string> titleList = new List<string>();
            var titles = dbContext.BCategories.Select(x => x.Title);
            if(titles != null)
            {
                foreach(var item in titleList)
                {
                    titleList.Add(item);
                }
            }
            return titleList;
        }
        public List<BookCategoryDto> getById(int id)
        {
            List<BookCategoryDto> categoryList = new List<BookCategoryDto>();
            var categorys = dbContext.BCategories.Select(x => x).Where(x => x.Id.Equals(id)).FirstOrDefault();
            if (categorys == null)
            {
                return categoryList;
            }
            return categoryList;
        }
        public int getIdByTitle(string title)
        {
            int id = 0;
            var idSelect =  dbContext.BCategories.Select(x => x).Where(x => x.Title.Equals(title)).Select(x => x.Id).FirstOrDefault();
            if(!idSelect.Equals(null))
            {
                id = idSelect;
            }
            return id;
        }
    }
}
