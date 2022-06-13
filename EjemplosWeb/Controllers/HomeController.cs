using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EjemplosWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GenerarID()
        {
            Random obo = new Random();
            //Genera un numero random del 0 al 999 con ceros antes; Ejemplo: 0023
            string result = obo.Next(0, 1000).ToString().PadLeft(4, '0');
            return Content(result);
        }
    }
}