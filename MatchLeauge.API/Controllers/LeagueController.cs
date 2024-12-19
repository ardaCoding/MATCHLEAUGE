using Microsoft.AspNetCore.Mvc;
using MatchLeauge.BLL.Repository;
using MatchLeauge.DAL.IRepository;
using YamlDotNet.Core.Tokens;
using MatchLeauge.DAL.MLContext;
using MatchLeauge.DAL.IUnitOfWork;
using MatchLeauge.DAL.DTO;
using AutoMapper;


namespace MatchLeauge.API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class LeagueController : BaseController
    {
        ILeagueRepository _leagueRepository;
        IUnitOfWork _unitOfWork;
        IMapper _mapper;

        public LeagueController(ILeagueRepository leagueRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _leagueRepository = leagueRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
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
        public IActionResult LeagueInsert(LeagueDTO leagueDTO)
        {
            #region 1.Hali
            //League league = new League();
            //league.LeagueName = leagueDTO.LeagueName;
            /*
            */
            //var add = _leagueRepository.LeagueAdd(league);//İsim, DTarihi, KayıtTarihi, Maaş,...=> RAM 
            //var add = _leagueRepository.LeagueAdd(_mapper.Map<League>(leagueDTO));
            //var result = _unitOfWork.Commit();//Database(Server)//Id:7// 
            #endregion

            var add = _leagueRepository.LeagueAdd(_mapper.Map<League>(leagueDTO));
            if (add != null)
            {
                return Ok(add);
            }
            return NoContent();
        }

        [HttpPut("LeagueUpdate")]
        public IActionResult LeagueUpdate(LeagueDTO leagueDTO)//request-istek
        {
            var mapLeague = _mapper.Map<League>(leagueDTO);//DTO nesnesi League e dönüştürüldü
            var getLeague = _leagueRepository.LeagueUpdate(mapLeague);//Update
            var getLeagueDTO = _mapper.Map<LeagueDTO>(getLeague);//League'i 

            return Ok(getLeagueDTO);//response
        }

        [HttpGet("GetLeagueById")]
        public IActionResult GetLeagueById(int Id)
        {
            var getLeague = _leagueRepository.GetById(Id);//Table getirir
            var getLeagueDTO = _mapper.Map<LeagueDTO>(getLeague);//table olan nesne DTO ya map edildi

            if (getLeague != null)
            {
                return Ok(getLeagueDTO);
            }
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
