using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace STATEMANAGEMENT2
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            Application["users"] = 0;
            Application["hits"] = 0;
        }
        protected void Session_Start(object sender,EventArgs e)
        {
            Application.Lock();
            Application["users"] =(int)Application["users"]+ 1;
            Application.UnLock();
            
        }
        protected void Session_End(object sender,EventArgs e)
        {
            Application.Lock();
            Application["users"] = (int)Application["users"] -1;
            Application.UnLock();
        }
        protected void Application_End(object sender,EventArgs e)
        {
           
        }
    }
}