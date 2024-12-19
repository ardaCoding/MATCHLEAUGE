using MatchLeauge.DAL.DTO;
using MatchLeauge.DAL.MLContext;
using Newtonsoft.Json;
using System.Net.Http;

namespace MatchLeauge.WEB.APIService
{
    public class TeamAPI
    {
        HttpClient _httpClient;

        public TeamAPI(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Team>> GetAll()
        {
            //API linki=> End point=>
            var endPoint = "https://localhost:7046/api/Team";

            var response = await _httpClient.GetFromJsonAsync<APIResponseDTO<List<Team>>>(endPoint);
            //
            return response.Data;
        }

        public async Task<Team> TeamInsert(TeamDTO teamDTO)
        {
            var endPoint = "https://localhost:7046/api/Team/AddTeam";
            var request = await _httpClient.PostAsJsonAsync(endPoint, teamDTO);

            if (request == null)
            {
                return null;
            }
            var responseBody = await request.Content.ReadFromJsonAsync<APIResponseDTO<Team>>();
            return responseBody.Data;
        }
        public async Task<TeamDTO> GetTeamById(int id)
        {
            var endPoint = "https://localhost:7046/api/Team/GetTeamById";
            var request = await _httpClient.GetAsync(endPoint + id);

            var responseBody = await request.Content.ReadAsStringAsync();

            if (request.IsSuccessStatusCode)
            {
                var getData = JsonConvert.DeserializeObject<TeamDTO>(responseBody);
                return getData;
            }
            return null;
        }
    }
}
