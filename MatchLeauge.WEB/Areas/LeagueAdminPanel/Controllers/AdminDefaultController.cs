using Microsoft.AspNetCore.Mvc;

namespace MatchLeauge.WEB.Areas.LeagueAdminPanel.Controllers
{
    public class AdminDefaultController : Controller
    {
        public IActionResult AdminDefaultIndex()
        {
            return View();
        }

        public IActionResult AboutIndex()
        {
            return View();
        }
    }
}
