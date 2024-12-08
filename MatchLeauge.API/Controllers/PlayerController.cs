using Microsoft.AspNetCore.Mvc;

namespace MatchLeauge.API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class PlayerController : BaseController
    {

        [HttpGet]
        public IActionResult PlayerIndex()
        {


            return View();
        }
    }
}
