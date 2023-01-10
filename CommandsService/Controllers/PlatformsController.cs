using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CommandsService.Controllers
{
    [Route("api/c/[controller]")]
    [ApiController]
    public class PlatformsController : ControllerBase
    {
        public PlatformsController() { }

        public ActionResult TestInboundConnection()
        {
            System.Console.WriteLine("--> Inbound post # Command Service");
            return Ok("Inbound test of  from Platform controller");
        }
    }
}
