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
        Player PlayerAdd(Player player);
        Player PlayerUpdate(Player player);
        Player PlayerDelete(Player player);
        IQueryable<Player> PlayerGetAll();

    }
}
