using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechBlogWeb.BAL.Interface;
using TechBlogWeb.Domain.Request.FeedBack;
using TechBlogWeb.Domain.Response.FeedBack;

namespace TechBlogWeb.API.Controllers
{
    
    [ApiController]
    public class FeedBackController : ControllerBase
    {
        private readonly IFeedBackService feedbackService;
        public FeedBackController(IFeedBackService feedbackService)
        {
            this.feedbackService = feedbackService;
        }
        [HttpGet]
        [Route("/api/feedback/gets")]
        public async Task<OkObjectResult> Gets()
        {
            return Ok(await feedbackService.Gets());
        }

        [HttpPost]
        [Route("/api/feedback/create")]
        public async Task<OkObjectResult> Create(CreateFeedBackRequest request)
        {
            return Ok(await feedbackService.CreateFeedBack(request));
        }

        [HttpDelete]
        [Route("/api/feedback/delete/{id}")]
        public async Task<DeleteFeedBackResult> Delete(int id)
        {
            return await feedbackService.DeleteFeedBack(id);
        }
    }
}
