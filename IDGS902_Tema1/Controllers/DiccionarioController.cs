using IDGS902_Tema1.Models;
using IDGS902_Tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace IDGS902_Tema1.Controllers
{
    public class DiccionarioController : Controller
    {
        // GET: Diccionario
        public ActionResult Diccionario(string i)
        {

            var arch = new VerListaService();
            ViewBag.i = Convert.ToInt16(i);
            ViewBag.p = arch.CrearDiccionario();

            return View();
        }
        [HttpPost]
        
        public ActionResult Diccionario(Palabras pal, string i)
        {
            
                var arch = new VerListaService();
                ViewBag.p = arch.CrearDiccionario();
                ViewBag.i = Convert.ToInt16(i);
                var opel = new GuardaPalService();
                opel.GuardarPalabra(pal);
            return RedirectToAction("Diccionario", pal);
        }

        public ActionResult BuscarP()
        {
            ViewBag.res = " ";
            return View();
        }
        [HttpPost]
        public ActionResult BuscarP(string palabra, string opcion)
        {
            var arch = new VerListaService();

            if (opcion == "Español") {
                ViewBag.res = arch.buscarEsp(palabra);
            }
            else { 
                ViewBag.res = arch.buscarIng(palabra);
            }
            return View();
        }

    }
}