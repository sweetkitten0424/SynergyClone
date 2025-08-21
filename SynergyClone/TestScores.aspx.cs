using System;
using System.Linq;
using SynergyClone.Data;

namespace SynergyClone
{
    public partial class TestScores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadTestScores();
            }
        }

        private void LoadTestScores()
        {
            using (var db = new SynergyContext())
            {
                var scores = db.TestScores
                    .OrderByDescending(s => s.DateTaken)
                    .ToList();
                TestScoresGrid.DataSource = scores;
                TestScoresGrid.DataBind();
            }
        }
    }
}