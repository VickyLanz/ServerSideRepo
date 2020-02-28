using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace FirstWebApplication
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string constring, qrystring;
            SqlConnection sqlcon;
            SqlCommand sqlcmd;
            SqlDataReader dr;
            constring = "Data Source=BLT10141\\SQLEXPRESS2017;Initial Catalog=Northwind;Integrated Security=True;";
            sqlcon = new SqlConnection(constring);
            qrystring = "Select Country From Customers";
            sqlcon.Open();
            sqlcmd = new SqlCommand(qrystring, sqlcon);
            dr = sqlcmd.ExecuteReader();
            while(dr.Read())
            {
                ddl.Items.Add(dr[0].ToString());
            }


        }

        protected void ddl_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constring, qrystring;
            SqlConnection sqlcon;
            SqlCommand sqlcmd;
            SqlDataReader dr;
            DataSet ds;
            SqlDataAdapter da;
            constring = "Data Source=BLT10141\\SQLEXPRESS2017;Initial Catalog=Northwind;Integrated Security=True;";
            sqlcon = new SqlConnection(constring);
            qrystring = "Select * From Customers where Country='"+ddl.Text+"'";
            sqlcon.Open();
            sqlcmd = new SqlCommand(qrystring, sqlcon);
            ds = new DataSet();
            da = new SqlDataAdapter(sqlcmd);
            da.Fill(ds, "CustomersInfo");
            gv.DataSource = ds;
            gv.DataMember = "CustomersInfo";
            gv.DataBind();
            

        }
    }
}