using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechBlogWeb.BAL.Interface;
using TechBlogWeb.Domain.Request.Contact;

namespace TechBlogWeb.API.Controllers
{

    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService contactService;
        public ContactController(IContactService contactService)
        {
            this.contactService = contactService;
        }
        [HttpGet]
        [Route("/api/contact/gets")]
        public async Task<OkObjectResult> Gets()
        {
            return Ok(await contactService.Gets());
        }

        [HttpPatch]
        [Route("/api/contact/update")]
        public async Task<OkObjectResult> Update(UpdateContactRequest request)
        {
            return Ok(await contactService.UpdateContact(request));
        }
    }
}
