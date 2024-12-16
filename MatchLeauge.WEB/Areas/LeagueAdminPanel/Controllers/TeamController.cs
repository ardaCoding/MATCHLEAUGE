using MatchLeauge.DAL.DTO;
using MatchLeauge.WEB.APIService;
using Microsoft.AspNetCore.Mvc;

namespace MatchLeauge.WEB.Areas.LeagueAdminPanel.Controllers
{
    public class TeamController : Controller
    {
        private readonly TeamAPI _teamAPI;
       public TeamController(TeamAPI teamAPI)
        {
             _teamAPI = teamAPI;
        }
        public async Task<IActionResult> TeamList()
        {
            var list = await _teamAPI.GetAll();

            return View(list);
        }

        [HttpPost]
        public IActionResult TeamInsert(TeamDTO teamDTO)
        {
            var getAPI = _teamAPI.TeamInsert(teamDTO);

            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
