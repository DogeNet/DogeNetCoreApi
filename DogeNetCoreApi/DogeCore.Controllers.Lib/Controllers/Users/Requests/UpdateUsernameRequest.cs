using DogeNetCore.Controllers.lib.Controllers.Clips.Requests;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace DogeNetCore.Controllers.lib.Controllers.Users.Requests
{
    [DataContract]
    public class UpdateUsernameRequest : BaseRequest
    {
        [DataMember, Required]
        public string NewUsername { get; set; }
    }
}
