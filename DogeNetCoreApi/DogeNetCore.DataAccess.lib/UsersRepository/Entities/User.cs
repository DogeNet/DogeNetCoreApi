using System;
using System.ComponentModel.DataAnnotations;

namespace DogeCore.Controllers.Lib.Entities.Users
{
    public class User
    {

        [Key]
        public Guid Id { get; set; }
        [Required,MaxLength(24)]
        public string Username { get; set; }
        [Required]
        public int Score { get; set; }
    }
}
