using IDGS902_Tema1.Models;
using IDGS902_Tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS902_Tema1.Controllers
{
    public class NuevoController : Controller
    {
        public ActionResult NuevoIndex()
        {
            return View();
        }
        public ActionResult OperasBas2(Calculos op, string opera)
        {
            var model = new Calculos();
            model.Res = op.Num1+op.Num2;
            
            /*
            int res = 0;

            if (Convert.ToInt16(opera) == 1) 
            {
                res = Convert.ToInt16(n1) + Convert.ToInt16(n2);
            }
            else if (Convert.ToInt16(opera) == 2)
            {
                res = Convert.ToInt16(n1) - Convert.ToInt16(n2);
            }
            else if (Convert.ToInt16(opera) == 3)
            {
                res = Convert.ToInt16(n1) * Convert.ToInt16(n2);
            }
            else if (Convert.ToInt16(opera) == 4)
            {
                res = Convert.ToInt16(n1) / Convert.ToInt16(n2);
            }
            */

            ViewBag.Res = model.Res;
            return View(model);
        }

        public ActionResult MuestraPulques()
        {
            var pulques = new PulquesServices();
            var model = pulques.ObtenerPulque();
            return View(model);  
        }

        public ActionResult MuestraPulques2()
        {
            var pulques = new PulquesServices();
            var model = pulques.ObtenerPulque();
            return View(model);
        }
    }

    public class DistanciaController : Controller
    {
        public ActionResult Distancia(Distancia op)
        {
            var model = new Distancia();

            model.Res = model.calcular(op.X1, op.Y1, op.X2, op.Y2);

            return View(model);
        }
    }
}
