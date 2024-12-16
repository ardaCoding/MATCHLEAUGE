using MatchLeauge.WEB.APIService;
using Microsoft.AspNetCore.Mvc;

namespace MatchLeauge.WEB.Areas.LeagueAdminPanel.Controllers
{
    public class PlayerController : Controller
    {
        private readonly PlayerAPI _playerAPI;
        public PlayerController(PlayerAPI playerAPI)
        {
            _playerAPI = playerAPI;
        }
        public async Task<IActionResult> PlayerList()
        {
            var list = await _playerAPI.GetAll();

            return View(list);
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