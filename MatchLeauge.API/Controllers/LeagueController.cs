using Microsoft.AspNetCore.Mvc;
using MatchLeauge.BLL.Repository;
using MatchLeauge.DAL.IRepository;
using YamlDotNet.Core.Tokens;
using MatchLeauge.DAL.MLContext;
using MatchLeauge.DAL.IUnitOfWork;
using MatchLeauge.DAL.DTO;


namespace MatchLeauge.API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class LeagueController : BaseController
    {
        ILeagueRepository _leagueRepository;
        IUnitOfWork _unitOfWork;

        public LeagueController(ILeagueRepository leagueRepository, IUnitOfWork unitOfWork)
        {
            _leagueRepository = leagueRepository;
            _unitOfWork = unitOfWork;
        }

        //endpoint=> api/League/LeagueIndex...
        [HttpGet]
        public IActionResult LeagueIndex()
        {
            var list = _leagueRepository.GetAll();
            if (list != null)
            {
                return ResultAPI(list);
            }
            return ResultAPI(204);
        }


        //[HttpPost]//=>https://localhost:7046/api/LeagueInsert"
        [HttpPost("AddLeague")]//=>https://localhost:7046/api/AddLeague"
        public IActionResult LeagueInsert(League league)
        {
            //League league = new League();
            //league.LeagueName= leagueDTO.LeagueName;

            var add = _leagueRepository.LeagueAdd(league);
           var result=_unitOfWork.CommitXX();

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
