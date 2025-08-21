using System;
using System.Linq;
using System.Web.UI;
using SynergyClone.Data;
using SynergyClone.Models;

namespace SynergyClone.StudentVUE
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDashboard();
            }
        }

        private void LoadDashboard()
        {
            using (var db = new SynergyContext())
            {
                var username = Context.User.Identity.Name;
                var user = db.Users.FirstOrDefault(u => u.Username == username);
                
                if (user == null) return;

                var student = db.Students.FirstOrDefault(s => s.UserId == user.Id);
                if (student == null) return;

                StudentName.Text = $"{user.FirstName} {user.LastName}";

                // Load courses
                var courses = db.Courses
                    .Where(c => c.Students.Any(s => s.Id == student.Id))
                    .OrderBy(c => c.Period)
                    .ToList();
                CoursesGrid.DataSource = courses;
                CoursesGrid.DataBind();

                // Load recent assignments
                var assignments = db.Assignments
                    .Where(a => a.Course.Students.Any(s => s.Id == student.Id))
                    .OrderByDescending(a => a.DueDate)
                    .Take(10)
                    .ToList();
                AssignmentsGrid.DataSource = assignments;
                AssignmentsGrid.DataBind();

                // Load recent attendance
                var attendance = db.Attendance
                    .Where(a => a.StudentId == student.Id)
                    .OrderByDescending(a => a.Date)
                    .Take(10)
                    .ToList();
                AttendanceGrid.DataSource = attendance;
                AttendanceGrid.DataBind();
            }
        }

        protected string GetCourseGrade(object courseObj)
        {
            if (!(courseObj is Course course)) return "N/A";

            using (var db = new SynergyContext())
            {
                var username = Context.User.Identity.Name;
                var user = db.Users.FirstOrDefault(u => u.Username == username);
                if (user == null) return "N/A";

                var student = db.Students.FirstOrDefault(s => s.UserId == user.Id);
                if (student == null) return "N/A";

                var grades = db.Grades
                    .Where(g => g.StudentId == student.Id && g.CourseId == course.Id)
                    .ToList();

                if (!grades.Any()) return "N/A";

                var weightedTotal = grades.Sum(g => (g.Score / g.MaxScore) * g.Assignment.Weight);
                var weightSum = grades.Select(g => g.Assignment).Sum(a => a.Weight);

                if (weightSum == 0) return "N/A";

                var percentage = (weightedTotal / weightSum) * 100;
                return $"{percentage:F1}%";
            }
        }

        protected string GetAssignmentScore(object assignmentObj)
        {
            if (!(assignmentObj is Assignment assignment)) return "N/A";

            using (var db = new SynergyContext())
            {
                var username = Context.User.Identity.Name;
                var user = db.Users.FirstOrDefault(u => u.Username == username);
                if (user == null) return "N/A";

                var student = db.Students.FirstOrDefault(s => s.UserId == user.Id);
                if (student == null) return "N/A";

                var grade = db.Grades
                    .FirstOrDefault(g => g.StudentId == student.Id && g.AssignmentId == assignment.Id);

                if (grade == null) return "Not Graded";

                return $"{grade.Score}/{grade.MaxScore}";
            }
        }
    }
}