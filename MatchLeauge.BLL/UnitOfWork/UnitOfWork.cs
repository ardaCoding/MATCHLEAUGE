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

        public int Commit()
        {
            return  _matchLeagueDB.SaveChanges();
        }

        //public int Commit()
        //{
        //   return  _matchLeagueDB.SaveChanges();
        //}
    }
}
