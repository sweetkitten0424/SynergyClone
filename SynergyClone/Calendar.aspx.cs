using System;
using System.Linq;
using SynergyClone.Data;

namespace SynergyClone
{
    public partial class Calendar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCalendarEvents();
            }
        }

        private void LoadCalendarEvents()
        {
            using (var db = new SynergyContext())
            {
                var eventsList = db.CalendarEvents
                    .OrderBy(e => e.StartDate)
                    .ToList();
                CalendarGrid.DataSource = eventsList;
                CalendarGrid.DataBind();
            }
        }
    }
}