using MatchLeauge.BLL.Repository;
using MatchLeauge.DAL.IRepository;
using MatchLeauge.DAL.IUnitOfWork;
using MatchLeauge.DAL.MLContext;
using Microsoft.AspNetCore.Mvc;
using YamlDotNet.Core.Tokens;

namespace MatchLeauge.API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class PlayerController : BaseController
    {
        IPlayerRepository  _playerRepository;
        IUnitOfWork _unitOfWork;
        public PlayerController(IPlayerRepository playerRepository, IUnitOfWork unitOfWork)
        {
             _playerRepository = playerRepository;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult PlayerIndex()
        {
            var list = _playerRepository.GetAll();
            if (list != null)
            {
                return ResultAPI(list);
            }
            return ResultAPI(204);
        }
        [HttpPost("AddPlayer")]//=>https://localhost:7046/api/AddPlayer"
        public IActionResult PlayerInsert(Player player)
        {
            //League league = new League();
            //league.LeagueName= leagueDTO.LeagueName;

            var add = _playerRepository.PlayerAdd(player);
            //var result = _unitOfWork.CommitXX();

            return View();
        }
    }
}
