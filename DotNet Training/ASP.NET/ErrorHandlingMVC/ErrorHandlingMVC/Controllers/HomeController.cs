using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ErrorHandlingMVC.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            int a, b, c;
            a = 20;
            b = 0;
            c = a / b;
            return Content(c.ToString());
        }
        [CutomError]
        public ActionResult About()
        {
          //  ViewBag.Message = "Your application description page.";
            int a, b, c;
            a = 20;
            b = 0;
            c = a / b;
            return Content(c.ToString());
           // return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}