using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TBD_library.Application.Catalog.Dtos;
using TBD_library.Application.PostService.Service;
using TBD_library.Data.EF;
using TBD_library.Data.Entities;

namespace TBD_library.Application.PostService.service
{
    public class PostCurd
    {
        private readonly TBD_libraryDBContext dbContext;
        CategoryGet getCategory = new CategoryGet();
        public async Task<int> create(PostDto postDto)
        {
            var post = new Post
            {
                Title = postDto.Title,
                Summary = postDto.Summary,
                Conten = postDto.Content,
                Img = postDto.Img,
                Created_at = DateTime.Now,
                Updated_at = DateTime.Now,
                ViewCount = 0,
                Status = postDto.Status,
                User_id = postDto.UserId,
            };
            foreach (var item in postDto.CategoryListName)
            {
                post.PostInCategories.Add(
                new PostInCategory()
                {
                    Category_id = getCategory.getIdByTitle(item),
                });
            }
            dbContext.Posts.AddRange(post);
            return await dbContext.SaveChangesAsync();
        }
        public async Task<int> update(PostDto postDto)
        {
            var post = await dbContext.Posts.FirstOrDefaultAsync(x => x.Id == postDto.Id);
            if (post != null)
            {
                post.Title = postDto.Title;
                post.Summary = postDto.Summary;
                post.Conten = postDto.Content;
                post.Img = postDto.Img;
                postDto.Update_at = DateTime.Now;
                post.Status = post.Status;
                foreach (var item in postDto.CategoryListName)
                {
                    post.PostInCategories.Add(
                    new PostInCategory()
                    {
                        Category_id = getCategory.getIdByTitle(item),
                    });
                }
                dbContext.UpdateRange(post);
            }
            else
            {
                throw new Exception("object post has not values");
            }
            return await dbContext.SaveChangesAsync();
        }
        public async Task<int> updateViewPost(int id)
        {
            var post = await dbContext.Posts.FirstOrDefaultAsync(x => x.Id == id);
            if(post != null)
            {
                post.ViewCount++;
            }
            else
            {
                throw new Exception($"don't find with id : {id}");
            }
            dbContext.Posts.Update(post);
            return await dbContext.SaveChangesAsync();
        }
        public async Task<int> delete(int id)
        {
            PostInCategory? postInCategory = await dbContext.PostInCategories.FirstOrDefaultAsync(x => x.Post_id == id);
            Post? post = await dbContext.Posts.FirstOrDefaultAsync(x => x.Id == id);
            if (post != null)
            {
                dbContext.Posts.RemoveRange(post);
                if (postInCategory != null)
                {
                    dbContext.PostInCategories.RemoveRange(postInCategory);
                }
            }
            else
            {
                throw new Exception("don't find id post need remove");
            }
            return await dbContext.SaveChangesAsync();
        }
    }
}
