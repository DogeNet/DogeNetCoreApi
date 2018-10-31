using DogeCore.Controllers.Lib.Controllers.Users.Commands;
using DogeCore.Controllers.Lib.Controllers.Users.Responses;
using DogeNetCore.DataAccess.lib.UsersRepository;
using DogeNetCore.DataAccess.lib.UsersRepository.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DogeNetCore.Controllers.lib.implementations.Controllers.Users.Commands
{
    public class UsersCommand : IUsersCommand
    {
        private readonly IUsersRepository<IUser> _repository;

        public UsersCommand(IUsersRepository<IUser> repository)
        {
            _repository = repository;
        }

        public Task<int> AddScoreToUser(string username, int toAdd)
        {
            throw new NotImplementedException();
        }

        public Task AddUser(IUser user)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<IUser>> GetLeaderboard()
        {
            throw new NotImplementedException();
        }

        public Task<IUser> GetUser(Guid userId)
        {
            throw new NotImplementedException();
        }

        public async Task<GetUsersResponse> GetUsers()
        {
            var result =  await _repository.GetAll();
            return new GetUsersResponse
            {
                Users = result
            };
        }

        public Task<GetUsersResponse> GetUsers(IEnumerable<Guid> userIds)
        {
            throw new NotImplementedException();
        }

        public Task RemoveUser(string username)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public Task UpdateUsername(string currentUsername, string newUsername)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUserScore(string username, int newScore)
        {
            throw new NotImplementedException();
        }
    }
}
