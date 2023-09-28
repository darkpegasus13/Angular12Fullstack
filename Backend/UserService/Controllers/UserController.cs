using CatalogService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserService.Clients;

namespace UserService.Controllers
{
    [Route("Users")]
    [ApiController]
    public class UserController : Controller
    {
        List<UserDTO> customers;
        private readonly DestinationsClient destinationsClient;
        public UserController(DestinationsClient _destinationsClient)
        {
            destinationsClient = _destinationsClient;
            customers = new List<UserDTO>
            {
                new UserDTO() { Id=1, Name="j",Email= "j@gmail.com",Password= "pass" }
            };
        }

        [HttpGet]
        public async Task<IEnumerable<dynamic>> Get()
        {
            var destinations = await destinationsClient.getUserMapping();

            var res = new List<dynamic>() {destinations.Select(x=>x),customers.Select(x=>x.Name) };
            return res;
        }
    }
}
