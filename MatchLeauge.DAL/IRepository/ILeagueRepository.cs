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

        League LeagueAdd(League league);
        League LeagueUpdate(League league);
        League LeagueDelete(League league);
        IQueryable<League> LeagueGetAll();
        //List<League> LeagueList();



    }
}
