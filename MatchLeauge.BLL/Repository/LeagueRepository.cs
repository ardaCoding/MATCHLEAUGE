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
    public class LeagueRepository : GenericRepository<League>, ILeagueRepository
    {
        IUnitOfWork _unitOfWork;
        public LeagueRepository(MatchLeagueDB matchLeagueDB, IUnitOfWork unitOfWork) : base(matchLeagueDB)
        {
            _unitOfWork = unitOfWork;
        }




        public League LeagueAdd(League league)
        {
            try
            {
                if (!string.IsNullOrEmpty(league.LeagueName))
                {
                    Add(league);
                    var result = _unitOfWork.Commit();
                    if (result > 0)
                    {
                        return league;
                    }
                    return null;
                }
                return null;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public League LeagueDelete(League league)
        {
            throw new NotImplementedException();
        }

        public IQueryable<League> LeagueFindAll(Expression<Func<League, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IQueryable<League> LeagueGetAll()
        {
            throw new NotImplementedException();
        }

        public League LeagueUpdate(League league)
        {
            Update(league);
            var result = _unitOfWork.Commit();

            if (result > 0)
            {
                return league;
            }
            return null;

            //throw new NotImplementedException();
        }

        //public League GetLeagueById(int Id)
        //{
        //    return GetById(Id);
        //}
    }
}
