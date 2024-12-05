using MatchLeauge.DAL.MLContext.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchLeauge.DAL.MLContext
{
    public class Match : BaseTable
    {
        //public int Id { get; set; }
        public int Team1Id { get; set; }
        public int Team2Id { get; set; }
        public byte Team1Score { get; set; }//Team1ScoreId
        public byte Team2Score { get; set; }
        public DateTime MatchDate { get; set; }
        public int LeagueId { get; set; }
        public League League { get; set; }

        public Team Teams1 { get; set; }
        public Team Teams2 { get; set; }



    }
}
