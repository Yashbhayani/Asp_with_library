using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Librarymethode.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Class1 oop = new Class1();

            ViewBag.Message = "Your application description page. it is working fine okay." ;
            ViewBag.Yash = oop.test();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            Class1 oop = new Class1();

            int k = oop.data(12);
            ViewBag.UU = k;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}