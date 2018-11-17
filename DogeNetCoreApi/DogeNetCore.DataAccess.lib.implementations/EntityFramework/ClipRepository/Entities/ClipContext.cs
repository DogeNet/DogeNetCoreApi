using DogeNetCore.DataAccess.lib.ClipsRepository.Entities;
using Microsoft.EntityFrameworkCore;

namespace DogeNetCore.DataAccess.lib.implementations.EntityFramework.ClipRepository.Entities
{
    public sealed class ClipContext : DbContext
    {
        public ClipContext(DbContextOptions<ClipContext> options) :
            base(options)
        {
            Database.Migrate();
        }
        public DbSet<Clip> Clips { get; set; }
    }
}
