using CatalogService.Models;

namespace UserService.Clients
{
    public class DestinationsClient
    {
        private HttpClient _httpClient;

        //creating a client for synchronous inter service communication
        public DestinationsClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }  

        public async Task<IReadOnlyCollection<Destination>> getUserMapping()
        {
            var destinations = await _httpClient.GetFromJsonAsync<IReadOnlyCollection<Destination>>("/Destinations");
            return destinations;
        }
    }
}
