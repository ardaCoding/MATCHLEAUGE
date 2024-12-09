using Microsoft.AspNetCore.Mvc;
using MatchLeauge.DAL.DTO;

namespace MatchLeauge.API.Controllers
{
    public class BaseController : Controller
    {


        //gönder
        //alabilir
        //aldın=>FB Oyuncularu tablo=> list
        //Aldın=> Alex bilgiler=> nesne

        public IActionResult SelectResponseResult<TEntity>(APIResponseDTO<TEntity> responseDTO)
        {
            switch (responseDTO.StatuCode)
            {
                case 204:

                    return new ObjectResult(null)
                    {
                        StatusCode = responseDTO.StatuCode,
                    };

                default:

                    return new ObjectResult(responseDTO)
                    {
                        StatusCode = responseDTO.StatuCode,
                    };
            }
        }

        public IActionResult ResultAPI<TEntity>(IQueryable<TEntity> tEntity)
        {
            try
            {
                if (tEntity.Count()>0)
                {
                    return SelectResponseResult(APIResponseDTO<List<TEntity>>.Success(200));
                }
                else if (tEntity.Count()==0)
                {
                    
                }
                return SelectResponseResult(APIResponseDTO<List<TEntity>>.Success(204));
                
                }
            catch (Exception ex)
            {
                return SelectResponseResult(APIResponseDTO<List<TEntity>>.Success(204));

            }


        }

        public IActionResult ResultAPI<TEntity>(TEntity tEntity)
        {
            try
            {
                if (tEntity != null)
                {
                    return SelectResponseResult(APIResponseDTO<List<TEntity>>.Success(200));
                }
               
                return SelectResponseResult(APIResponseDTO<List<TEntity>>.Fail(204,"Hatalı"));

            }
            catch (Exception ex)
            {
                return SelectResponseResult(APIResponseDTO<List<TEntity>>.Fail(204,"Nesne boş"));

            }


        }

    }
}
