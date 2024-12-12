using MatchLeauge.DAL.IUnitOfWork;
using MatchLeauge.DAL.MLContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchLeauge.BLL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {

        protected readonly MatchLeagueDB _matchLeagueDB;
        public UnitOfWork(MatchLeagueDB matchLeagueDB)
        {
            _matchLeagueDB = matchLeagueDB;
        }

        public void Commit()
        {
             _matchLeagueDB.SaveChanges();
        }

        public int CommitXX()
        {
           return  _matchLeagueDB.SaveChanges();
        }
    }
}
