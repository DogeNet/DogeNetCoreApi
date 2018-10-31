using DogeNetCore.DataAccess.lib.Entities;
using System;

namespace DogeNetCore.DataAccess.lib.UsersRepository.Entities
{
    public interface IUser : IEntity<string>
    {
         Guid Id { get; set; }
         string Username { get; set; }
         int Score { get; set; }
    }
}
