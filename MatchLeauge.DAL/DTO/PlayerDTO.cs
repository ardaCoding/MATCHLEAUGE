using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchLeauge.DAL.DTO
{
    public class PlayerDTO
    {
        public string PlayerName { get; set; }
        public string PlayerSurname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Nationality { get; set; }
        public int PlayerPositionId { get; set; }
        public int TeamId { get; set; }
    }
}
