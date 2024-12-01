using MatchLeauge.DAL.MLContext.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchLeauge.DAL.MLContext
{
    public class Team:BaseTable  
    {
        public string Name { get; set; }    
        public byte Logo { get; set; }

        //public static readonly int MAX_PLAYER_COUNT = 28; // toplam kadroda 25 oyuncu kabul etmesi gerekiyor
        //db ye trigger yapılabilir 28 geçmemesi için yada bll katmanında bunun için koşul yazılır

    }
}
