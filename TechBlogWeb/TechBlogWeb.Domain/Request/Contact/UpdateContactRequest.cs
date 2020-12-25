using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TechBlogWeb.Domain.Request.Contact
{
    public class UpdateContactRequest
    {
        [Required(ErrorMessage = "Nhập Address!")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Nhập Phone!")]
        public int Phone { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Nhập Email!")]
        public string Email { get; set; }
    }
}
