using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechBlogWeb.BAL.Interface;
using TechBlogWeb.Domain.Request.HomeFuture;

namespace TechBlogWeb.API.Controllers
{

    [ApiController]
    public class HomeFutureController : ControllerBase
    {
        private readonly IHomeFutureService homefutureService;
        public HomeFutureController(IHomeFutureService homefutureService)
        {
            this.homefutureService = homefutureService;
        }
        [HttpGet]
        [Route("/api/homefuture/gets")]
        public async Task<OkObjectResult> Gets()
        {
            return Ok(await homefutureService.Gets());
        }

        [HttpPatch]
        [Route("/api/homefuture/update")]
        public async Task<OkObjectResult> Update(UpdateHomeFutureRequest request)
        {
            return Ok(await homefutureService.UpdateHomeFuture(request));
        }
    }
}
