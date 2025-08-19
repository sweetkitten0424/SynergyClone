using System.Data.Entity;
using SynergyClone.Models;

namespace SynergyClone.Data
{
    public class SynergyContext : DbContext
    {
        public SynergyContext() : base("SynergyDb") { }

        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<AttendanceRecord> AttendanceRecords { get; set; }
        public DbSet<Grade> Grades { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasMany(s => s.Enrollments)
                .WithRequired(e => e.Student)
                .HasForeignKey(e => e.StudentId);

            modelBuilder.Entity<Course>()
                .HasMany(c => c.Enrollments)
                .WithRequired(e => e.Course)
                .HasForeignKey(e => e.CourseId);

            modelBuilder.Entity<Enrollment>()
                .HasMany(e => e.Grades)
                .WithRequired(g => g.Enrollment)
                .HasForeignKey(g => g.EnrollmentId);

            base.OnModelCreating(modelBuilder);
        }
    }
}