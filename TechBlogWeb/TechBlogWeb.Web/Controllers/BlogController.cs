using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechBlogWeb.Domain.Response.Blog;

namespace TechBlogWeb.Web.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            List<Blog> blogs = new List<Blog>();
            blogs = Helper.ApiHelper<List<Blog>>.HttpGetAsync("api/blog/gets");
            return View(blogs);
        }
    }
}
