using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechBlogWeb.Domain.Request.Home;
using TechBlogWeb.Domain.Response.Home;

namespace TechBlogWeb.DAL.Interface
{
    public interface IHomeRepository
    {
        Task<IEnumerable<Home>> Gets();
        Task<UpdateHomeResult> UpdateHome(UpdateHomeRequest request);
    }
}
