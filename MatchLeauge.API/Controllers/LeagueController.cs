using Microsoft.AspNetCore.Mvc;

namespace MatchLeauge.API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class LeagueController : Controller
    {
        [HttpGet]
        public IActionResult LeagueIndex()
        {
            return View();
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
