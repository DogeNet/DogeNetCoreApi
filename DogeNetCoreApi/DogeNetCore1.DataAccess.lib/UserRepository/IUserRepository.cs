using System.Threading.Tasks;
using DogeNetCore.DataAccess.lib.UserRepository.Entities;

namespace DogeNetCore.DataAccess.lib.UserRepository
{
    public interface IUserRepository <TEntity> : IRepository<TEntity, string>
    where TEntity : User
    {
        Task<bool> UpdateUsername(string currentUsername, string newUsername);
        Task<bool> UpdateScore(string username, int newScore);
        Task<bool> AddScore(string username, int scoreToAdd);
    }
}
