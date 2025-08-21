using System;

namespace SynergyClone.Models
{
    public class DisciplineRecord
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public DateTime Date { get; set; }
        public string IncidentType { get; set; }
        public string Description { get; set; }
        public string ActionTaken { get; set; }
        public string StaffInvolved { get; set; }
    }
}