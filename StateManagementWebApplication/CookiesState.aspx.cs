using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementWebApplication
{
    public partial class CookiesState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies.Get("text") != null)
            {
                label.Text = "Old cookie: " + Request.Cookies.Get("text").Value;
            }
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("text", textBox.Text);
            Response.Cookies.Add(cookie);
            Response.Redirect("~/CookiesState.aspx");
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            
        }
    }
}