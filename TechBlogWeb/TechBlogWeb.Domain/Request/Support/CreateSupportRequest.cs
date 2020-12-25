using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TechBlogWeb.Domain.Request.Support
{
    public class CreateSupportRequest
    {
        [Required(ErrorMessage = "Nhập ContentSupport!")]
        public string ContentSupport { get; set; }

        [Required(ErrorMessage = "Nhập Name!")]
        public string Name { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Nhập Email!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Nhập Subject!")]
        public string Subject { get; set; }
    }
}
