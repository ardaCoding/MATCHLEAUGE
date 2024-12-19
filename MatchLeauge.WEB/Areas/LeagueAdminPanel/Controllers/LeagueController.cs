using MatchLeauge.DAL.DTO;
using MatchLeauge.DAL.MLContext;
using MatchLeauge.WEB.APIService;
using Microsoft.AspNetCore.Mvc;

namespace MatchLeauge.WEB.Areas.LeagueAdminPanel.Controllers
{
    public class LeagueController : Controller
    {
        private readonly LeagueGetAPI _leagueGetAPI;//DI
        public LeagueController(LeagueGetAPI leagueGetAPI)
        {
            _leagueGetAPI = leagueGetAPI;
        }


        public async Task<IActionResult> LeagueList()
        {
            var list = await _leagueGetAPI.GetAll();

            return View(list);
        }

        public IActionResult LeagueInsert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LeagueInsert(LeagueDTO leagueDTO)
        {
            var getAPI = _leagueGetAPI.LeagueInsert(leagueDTO);

            if (getAPI != null)
            {
                ViewBag.mesaj = leagueDTO.LeagueName + "ligi başarılı bir şekilde eklendi";
                return View();
            }

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> LeagueUpdate(int id)
        {
            //Id si ile gelen Lig dayasını inputlara doldur
            var getLig = await _leagueGetAPI.GetLeagueById(id);

            return View(getLig);
        }

        [HttpPost]
        public IActionResult LeagueUpdate(LeagueDTO leaguedto)
        {
            var updateLeague = _leagueGetAPI.LeagueUpdate(leaguedto);

#warning bu kısımda route ayarı View() için yapılacak
            //return View(updateLeague);//
            return RedirectToAction("LeagueList", "League", "LeagueAdminPanel");//1.parametre view,2.parametre Controller,3.parametre ise Admin Paneli route isimlerini temsil eder

        }

        [HttpGet]
        public IActionResult LeagueDelete(int id)
        {
            return View();
        }
    }
}
