using System;
using System.Collections.Generic;
using System.Text;

namespace TechBlogWeb.Domain.Response.About
{
    public class UpdateAboutResult
    {
        public string Title { get; set; }
        public string ShortContent { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public string Result { get; set; }
    }
}
