using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HTMLHelpersAndModelBinding.Models;


namespace HTMLHelpersAndModelBinding.Controllers
{
    public class BankController : Controller
    {
        // GET: Bank
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CalculateInterest(FormCollection c)
        {
            SavingsBank sb = new SavingsBank();
            sb.PrincipalAmount = double.Parse(c["PrincipalAmount"]);
            sb.TimeInYears = float.Parse(c["TimeInYears"]);
            sb.InterestRate = float.Parse(c["InterestRate"]);

            double simpleinterest = (sb.PrincipalAmount * sb.TimeInYears * sb.InterestRate) / 100;
            ViewBag.SI = simpleinterest;
            return View("Index");
        }

    }
}