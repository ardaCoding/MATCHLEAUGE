using MatchLeauge.DAL.MLContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MatchLeauge.DAL.IRepository
{
    public interface ITeamRepository:IGenericRepository<Team>
    {
        Team TeamInsert(Team team);
        Team TeamUpdate(Team team);
        Team TeamDelete(Team team);
        //Team GetById(int Id);

        List<Team> Teamlist();
        //IQueryable<Team> GetAll();
        //IQueryable<Team> FindAll(Expression<Func<Team, bool>> predicate);

    }
}
