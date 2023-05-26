using IDGS902_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS902_Tema1.Controllers
{
    public class PruebasController : Controller
    {
        // GET: Pruebas
        public ActionResult Index()
        {
            var idgs902 = new Alumnos(){ Nombre = "Mario", Email = "mar@gmail.com", Edad = 23};
            return Json(idgs902, JsonRequestBehavior.AllowGet);
            return Content("<h1>Index</h1>");    
            return View();
        }

        public RedirectResult Index2()
        {
            return Redirect("Index");
        }

        public RedirectToRouteResult Index3()
        {
            return RedirectToAction("OperasBas2", "Nuevo");
        }
        public ActionResult Index4()
        {
            ViewBag.Grupo = "IDGS902";
            ViewBag.Numero = 20;
            ViewBag.FechaInicio = new DateTime(2023,2,5);
            ViewData["Nombre"] = "Mario";

            return View();
        }
    }
}