using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.FileProviders;
using System;
using WebAPI.Model;
using System.IO;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediaController : ControllerBase
    {
        public IConfiguration Configuration { get; }
        public AppConfig appConfig;


        public MediaController(IConfiguration configuration)
        {
            Configuration = configuration;
            appConfig = Configuration.GetSection("PhotoInformation").Get<AppConfig>();

        }



    [HttpGet("showMedia/{guid}")]
        public IActionResult ShowMedia(Guid guid)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "Media");
            var image = System.IO.File.OpenRead(path + "/" + guid);

            return File(image, "image/jpeg");
        }
    }
}
