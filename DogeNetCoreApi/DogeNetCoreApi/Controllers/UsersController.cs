using DogeNetCore.Controllers.lib.Controllers.Users.Commands;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using DogeNetCore.Controllers.lib.Controllers.Users.Responses;

namespace DogeNetCoreApi.Controllers
{
    [Route("api/Users")]
    public class UsersController : Controller
    {
        private readonly IUsersCommand _command;

        public UsersController(IUsersCommand command)
        {
            _command = command;
        }
        // GET api/values
        [HttpGet]
        public async Task<GetUsersResponse> GetUsers()
        {
            return await _command.GetUsers();
        }

        [HttpGet("{username}")]
        public async Task<GetUserResponse> GetUser(string username)
        {
            return await _command.GetUser(username);
        }
    }
}
