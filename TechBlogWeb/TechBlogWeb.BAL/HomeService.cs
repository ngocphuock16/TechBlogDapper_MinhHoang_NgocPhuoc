using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechBlogWeb.BAL.Interface;
using TechBlogWeb.DAL.Interface;
using TechBlogWeb.Domain.Request.Home;
using TechBlogWeb.Domain.Response.Home;

namespace TechBlogWeb.BAL
{
    public class HomeService : IHomeService
    {
        private readonly IHomeRepository homeRepository;
        public HomeService(IHomeRepository homeRepository)
        {
            this.homeRepository = homeRepository;
        }

        public async Task<IEnumerable<Home>> Gets()
        {
            return await homeRepository.Gets();
        }

        public async Task<UpdateHomeResult> UpdateHome(UpdateHomeRequest request)
        {
            return await homeRepository.UpdateHome(request);
        }
    }
}
