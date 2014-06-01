using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementWebApplication
{
    public partial class SessionState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["counter"] == null)
            {
                Session["counter"] = 0;
            }
            int i = (int)Session["counter"];
            Session["counter"] = ++i;           
            label.Text = String.Format("You requested {0} pages.", i);
        }
    }
}