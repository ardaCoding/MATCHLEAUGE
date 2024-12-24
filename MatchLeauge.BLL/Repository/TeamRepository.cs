using MatchLeauge.DAL.IRepository;
using MatchLeauge.DAL.IUnitOfWork;
using MatchLeauge.DAL.MLContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MatchLeauge.BLL.Repository
{
    // logittech 500 serisi klavye
    public class TeamRepository : GenericRepository<Team>, ITeamRepository
    {
        IUnitOfWork _unitOfWork;
        public TeamRepository(MatchLeagueDB matchLeagueDB, IUnitOfWork unitOfWork) : base(matchLeagueDB)
        {
            _unitOfWork = unitOfWork;
        }

        public List<Team> Teamlist()
        {
            var lst = GetAll();
            throw new NotImplementedException();
        }

        public Team TeamInsert(Team team)
        {
            try
            {
                if (string.IsNullOrEmpty(team.Logo.ToString()))
                {
                    throw new ArgumentException("Logo boş bırakılamaz.");
                }

                if (string.IsNullOrEmpty(team.Name))
                {
                    throw new ArgumentException("Takım ismi boş bırakılamaz.");
                }

                Add(team);

                var result = _unitOfWork.Commit();//Kayıt yoksa 0 döner,kayıt varsa 1 döner
                if (result > 0)
                {
                    return team;
                }
                //else
                //{
                return null;
                //}
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
            Update(team);
            var result = _unitOfWork.Commit();

            if (result > 0)
            {
                return team;
            }
            return null;
        }
    }
}
