using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WWA_LAB2.Controllers
{
    public class LoanController : Controller
    {
        // GET: Calculation
        [HttpGet]
        public ActionResult LoanIndex()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LoanIndex(int years, double amount, double interest)
        {
            ViewData["years"] = years;
            ViewData["amount"] = amount;
            ViewData["interest"] = interest;

            for (int i = 0; i < years; i++)
            {
                amount += amount * (interest / 100);
            }

            ViewData["finalAmount"] = Convert.ToDecimal(amount).ToString("C");
            return View();
        }
    }
}