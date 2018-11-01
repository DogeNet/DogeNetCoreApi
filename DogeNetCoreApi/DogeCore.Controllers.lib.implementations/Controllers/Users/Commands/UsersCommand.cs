using DogeNetCore.Controllers.lib.Controllers.Users.Commands;
using DogeNetCore.DataAccess.lib.implementations.EntityFramework.UsersRepository.Entities;
using DogeNetCore.DataAccess.lib.UsersRepository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DogeNetCore.Controllers.lib.Controllers.Users.Responses;

namespace DogeNetCore.Controllers.lib.implementations.Controllers.Users.Commands
{
    public class UsersCommand : IUsersCommand
    {
        private readonly IUsersRepository<User> _repository;

        public UsersCommand(IUsersRepository<User> repository)
        {
            _repository = repository;
        }

        public Task<int> AddScoreToUser(string username, int toAdd)
        {
            throw new NotImplementedException();
        }

        public Task AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetLeaderBoard()
        {
            throw new NotImplementedException();
        }

        public async Task<GetUserResponse> GetUser(string username)
        {
            var result = await _repository.FindAsync(username);
            return new GetUserResponse
            {
                user = result
            };
        }

        public async Task<GetUsersResponse> GetUsers()
        {
            var result =  await _repository.GetAll();
            return new GetUsersResponse
            {
                Users = result
            };
        }

        public Task<GetUsersResponse> GetUsers(IEnumerable<string> usernames)
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
