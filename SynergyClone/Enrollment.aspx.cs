using System;
using System.Linq;
using SynergyClone.Data;

namespace SynergyClone
{
    public partial class Enrollment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadEnrollments();
            }
        }

        private void LoadEnrollments()
        {
            using (var db = new SynergyContext())
            {
                var enrollments = db.Enrollments.ToList();
                EnrollmentGrid.DataSource = enrollments;
                EnrollmentGrid.DataBind();
            }
        }
    }
}