using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechBlogWeb.BAL.Interface;
using TechBlogWeb.DAL.Interface;
using TechBlogWeb.Domain.Request.HomeFuture;
using TechBlogWeb.Domain.Response.HomeFuture;

namespace TechBlogWeb.BAL
{
    public class HomeFutureService : IHomeFutureService
    {
        private readonly IHomeFutureRepository homefutureRepository;
        public HomeFutureService(IHomeFutureRepository homefutureRepository)
        {
            this.homefutureRepository = homefutureRepository;
        }
        public async Task<IEnumerable<HomeFuture>> Gets()
        {
            return await homefutureRepository.Gets();
        }

        public async Task<UpdateHomeFutureResult> UpdateHomeFuture(UpdateHomeFutureRequest request)
        {
            return await homefutureRepository.UpdateHomeFuture(request);
        }
    }
}
