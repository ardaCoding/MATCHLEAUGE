using MatchLeauge.DAL.DTO;
using MatchLeauge.DAL.MLContext;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Net.Http.Json;
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

        public async Task<List<League>> GetAll()
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
            return response.Data;
        }

        public async Task<League> LeagueInsert(LeagueDTO leagueDTO)
        {
            //APı linki=> End point=>
            var endPoint = "https://localhost:7046/api/League/AddLeague";

            var request = await _httpClient.PostAsJsonAsync(endPoint, leagueDTO);

            if (request == null)
            {
                return null;
            }
            var responseBody = await request.Content.ReadFromJsonAsync<APIResponseDTO<League>>();
            return responseBody.Data;

        }

        public async Task<LeagueDTO> GetLeagueById(int id)
        {
            ////swagger da olduğu gibi  'https://localhost:7046/api/League/GetLeagueById?Id=10' bu linki oluşturmak gereklidir
            var endPoint = "https://localhost:7046/api/League/GetLeagueById?Id=" ;
            //var endPoint = "https://localhost:7046/api/League/GetLeagueById?Id=" + id;
            //GetLeagueById
            var request = await _httpClient.GetAsync(endPoint + id);

            var responseBody=await request.Content.ReadAsStringAsync();//json

            if (request.IsSuccessStatusCode)
            {
                var getData = JsonConvert.DeserializeObject<LeagueDTO>(responseBody);
                return getData;
            }
            return null;
        }

        public async Task<LeagueDTO> LeagueUpdate(LeagueDTO leagueDTO)
        {
            var endPoint = "https://localhost:7046/api/League/LeagueUpdate";

            var request = await _httpClient.PutAsJsonAsync(endPoint, leagueDTO);
            var response=await  request.Content.ReadFromJsonAsync<APIResponseDTO<LeagueDTO>>();
            return response.Data;
        }
    }
}
