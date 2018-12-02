using System.Collections.Generic;
using DogeNetCore.Controllers.lib.Controllers.Users.Data;

namespace DogeNetCore.Controllers.lib.Controllers.Users.Responses
{
    public class GetUsersResponse
    {
        /// <summary>
        /// A collection of user data
        /// </summary>
        public IEnumerable<User> Users { get; set; }
    }
}
