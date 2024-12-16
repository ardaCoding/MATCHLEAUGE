using AutoMapper;
using MatchLeauge.BLL.Repository;
using MatchLeauge.DAL.DTO;
using MatchLeauge.DAL.IRepository;
using MatchLeauge.DAL.IUnitOfWork;
using MatchLeauge.DAL.MLContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MatchLeauge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : BaseController
    {

        ITeamRepository _teamRepository;
        IUnitOfWork _unitOfWork;
        IMapper _mapper;
        public TeamController(ITeamRepository teamRepository, IUnitOfWork unitOfWork,IMapper mapper)
        {
            _mapper = mapper;
            _teamRepository = teamRepository;
            _unitOfWork = unitOfWork;
        }


        [HttpGet]
        public IActionResult TeamIndex()
        {
            var list = _teamRepository.GetAll();
            if (list != null)
            {
                return ResultAPI(list);
            }
            return ResultAPI(204);
        }



        [HttpPost("AddTeam")]//=>https://localhost:7046/api/AddTeam"
        public IActionResult TeamInsert(TeamDTO teamDTO)
        {

            var add = _teamRepository.TeamInsert(_mapper.Map<Team>(teamDTO));
            if (add != null)
            {
                return ResultAPI(add);
            }
            return NoContent();
        }

    }
}
