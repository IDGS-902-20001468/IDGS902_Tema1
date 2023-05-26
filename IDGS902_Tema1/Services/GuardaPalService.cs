using IDGS902_Tema1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS902_Tema1.Services
{
    public class GuardaPalService
    {
        public void GuardarPalabra(Palabras pal)
        {
            var esp = pal.palabraEsp;
            var ing = pal.palabraIng;
            var datos = esp + ", " + ing + Environment.NewLine;
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/diccionario.txt");
            File.AppendAllText(archivo, datos);
        }
    }

}