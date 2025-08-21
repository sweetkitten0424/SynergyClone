using System;
using System.Linq;
using SynergyClone.Data;

namespace SynergyClone
{
    public partial class Messages : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadMessages();
            }
        }

        private void LoadMessages()
        {
            using (var db = new SynergyContext())
            {
                var username = Context.User.Identity.Name;
                var user = db.Users.FirstOrDefault(u => u.Username == username);
                if (user == null) return;
                var messages = db.Messages
                    .Where(m => m.RecipientId == user.Id)
                    .OrderByDescending(m => m.SentDate)
                    .ToList();
                MessagesGrid.DataSource = messages;
                MessagesGrid.DataBind();
            }
        }
    }
}