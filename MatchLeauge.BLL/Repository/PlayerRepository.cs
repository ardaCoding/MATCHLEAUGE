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
    public class PlayerRepository : GenericRepository<Team>, IPlayerRepository
    {
        public PlayerRepository(MatchLeagueDB matchLeagueDB) : base(matchLeagueDB)
        {
        }

        public Player Add(Player player)
        {
            throw new NotImplementedException();
        }

        public Player Delete(Player player)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Player> FindAll(Expression<Func<Player, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Player Update(Player player)
        {
            throw new NotImplementedException();
        }

        IQueryable<Player> IPlayerRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        IQueryable<Player> IGenericRepository<Player>.GetAll()
        {
            throw new NotImplementedException();
        }

        Player IPlayerRepository.GetById(int Id)
        {
            throw new NotImplementedException();
        }

        Player IGenericRepository<Player>.GetById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
