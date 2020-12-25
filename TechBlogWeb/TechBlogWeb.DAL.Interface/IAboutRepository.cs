using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechBlogWeb.Domain.Request.About;
using TechBlogWeb.Domain.Response.About;

namespace TechBlogWeb.DAL.Interface
{
    public interface IAboutRepository
    {
        Task<IEnumerable<About>> Gets();
        Task<UpdateAboutResult> UpdateAbout(UpdateAboutRequest request);
    }
}
