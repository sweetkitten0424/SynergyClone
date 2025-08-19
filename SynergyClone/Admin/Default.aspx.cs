using System;
namespace SynergyClone.Admin
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object s, EventArgs e)
        {
            if (!User.Identity.IsAuthenticated)
                Response.Redirect("~/PXP2_Login_Admin.aspx");
            lblWelcome.Text = "Welcome to Admin Console, " + Server.HtmlEncode(User.Identity.Name) + "!";
        }
    }
}