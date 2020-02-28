using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading;

namespace AjaxExample.Controllers
{
    public class AjaxController : Controller
    {
        // GET: Ajax
        public ActionResult Index()
        {
            return View();
        }
        public string GetTime()
        {
            Thread.Sleep(3000);
            return DateTime.Now.ToLongTimeString();
        }
    }
}