using Microsoft.AspNetCore.Mvc;

namespace MatchLeauge.WEB.Areas.LeagueAdminPanel.Controllers
{
    public class LeagueController : Controller
    {
        public IActionResult LeagueList()
        {
            return View();
        }

        public IActionResult LeagueInsert()
        {
            return View();
        }

        [HttpGet]
        public IActionResult LeagueUpdate(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult LeagueUpdate(string blabla)
        {
            return View();
        }

        [HttpGet]
        public IActionResult LeagueDelete(int id)
        {
            return View();
        }
    }
}
