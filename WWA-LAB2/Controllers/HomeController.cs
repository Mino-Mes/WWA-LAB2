using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WWA_LAB2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult HomeIndex()
        {
            return View();
        }
    }
}