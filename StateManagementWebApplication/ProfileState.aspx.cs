using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Profile;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementWebApplication
{
    public partial class ProfileState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {           
        }


        protected void createBtn_Click(object sender, EventArgs e)
        {
            ProfileBase profile = ProfileBase.Create(nametextBox.Text);
            profile.SetPropertyValue("Email", emailTextBox.Text );
            profile.SetPropertyValue("Birthday", birthdayCalendar.SelectedDate);
            profile.Save();            
        }
        protected void showBtn_Click(object sender, EventArgs e)
        {
            ProfileBase profile = ProfileBase.Create(nametextBox.Text);
            emailTextBox.Text = profile.GetPropertyValue("Email").ToString();
            birthdayCalendar.SelectedDate = (DateTime)profile.GetPropertyValue("Birthday");
        }


        protected void Page_PreRender(object sender, EventArgs e)
        {           
        }
    }
}