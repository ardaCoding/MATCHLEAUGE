using MatchLeauge.BLL.Repository;
using MatchLeauge.DAL.IRepository;
using MatchLeauge.DAL.IUnitOfWork;
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
    }
}
