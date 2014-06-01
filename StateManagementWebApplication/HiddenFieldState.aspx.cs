using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementWebApplication
{
    public partial class HiddenFieldState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Hello world!
            hiddenField.Value = "SGVsbG8gd29ybGQh";
        }
    }
}