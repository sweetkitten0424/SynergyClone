using System.Data.Entity;
using SynergyClone.Models;

namespace SynergyClone.Data
{
    public class SynergyContext : DbContext
    {
        public SynergyContext() : base("name=SynergyConnection")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Attendance> Attendance { get; set; }
        public DbSet<DisciplineRecord> DisciplineRecords { get; set; }
        public DbSet<HealthRecord> HealthRecords { get; set; }
        public DbSet<TestScore> TestScores { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<CalendarEvent> CalendarEvents { get; set; }
        public DbSet<Incident> Incidents { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Schedule> Schedules { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configure many-to-many relationship between Student and Course
            modelBuilder.Entity<Student>()
                .HasMany(s => s.Courses)
                .WithMany(c => c.Students)
                .Map(m =>
                {
                    m.ToTable("StudentCourses");
                    m.MapLeftKey("StudentId");
                    m.MapRightKey("CourseId");
                });

            // Configure Teacher relationship
            modelBuilder.Entity<Course>()
                .HasRequired(c => c.Teacher)
                .WithMany()
                .HasForeignKey(c => c.TeacherId)
                .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }
    }
}