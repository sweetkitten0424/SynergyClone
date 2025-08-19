using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SynergyClone.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required, MaxLength(64)]
        public string FirstName { get; set; }

        [Required, MaxLength(64)]
        public string LastName { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}