using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IgnisLab.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.Message = "Your application description page.";
            ViewBag.Message = "Mensaje de prueba!!!";
            ViewBag.Message = "Mensaje de prueba 2.0 !!!";
            ViewBag.Message = "Mensaje de prueba 3.0 !!!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}