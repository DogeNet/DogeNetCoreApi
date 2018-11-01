using DogeNetCore.DataAccess.lib.UsersRepository.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using DogeNetCore.DataAccess.lib.Entities;

namespace DogeNetCore.DataAccess.lib.implementations.EntityFramework.UsersRepository.Entities
{
    public class User : IEntity<string>
    {
        [Key]
        public Guid Id { get; set; }
        [Required,MaxLength(24)]
        public string Username { get; set; }
        [Required]
        public int Score { get; set; }


        public string Key => Username;
    }
}
