using System.ComponentModel.DataAnnotations;

namespace SynergyClone.Models
{
    public enum UserRole { Staff = 0, Teacher = 1, Parent = 2, Student = 3 }

    public class User
    {
        public int Id { get; set; }

        [Required, MaxLength(64)]
        public string Username { get; set; }

        [Required, MaxLength(128)]
        public string PasswordHash { get; set; }

        [Required]
        public UserRole Role { get; set; }

        [Required, MaxLength(128)]
        public string Email { get; set; }
    }
}