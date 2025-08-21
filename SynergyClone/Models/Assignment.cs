using System;
using System.Collections.Generic;

namespace SynergyClone.Models
{
    public class Assignment
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public decimal MaxScore { get; set; }
        public string Category { get; set; }
        public decimal Weight { get; set; }
        public virtual ICollection<Grade> Grades { get; set; }
    }
}