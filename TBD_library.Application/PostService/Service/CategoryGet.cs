using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBD_library.Application.PostService.Dtos;
using TBD_library.Application.PostService.Interface;
using TBD_library.Data.EF;

namespace TBD_library.Application.PostService.Service
{
    public class CategoryGet : ICategoryGet
    {
        private readonly TBD_libraryDBContext dbContext;
        public List<CategoryDto> getAllList()
        {
            List<CategoryDto> caregoryList = new List<CategoryDto>();
            IQueryable<Data.Entities.Category> categorys = dbContext.Categories.Select(x => x);
            if(categorys.Any())
            {
                foreach(var item in categorys)
                {
                    caregoryList.Add(new CategoryDto(item.Id , item.Title, item.Description));
                }
            }
            return caregoryList;
        }

        public List<string> getAllTitleListById(int id) 
        {
            List<string> titleList = new List<string>();
            IQueryable<string> titles = dbContext.Categories.Where(x => x.Id.Equals(id)).Select(x => x.Title);
            if(titles.Any())
            {
                foreach(var item in titles)
                {
                    titleList.Add(item);
                }
            }    
            return titleList;
        }

        public List<CategoryDto> getCaregoryListById(int id)
        {
            List<CategoryDto> categoryList = new List<CategoryDto>();
            var categorys = dbContext.Categories.Where(x => x.Id.Equals(id)).Select(x => x);
            if(categorys.Any())
            {
                foreach(var item in categorys)
                {
                    categoryList.Add(new CategoryDto(item.Id, item.Title, item.Description));
                }
            }
            return categoryList;
        }

        public int getIdByTitle(string title)
        {
            int id = 0;
            var selectId = dbContext.Categories.Where(x => x.Title.Equals(title.Equals(title))).Select(x => x.Id);
            if(selectId.Any())
            {
                foreach(var item in selectId)
                {
                    id = item;
                }
            }
            return id;
        }
    }
}
