using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechBlogWeb.Domain.Request.FeedBack;
using TechBlogWeb.Domain.Response.FeedBack;

namespace TechBlogWeb.BAL.Interface
{
    public interface IFeedBackService
    {
        Task<IEnumerable<FeedBack>> Gets();
        Task<CreateFeedBackResult> CreateFeedBack(CreateFeedBackRequest request);
        Task<DeleteFeedBackResult> DeleteFeedBack(int FeedBackId);
    }
}
