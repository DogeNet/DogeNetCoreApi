using DogeCore.Controllers.Lib.Controllers.Users.Responses;
using DogeNetCore.Controllers.lib.Controllers.Users.Commands;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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
        public async Task<GetUsersResponse> Get()
        {
            return await _command.GetUsers();
        }
    }
}
