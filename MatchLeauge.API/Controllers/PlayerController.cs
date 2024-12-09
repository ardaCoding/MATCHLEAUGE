using MatchLeauge.BLL.Repository;
using MatchLeauge.DAL.IRepository;
using Microsoft.AspNetCore.Mvc;
using YamlDotNet.Core.Tokens;

namespace MatchLeauge.API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class PlayerController : BaseController
    {
        IPlayerRepository  _playerRepository;
        public PlayerController(IPlayerRepository playerRepository)
        {
             _playerRepository = playerRepository;
        }

        [HttpGet]
        public IActionResult PlayerIndex()
        {

            return View();
        }
    }
}
