﻿using DogeCore.Controllers.Lib.Controllers.Users.Responses;
using DogeNetCore.DataAccess.lib.implementations.EntityFramework.UsersRepository.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DogeNetCore.Controllers.lib.Controllers.Users.Commands
{
    public interface IUsersCommand
    {
        /// <summary>
        /// Gets a collection of all user details
        /// </summary>
        /// <returns>Users</returns>
        Task<GetUsersResponse> GetUsers();

        /// <summary>
        /// Gets a collection of all user details whose Id is specified
        /// </summary>
        /// <param name="userIds">a collection of users to be obtained</param>
        /// <returns>Users</returns>
        Task<GetUsersResponse> GetUsers(IEnumerable<Guid> userIds);

        /// <summary>
        /// Gets a collection of all user details ordered by score desc
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<User>> GetLeaderBoard();

        /// <summary>
        /// Gets a specific User
        /// </summary>
        /// <param name="userId">The Users Id</param>
        /// <returns>User</returns>
        Task<User> GetUser(Guid userId);

        /// <summary>
        /// Adds a User to the table
        /// </summary>
        /// <param name="user">the user to be added</param>
        /// <returns></returns>
        Task AddUser(User user);

        /// <summary>
        /// Removes the specified user from the table
        /// </summary>
        /// <param name="username">the user to be removed</param>
        /// <returns></returns>
        Task RemoveUser(string username);

        /// <summary>
        /// Updates the User's username
        /// </summary>
        /// <param name="currentUsername"></param>
        /// <param name="newUsername"></param>
        /// <returns></returns>
        Task UpdateUsername(string currentUsername, string newUsername);

        /// <summary>
        /// Adds the number to the specified users score, can be negative
        /// </summary>
        /// <param name="username"></param>
        /// <param name="toAdd">number to add, can be negative</param>
        /// <returns>the new score</returns>
        Task<int> AddScoreToUser(string username, int toAdd);

        /// <summary>
        /// Updates the specified user's score to a specific value
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="newScore"></param>
        /// <returns></returns>
        Task UpdateUserScore(string username, int newScore);

        bool Save();
    }
}
