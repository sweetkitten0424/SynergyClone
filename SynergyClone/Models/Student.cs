using System;
using System.Collections.Generic;

namespace SynergyClone.Models
{
    public class Student
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string StudentNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Grade { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Grade> Grades { get; set; }
        public virtual ICollection<Attendance> AttendanceRecords { get; set; }
    }
}