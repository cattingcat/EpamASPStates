using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementWebApplication
{
    public partial class QueryStringState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] arr = Request.QueryString.AllKeys;
            StringBuilder sb = new StringBuilder();
            foreach(var s in arr){
                sb.Append(s);
                sb.Append(" ");
            }
            label.Text = String.Format("query string have {0} keys: {1}", arr.Length, sb.ToString());
        }
    }
}