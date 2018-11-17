using DogeNetCore.Controllers.lib.Controllers.Clips.Requests;
using DogeNetCore.Controllers.lib.Controllers.Clips.Responses;
using DogeNetCore.Controllers.lib.Controllers.Users.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;
using DogeNetCore.DataAccess.lib.UserRepository.Entities;

namespace DogeNetCore.Controllers.lib.Controllers.Clips.Commands
{
    public interface IClipsCommand
    {
        /// <summary>
        /// Gets a collection of all user details
        /// </summary>
        /// <returns>Users</returns>
        Task<GetClipsResponse> GetClips();

        /// <summary>
        /// Gets a collection of all user details whose Id is specified
        /// </summary>
        /// <param name="usernames">a collection of users to be obtained</param>
        /// <returns>Users</returns>
        Task<GetClipsResponse> GetUsers(IEnumerable<string> usernames);

        /// <summary>
        /// Gets a collection of all user details ordered by score desc
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<User>> GetLeaderBoard();

        /// <summary>
        /// Gets a specific Clip
        /// </summary>
        /// <returns>Clip</returns>
        Task<GetClipsResponse> GetClip(string name);

        /// <summary>
        /// Adds a clip to the table
        /// </summary>
        /// <param name="clip">the clip to be added</param>
        /// <returns></returns>
        Task AddClip(AddClipRequest clip);

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
        /// <param name="username"></param>
        /// <param name="newScore"></param>
        /// <returns></returns>
        Task UpdateUserScore(string username, int newScore);

        bool Save();
    }
}
