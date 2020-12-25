using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechBlogWeb.BAL.Interface;
using TechBlogWeb.DAL.Interface;
using TechBlogWeb.Domain.Request.Contact;
using TechBlogWeb.Domain.Response.Contact;

namespace TechBlogWeb.BAL
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository contactRepository;
        public ContactService(IContactRepository contactRepository)
        {
            this.contactRepository = contactRepository;
        }
        public async Task<IEnumerable<Contact>> Gets()
        {
            return await contactRepository.Gets();
        }

        public async Task<UpdateContactResult> UpdateContact(UpdateContactRequest request)
        {
            return await contactRepository.UpdateContact(request);
        }
    }
}
