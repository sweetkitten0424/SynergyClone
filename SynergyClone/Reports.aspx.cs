using System;
using System.Linq;
using SynergyClone.Data;

namespace SynergyClone
{
    public partial class Reports : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadReports();
            }
        }

        private void LoadReports()
        {
            using (var db = new SynergyContext())
            {
                var reports = db.Reports
                    .OrderByDescending(r => r.CreatedDate)
                    .ToList();
                ReportsGrid.DataSource = reports;
                ReportsGrid.DataBind();
            }
        }
    }
}