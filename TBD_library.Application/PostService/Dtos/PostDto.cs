using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBD_library.Data.Enums;

namespace TBD_library.Application.Catalog.Dtos
{
    public class Post
    {
        private int id;
        private String title;
        private String summary;
        private String content;
        private String img;
        private DateTime create_at;
        private DateTime update_at;
        private int viewCount;
        private ePostStatus status;
        private int userId;

        public Post() { }

        public Post(int id, string title, string summary, string content, string img, DateTime create_at, DateTime update_at, int viewCount, ePostStatus status, int userId)
        {
            this.id = id;
            this.title = title;
            this.summary = summary;
            this.content = content;
            this.img = img;
            this.create_at = create_at;
            this.update_at = update_at;
            this.viewCount = viewCount;
            this.status = status;
            this.userId = userId;
        }

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Summary { get => summary; set => summary = value; }
        public string Content { get => content; set => content = value; }
        public string Img { get => img; set => img = value; }
        public DateTime Create_at { get => create_at; set => create_at = value; }
        public DateTime Update_at { get => update_at; set => update_at = value; }
        public int ViewCount { get => viewCount; set => viewCount = value; }
        public ePostStatus Status { get => status; set => status = value; }
        public int UserId { get => userId; set => userId = value; }
    }
}
