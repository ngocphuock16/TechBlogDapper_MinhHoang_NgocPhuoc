using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TechBlogWeb.BAL.Interface;
using TechBlogWeb.Domain.Request.Category;
using TechBlogWeb.Domain.Response.Category;

namespace TechBlogWeb.API.Controllers
{
    
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        [HttpGet]
        [Route("/api/category/gets")]
        public async Task<OkObjectResult> Gets()
        {
            return Ok(await categoryService.Gets());
        }

        [HttpPost]
        [Route("/api/category/create")]
        public async Task<OkObjectResult> Create(CreateCategoryRequest request)
        {
            return Ok(await categoryService.CreateCategory(request));
        }

        [HttpPatch]
        [Route("/api/category/update")]
        public async Task<OkObjectResult> Update(UpdateCategoryRequest request)
        {
            return Ok(await categoryService.UpdateCatgory(request));
        }
        [HttpDelete]
        [Route("/api/category/delete/{id}")]
        public async Task<DeleteCategoryResult> Delete(int id)
        {
            return await categoryService.DeleteCategory(id);
        }
    }
}
