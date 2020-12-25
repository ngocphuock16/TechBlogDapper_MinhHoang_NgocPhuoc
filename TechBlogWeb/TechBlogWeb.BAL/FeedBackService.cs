using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechBlogWeb.BAL.Interface;
using TechBlogWeb.DAL.Interface;
using TechBlogWeb.Domain.Request.FeedBack;
using TechBlogWeb.Domain.Response.FeedBack;

namespace TechBlogWeb.BAL
{
    public class FeedBackService : IFeedBackService
    {
        private readonly IFeedBackRepository feedbackRepository;
        public FeedBackService(IFeedBackRepository feedbackRepository)
        {
            this.feedbackRepository = feedbackRepository;
        }

        public async Task<CreateFeedBackResult> CreateFeedBack(CreateFeedBackRequest request)
        {
            return await feedbackRepository.CreateFeedBack(request);
        }

        public async Task<DeleteFeedBackResult> DeleteFeedBack(int FeedBackId)
        {
            return await feedbackRepository.DeleteFeedBack(FeedBackId);
        }

        public async Task<IEnumerable<FeedBack>> Gets()
        {
            return await feedbackRepository.Gets();
        }
    }
}
