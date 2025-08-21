using System;
using System.Linq;
using SynergyClone.Data;

namespace SynergyClone
{
    public partial class Health : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadHealthRecords();
            }
        }

        private void LoadHealthRecords()
        {
            using (var db = new SynergyContext())
            {
                var records = db.HealthRecords
                    .OrderByDescending(r => r.Date)
                    .ToList();
                HealthGrid.DataSource = records;
                HealthGrid.DataBind();
            }
        }
    }
}