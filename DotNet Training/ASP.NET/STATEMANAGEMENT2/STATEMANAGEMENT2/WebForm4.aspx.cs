using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace STATEMANAGEMENT2
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.IsPostBack)
            {
                Application["hits"] = (int)Application["hits"] + 1;
            }
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            Response.Write("this page has been Requested For " + Application["hits"] + "<br>number of users " + Application["users"]);
        }
    }
}