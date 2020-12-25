using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TechBlogWeb.Domain.Request.Home
{
    public class UpdateHomeRequest
    {
        [Required(ErrorMessage = "Nhập Title!")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Nhập Content!")]
        public string Content { get; set; }
    }
}
