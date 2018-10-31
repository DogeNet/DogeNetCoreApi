using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DogeCore.Controllers.Lib.Entities.Users;

namespace DogeCore.Controllers.Lib.Services
{
    public interface IUsersRepository
    {
        /// <summary>
        /// Gets a collection of all user details
        /// </summary>
        /// <returns>Users</returns>
        Task<IEnumerable<User>> GetUsers();
        /// <summary>
        /// Gets a collection of all user details ordered by score desc
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<User>> GetLeaderboard();
        /// <summary>
        /// Gets a collection of all user details whose Id is specified
        /// </summary>
        /// <param name="userIds">a collection of users to be obtained</param>
        /// <returns>Users</returns>
        Task<IEnumerable<User>> GetUsers(IEnumerable<Guid> userIds);
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
        /// <param name="userId">the user to be removed</param>
        /// <returns></returns>
        Task RemoveUser(Guid userId);
        /// <summary>
        /// Updates the User's username
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="username"></param>
        /// <returns></returns>
        Task UpdateUsername(Guid userId, string username);
        /// <summary>
        /// Adds the number to the specified users score, can be negative
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="toAdd">number to add, can be negative</param>
        /// <returns>the new score</returns>
        Task<int> AddScoreToUser(Guid userId, int toAdd);
        /// <summary>
        /// Updates the specified user's score to a specific value
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="newScore"></param>
        /// <returns></returns>
        Task UpdateUserScore(Guid userId, int newScore);
        bool Save();
    }
}
