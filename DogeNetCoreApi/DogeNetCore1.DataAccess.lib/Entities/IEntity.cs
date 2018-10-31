using System;
using System.ComponentModel.DataAnnotations;

namespace DogeNetCore.DataAccess.lib.Entities
{
    public interface IEntity<TKey>
    {
        [Key]
        TKey Key { get; }
    }
}
