using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechBlogWeb.BAL.Interface;
using TechBlogWeb.DAL.Interface;
using TechBlogWeb.Domain.Request.About;
using TechBlogWeb.Domain.Response.About;

namespace TechBlogWeb.BAL
{
    public class AboutService : IAboutService
    {
        private readonly IAboutRepository aboutRepository;
        public AboutService(IAboutRepository aboutRepository)
        {
            this.aboutRepository = aboutRepository;
        }

        public async Task<IEnumerable<About>> Gets()
        {
            return await aboutRepository.Gets();
        }

        public async Task<UpdateAboutResult> UpdateAbout(UpdateAboutRequest request)
        {
            return await aboutRepository.UpdateAbout(request);
        }
    }
}
