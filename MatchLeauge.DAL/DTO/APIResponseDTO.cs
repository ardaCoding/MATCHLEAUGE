using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchLeauge.DAL.DTO
{
    public class APIResponseDTO<TEntity>
    {
        public TEntity Data { get; set; }

        //200,300,400,500
        public  int StatuCode{ get; set; }

        public List<string> Errors{ get; set; }


        public static APIResponseDTO<TEntity> Success(int statuCode)
        {
            return new APIResponseDTO<TEntity> { StatuCode = statuCode };
        }
        public static APIResponseDTO<TEntity> Fail(int statuCode,string errors)
        {
            return new APIResponseDTO<TEntity> { StatuCode = statuCode, Errors = new List<string> { errors } };
        }


    }
}
