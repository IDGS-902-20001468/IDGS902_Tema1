using IDGS902_Tema1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS902_Tema1.Services
{
    public class VerListaService
    {
        public Dictionary<string, string> CrearDiccionario()
        {
            Dictionary<string, string> palabrasDatos = null;
            var datos = HttpContext.Current.Server.MapPath("~/App_Data/diccionario.txt");
            if (File.Exists(datos))
            {
                palabrasDatos = new Dictionary<string, string>();
                var lineas = File.ReadAllLines(datos);
                foreach (var linea in lineas)
                {
                    var dividirP = linea.Split(',');
                    if (dividirP.Length == 2)
                    {
                        var clave = dividirP[0].Trim();
                        var valor = dividirP[1].Trim();
                        palabrasDatos[clave] = valor;
                    }
                }
            }
            return palabrasDatos;
        }

        public string buscarIng(string filtro)
        {
            Dictionary<string, string> diccionario = CrearDiccionario();
             string filtroL = filtro.ToLower();
            string mensaje = "";
            foreach (var clave in diccionario.Keys)
            {
                Console.WriteLine(clave);
                Console.WriteLine(filtroL);
                if (filtroL == clave.ToLower())
                {
                    var valor = diccionario[clave];
                    mensaje = "La traducción de " + filtro + " en Inglés es: " + valor;
                    break;
                }
                else
                {
                    mensaje = "La palabra no se encuentra en el diccionario";  
                }
            }
            return mensaje;
        }

        public string buscarEsp(string filtro)
        {
            Dictionary<string, string> diccionario = CrearDiccionario();
            string filtroL = filtro.ToLower();
            string claveF = "";

            foreach (var palabras in diccionario)
            {
                string clave = palabras.Key;
                string valor = palabras.Value;

                if (filtroL == valor.ToLower())
                {
                    claveF = clave;
                    break;
                }
            }

            if (!string.IsNullOrEmpty(claveF))
            {
                string mensaje = "La traducción de " + filtro + " en Español es: " + claveF;
                return mensaje;
            }
            else
            {
                string mensaje = "La palabra no se encuentra en el diccionario";
                return mensaje;
            }

        }



    }
}