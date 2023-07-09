using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBD_library.Application.PostService.Dtos
{
    public class CategoryDto
    {
        private int id;
        private String title;
        private String description;

        public CategoryDto() { }

        public CategoryDto(int id, string title, string description)
        {
            this.id = id;
            this.title = title;
            this.description = description;
        }

        public int Id { get => id; set => id = value; }
        public string Title { get => Title; set => Title = value; }
        public string Description { get => description; set => description = value; }
    }
}
