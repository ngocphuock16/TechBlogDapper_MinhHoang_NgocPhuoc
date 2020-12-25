using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechBlogWeb.Domain.Request.Blog;
using TechBlogWeb.Domain.Response.Blog;

namespace TechBlogWeb.BAL.Interface
{
    public interface IBlogService
    {
        Task<IEnumerable<Blog>> Gets();

        Task<CreateBlogResult> CreateBlog(CreateBlogRequest request);

        Task<UpdateBlogResult> UpdateBlog(UpdateBlogRequest request);

        Task<DeleteBlogResult> DeleteBlog(int BlogId);
    }
}
