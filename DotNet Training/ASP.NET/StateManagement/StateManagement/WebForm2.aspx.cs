using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ViewState["Company"] = "CTS";
            ViewState["Status"] = "Fortune 500 Company";
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            Response.Write("Successfully Submitted");
            Response.Write("Company Name =" + ViewState["Company"] + "</br>");
            Response.Write("Company Status :" + ViewState["Status"] + "</br>");

        }
    }
}