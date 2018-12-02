using DogeNetCore.Controllers.lib.Controllers.Users.Commands.Users;
using DogeNetCore.Controllers.lib.Controllers.Users.Requests;
using DogeNetCore.Controllers.lib.Controllers.Users.Responses;
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
        /// <summary>
        /// Gets a list of all users
        /// </summary>
        [HttpGet]
        public async Task<GetUsersResponse> GetUsers()
        {
            return await _command.GetUsers();
        }

        /// <summary>
        /// Gets a specific users details based on username
        /// </summary>
        [HttpGet("{username}")]
        public async Task<GetUserResponse> GetUser(string username)
        {
            return await _command.GetUser(username);
        }

        /// <summary>
        /// Adds a user to the database
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> AddUser([FromBody]AddUserRequest request)
        {
            await _command.AddUser(request);
            return Ok();
        }

        /// <summary>
        /// Set the specified users score to the specified value
        /// </summary>
        [HttpPatch("{username}/Update")]
        public async Task<IActionResult> UpdateScore(string username, [FromBody] UpdateScoreRequest request)
        {
            if (await _command.UpdateUserScore(username, request.Score))
                return Ok();
            return NotFound();
        }
        /// <summary>
        /// Adds the specified value to the users score
        /// </summary>
        [HttpPatch("{username}/Add")]
        public async Task<IActionResult> AddScore(string username, [FromBody] AddScoreRequest request)
        {
            if (await _command.AddScoreToUser(username, request.Score))
                return Ok();
            return NotFound();
        }

    }
}
