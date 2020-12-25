using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechBlogWeb.Domain.Request.Contact;
using TechBlogWeb.Domain.Response.Contact;

namespace TechBlogWeb.DAL.Interface
{
    public interface IContactRepository
    {
        Task<IEnumerable<Contact>> Gets();
        Task<UpdateContactResult> UpdateContact(UpdateContactRequest request);
    }
}
