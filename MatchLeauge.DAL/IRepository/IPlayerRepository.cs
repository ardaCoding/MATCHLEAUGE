using MatchLeauge.DAL.MLContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MatchLeauge.DAL.IRepository
{
    public interface IPlayerRepository:IGenericRepository<Player>
    {
        Player Add(Player player);
        Player Update(Player player);
        Player Delete(Player player);
        IQueryable<Player> GetAll();
        IQueryable<Player> FindAll(Expression<Func<Player, bool>> predicate);
        Player GetById(int Id);
    }
}
