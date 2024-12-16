using MatchLeauge.WEB.APIService;
using Microsoft.AspNetCore.Mvc;

namespace MatchLeauge.WEB.Areas.LeagueAdminPanel.Controllers
{
    public class PlayerController : Controller
    {
        private readonly PlayerAPI playerAPI;
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