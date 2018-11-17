using DogeNetCore.Controllers.lib.Controllers.Clips.Commands;
using DogeNetCore.Controllers.lib.Controllers.Clips.Requests;
using DogeNetCore.Controllers.lib.Controllers.Clips.Responses;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DogeNetCoreApi.Controllers
{
    [Route("api/Clips")]
    public class ClipsController : Controller
    {
        private readonly IClipsCommand _command;

        public ClipsController(IClipsCommand command)
        {
            _command = command;
        }
        // GET api/values
        [HttpGet]
        public async Task<GetClipsResponse> GetUsers()
        {
            return await _command.GetClips();
        }

        [HttpGet("{name}")]
        public async Task<GetClipsResponse> GetUser(string name)
        {
            return await _command.GetClip(name);
        }

        [HttpPost]
        public async Task<IActionResult> AddUser([FromBody]AddClipRequest request)
        {
            await _command.AddClip(request);
            return Ok();
        }
    }
}
