using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementWebApplication
{
    public partial class CacheState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Cache.Get("date") == null)
                Cache.Insert("date", DateTime.Now, null, DateTime.UtcNow.AddMinutes(2), Cache.NoSlidingExpiration);
            label.Text = String.Format("Now: {0}", Cache.Get("date"));
        }
    }
}