using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApplication
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                lbox.Items.Add("John Snow");
                lbox.Items.Add("Arya Stark");
                lbox.Items.Add("Sansa Stark");
                lbox.Items.Add("Sofield");
                lbox.Items.Add("Ra's Al Ghu");
                lbox.Items.Add("Vicky Lanz");
                lbox.Items.Add("Stark");

            }
        }

        protected void lbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            lbl.Text = null;
            for(int i=0;i<lbox.Items.Count;i++)
            {
                if(lbox.Items[i].Selected)
                {
                    lbl.Text += lbox.Items[i];
                }
            }
        }
    }
}