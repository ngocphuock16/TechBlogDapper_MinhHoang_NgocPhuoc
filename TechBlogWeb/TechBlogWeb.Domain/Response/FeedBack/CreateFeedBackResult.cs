using System;
using System.Collections.Generic;
using System.Text;

namespace TechBlogWeb.Domain.Response.FeedBack
{
    public class CreateFeedBackResult
    {
        public int FeedBackId { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}
