using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchLeauge.DAL.IUnitOfWork
{
    public interface IUnitOfWork
    {
        void Commit();//Kayıt yapar
        int CommitXX();
    }
}
