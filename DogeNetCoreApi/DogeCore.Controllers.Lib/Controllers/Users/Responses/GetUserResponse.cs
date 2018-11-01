using System;
using System.Collections.Generic;
using System.Text;
using DogeNetCore.DataAccess.lib.implementations.EntityFramework.UsersRepository.Entities;

namespace DogeNetCore.Controllers.lib.Controllers.Users.Responses
{
    public class GetUserResponse
    {
        public User user { get; set; }
    }
}
