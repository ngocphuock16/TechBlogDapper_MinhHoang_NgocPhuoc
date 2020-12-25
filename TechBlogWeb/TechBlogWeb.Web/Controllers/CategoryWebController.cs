using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechBlogWeb.Domain.Request.Category;
using TechBlogWeb.Domain.Response.Category;
using TechBlogWeb.Web.Helper;
using TechBlogWeb.Web.Models;

namespace TechBlogWeb.Web.Controllers
{
    public class CategoryWebController : Controller
    {
        private readonly ILogger<CategoryWebController> _logger;

        public CategoryWebController(ILogger<CategoryWebController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Category> categories = new List<Category>();
            categories = Helper.ApiHelper<List<Category>>.HttpGetAsync("api/category/gets");
            return View(categories);
        }

        [HttpGet]   
        public IActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryRequest model)
        {
            if (ModelState.IsValid)
            {
                var result = new CreateCategoryResult() ;
                result = Helper.ApiHelper<CreateCategoryResult>.HttpPostAsync("api/category/create", "POST", model);
                if (result.CategoryId > 0)
                {
                    return RedirectToAction("index");
                }
                ModelState.AddModelError("", result.Message);
                return View(model);
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult UpdateCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UpdateCategory(UpdateCategoryRequest model)
        {
            if (ModelState.IsValid)
            {
                var result = new UpdateCategoryResult();
                result = Helper.ApiHelper<UpdateCategoryResult>.HttpPostAsync("api/category/update", "PATCH", model);
                if (result.CategoryId > 0)
                {
                    return RedirectToAction("index");
                }
                ModelState.AddModelError("", result.Message);
                return View(model);
            }
            return View(model);
        }


        [Route("/category/delete/{id}")]
        public IActionResult Delete(int id)
        {

            {
                var result = new DeleteCategoryResult();
                result = ApiHelper<DeleteCategoryResult>.HttpGetAsync(
                                                        $"{TechBlogWeb.Web.Helper.Helper.domainUrl}api/category/delete/{id}",
                                                        "DELETE"
                                                    );
                return View();
            }
        }
    }
}
