using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Task_8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestConfigController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get(IConfiguration config)
        {
            //IConfiguration config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            return Ok(config.GetSection("Settings:BlackList").Get<string[]>());
        }
    }
}
