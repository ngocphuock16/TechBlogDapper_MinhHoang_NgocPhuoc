using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechBlogWeb.BAL.Interface;
using TechBlogWeb.DAL.Interface;
using TechBlogWeb.Domain.Request.Blog;
using TechBlogWeb.Domain.Response.Blog;

namespace TechBlogWeb.BAL
{
    public class BlogService : IBlogService
    {
        private readonly IBlogRepository blogRepository;
        public BlogService(IBlogRepository blogRepository)
        {
            this.blogRepository = blogRepository;
        }


        public async Task<CreateBlogResult> CreateBlog(CreateBlogRequest request)
        {
            return await blogRepository.CreateBlog(request);
        }

        public async Task<DeleteBlogResult> DeleteBlog(int BlogId)
        {
            return await blogRepository.DeleteBlog(BlogId);
        }

        public async Task<IEnumerable<Blog>> Gets()
        {
            return await blogRepository.Gets();
        }

        public async Task<UpdateBlogResult> UpdateBlog(UpdateBlogRequest request)
        {
            return await blogRepository.UpdateBlog(request);
        }
    }
}
