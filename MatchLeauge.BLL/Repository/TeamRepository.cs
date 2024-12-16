using MatchLeauge.DAL.IRepository;
using MatchLeauge.DAL.IUnitOfWork;
using MatchLeauge.DAL.MLContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchLeauge.BLL.Repository
{
    public class TeamRepository : GenericRepository<Team>, ITeamRepository
    {
        IUnitOfWork _unitOfWork;
        public TeamRepository(MatchLeagueDB matchLeagueDB, IUnitOfWork unitOfWork) : base(matchLeagueDB)
        {
            _unitOfWork = unitOfWork;
        }

        public List<Team> Teamlist()
        {
            throw new NotImplementedException();
        }

        public Team TeamInsert(Team team)
        {
            try
            {
                if (!string.IsNullOrEmpty(team.Name))
                {
                    Add(team);
                    var result = _unitOfWork.Commit();
                    if (result > 0)
                    {
                        return team;
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

       

         public Team TeamDelete(Team team)
        {
            throw new NotImplementedException();
        }
        public Team TeamUpdate(Team team)
        {
            throw new NotImplementedException();
        }
    }
}
