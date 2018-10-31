using DogeNetCore.DataAccess.lib.UsersRepository.Entities;
using System.Collections.Generic;

namespace DogeCore.Controllers.Lib.Controllers.Users.Responses
{
    public class GetUsersResponse
    {
        public IEnumerable<IUser> Users { get; set; }
    }
}
