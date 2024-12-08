using Microsoft.AspNetCore.Mvc;
using MatchLeauge.BLL.Repository;
using MatchLeauge.DAL.IRepository;
using YamlDotNet.Core.Tokens;


namespace MatchLeauge.API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class LeagueController : BaseController
    {
        ILeagueRepository _leagueRepository;

        public LeagueController(ILeagueRepository leagueRepository)
        {
               _leagueRepository = leagueRepository;
        }

        //endpoint=> api/League/LeagueIndex...
        [HttpGet]
        public IActionResult LeagueIndex()
        {
            var list=_leagueRepository.GetAll();
            if (list!=null)
            {
                return ResultAPI(list);
            }
            return  ResultAPI(204);
        }


        [HttpPut]
        public IActionResult LeagueInsert()
        {
            return View();
        }

        [HttpDelete]
        public IActionResult LeagueUpdate()
        {
            return View();
        }

        //public IActionResult LeagueDelete()
        //{
        //    return View();
        //}

        //public IActionResult LeagueFind()
        //{
        //    return View();
        //}

        //public IActionResult LeagueDetail()
        //{
        //    return View();
        //}
    }
}
