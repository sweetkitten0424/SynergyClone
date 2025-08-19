using System;
using System.Linq;
using System.Web.Security;
using SynergyClone.Data;
using SynergyClone.Models;

namespace SynergyClone
{
    public partial class PXP2_Login_Parent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string username = Request.Form["username"];
                string password = Request.Form["password"];

                if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
                {
                    using (var db = new SynergyContext())
                    {
                        string passwordHash = SimpleHash(password);

                        var user = db.Users.FirstOrDefault(u => u.Username == username && u.PasswordHash == passwordHash && u.Role == UserRole.Parent);

                        if (user != null)
                        {
                            FormsAuthentication.SetAuthCookie(user.Username, false);
                            Response.Redirect("~/ParentVUE/Dashboard.aspx");
                        }
                        else
                        {
                            Response.Write("<div style='color:red'>Invalid parent username or password</div>");
                        }
                    }
                }
            }
        }

        static string SimpleHash(string input)
        {
            return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(input));
        }
    }
}