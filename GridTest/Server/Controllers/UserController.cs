using GridTest.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace GridTest.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly HttpClient _httpClient;

        public UserController(HttpClient httpClient) 
        {
            _httpClient = httpClient;
        }

        public async Task<DataModel> GetAllUsers()
        {
            DataModel result = new();
            try
            {
                result = await _httpClient.GetFromJsonAsync<DataModel>("https://randomuser.me/api/?results=1000&inc=gender,name,nat,email,cell,id");
            }
            catch(Exception e)
            {
                Console.WriteLine("---------------------------------------------------------------------------------");
                Console.WriteLine("---------------------------------------------------------------------------------");
                Console.WriteLine(e.Message);
            }

            return result;
        }
    }
}
