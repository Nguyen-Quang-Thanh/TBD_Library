using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBD_library.Application.PostService.Dtos;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;

namespace TBD_library.Application.PostService.Interface
{
    public interface ICategory
    {
        List<CategoryDto> getAllList();
        int getIdByTitle(String title);
        List<CategoryDto> getCaregoryListById(int id);
        List<String> getAllTitleListById(int id);
    }
}
