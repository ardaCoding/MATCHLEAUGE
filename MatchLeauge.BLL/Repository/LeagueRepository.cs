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
    public class LeagueRepository : GenericRepository<League>, ILeagueRepository
    {
        public LeagueRepository(MatchLeagueDB matchLeagueDB) : base(matchLeagueDB)
        {
        }

        public League LeagueAdd(League league)
        {
            try
            {
                if (string.IsNullOrEmpty(league.LeagueName))
                {
                    Add(league);
                    return league;
                }
                return null;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public League LeagueDelete(League league)
        {
            throw new NotImplementedException();
        }

        public IQueryable<League> LeagueFindAll(Expression<Func<League, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IQueryable<League> LeagueGetAll()
        {
            throw new NotImplementedException();
        }

        public League LeagueUpdate(League league)
        {
            throw new NotImplementedException();
        }
    }
}
