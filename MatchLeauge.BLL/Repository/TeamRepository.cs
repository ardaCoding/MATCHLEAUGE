using MatchLeauge.DAL.IRepository;
using MatchLeauge.DAL.MLContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchLeauge.BLL.Repository
{
    public class TeamRepository : GenericRepository<Team>, ITeamRepository
    {
        public TeamRepository(MatchLeagueDB matchLeagueDB) : base(matchLeagueDB)
        {
        }

        public Team TeamDelete(Team team)
        {
            throw new NotImplementedException();
        }

        public Team TeamInsert(Team team)
        {
            throw new NotImplementedException();
        }

        public List<Team> Teamlist()
        {
            throw new NotImplementedException();
        }

        public Team TeamUpdate(Team team)
        {
            throw new NotImplementedException();
        }
    }
}
