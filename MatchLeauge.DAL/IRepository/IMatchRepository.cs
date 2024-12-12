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
        Match MatchAdd(Match match);
        Match MatchUpdate(Player match);
        Match MatchDelete(Match match);
        IQueryable<Match> MatchGetAll();
    }
}
