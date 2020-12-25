using System;
using System.Collections.Generic;
using System.Text;

namespace TechBlogWeb.Domain.Response.Blog
{
    public class UpdateBlogResult
    {
        public int BlogId { get; set; }
        public string ImageUrl { get; set; }
        public DateTime PublishDate { get; set; }
        public string Title { get; set; }
        public string ShortContent { get; set; }
        public string FullContent { get; set; }
        public int CategoryId { get; set; }
        public string Message { get; set; }

        public string Result { get; set; }
    }
}
