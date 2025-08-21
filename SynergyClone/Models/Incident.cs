using System;

namespace SynergyClone.Models
{
    public class Incident
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string ActionTaken { get; set; }
    }
}