using MatchLeauge.DAL.MLContext.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchLeauge.DAL.MLContext
{
    public class League:BaseTable
    {
        public string LeagueName { get; set; }
        public ICollection<Match> LeaugeMatches { get; set; }
        //List <Team> TeamList { get; set; }


    }
}
