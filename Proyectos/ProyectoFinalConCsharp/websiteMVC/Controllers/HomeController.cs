using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using websiteMVC.Models; ///agregado

namespace websiteMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult listarProductos()
        {
            Data.NorthwindEntities context = new Data.NorthwindEntities();
            List<websiteMVC.Models.Product> Productos = context.Products.ToList();  //add this line
            return View(Productos);
        }
        [HttpGet]
        public ActionResult CrearProducto()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CrearProducto(Product producto)
        {


            Data.NorthwindEntities ctx = new Data.NorthwindEntities();
            ctx.Products.Add(producto);
            ctx.SaveChanges();

            return RedirectToAction("ListarProductos");


        }
    }
}
