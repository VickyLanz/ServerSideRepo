using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace ErrorHandlingMVC
{
    public class CutomError : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            // base.OnException(filterContext);
            string cName = "Error occured in :" + filterContext.RouteData.Values["controller"].ToString();
            string aName = "Error in the Action Method :" + filterContext.RouteData.Values["action"].ToString();

            HandleErrorInfo model = new HandleErrorInfo(filterContext.Exception, cName, aName);
            ViewResult result = new ViewResult();
            result.ViewName = this.View;
            result.MasterName = this.Master;
            result.ViewData = new ViewDataDictionary<HandleErrorInfo>(model);
            result.TempData = filterContext.Controller.TempData;
            filterContext.Result = result;
            filterContext.ExceptionHandled = true;
            filterContext.HttpContext.Response.Clear();
            filterContext.HttpContext.Response.StatusCode = 500;
        }
    }
}