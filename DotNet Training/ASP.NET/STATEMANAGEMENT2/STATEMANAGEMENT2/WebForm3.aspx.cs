using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace STATEMANAGEMENT2
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Session ID :" + Session.SessionID + "<br>");
            Response.Write("Number of Session Variable:" + Session.Count + "<br>");

            Response.Write("Player= " + Session["Player"] + "<br>");
            Response.Write("Matchesr= " + Session["Matches"] + "<br>");
            Response.Write("Country= " + Session["Country"] + "<br>");

        }
    }
}