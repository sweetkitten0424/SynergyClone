using System;

namespace SynergyClone.Models
{
    public class HealthRecord
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public DateTime Date { get; set; }
        public string Issue { get; set; }
        public string Treatment { get; set; }
        public string Notes { get; set; }
    }
}