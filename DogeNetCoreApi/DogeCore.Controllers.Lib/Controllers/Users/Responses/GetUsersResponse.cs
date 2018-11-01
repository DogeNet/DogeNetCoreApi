﻿using System.Collections.Generic;
using DogeNetCore.DataAccess.lib.implementations.EntityFramework.UsersRepository.Entities;

namespace DogeNetCore.Controllers.lib.Controllers.Users.Responses
{
    public class GetUsersResponse
    {
        public IEnumerable<User> Users { get; set; }
    }
}
