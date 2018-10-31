using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DogeNetCore.DataAccess.lib.implementations.EntityFramework.UsersRepository.Entities;
using DogeNetCore.DataAccess.lib.UsersRepository;
using DogeNetCore.DataAccess.lib.UsersRepository.Entities;

namespace DogeNetCore.DataAccess.lib.implementations.EntityFramework.UsersRepository
{
    public class UsersRepositroy : BaseRespository<User, UsersContext, string>, IUsersRepository<User>
    {
        public UsersRepositroy(UsersContext context) : base(context)
        {
        }

    }
}
