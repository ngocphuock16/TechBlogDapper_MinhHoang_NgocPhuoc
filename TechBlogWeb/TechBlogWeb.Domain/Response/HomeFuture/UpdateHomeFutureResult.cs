using System;
using System.Collections.Generic;
using System.Text;

namespace TechBlogWeb.Domain.Response.HomeFuture
{
    public class UpdateHomeFutureResult
    {
        public int HFId { get; set; }
        public string HFTitle { get; set; }
        public string HFContent { get; set; }
        public string Result { get; set; }
    }
}
