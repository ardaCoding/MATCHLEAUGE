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
    public class MatchRepository : GenericRepository<Team>, IMatchRepository
    {
        public MatchRepository(MatchLeagueDB matchLeagueDB) : base(matchLeagueDB)
        {
        }

        public void Add(Match entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Match entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Match> FindAll(Expression<Func<Player, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Match> FindAll(Expression<Func<Match, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Match MatchAdd(Match match)
        {
            throw new NotImplementedException();
        }

        public Match MatchDelete(Match match)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Match> MatchGetAll()
        {
            throw new NotImplementedException();
        }

        public Match MatchGetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Match MatchUpdate(Player match)
        {
            throw new NotImplementedException();
        }

        public void Update(Match entity)
        {
            throw new NotImplementedException();
        }

        IQueryable<Match> IGenericRepository<Match>.GetAll()
        {
            throw new NotImplementedException();
        }

        Match IGenericRepository<Match>.GetById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
