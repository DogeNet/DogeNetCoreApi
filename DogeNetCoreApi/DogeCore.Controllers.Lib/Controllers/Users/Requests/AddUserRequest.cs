using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace DogeNetCore.Controllers.lib.Controllers.Users.Requests
{
    [DataContract]
    public class AddUserRequest
    {
        [DataMember,Required]
        public string Username { get; set; }
    }
}
