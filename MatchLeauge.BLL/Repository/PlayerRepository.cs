using MatchLeauge.DAL.IRepository;
using MatchLeauge.DAL.MLContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MatchLeauge.BLL.Repository
{
    public class PlayerRepository : GenericRepository<Team>
    {
        public PlayerRepository(MatchLeagueDB matchLeagueDB) : base(matchLeagueDB)
        {
        }

    }
}
