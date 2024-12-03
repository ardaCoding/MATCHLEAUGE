using Microsoft.AspNetCore.Mvc;

namespace MatchLeauge.WEB.Areas.LeagueAdminPanel.Controllers
{
    public class DefaultContoller : Controller
    {
        public IActionResult DefaultIndex()
        {
            return View();
        }
    }
}
