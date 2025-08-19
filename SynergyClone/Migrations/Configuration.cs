using System.Data.Entity.Migrations;
using SynergyClone.Models;

namespace SynergyClone.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<SynergyClone.Data.SynergyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SynergyClone.Data.SynergyContext context)
        {
            context.Users.AddOrUpdate(
                u => u.Username,
                new User { Username="admin",    PasswordHash=SimpleHash("admin"),    Role=UserRole.Staff,   Email="admin@synergy.com" },
                new User { Username="teacher1", PasswordHash=SimpleHash("teacher1"), Role=UserRole.Teacher, Email="teacher1@synergy.com" },
                new User { Username="parent1",  PasswordHash=SimpleHash("parent1"),  Role=UserRole.Parent,  Email="parent1@synergy.com" },
                new User { Username="student1", PasswordHash=SimpleHash("student1"), Role=UserRole.Student, Email="student1@synergy.com" }
            );
        }

        private static string SimpleHash(string input)
        {
            return System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(input));
        }
    }
}