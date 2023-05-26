using IDGS902_Tema1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS902_Tema1.Services
{
    public class GuardaService
    {
        public void GuardarArchivo(Maestros maes)
        {
            var nombre = maes.Nombre;
            var apepaterno = maes.Apaterno;
            var apematerno = maes.Amaterno;
            var edad = maes.Edad;
            var email = maes.Email;
            var datos = nombre+", "+apematerno+", "+apematerno + ", " +edad+", "+email+ Environment.NewLine;
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/datos.txt");
            File.AppendAllText(archivo, datos);
        }


    }
}