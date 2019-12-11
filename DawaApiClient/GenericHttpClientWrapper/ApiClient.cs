using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Dawa.Api.Client.GenericHttpClientWrapper
{
    internal class ApiClient : IDisposable
    {
        private readonly HttpClient _httpClient;

        public ApiClient() : this(new HttpClient()) { }

        public ApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ApiResponse<T>> GetResponse<T>(string url) where T : class, new()
        {
            var response = await _httpClient.GetAsync(url);
            var result = new ApiResponse<T>()
            {
                HttpStatusCode = response.StatusCode,
                ResponsePhrase = response.ReasonPhrase
            };
            if (!response.IsSuccessStatusCode)
            {
                return result;
            }
            var jsonResponse = await response.Content.ReadAsStringAsync();
            var jsonObj = JsonConvert.DeserializeObject<T>(jsonResponse);
            result.Result = jsonObj;

            return result;
        }

        public void Dispose()
        {
            _httpClient?.Dispose();
        }
    }
}
