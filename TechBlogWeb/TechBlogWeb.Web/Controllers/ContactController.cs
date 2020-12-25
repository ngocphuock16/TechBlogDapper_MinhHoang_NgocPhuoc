using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechBlogWeb.Domain.Response.Contact;

namespace TechBlogWeb.Web.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            List<Contact> contacts = new List<Contact>();
            contacts = Helper.ApiHelper<List<Contact>>.HttpGetAsync("api/contact/gets");
            return View(contacts);
        }
    }
}
