using DogeNetCore.DataAccess.lib.ClipsRepository.Entities;

namespace DogeNetCore.DataAccess.lib.ClipsRepository
{
    public interface IClipRepository <TEntity> : IRepository<TEntity, string>
    where TEntity : Clip
    {
    }
}
