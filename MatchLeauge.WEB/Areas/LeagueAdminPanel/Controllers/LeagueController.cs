﻿using MatchLeauge.WEB.APIService;
using Microsoft.AspNetCore.Mvc;

namespace MatchLeauge.WEB.Areas.LeagueAdminPanel.Controllers
{
    public class LeagueController : Controller
    {
        private readonly LeagueGetAPI _leagueGetAPI;
        public LeagueController(LeagueGetAPI leagueGetAPI)
        {
            _leagueGetAPI = leagueGetAPI;
        }


        public async Task<IActionResult> LeagueList()
        {
          var list=  await _leagueGetAPI.GetAll();

            return View(list);
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
