using System;
using Newtonsoft.Json;
using System.Net.Http;
using SeasonAPISport.Models;
using System.Threading.Tasks;
using SeasonAPISport.Services;


namespace SeasonAPISport.Services
{
    public class SeasonLAPIService : ISeasonLAPIService

    {
        public async Task<SeasonInfo> GetSeasonInfoAsync()
        {
            SeasonInfo season = null;
            var client = new HttpClient(); 
            var request = new HttpRequestMessage 
            { 
                Method = HttpMethod.Get, 
                RequestUri = new Uri("https://sportscore1.p.rapidapi.com/seasons"), 
                Headers = 
                { 
                    { "x-rapidapi-key", "8aaee18d33msh73133a98dbb4908p146d53jsn17633aea599f" }, 
                    { "x-rapidapi-host", "sportscore1.p.rapidapi.com" }, 
                }, 
            };
            var response = await client.SendAsync(request);
            if  (response.IsSuccessStatusCode)
            {
                season = JsonConvert.DeserializeObject<SeasonInfo>(await response.Content.ReadAsStringAsync());
                    
            }
            return season;
        }
    }
}
