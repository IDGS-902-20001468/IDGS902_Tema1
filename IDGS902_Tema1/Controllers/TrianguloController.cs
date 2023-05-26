using IDGS902_Tema1.Models;
using IDGS902_Tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS902_Tema1.Controllers
{
    public class TrianguloController : Controller
    {
        // GET: Triangulo
        public ActionResult Triangulo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Triangulo(Punto punto1, Punto punto2, Punto punto3)
        {
            Triangulo triangulo = new Triangulo();
            ValidarTrianguloService objValidar = new ValidarTrianguloService();
            triangulo.punto1 = punto1;
            triangulo.punto2 = punto2;
            triangulo.punto3 = punto3;

            if (objValidar.validarTriangulo(triangulo))
            {
                ViewBag.Triangulo = "Es Triangulo";
                ViewBag.Tipo = objValidar.obtenerTipo(triangulo);
                ViewBag.Area = "Area: "+objValidar.CalcularArea(triangulo);
            }
            else
            {
                ViewBag.Triangulo = "No es Triangulo";
                ViewBag.Tipo = "";
                ViewBag.Area = "";
            }

            return View();
        }

    }
}