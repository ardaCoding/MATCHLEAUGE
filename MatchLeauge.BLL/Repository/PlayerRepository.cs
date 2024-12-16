using MatchLeauge.DAL.IRepository;
using MatchLeauge.DAL.IUnitOfWork;
using MatchLeauge.DAL.MLContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MatchLeauge.BLL.Repository
{
    public class PlayerRepository : GenericRepository<Player>, IPlayerRepository
    {
        IUnitOfWork _unitOfWork;
        public PlayerRepository(MatchLeagueDB matchLeagueDB, IUnitOfWork unitOfWork) : base(matchLeagueDB)
        {
            _unitOfWork = unitOfWork;
        }
        public Player PlayerAdd(Player player)
        {

            try
            {
                if (string.IsNullOrEmpty(player.Name))
                {
                    throw new ArgumentException("Oyuncu adı boş bırakılamaz.");
                }
                if (string.IsNullOrEmpty(player.Surname))
                {
                    throw new ArgumentException("Oyuncu soy adı boş bırakılamaz");
                }
                if (string.IsNullOrEmpty(player.Nationality))
                {
                    throw new ArgumentException("Oyuncu uyruğu boş bırakılamaz");
                }
                if (player.BirthDate == null || player.BirthDate == DateTime.MinValue)
                {
                    throw new ArgumentException("Oyuncunun doğum tarihi boş bırakılamaz.");
                }
                if (player.PlayerPositionId == null || player.PlayerPositionId <= 0)
                {
                    throw new ArgumentException("mevki boş kalamz");
                }


                Add(player);
#warning eklenecek yapı
                //unitOfWork eklenecek
                return player;

            }


            catch (Exception)
            {
                throw;
            }

        }


        public Player PlayerDelete(Player player)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Player> PlayerFindAll(Expression<Func<Player, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Player> PlayerGetAll()
        {
            throw new NotImplementedException();
        }

        public Player PlayerUpdate(Player player)
        {
            throw new NotImplementedException();
        }


    }
}


















