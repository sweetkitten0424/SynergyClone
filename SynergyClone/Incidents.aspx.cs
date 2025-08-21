using System;
using System.Linq;
using SynergyClone.Data;

namespace SynergyClone
{
    public partial class Incidents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadIncidents();
            }
        }

        private void LoadIncidents()
        {
            using (var db = new SynergyContext())
            {
                var incidents = db.Incidents
                    .OrderByDescending(i => i.Date)
                    .ToList();
                IncidentsGrid.DataSource = incidents;
                IncidentsGrid.DataBind();
            }
        }
    }
}