using System;
using System.Collections.Generic;
using System.Linq;
using CalculatorMVC.Models;
using System.Web.Mvc;

namespace CalculatorMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Calculator calc = new Calculator();
            return View(calc);
        }

        [HttpPost]
        public ActionResult Index(Calculator calc)
        {
            if (ModelState.IsValid)
            {
                calc.Calculate();
            }

            return View(calc);
        }
    }
}