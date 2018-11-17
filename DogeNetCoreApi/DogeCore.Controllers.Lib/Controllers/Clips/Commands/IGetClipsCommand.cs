using System.Collections.Generic;
using System.Threading.Tasks;
using DogeNetCore.Controllers.lib.Controllers.Clips.Responses;

namespace DogeNetCore.Controllers.lib.Controllers.Clips.Commands
{
    public interface IGetClipsCommand
    {
        Task<GetClipsResponse> GetClipsAsync();
        Task<GetClipsResponse> GetClipsAsync(string name);
        Task<GetClipsResponse> GetClipsAsync(IEnumerable<string> name);
    }
}
