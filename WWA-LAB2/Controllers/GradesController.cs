using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WWA_LAB2.Controllers
{
    public class GradesController : Controller
    {
        // GET: Grades
        [HttpGet]
        public ActionResult GradesIndex()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GradesIndex(FormCollection form)
        {
            double grade1 = double.Parse(form["grade1"]);
            double grade2 = double.Parse(form["grade2"]);
            double grade3 = double.Parse(form["grade3"]);

            if (grade1 < 0 || grade2 < 0 || grade3 < 0)
            {
                ViewData["Error"] = "The grade can not be below 0";
            }
            else
            {

                double average = (grade1 + grade2 + grade3) / 3;

                ViewData["average"] = Math.Round(average,2);

                if (average < 59)
                {
                    ViewData["finalGrade"] = "F";
                }
                else if (average < 70)
                {
                    ViewData["finalGrade"] = "D";
                }
                else if (average < 80)
                {
                    ViewData["finalGrade"] = "C";
                }
                else if (average < 90)
                {
                    ViewData["finalGrade"] = "B";
                }
                else if (average <= 100)
                {
                    ViewData["finalGrade"] = "A";
                }
            }

            return View();
        }
    }
}