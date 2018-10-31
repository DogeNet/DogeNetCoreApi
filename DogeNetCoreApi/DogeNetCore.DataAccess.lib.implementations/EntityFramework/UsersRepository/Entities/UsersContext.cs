using Microsoft.EntityFrameworkCore;

namespace DogeNetCore.DataAccess.lib.implementations.EntityFramework.UsersRepository.Entities
{
    public sealed class UsersContext : DbContext
    {
        public UsersContext(DbContextOptions options) :
            base(options)
        {
            Database.Migrate();
        }
        public DbSet<User> Users { get; set; }
    }
}
