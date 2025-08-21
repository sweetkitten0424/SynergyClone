using System;
using System.Linq;
using SynergyClone.Data;

namespace SynergyClone
{
    public partial class Announcements : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadAnnouncements();
            }
        }

        private void LoadAnnouncements()
        {
            using (var db = new SynergyContext())
            {
                var announcements = db.Announcements
                    .OrderByDescending(a => a.PostedDate)
                    .ToList();
                AnnouncementsGrid.DataSource = announcements;
                AnnouncementsGrid.DataBind();
            }
        }
    }
}