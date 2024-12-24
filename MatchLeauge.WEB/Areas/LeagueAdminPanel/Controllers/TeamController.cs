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
        [HttpGet]
        public async Task<IActionResult> TeamUpdate(int id)
        {
            //Id si ile gelen Lig dayasını inputlara doldur
            var getTeamApi = await _teamAPI.GetTeamById(id);

            return View(getTeamApi);
        }


        [HttpPost]
        public IActionResult TeamUpdate(TeamDTO teamDTO)
        {
            var updateLeague = _teamAPI.TeamUpdate(teamDTO);


            
       return RedirectToAction("TeamList", "Team", "LeagueAdminPanel");
      //1.parametre view,2.parametre Controller,3.parametre ise Admin Paneli route isimlerini temsil eder

        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
