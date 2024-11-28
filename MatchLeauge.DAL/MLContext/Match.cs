using MatchLeauge.DAL.MLContext.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchLeauge.DAL.MLContext
{
    internal class Match : BaseTable
    {
        //public int Id { get; set; }
        int Team1Id { get; set; }
        int Team2Id { get; set; }
        byte Team1Score { get; set; }//Team1ScoreId
        byte Team2Score { get; set; }
        public DateTime MatchDate { get; set; }
        public string? StadiumName { get; set; }//StadiumId=> StadiumTable
#warning Match'larda LeagueId olacak mı
        //Match'larda LeagueId olması gerekli mi sonda bakılacak?????????????????
    }
}
