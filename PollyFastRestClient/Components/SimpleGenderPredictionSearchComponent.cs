using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace PollyFastRestClient.Components
{
    public class SimpleGenderPredictionSearchComponent : ISearchComponent
    {
        public async Task<string> Search(string name)
        {
            using var httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://api.genderize.io/"),
                DefaultRequestHeaders =
                {
                    { "User-Agent", "PollyFastHttpClient" }
                }
            };

            return await httpClient.GetStringAsync($"?name={name}");
        }
    }
}
