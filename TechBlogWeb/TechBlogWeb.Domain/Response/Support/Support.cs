using System;
using System.Collections.Generic;
using System.Text;

namespace TechBlogWeb.Domain.Response.Support
{
    public class Support
    {
        public int SupportId { get; set; }
        public string ContentSupport { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
    }
}
