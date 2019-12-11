using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Dawa.Api.Client.GenericHttpClientWrapper;
using Dawa.Api.Model.Address.Flat;
using Dawa.Api.Model.Address.Mini;
using Dawa.Api.Model.Address.Nested;

namespace Dawa.Api.Client.DawaEndpoints
{
    public class DawaClient : IDisposable
    {
        private readonly ApiClient _client;

        public DawaClient() : this(new HttpClient()) { }

        public DawaClient(HttpClient httpClient)
        {
            _client = new ApiClient(httpClient);
        }

        public async Task<ApiResponse<List<DawaAdresse>>> CallAddressEndpoint(DawaAddressEndpointBuilder endpoint)
        {
            var result = await _client.GetResponse<List<DawaAdresse>>(endpoint.GenerateUrl());
            return result;
        }

        public async Task<ApiResponse<List<DawaAdresseMini>>> CallAddressEndpointMini(DawaAddressEndpointBuilder endpoint)
        {
            endpoint.UseMini();
            var result = await _client.GetResponse<List<DawaAdresseMini>>(endpoint.GenerateUrl());
            return result;
        }

        public async Task<ApiResponse<List<DawaAdresseFlad>>> CallAddressEndpointFlat(DawaAddressEndpointBuilder endpoint)
        {
            endpoint.UseFlat();
            var result = await _client.GetResponse<List<DawaAdresseFlad>>(endpoint.GenerateUrl());
            return result;
        }

        public void Dispose()
        {
            _client?.Dispose();
        }
    }
}
