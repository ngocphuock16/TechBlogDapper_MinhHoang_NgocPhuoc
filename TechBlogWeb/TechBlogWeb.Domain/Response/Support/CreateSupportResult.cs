using System;
using System.Collections.Generic;
using System.Text;

namespace TechBlogWeb.Domain.Response.Support
{
    public class CreateSupportResult
    {
        public int SupportId { get; set; }
        public string ContentSupport { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
