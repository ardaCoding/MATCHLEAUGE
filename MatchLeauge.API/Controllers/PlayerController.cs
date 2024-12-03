using Microsoft.AspNetCore.Mvc;

namespace MatchLeauge.API.Controllers
{
    public class PlayerController : Controller
    {
        public IActionResult PlayerIndex()
        {


            return View();
        }
    }
}
