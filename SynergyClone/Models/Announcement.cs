using System;

namespace SynergyClone.Models
{
    public class Announcement
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime PostedDate { get; set; }
        public int PostedById { get; set; }
        public User PostedBy { get; set; }
    }
}