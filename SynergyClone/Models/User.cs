using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SynergyClone.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required, MaxLength(64)]
        public string Username { get; set; }

        [Required, MaxLength(128)]
        public string PasswordHash { get; set; }

        [Required, MaxLength(32)]
        public string FirstName { get; set; }

        [Required, MaxLength(32)]
        public string LastName { get; set; }

        [Required, MaxLength(128)]
        public string Email { get; set; }

        [Required]
        public UserRole Role { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        public DateTime? LastLoginDate { get; set; }
    }

    public enum UserRole
    {
        Student,
        Parent,
        Teacher,
        Staff,
        Admin
    }
}