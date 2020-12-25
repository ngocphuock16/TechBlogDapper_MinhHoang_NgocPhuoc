using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechBlogWeb.Domain.Request.Support;
using TechBlogWeb.Domain.Response.Support;

namespace TechBlogWeb.DAL.Interface
{
    public interface ISupportRepository
    {
        Task<IEnumerable<Support>> Gets();

        Task<CreateSupportResult> CreateSupport(CreateSupportRequest request);
        Task<DeleteSupportResult> DeleteSupport(int SupportId);
    }
}
