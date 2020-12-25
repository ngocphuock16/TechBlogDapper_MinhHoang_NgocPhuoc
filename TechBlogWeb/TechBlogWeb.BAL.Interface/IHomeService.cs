using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechBlogWeb.Domain.Request.Home;
using TechBlogWeb.Domain.Response.Home;

namespace TechBlogWeb.BAL.Interface
{
    public interface IHomeService
    {
        Task<IEnumerable<Home>> Gets();
        Task<UpdateHomeResult> UpdateHome(UpdateHomeRequest request);
    }
}
