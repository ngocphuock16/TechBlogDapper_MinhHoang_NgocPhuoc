using System;
using System.Collections.Generic;
using System.Text;

namespace TechBlogWeb.Domain.Response.Contact
{
    public class UpdateContactResult
    {
        public string Address { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public string Result { get; set; }
    }
}
