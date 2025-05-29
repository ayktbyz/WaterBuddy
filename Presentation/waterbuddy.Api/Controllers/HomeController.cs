using Microsoft.AspNetCore.Mvc;

namespace waterbuddy.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Test Endpoint";
        }
    }
}