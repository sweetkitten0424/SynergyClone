using System;

namespace SynergyClone.Models
{
    public class Report
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedById { get; set; }
        public User CreatedBy { get; set; }
        public string ReportType { get; set; }
    }
}