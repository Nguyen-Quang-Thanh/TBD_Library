using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBD_library.Application.Catalog.Dtos;
using TBD_library.Application.PostService.Dtos;

namespace TBD_library.Application.PostService.Interface
{
    internal interface IPostGet
    {
        Task<List<PostDto>> getAllPostList();
        Task<int> getIdByCreate_at();
    }
}
