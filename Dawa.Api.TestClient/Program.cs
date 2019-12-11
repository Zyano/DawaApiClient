using System;
using System.Threading.Tasks;
using Dawa.Api.Client.DawaEndpoints;

namespace Dawa.Api.TestClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var client = new DawaClient();

            var endpoint = new DawaAddressEndpointBuilder();
            endpoint.AddFreeTextQuery("Olaf Rudes Vej 25 st. 6 8270");
            var result = await client.CallAddressEndpointMini(endpoint);

            Console.ReadLine();
        }
    }
}
