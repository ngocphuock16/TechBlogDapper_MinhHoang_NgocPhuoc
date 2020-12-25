using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechBlogWeb.Domain.Request.HomeFuture;
using TechBlogWeb.Domain.Response.HomeFuture;

namespace TechBlogWeb.BAL.Interface
{
    public interface IHomeFutureService
    {
        Task<IEnumerable<HomeFuture>> Gets();
        Task<UpdateHomeFutureResult> UpdateHomeFuture(UpdateHomeFutureRequest request);
    }
}
