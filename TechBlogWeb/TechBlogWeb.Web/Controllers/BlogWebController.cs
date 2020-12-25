using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechBlogWeb.Domain.Request.Blog;
using TechBlogWeb.Domain.Response.Blog;
using TechBlogWeb.Web.Helper;
using TechBlogWeb.Web.Models;

namespace TechBlogWeb.Web.Controllers
{
    public class BlogWebController : Controller
    {
        public IActionResult Index()
        {

            List<Blog> blogs = new List<Blog>();
            blogs = Helper.ApiHelper<List<Blog>>.HttpGetAsync("api/blog/gets");
            return View(blogs);
        }
        [HttpGet]
        public IActionResult CreateBlog()
        {

            return View();
        }

        [HttpPost]
        public IActionResult CreateBlog(CreateBlogRequest model)
        {
            if (ModelState.IsValid)
            {
                var result = new CreateBlogResult();
                result = Helper.ApiHelper<CreateBlogResult>.HttpPostAsync("api/blog/create", "POST", model);
                if (result.BlogId >0)
                {
                    return RedirectToAction("index");
                }
                ModelState.AddModelError("", result.Message);
                return View(model);
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult UpdateBlog()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UpdateBlog(UpdateBlogRequest model)
        {
            if (ModelState.IsValid)
            {
                var result = new UpdateBlogResult();
                result = Helper.ApiHelper<UpdateBlogResult>.HttpPostAsync("api/blog/update", "PATCH", model);
                if (result.BlogId > 0)
                {
                    return RedirectToAction("index");
                }
                ModelState.AddModelError("", result.Message);
                return View(model);
            }
            return View(model);
        }


        [Route("/blog/delete/{id}")]
        public IActionResult Delete(int id)
        {

            {
                var result = new DeleteBlogResult();
                result = ApiHelper<DeleteBlogResult>.HttpGetAsync(
                                                        $"{TechBlogWeb.Web.Helper.Helper.domainUrl}api/blog/delete/{id}",
                                                        "DELETE"
                                                    );
                return View();
            }
        }
    }
}
