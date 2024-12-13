using MatchLeauge.DAL.DTO;
using MatchLeauge.DAL.MLContext;

namespace MatchLeauge.WEB.APIService
{
    public class PlayerAPI
    {
        HttpClient _httpClient;
        public PlayerAPI(HttpClient httpClient)
        {
             _httpClient = httpClient;
        }
        public async Task<List<Player>> GetAll()
        {
            //API linki=> End point=>
            var endPoint = "https://localhost:7046/api/Player";

            var response = await _httpClient.GetFromJsonAsync<APIResponseDTO<List<Player>>>(endPoint);
            //
            return response.Data;

        }
        public async Task<Player> PlayerInsert(Player player)
        {
            //APı linki=> End point=>
            var endPoint = "https://localhost:7046/api/AddPlayer";

            var response = await _httpClient.PostAsJsonAsync(endPoint, player);

            if (response == null)
            {
                return null;
            }
            var responseBody = await response.Content.ReadFromJsonAsync<APIResponseDTO<Player>>();
            return responseBody.Data;

        }


    }
}
