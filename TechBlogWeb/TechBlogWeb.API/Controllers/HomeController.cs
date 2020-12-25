using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechBlogWeb.BAL.Interface;
using TechBlogWeb.Domain.Request.Home;

namespace TechBlogWeb.API.Controllers
{

    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IHomeService homeService;
        public HomeController(IHomeService homeService)
        {
            this.homeService = homeService;
        }
        [HttpGet]
        [Route("/api/home/gets")]
        public async Task<OkObjectResult> Gets()
        {
            return Ok(await homeService.Gets());
        }

        [HttpPatch]
        [Route("/api/home/update")]
        public async Task<OkObjectResult> Update(UpdateHomeRequest request)
        {
            return Ok(await homeService.UpdateHome(request));
        }
    }
}
