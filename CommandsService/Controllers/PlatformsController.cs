using Microsoft.AspNetCore.Mvc;

namespace CommandsService.Controllers
{
    [Route("api/c/[controller]")]
    [ApiController]
    public class PlatformsController : ControllerBase
    {
        public PlatformsController()
        {

        }
        [HttpPost]
        public ActionResult TestInboundConnection()
        {
            System.Console.WriteLine("-------Inbound test of from Platforms Controller");
            return Ok("Inbound test of from Platforms Controller");
        }
    }
}

