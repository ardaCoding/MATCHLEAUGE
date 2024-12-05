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
        public Match Add(Match match)
        {
            throw new NotImplementedException();
        }

        public Match Delete(Match match)
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

        public Match Update(Player match)
        {
            throw new NotImplementedException();
        }

        public Match Update(Match entity)
        {
            throw new NotImplementedException();
        }

        IQueryable<Match> IMatchRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        IQueryable<Match> IGenericRepository<Match>.GetAll()
        {
            throw new NotImplementedException();
        }

        Match IMatchRepository.GetById(int Id)
        {
            throw new NotImplementedException();
        }

        Match IGenericRepository<Match>.GetById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
