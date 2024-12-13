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

        [NonAction]
        public IActionResult SelectResponseResult<TEntity>(APIResponseDTO<TEntity> responseDTO)
        {
            switch (responseDTO.StatuCode)
            {
                case 204:

                    return new ObjectResult(null)
                    {
                        StatusCode = responseDTO.StatuCode,
                    };

                //case 200:
                //    return new ObjectResult(null)
                //    {
                //        StatusCode = responseDTO.StatuCode,
                //    };

                default:

                    return new ObjectResult(responseDTO)
                    {
                        StatusCode = responseDTO.StatuCode,
                    };
            }
        }

        [NonAction]
        public IActionResult ResultAPI<TEntity>(List<TEntity> tEntity)
        {
            try
            {               

                if (tEntity.Count() > 0)
                {
                    return SelectResponseResult(APIResponseDTO<List<TEntity>>.Success(200, tEntity));//başarılı=> json içeriği vermem gerekiyor
                }
                else if (tEntity.Count() == 0)
                {
                    return SelectResponseResult(APIResponseDTO<List<TEntity>>.Fail(200, "Liste boş"));

                }
                return SelectResponseResult(APIResponseDTO<List<TEntity>>.Fail(201, "Hata"));

            }
            catch (Exception ex)
            {
                return SelectResponseResult(APIResponseDTO<List<TEntity>>.Success(204, tEntity));

            }
        }

        [NonAction]
        public IActionResult ResultAPI<TEntity>(TEntity tEntity)
        {
            try
            {
                if (tEntity!=null)
                {
                    return SelectResponseResult(APIResponseDTO<TEntity>.Success(200, tEntity));//başarılı=> json içeriği vermem gerekiyor
                }
                else if (tEntity==null)
                {
                    return SelectResponseResult(APIResponseDTO<TEntity>.Fail(200, "Liste boş"));

                }
                return SelectResponseResult(APIResponseDTO<TEntity>.Fail(201, "Hata"));

            }
            catch (Exception ex)
            {
                return SelectResponseResult(APIResponseDTO<TEntity>.Success(204, tEntity));

            }
        }

        //public void Test()
        //{
        //    //Session ları çeğırmak=> server
        //    //Cookie=> local
        //}

    }
}
