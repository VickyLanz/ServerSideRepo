using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace STATEMANAGEMENT2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Employee Name :" + Request.Params["ename"]+"<br>");
            Response.Write("Employee Desig :" + Request.Params["edesig"]);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Add("Player ", txtmatch.Text);
            Session["Country"] = txtcountry;
            Session["Matches"] = txtmatch;
            Response.Write("WebForm3.aspx");
        }
    }
}