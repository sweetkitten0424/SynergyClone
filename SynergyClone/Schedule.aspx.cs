using System;
using System.Linq;
using SynergyClone.Data;

namespace SynergyClone
{
    public partial class Schedule : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadSchedules();
            }
        }

        private void LoadSchedules()
        {
            using (var db = new SynergyContext())
            {
                var schedules = db.Schedules
                    .ToList();
                ScheduleGrid.DataSource = schedules;
                ScheduleGrid.DataBind();
            }
        }
    }
}