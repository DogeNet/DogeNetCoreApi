using DogeNetCore.DataAccess.lib.ClipsRepository;
using DogeNetCore.DataAccess.lib.ClipsRepository.Entities;
using DogeNetCore.DataAccess.lib.implementations.EntityFramework.ClipRepository.Entities;
using Microsoft.EntityFrameworkCore;

namespace DogeNetCore.DataAccess.lib.implementations.EntityFramework.ClipRepository
{
    public class ClipRepository : BaseRepository<Clip, string>, IClipRepository<Clip>
    {
        public ClipRepository(ClipContext context) : base(context)
        {
        }
    }
}
 