using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TechBlogWeb.Domain.Request.Category
{
    public class UpdateCategoryRequest
    {
        [Required(ErrorMessage = "Nhập CategoryId!")]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Nhập tên Category!")]
        public string CategoryName { get; set; }
    }
}
