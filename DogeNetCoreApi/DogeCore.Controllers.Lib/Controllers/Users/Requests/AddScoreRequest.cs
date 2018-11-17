using DogeNetCore.Controllers.lib.Controllers.Clips.Requests;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace DogeNetCore.Controllers.lib.Controllers.Users.Requests
{
    [DataContract]
    public class AddScoreRequest : BaseRequest
    {
        [DataMember, Required]
        public int Score { get; set; }
    }
}
