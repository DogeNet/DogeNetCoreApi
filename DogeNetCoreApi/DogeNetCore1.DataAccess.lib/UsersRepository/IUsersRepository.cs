using DogeNetCore.DataAccess.lib.UsersRepository.Entities;
using System.Threading.Tasks;

namespace DogeNetCore.DataAccess.lib.UsersRepository
{
    public interface IUsersRepository<TEntity> : IRepository<TEntity, string> where TEntity : IUser
    {
    }
}
