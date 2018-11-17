using DogeNetCore.Controllers.lib.Controllers.Users.Commands.Users;
using DogeNetCore.Controllers.lib.Controllers.Users.Requests;
using DogeNetCore.Controllers.lib.Controllers.Users.Responses;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DogeNetCore.DataAccess.lib.UserRepository;
using DogeNetCore.DataAccess.lib.UserRepository.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DogeNetCore.Controllers.lib.implementations.Controllers.Users.Commands
{
    public class UsersCommand : IUsersCommand
    {
        private readonly IUserRepository<User> _repository;

        public UsersCommand(IUserRepository<User> repository)
        {
            _repository = repository;
        }

        public async Task AddUser(AddUserRequest request)
        {
            var user = new User
            {
                Username = request.Username
            };
            await _repository.AddAsync(user);
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
                User = new lib.Controllers.Users.Data.User
                {
                    Score = result.Score,
                    Username = result.Username
                }
            };
        }

        public async Task<GetUsersResponse> GetUsers()
        {
            var result =  await _repository.GetAll();
            var users = new List<lib.Controllers.Users.Data.User>();
            foreach (var user in result)
            {
                users.Add(new lib.Controllers.Users.Data.User
                {
                    Username = user.Username,
                    Score = user.Score
                });
            }

            return new GetUsersResponse
            {
                Users = users
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

        public async Task<bool> UpdateUsername(string currentUsername, string newUsername)
        {
            return await _repository.UpdateUsername(currentUsername, newUsername);
        }

        public async Task<bool> UpdateUserScore(string username, int newScore)
        {
            return await _repository.UpdateScore(username, newScore);
        }

        public async Task<bool> AddScoreToUser(string username, int toAdd)
        {
            return await _repository.AddScore(username, toAdd);
        }
}
}
