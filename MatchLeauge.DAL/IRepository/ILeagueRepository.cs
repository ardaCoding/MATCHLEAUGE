using MatchLeauge.DAL.MLContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MatchLeauge.DAL.IRepository
{
    public interface ILeagueRepository: IGenericRepository<League>
    {

        League Add(League league);
        League Update(League league);
        League Delete(League league);
        IQueryable<League> GetAll();
        IQueryable<League> FindAll(Expression<Func<League, bool>> predicate);
        League GetById(int Id);
        //List<League> LeagueList();



    }
}
