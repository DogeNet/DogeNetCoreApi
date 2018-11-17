using System.Collections.Generic;
using DogeNetCore.Controllers.lib.Controllers.Users.Data;

namespace DogeNetCore.Controllers.lib.Controllers.Users.Responses
{
    public class GetUsersResponse
    {
        public IEnumerable<User> Users { get; set; }
    }
}
