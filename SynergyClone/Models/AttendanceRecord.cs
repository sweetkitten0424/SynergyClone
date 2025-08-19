using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SynergyClone.Models
{
    public enum AttendanceStatus { Present = 0, Absent = 1, Tardy = 2 }

    public class AttendanceRecord
    {
        public int Id { get; set; }
        public int StudentId { get; set; }

        [Required]
        public DateTime Date { get; set; }
        [Required]
        public AttendanceStatus Status { get; set; }

        [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }
    }
}