using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TechBlogWeb.Domain.Request.Blog
{
    public class CreateBlogRequest
    {
        [Required(ErrorMessage = "Nhập ImageUrl!")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Nhập PublishDate!")]
        public DateTime PublishDate { get; set; }

        [Required(ErrorMessage = "Nhập Title!")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Nhập ShortContent!")]
        public string ShortContent { get; set; }

        [Required(ErrorMessage = "Nhập FullContent!")]
        public string FullContent { get; set; }

        [Required(ErrorMessage = "Nhập CategoryId!")]
        public int CategoryId { get; set; }
       
        
    }
}
