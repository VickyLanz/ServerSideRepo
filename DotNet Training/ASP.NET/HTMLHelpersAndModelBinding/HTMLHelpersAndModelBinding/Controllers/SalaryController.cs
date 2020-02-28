using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTMLHelpersAndModelBinding.Controllers
{
    public class SalaryController : Controller
    {
        // GET: Salary
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Salary(FormCollection c)
        {
            int nod = int.Parse(c["nod"]);
            double salary = Double.Parse(c["spd"]);
            double icp = double.Parse(c["icp"]);
            double s = salary * nod;
            double incentive = s * (icp / 100);
            double total = s + incentive;
            ViewBag.Salary = s;
            ViewBag.Incentive = incentive;
            ViewBag.Total = total;


            return View("Index");
        }
    }
}