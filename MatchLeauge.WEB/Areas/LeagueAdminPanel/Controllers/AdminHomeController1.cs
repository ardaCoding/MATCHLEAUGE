using Microsoft.AspNetCore.Mvc;

namespace MatchLeauge.WEB.Areas.LeagueAdminPanel.Controllers
{
    public class AdminHomeController1 : Controller
    {
        public IActionResult AdminHomeIndex()
        {
            return View();
        }
    }
}
