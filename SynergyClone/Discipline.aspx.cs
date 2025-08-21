using System;
using System.Linq;
using SynergyClone.Data;

namespace SynergyClone
{
    public partial class Discipline : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDisciplineRecords();
            }
        }

        private void LoadDisciplineRecords()
        {
            using (var db = new SynergyContext())
            {
                var records = db.DisciplineRecords
                    .OrderByDescending(r => r.Date)
                    .ToList();
                DisciplineGrid.DataSource = records;
                DisciplineGrid.DataBind();
            }
        }
    }
}