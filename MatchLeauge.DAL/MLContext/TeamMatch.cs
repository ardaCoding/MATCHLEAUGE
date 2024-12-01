using MatchLeauge.DAL.MLContext.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchLeauge.DAL.MLContext
{
    public class TeamMatch:BaseTable
    {
        public int TeamId { get; set; }
        public int MatchId { get; set; }
    }
}
