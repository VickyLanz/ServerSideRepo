using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTMLHelpersAndModelBinding.Controllers
{
    public class HelpersController : Controller
    {
        // GET: Helpers
        public ActionResult Index()
        {
            //ViewBag.Message = "Hello Vicky_lanz Have a Fantastic day";
            return View();
        }
        [HttpPost]
        public ActionResult Calculate(string txtname, string txtquantity,string txtprice)
        {
            string ProductName = txtname;
            int Quantity = int.Parse(txtquantity);
            double Price = double.Parse(txtprice);

            double BillAmount = Quantity * Price;
            double Discount = BillAmount * 10 / 100;

            double Netamount = BillAmount - Discount;

            ViewBag.Name = ProductName;
            ViewBag.BillAmount = BillAmount;
            ViewBag.Discount = Discount;
            ViewBag.Total = Netamount;
          // return RedirectToAction("Index");
            return View("Index");
        }
        [HttpPost]
        public ActionResult Index(FormCollection  collection)
        {
            string ProductName = collection["txtname"];
            int Quantity = int.Parse(collection["txtquantity"]);
            double Price = double.Parse(collection["txtprice"]);

            double BillAmount = Quantity * Price;
            double Discount = BillAmount * 10 / 100;

            double Netamount = BillAmount - Discount;

            ViewBag.Name = ProductName;
            ViewBag.BillAmount = BillAmount;
            ViewBag.Discount = Discount;
            ViewBag.Total = Netamount;
          
            return View("Index");

            return View();
        }
    }
}