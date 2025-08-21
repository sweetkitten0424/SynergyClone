using System;

namespace SynergyClone.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public DateTime Date { get; set; }
        public string Period { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}