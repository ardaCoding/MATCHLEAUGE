using MatchLeauge.DAL.MLContext.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchLeauge.DAL.MLContext
{
    public class PlayerMatch : BaseTable
    {
        //4 sayfa fazla kod yapmak=> insert, list, delete ,detail, update
        public int PlayerId { get; set; }
        public int MatchId { get; set; }
    }
}
