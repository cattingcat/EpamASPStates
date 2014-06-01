using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementWebApplication
{
    public partial class ViewControlState : System.Web.UI.Page
    {
        public int MyProperty
        {
            get
            {
              object o = ViewState["MyProperty"];
              return (o != null)? (int)o: 0;
            }
            set
            {
              ViewState["MyProperty"] = value;
            }
        }


        protected void Page_Load(object sender, EventArgs e)
        {            
            message.Text = String.Format("before setting value, MyProperty = {0}", MyProperty);

            if (!IsPostBack)
            {
                control.ViewStateText = "777";
                control.ControlStateText = "888";
                MyProperty = 6;
            }
        }
    }
}