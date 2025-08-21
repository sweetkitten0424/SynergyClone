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
        public string Description { get; set; }
        public int TeacherId { get; set; }
        public User Teacher { get; set; }
        public string Period { get; set; }
        public string RoomNumber { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Assignment> Assignments { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}