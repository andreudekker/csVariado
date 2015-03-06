using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AplicacionPruebaMVC.Controllers
{
    public class PerroController : Controller
    {
        //
        // GET: /Perro/

        public ActionResult Index()
        {
            ViewBag.apellido = "Sanchez";  //Parametros dinamicos desde el .Puedo escojer
            ViewData["Nombre es:"] = "Andreu";
            return View();
        }
        public ActionResult About()
        {
            return View();
        }


    }
}
