using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBD_library.Application.Catalog.Dtos;
using TBD_library.Application.PostService.Dtos;

namespace TBD_library.Application.PostService.Interface
{
    public interface IPostGet
    {
        List<PostDto> getAllPost();
        List<PostDto> getPostListById(int id);
        int getIdByTitle(string title);
    }
}
