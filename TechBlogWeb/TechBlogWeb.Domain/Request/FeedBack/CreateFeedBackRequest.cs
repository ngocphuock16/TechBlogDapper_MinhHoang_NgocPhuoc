using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TechBlogWeb.Domain.Request.FeedBack
{
    public class CreateFeedBackRequest
    {
        [Required(ErrorMessage = "Nhập Name!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Nhập Comment!")]
        public string Comment { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Nhập Email!")]
        public string Email { get; set; }
    }
}
