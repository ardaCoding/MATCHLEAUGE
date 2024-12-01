using MatchLeauge.DAL.MLContext.BaseEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchLeauge.DAL.MLContext
{
    public class Player : BaseTable
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Nationality { get; set; }//bütün ülkeleri tutmak lazım=>89
        public int PlayerPositionId { get; set; }

        public bool IsOnGame { get; set; } // oyuncu maçta oynayan bir oyuncu mu?  statüsü true mu?

        //#warning neden bu şekilde bir kodlama seçilmedi
        //[ForeignKey("teamId")]=>Neden??
        public int TeamId { get; set; }
    }

}
