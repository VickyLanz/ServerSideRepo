using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace STATEMANAGEMENT2
{
    public partial class WebForm1 : System.Web.UI.Page
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie ck = new HttpCookie(ckname.Text, ckvalue.Text);
            Response.Cookies.Add(ck);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            foreach(string ck in Request.Cookies)
            {
                Response.Write("Cookie Name =" + Request.Cookies[ck].Name+"  ");
                Response.Write("Cookie Value =" + Request.Cookies[ck].Value+"<br>");

            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string name, desig;
            Response.Redirect("WebForm2.aspx?ename=" + txtename.Text + "&edesig=" + txtedesig.Text);
        }
    }
}