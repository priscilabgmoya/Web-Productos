using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication5.Controllers
{
    // obj es el que esta recibiendo solicitudes y peticiones de la misma. 
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult OfertasDelMes()
        {
            // obtener las ofertas del mes desde la db 
            // ViewBag.Ofertas = ArrayOfertas; 
            return View();
        }
        public ActionResult About()
        {
            // obj dinamico, 
            ViewBag.Message = "Your application description page. this is prueba";
            ViewBag.Saludo = "Hola Mundo!";
            ViewBag.Adios = "Nos vemos!"; 
            // devuelve el archivo About.cshtml
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}