using Microsoft.AspNetCore.Mvc;

namespace MatchLeauge.WEB.Areas.LeagueAdminPanel.Controllers
{
    public class PlayerController : Controller
    {
        public IActionResult PlayerList()
        {
            return View();
        }

        public IActionResult PlayerInsert()
        {
            return View();
        }

        [HttpGet]
        public IActionResult PlayerUpdate(int id)
        {
            return View();
        }
    }
}