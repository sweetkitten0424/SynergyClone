using System;

namespace SynergyClone.Models
{
    public class TestScore
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public string TestName { get; set; }
        public DateTime DateTaken { get; set; }
        public decimal Score { get; set; }
        public string Notes { get; set; }
    }
}