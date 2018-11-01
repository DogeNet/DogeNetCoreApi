using DogeNetCore.DataAccess.lib.implementations.EntityFramework.UsersRepository.Entities;
using DogeNetCore.DataAccess.lib.UsersRepository;
using DogeNetCore.DataAccess.lib.UsersRepository.Entities;
using Microsoft.EntityFrameworkCore;

namespace DogeNetCore.DataAccess.lib.implementations.EntityFramework.UsersRepository
{
    public class UsersRepository : BaseRepository<User, string>, IUsersRepository<User>
    {
        public UsersRepository(UsersContext context) : base(context)
        {
        }
    }
}
