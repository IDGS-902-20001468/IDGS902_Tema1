using IDGS902_Tema1.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS902_Tema1.Controllers
{
    public class Pruebas2Controller : Controller
    {
        // GET: Pruebas2
        public ActionResult Index()
        {
            var alumno = new Alumnos()
            {
                Nombre = "Jimena",
                Edad = 28,
                Email = "jlopez@gmailcom",
                Activo = false,
                Inscripcion = new DateTime(2023, 4, 20)
            };
            ViewBag.Alumnos = alumno;
            return View();
        }

        public ActionResult Escuela() {
            var alumno = new Alumnos()
            {
                Nombre = "Jimena",
                Edad = 28,
                Email = "jlopez@gmailcom",
                Activo = false,
                Inscripcion = new DateTime(2023, 4, 20)
            };
            ViewBag.Alumnos = alumno;
            return View(alumno);
        }

        public ActionResult ActividadCaja(string numCajas, string cajas)
        {
            if (string.IsNullOrEmpty(numCajas))
            {
                ViewBag.NumCajas = 0;
            }
            else
            {
                ViewBag.NumCajas = numCajas;
            }
            ViewBag.Cajas = cajas;
            return View();
        }
        public ActionResult Resultado(string caj, string[] a)
        {
            int suma = 0;
            for (int i = 0; i < Convert.ToInt16(caj); ++i)
            {
                suma += Convert.ToInt16(a[i].ToString());
            }

            List<string> numerosRepetidos = new List<string>();
            List<string> numeros = new List<string>();
            for (int i = 0; i < a.Length; i++)
            {
                string numero = a[i];
                if (numeros.Contains(numero))
                {
                    if (!numerosRepetidos.Contains(numero))
                    {
                        numerosRepetidos.Add(numero);
                    }
                }
                else
                {
                    numeros.Add(numero);
                }
            }

            
            ViewBag.suma = suma;
            ViewBag.numeros = numerosRepetidos;
            return View();
        }      

    }
}