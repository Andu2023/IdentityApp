using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Models
{
    public class User:IdentityUser
    {
        [Required]
        public int FirstName { get; set; }
        [Required]
        public int LastName { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    }
}
