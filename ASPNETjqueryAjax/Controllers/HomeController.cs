using ASPNETjqueryAjax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNETjqueryAjax.Controllers
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

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult PruebaAjax() {
            return View();
        }
        public ActionResult Ejemplo1() //Queremos llegar acá usando ajax
        {
            return Content("Texto retorado desde la Acción Ejemplo1", "text/plain");
        }
        public ActionResult Ejemplo2(string nombreC)//Recibir un dato y enviar otro, previo proceso
        {
            return Content("Hola, bienvenido "+ nombreC, "text/plaint");
        }
        public ActionResult Ejemplo3()//envía un objeto a la página
        {
            Producto p = new Producto() {
                Id = "001",
                Nombre = "Sardinas",
                Precio = 12.5f
            };
            return Json(p,JsonRequestBehavior.AllowGet);
        }
        public ActionResult Ejemplo4()//Envía una lista de objetos a la página
        {
            List<Producto> productos = new List<Producto>() {
                new Producto()
            {
                Id = "001",
                Nombre = "Sardinas",
                Precio = 12.5f
            },
                new Producto()
            {
                Id = "002",
                Nombre = "Atún",
                Precio = 10f
            },
                new Producto()
            {
                Id = "003",
                Nombre = "Pan",
                Precio = 5f
            },
                new Producto()
            {
                Id = "004",
                Nombre = "Azúcar",
                Precio = 8.5f
            }
            };
            return Json(productos, JsonRequestBehavior.AllowGet);
        }
    }
}