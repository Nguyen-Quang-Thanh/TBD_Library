using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBD_library.Application.Catalog.Dtos;
using TBD_library.Application.PostService.Service;
using TBD_library.Data.EF;

namespace TBD_library.Application.PostService.service
{
    public class PostGet
    {
        private readonly TBD_libraryDBContext dbContext;
        CategoryGet getCategory = new CategoryGet();
        public List<PostDto> getAllPost()
        {
            List<PostDto> postList = new List<PostDto>();
            var post = dbContext.Posts.Select(x => x); //from item in dbContext.Posts join item2 in dbContext.
            if (post != null)
            {
                foreach (var item in post)
                {
                    postList.Add(new PostDto(item.Id, item.Title, item.Summary, item.Conten, item.Img,
                                            item.Created_at, item.Updated_at, item.ViewCount,item.Status, item.User_id,
                                            getCategory.getAllTitleListById(item.PostInCategories.Select(x => x.Category_id).FirstOrDefault())));
                }
            }
            else
            {
                return postList;
            }
            return postList;
        }
        public List<PostDto> getPostListById(int id)
        {
            List<PostDto> postList = new List<PostDto>();
            var post = dbContext.Posts.Where(x => x.Id.Equals(id)).Select(x => x);
            if(post != null)
            {
                foreach(var item in post)
                {
                    postList.Add(new PostDto(item.Id, item.Title, item.Summary, item.Conten, item.Img,
                                        item.Created_at, item.Updated_at, item.ViewCount, item.Status, item.User_id,
                                        getCategory.getAllTitleListById(item.PostInCategories.Select(x => x.Category_id).FirstOrDefault())));
                }
            }
            return postList;
        }
        public int getIdByTitle(string title)
        {
            int id = 0; 
            var idPost = getAllPost().Where(x => x.Title == title).Select(x => x.Id);
            if(idPost != null)
            {
                foreach(var item in idPost)
                {
                    id = item;
                }
            }
            else
            {
                throw new Exception($"don't find with title");
            }
            return id;
        }
    }
}
