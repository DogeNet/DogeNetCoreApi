using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DogeCore.Controllers.Lib.Controllers.Users.Commands;
using DogeCore.Controllers.Lib.Controllers.Users.Responses;
using Microsoft.AspNetCore.Mvc;

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
