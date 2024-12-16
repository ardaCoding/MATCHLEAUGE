using AutoMapper;
using MatchLeauge.DAL.DTO;
using MatchLeauge.DAL.MLContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchLeauge.BLL.MapperProfile
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<League, LeagueDTO>().ReverseMap();
            CreateMap<Team, TeamDTO>().ReverseMap();
            CreateMap<Player, PlayerDTO>().ReverseMap();

        }
    }
}
