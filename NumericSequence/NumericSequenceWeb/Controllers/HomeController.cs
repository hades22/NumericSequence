using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NumericSequenceCore;
using NumericSequenceWeb.Models;

namespace NumericSequenceWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly INumericSequenceService numService;
        public HomeController(INumericSequenceService numService)
        {
            this.numService = numService;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Result()
        {
            return View(new ResultViewModel());
        }

        [HttpPost]
        public ActionResult Result(int num)
        {
            numService.TheNumber = num;
            var model = new ResultViewModel()
            {
                Number = num,
                All = numService.All(),
                Even = numService.Even(),
                Odd = numService.Odd(),
                Multipler = numService.Multipler(),
                Fibonacci = numService.FibonacciGenerate()
            };
            return View(model);
        }
    }
}