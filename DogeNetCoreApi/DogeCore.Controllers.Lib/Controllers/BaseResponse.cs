using DogeNetCore.Controllers.lib.Controllers.Clips.Data;
using System.Collections.Generic;
using System.Net.Http;

namespace DogeNetCore.Controllers.lib.Controllers.Clips.Responses
{
    public class BaseResponse : HttpResponseMessage
    {
        public Error Error { get; set; }
    }
}
