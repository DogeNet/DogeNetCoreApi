using DogeNetCore.DataAccess.lib.Entities;

namespace DogeNetCore.DataAccess.lib.UsersRepository
{
    public interface IUsersRepository <TEntity> : IRepository<TEntity, string>
    where TEntity : class, IEntity<string>
    {
    }
}
