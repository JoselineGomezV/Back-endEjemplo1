using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Back_endEjemplo1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(); //Nos permite enviar datos del controlador a la vista
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.tem = "PWA IEVN 1002";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}