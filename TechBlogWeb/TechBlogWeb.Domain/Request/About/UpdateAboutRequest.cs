using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TechBlogWeb.Domain.Request.About
{
    public class UpdateAboutRequest
    {
        [Required(ErrorMessage = "Nhập Title!")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Nhập ShortContent!")]
        public string ShortContent { get; set; }

        [Required(ErrorMessage = "Nhập Content!")]
        public string Content { get; set; }

        [Required(ErrorMessage = "Nhập ImageUrl!")]
        public string ImageUrl { get; set; }
    }
}
