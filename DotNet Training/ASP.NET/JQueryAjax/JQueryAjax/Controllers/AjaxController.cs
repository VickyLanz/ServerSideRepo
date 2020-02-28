using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading;

namespace JQueryAjax.Controllers
{
    public class AjaxController : Controller
    {
        // GET: Ajax
        public ActionResult Index()
        {
            return View();
        }
        public string  GetCurrentTime()
        {
            Thread.Sleep(2000);
           
            return DateTime.Now.ToLongTimeString();
           
        }
    }
}