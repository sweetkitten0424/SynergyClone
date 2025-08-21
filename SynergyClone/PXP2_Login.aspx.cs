using System;
using System.Linq;
using System.Web.Security;
using SynergyClone.Data;
using SynergyClone.Models;

namespace SynergyClone
{
    public partial class PXP2_Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) return;
            string user = Request.Form["username"], pass = Request.Form["password"];
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass)) return;
            using (var db = new SynergyContext())
            {
                var hash = SimpleHash(pass);
                var u = db.Users.FirstOrDefault(x => x.Username==user && x.PasswordHash==hash && x.Role==UserRole.Staff);
                if (u!=null)
                {
                    FormsAuthentication.SetAuthCookie(u.Username, false);
                    Response.Redirect("~/Home/Default.aspx");
                }
                else Response.Write("<div style='color:red'>Invalid username or password</div>");
            }
        }

        static string SimpleHash(string input)
            => Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(input));
    }
}