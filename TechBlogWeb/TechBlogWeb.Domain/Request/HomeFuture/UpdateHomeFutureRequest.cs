using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TechBlogWeb.Domain.Request.HomeFuture
{
    public class UpdateHomeFutureRequest
    {
        [Required(ErrorMessage = "Nhập HFId!")]
        public int HFId { get; set; }

        [Required(ErrorMessage = "Nhập HFTitle!")]
        public string HFTitle { get; set; }

        [Required(ErrorMessage = "Nhập HFContent!")]
        public string HFContent { get; set; }
    }
}
