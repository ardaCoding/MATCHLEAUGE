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
        int Team1Id { get; set; }
        int Team2Id { get; set; }
        byte Team1Score { get; set; }//Team1ScoreId
        byte Team2Score { get; set; }
        public DateTime MatchDate { get; set; }
        public int LeagueId { get; set; }
       public League League { get; set; }   


        

    }
}
