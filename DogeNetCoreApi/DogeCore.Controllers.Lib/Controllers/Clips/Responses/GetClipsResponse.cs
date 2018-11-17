
using System.Collections.Generic;
using DogeNetCore.Controllers.lib.Controllers.Clips.Data;

namespace DogeNetCore.Controllers.lib.Controllers.Clips.Responses
{
    public class GetClipsResponse : BaseResponse
    {
        public IEnumerable<Clip> Clips{ get; set; }
    }
}
