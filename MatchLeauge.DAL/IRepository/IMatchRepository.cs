using MatchLeauge.DAL.MLContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MatchLeauge.DAL.IRepository
{
    public interface IMatchRepository : IGenericRepository<Match>
    {
        Match Add(Match match);
        Match Update(Player match);
        Match Delete(Match match);
        IQueryable<Match> GetAll();
        IQueryable<Match> FindAll(Expression<Func<Player, bool>> predicate);
        Match GetById(int Id);
    }
}
