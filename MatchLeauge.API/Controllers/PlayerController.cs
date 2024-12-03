using Microsoft.AspNetCore.Mvc;

namespace MatchLeauge.API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class PlayerController : Controller
    {

        [HttpGet]
        public IActionResult PlayerIndex()
        {


            return View();
        }
    }
}
