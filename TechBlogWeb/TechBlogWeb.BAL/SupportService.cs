using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechBlogWeb.BAL.Interface;
using TechBlogWeb.DAL.Interface;
using TechBlogWeb.Domain.Request.Support;
using TechBlogWeb.Domain.Response.Support;

namespace TechBlogWeb.BAL
{
    public class SupportService : ISupportService
    {
        private readonly ISupportRepository supportRepository;
        public SupportService(ISupportRepository supportRepository)
        {
            this.supportRepository = supportRepository;
        }



        public async Task<CreateSupportResult> CreateSupport(CreateSupportRequest request)
        {
            return await supportRepository.CreateSupport(request);
        }

        public async Task<DeleteSupportResult> DeleteSupport(int SupportId)
        {
            return await supportRepository.DeleteSupport(SupportId);
        }

        public async Task<IEnumerable<Support>> Gets()
        {
            return await supportRepository.Gets();
        }
    }
}
