using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechBlogWeb.Domain.Response.About;

namespace TechBlogWeb.Web.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            List<About> abouts = new List<About>();
            abouts = Helper.ApiHelper<List<About>>.HttpGetAsync("api/about/gets");
            return View(abouts);
        }
    }
}
