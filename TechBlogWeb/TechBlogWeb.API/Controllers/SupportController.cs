using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechBlogWeb.BAL.Interface;
using TechBlogWeb.Domain.Request.Support;
using TechBlogWeb.Domain.Response.Support;

namespace TechBlogWeb.API.Controllers
{
    
    [ApiController]
    public class SupportController : ControllerBase
    {
        private readonly ISupportService supportService;
        public SupportController(ISupportService supportService)
        {
            this.supportService = supportService;
        }
        [HttpGet]
        [Route("/api/support/gets")]
        public async Task<OkObjectResult> Gets()
        {
            return Ok(await supportService.Gets());
        }

        [HttpPost]
        [Route("/api/support/create")]
        public async Task<OkObjectResult> Create(CreateSupportRequest request)
        {
            return Ok(await supportService.CreateSupport(request));
        }

        [HttpDelete]
        [Route("/api/support/delete/{id}")]
        public async Task<DeleteSupportResult> Delete(int id)
        {
            return await supportService.DeleteSupport(id);
        }
    }
}
