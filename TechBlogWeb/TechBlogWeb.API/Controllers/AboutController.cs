using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechBlogWeb.BAL.Interface;
using TechBlogWeb.Domain.Request.About;

namespace TechBlogWeb.API.Controllers
{

    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService aboutService;
        public AboutController(IAboutService aboutService)
        {
            this.aboutService = aboutService;
        }
        [HttpGet]
        [Route("/api/about/gets")]
        public async Task<OkObjectResult> Gets()
        {
            return Ok(await aboutService.Gets());
        }

        [HttpPatch]
        [Route("/api/about/update")]
        public async Task<OkObjectResult> Update(UpdateAboutRequest request)
        {
            return Ok(await aboutService.UpdateAbout(request));
        }
    }
}
