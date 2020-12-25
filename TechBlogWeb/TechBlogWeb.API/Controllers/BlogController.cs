using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TechBlogWeb.BAL.Interface;
using TechBlogWeb.Domain.Request.Blog;
using TechBlogWeb.Domain.Response.Blog;

namespace TechBlogWeb.API.Controllers
{
    
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IBlogService blogService;
        public BlogController(IBlogService blogService)
        {
            this.blogService = blogService;
        }
        [HttpGet]
        [Route("/api/blog/gets")]
        public async Task<OkObjectResult> Gets()
        {
            return Ok(await blogService.Gets());
        }

        [HttpPost]
        [Route("/api/blog/create")]
        public async Task<OkObjectResult> Create(CreateBlogRequest request)
        {
            return Ok(await blogService.CreateBlog(request));
        }

        [HttpPatch]
        [Route("/api/blog/update")]
        public async Task<OkObjectResult> Update(UpdateBlogRequest request)
        {
            return Ok(await blogService.UpdateBlog(request));
        }
        [HttpDelete]
        [Route("/api/blog/delete/{id}")]
        public async Task<DeleteBlogResult> Delete(int id)
        {
            return await blogService.DeleteBlog(id);
        }
    }
}
