using MatchLeauge.DAL.MLContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchLeauge.DAL.IRepository
{
    public interface ILeagueRepository: IGenericRepository<League>
    {

        //CRUD
        League LeagueInsert(League league);
        List<League> LeagueList();


    }
}
