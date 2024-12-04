using Microsoft.AspNetCore.Mvc;

namespace MatchLeauge.WEB.Areas.LeagueAdminPanel.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult HomeIndex()
        {
            return View();
        }
    }
}
