using MatchLeauge.DAL.DTO;
using MatchLeauge.DAL.MLContext;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MatchLeauge.WEB.APIService
{
    public class LeagueGetAPI
    {
        HttpClient _httpClient;

        public LeagueGetAPI(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async  Task<List<League>> GetAll()
        {
            //API linki=> End point=>
            var endPoint = "https://localhost:7046/api/League";

            var response = await _httpClient.GetFromJsonAsync<APIResponseDTO<List<League>>>(endPoint);
            //
            return response.Data;

        }

        public async Task<IQueryable<League>> GetAll2()
        {
            

            //APı linki=> End point=>
            var endPoint = "https://localhost:7046/api/League";

            var response = await _httpClient.GetFromJsonAsync<APIResponseDTO<IQueryable<League>>>(endPoint);
            //
            return response.Data;

        }


        public void LeagueInsert(League league)
        {

        }
    }
}
