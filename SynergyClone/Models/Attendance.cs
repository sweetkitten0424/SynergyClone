using System;

namespace SynergyClone.Models
{
    public class Attendance
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public DateTime Date { get; set; }
        public AttendanceStatus Status { get; set; }
        public string Notes { get; set; }
    }

    public enum AttendanceStatus
    {
        Present,
        Absent,
        Tardy,
        ExcusedAbsence
    }
}