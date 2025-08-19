using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SynergyClone.Models
{
    public class Grade
    {
        public int Id { get; set; }
        public int EnrollmentId { get; set; }

        [Required]
        public decimal Score { get; set; }

        [Required]
        public DateTime DateRecorded { get; set; }

        [ForeignKey("EnrollmentId")]
        public virtual Enrollment Enrollment { get; set; }
    }
}