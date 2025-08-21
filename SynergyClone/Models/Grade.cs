using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SynergyClone.Models
{
    public class Grade
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int? AssignmentId { get; set; }
        public Assignment Assignment { get; set; }
        
        [Required]
        public decimal Score { get; set; }
        
        [Required]
        public decimal MaxScore { get; set; }

        [Required]
        public DateTime DateEntered { get; set; }
        public string Comments { get; set; }
    }
}