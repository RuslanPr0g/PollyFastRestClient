using ExamplePollyFastRestClient.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ExamplePollyFastRestClient.Services
{
    public class GenderService : IGenderService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public GenderService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<Gender> Predict(string name)
        {
            var httpClient = _httpClientFactory.CreateClient("GenderPrediction");
            var response = await httpClient.GetStringAsync($"?name={name}");

            return Gender.Male;
        }
    }
}
