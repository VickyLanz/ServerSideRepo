using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ddl.Items.Add("India");
                ddl.Items.Add("Bangladesh");
                ddl.Items.Add("Srilanka");
                ddl.Items.Add("Australia");
                ddl.Items.Add("England");
                ddl.Items.Add("South Africa");
                ddl.Items.Add("West Indies");
                ddl.Items.Add("New Zealand");
                ddl.Items.Add("India");
                CheckBoxList1.Items.Add("Swimming");
                CheckBoxList1.Items.Add("Listening Songs");
                CheckBoxList1.Items.Add("Running");
                CheckBoxList1.Items.Add("Reading");


            }
            if(Page.IsPostBack)
            {
                lbl.Text = null;
                for(int i=0;i<CheckBoxList1.Items.Count;i++)
                {
                    if (CheckBoxList1.Items[i].Selected)
                        lbl.Text += CheckBoxList1.Items[i].Text + "<br>";
                }
            }
            DateTime dt = DateTime.Today;
            Response.Write("Today's Date :" + dt);
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
           
            Response.Write("Successfully submited<br>");
            Response.Write("Hie Mr/Mrs " + txtName.Text+ "from " + txtAddress.Text + "to this tutorial");
            txtAddress.Text = null;
            txtName.Text = null;
        }

        protected void ddl_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            Response.Write("You have selected :" + ddl.Text+"<br>");
        }

        protected void cid_SelectionChanged(object sender, EventArgs e)
        {
            lbldate.Text = "You Have selected :" + cid.SelectedDate;
        }
    }
}