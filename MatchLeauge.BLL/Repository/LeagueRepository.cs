using MatchLeauge.DAL.IRepository;
using MatchLeauge.DAL.MLContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchLeauge.BLL.Repository
{
    public class LeagueRepository : GenericRepository<League>, ILeagueRepository
    {
        public LeagueRepository(MatchLeagueDB matchLeagueDB) : base(matchLeagueDB)
        {
        }

        public League LeagueInsert(League league)
        {
            throw new NotImplementedException();
        }

     

        
    }
}
