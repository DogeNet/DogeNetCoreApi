using DogeNetCore.DataAccess.lib.UsersRepository.Entities;
using System.Collections.Generic;
using DogeNetCore.DataAccess.lib.implementations.EntityFramework.UsersRepository.Entities;

namespace DogeCore.Controllers.Lib.Controllers.Users.Responses
{
    public class GetUsersResponse
    {
        public IEnumerable<User> Users { get; set; }
    }
}
