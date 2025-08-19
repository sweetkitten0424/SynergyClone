using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SynergyClone.Models
{
    public class Enrollment
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        [Required]
        public DateTime EnrollDate { get; set; }

        public string Grade { get; set; }

        [ForeignKey("StudentId")] public virtual Student Student { get; set; }
        [ForeignKey("CourseId")]  public virtual Course  Course  { get; set; }
        public virtual ICollection<Grade> Grades { get; set; }
    }
}