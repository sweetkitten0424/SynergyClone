using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SynergyClone.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required, MaxLength(16)]
        public string CourseCode { get; set; }

        [Required, MaxLength(128)]
        public string Title { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}