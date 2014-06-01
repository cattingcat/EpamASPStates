using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementWebApplication
{
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:WebCustomControl runat=server></{0}:WebCustomControl>")]
    public class WebCustomControl : WebControl
    {
        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        [Localizable(true)]
        public string ViewStateText
        {
            get
            {
                String s = (String)ViewState["Text"];
                return ((s == null) ? String.Empty : s);
            }

            set
            {
                ViewState["Text"] = value;
            }
        }
        public string ControlStateText { get; set; }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            Page.RegisterRequiresControlState(this);
        }

        protected override void RenderContents(HtmlTextWriter output)
        {
            output.Write("ViewState text: {0}, ControlStateText: {1}", ViewStateText, ControlStateText);
        }


        protected override void LoadControlState(object savedState)
        {
            ControlStateText = (string)savedState;
        }

        protected override object SaveControlState()
        {
            return ControlStateText;
        }

    }
}
